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
    public partial class AdicionarClientes : Form
    {
        DataHelper datahelper;
        int index;
        public int Index
        {
            get
            {
                return index;
            }

            set
            {
                index = value;
            }
        }

        public AdicionarClientes(int index)
        {
            this.Index = index;
        }

        public AdicionarClientes()
        {
            datahelper = new DataHelper();
            InitializeComponent();
        }

        GenderType RadioButtonGenderSelecionado()
        {
            bool e_Masculino = radioButtonMasculino.Checked;
            GenderType genero;
            if (e_Masculino)
            {
                genero = GenderType.Masculino;
            }
            else
            {
                genero = GenderType.Feminino;
            }
            return genero;
        }

        DesportoType RadioButtonDesportoSelecionado()
        {
            DesportoType desporto;
            bool PraticaDesporto = radioButtonSim.Checked;
            if (PraticaDesporto)
            {
                desporto = DesportoType.Sim;
            }
            else
            {
                desporto = DesportoType.Não;
            }
            return desporto;
        }
        // Quando selecionado o botao adicionar na form Clientes, apenas botao fica ativo
        private void buttonGravar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem a certeza que pretende adicionar um novo Cliente?", "Alerta:", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                ClasseCliente clienteParaAdicionar = new ClasseCliente(textBoxNome.Text, numericUpDownIdade.Value, double.Parse(textBoxAltura.Text), float.Parse(textBoxPeso.Text), RadioButtonGenderSelecionado(), RadioButtonDesportoSelecionado(), double.Parse(textBoxIMC.Text));

                ClasseCliente.AdicionarParaDataBase(datahelper, clienteParaAdicionar);

                this.Close();
            }
        }

        // Quando selecionado botao editar na form Clientes, apenas este botao fica ativo
        private void buttonGravaralteracoes_Click(object sender, EventArgs e)
        {
            ClasseCliente clienteParaEditar = new ClasseCliente(textBoxNome.Text, numericUpDownIdade.Value, double.Parse(textBoxAltura.Text), float.Parse(textBoxPeso.Text), RadioButtonGenderSelecionado(), RadioButtonDesportoSelecionado(), double.Parse(textBoxIMC.Text));

            ClasseCliente.editarNaBaseDados(datahelper, clienteParaEditar, Index);

            this.Close(); 
        }

        // Faz o calculo do IMC e apresenta-o para posteriormente ser adicionado à dataGridViewClientes
        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            double imc = 0;
            double imcArredondado = 0;
            float peso = float.Parse(textBoxPeso.Text);
            double altura = double.Parse(textBoxAltura.Text);

            imc = peso / (altura * altura);
            imcArredondado = System.Math.Round(imc, 2);
            textBoxIMC.Text = imcArredondado.ToString();

            if (imcArredondado >= 18.50 && imcArredondado <= 24.99)
            {
                textBoxIMCResultado.Text = "Peso Normal";
            }
            else if (imcArredondado >= 25.00)
            {
                textBoxIMCResultado.Text = "Sobrepeso";
            }
            else textBoxIMCResultado.Text = "Baixo Peso";
        }
    }
}
