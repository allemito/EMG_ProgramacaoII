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
    public partial class FazerExame : Form
    {
        public FazerExame()
        {
            InitializeComponent();
            DeviceSingletone.Instance.NewData += Instance_NewData;
        }

        private void Instance_NewData(string data)
        {
            AddTexttoListBox(data);
        }

        private async void buttonStart_Click(object sender, EventArgs e)
        {
            await DeviceSingletone.Instance.ReadDevice();
        }

        delegate void AddTextDelegate(string text);
        private void AddTexttoListBox(string text)
        {
            if (this.textBoxExame.InvokeRequired)
            {
                AddTextDelegate d = new AddTextDelegate(AddTexttoListBox);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                textBoxExame.Text += text;
            }
        }
    }
}
