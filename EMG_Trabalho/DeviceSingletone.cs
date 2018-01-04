using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMG_Trabalho
{
    class DeviceSingletone
    {
        Bitalino.DevInfo device;
        public Bitalino.DevInfo Device
        {
            get
            {
                return device;
            }

            set
            {
                device = value;
            }
        }

        public Boolean connected = false;

        public void disconnect()
        {
            connected = false;
        }

        //criar uma estancia estatica dentro desta classe
        private static DeviceSingletone instance;

        private DeviceSingletone()
        {

        }

        public static DeviceSingletone Instance//propriedade do instance
        {
            get
            {
                if (instance == null)
                { instance = new DeviceSingletone(); }
                return instance;
            }
        }

        public delegate void EventSearchDeviceHandler(Bitalino.DevInfo[] devs);
        public event EventSearchDeviceHandler EncontrarDispositivos;//evento

        public async Task SearchDevices()
        {
            await Task.Run(() => {
                Bitalino.DevInfo[] devs = Bitalino.find();
                EventSearchDeviceHandler handler = EncontrarDispositivos;
                if (handler != null) handler(devs);
            });//o metodo devolve uma tarefa, como é um async task vai estar dentro do 'await'
            // os '()' são uma função e o que está dentro dos '{}' é a solução(call back) dessa função

        }

        public delegate void EventDataDeviceHandler(String data);
        public event EventDataDeviceHandler NewData;//evento
        public async Task ReadDevice()
        {
            await Task.Run(() => {
                try
                {
                    // uncomment this block to search for Bluetooth devices

                    Console.WriteLine("A conectar ao dispositivo...");

                    Bitalino dev = new Bitalino("20:16:04:12:01:94");  // device MAC address
                                                                       //Bitalino dev = new Bitalino("COM7");  

                    Console.WriteLine("Dispositivo conectado. Pressione Enter para sair.");

                    string ver = dev.version();    // get device version string
                    Console.WriteLine("Bitalino versão: {0}", ver);

                    dev.battery(10);  // set battery threshold (optional)

                    dev.start(100, new int[] { 0, 1, 2, 3, 4, 5 });   // start acquisition of all channels at 1000 Hz
                                                                      // NECESSARIO ESCOLHER O CANAL
                    bool ledState = false;

                    Bitalino.Frame[] frames = new Bitalino.Frame[100];
                    for (int i = 0; i < frames.Length; i++)
                        frames[i] = new Bitalino.Frame();   // must initialize all elements in the array

                    connected = true;
                    do
                    {
                        ledState = !ledState;   // toggle LED state
                        dev.trigger(new bool[] { false, false, ledState, false });

                        dev.read(frames); // get 100 frames from device
                        Bitalino.Frame f = frames[0];  // get a reference to the first frame of each 100 frames block
                        String dataStr = String.Format("{0} : {1} {2} {3} {4} ; {5} {6} {7} {8} {9} {10}",   // dump the first frame
                                          f.seq,
                                          f.digital[0], f.digital[1], f.digital[2], f.digital[3],
                                          f.analog[0], f.analog[1], f.analog[2], f.analog[3], f.analog[4], f.analog[5]);

                        Console.WriteLine(dataStr);

                        EventDataDeviceHandler handler = NewData;
                        if (handler != null) NewData(dataStr);
                    }

                    while (connected); // until a key is pressed

                    dev.stop(); // stop acquisition

                    dev.Dispose(); // disconnect from device*/
                }
                catch (Bitalino.Exception e)
                {
                    Console.WriteLine("Bitalino Excepção: {0}", e.Message);
                }



            });
        }
    }
}

