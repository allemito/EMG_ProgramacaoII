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
        ClasseCliente clienteParaEditar;
        DataHelper datahelper;
        List<double> valoresExame = new List<double>();

        public ClasseCliente ClienteParaEditar
        {
            get
            {
                return clienteParaEditar;
            }

            set
            {
                clienteParaEditar = value;
            }
        }

        public FazerExame(ClasseCliente cliente)
        {
            datahelper = new DataHelper();

            this.clienteParaEditar = cliente;
            InitializeComponent();
            this.Text = cliente.Nome;

            DeviceSingletone.Instance.NewData += Instance_NewData;
        }
        
        private void Instance_NewData(string data)
        {
            AddTexttoListBox(data);
        }

        // Botao para começar a tirar dados do Bitalino
        private async void buttonStart_Click(object sender, EventArgs e)
        {
            await DeviceSingletone.Instance.ReadDevice();
        }

        // Botao para parar de tirar dados do Bitalino
        private void buttonParar_Click(object sender, EventArgs e)
        {
            DeviceSingletone.Instance.disconnect();
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

        // Botao para gravar os dados acerca do exame
        private void buttonGravar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem a certeza que pretende adicionar um novo Cliente?", "Alerta:", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                ClasseExames exameParaAdicionar = new ClasseExames (textBoxTipoExame.Text, ClienteParaEditar.Id, textBoxMedia.Text);
                ClasseExames.AdicionarExameParaDataBase(datahelper, exameParaAdicionar);

                this.Close();
            }
        }
        
        // Com esta função obtemos a media dos valores retirados pelo Bitalino
        private void converterValoresEmMedia ()
        {
            double mediaExame = 0; ;
            string media;
            double soma = 0;
            foreach (double valor in this.listBoxExame.Items)
            {
                soma += valor;
                mediaExame = soma / (valoresExame.Count);
            }
            media = System.Convert.ToString(mediaExame);
            textBoxMedia.Text = media;
        }

        // Botao para reproduzir o exame recolhido
        private void buttonVerExame_Click(object sender, EventArgs e)
        {
            int i;
            foreach (string str in textBoxExame.Text.Split(' '))
            {
                if (int.TryParse(str, out i))
                    valoresExame.Add(int.Parse(str));
            }

            for (int x = 0; x < valoresExame.Count; x++)
            {
                listBoxExame.Items.Add(valoresExame[x]);
            }
            converterValoresEmMedia();
        }

       
    }
}
