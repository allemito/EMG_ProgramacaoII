using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMG_Trabalho 
{
    public partial class EmparelharBitalino : Form
    {
        Bitalino.DevInfo[] devices;

        public EmparelharBitalino()
        {
            InitializeComponent();
            DeviceSingletone.Instance.EncontrarDispositivos += Instance_EncontrarDispositivos;
            pictureBox.Enabled = false;
        }

        private async void buttonProcurarDispositivo_Click(object sender, EventArgs e)
        {
            pictureBox.Enabled = true;
            await DeviceSingletone.Instance.SearchDevices();
        }

        private void Instance_EncontrarDispositivos(Bitalino.DevInfo[] devs)
        {
            devices = devs;
            foreach (Bitalino.DevInfo device in devs)
            {
                AdicionarDispositivoListBox(String.Format("{0}-{1}", device.name, device.macAddr));
            }
        }

        delegate void AddDeviceDelegate(string text);
        private void AdicionarDispositivoListBox(string text)
        {
            if (this.listBoxDevices.InvokeRequired)
            {
                AddDeviceDelegate d = new AddDeviceDelegate(AdicionarDispositivoListBox);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                pictureBox.Enabled = false;
                listBoxDevices.Items.Add(text);
            }
        }
        
        // Fecha a Form EmparelharBitalino ao selecionar um dispositivo de bluetooth disponivel
        private void listBoxDevices_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            int index = listBoxDevices.SelectedIndex;
            DeviceSingletone.Instance.Device = devices[index]; // gravamos no lugar onde está o index
            this.Close();
            
        }
    }
}
