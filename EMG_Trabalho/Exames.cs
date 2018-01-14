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
    public partial class Exames : Form
    {

        ClasseCliente clienteParaEditar;
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
        // Modelo de dados
        DataHelper datahelper;

        public Exames(ClasseCliente cliente)
        {
            this.clienteParaEditar = cliente;
            InitializeComponent();
            this.Text = cliente.Nome;

            buttonNovoExame.Enabled = false;

            datahelper = new DataHelper();
            DataView dataView = datahelper.DataSet.Tables[DataHelper.DATATABLE_EXAMES].DefaultView;
            dataView.RowFilter = string.Format("[{0}] = '{1}'", DataHelper.EXAME_CLIENTE_ID, cliente.Id);
            dataGridViewExames.DataSource = dataView;
            dataGridViewExames.AutoGenerateColumns = true;
            dataGridViewExames.AutoResizeColumns();
        }

        public Exames()
        {
            InitializeComponent();
        }

        // Com este buotao somos redirecionados para uma nova forma para conectar a um dispositivo de bluetooth
        private async void buttonEmparelhar_Click(object sender, EventArgs e)
        {
            buttonNovoExame.Enabled = true;
            EmparelharBitalino procurarBitalino = new EmparelharBitalino();
            procurarBitalino.ShowDialog();
        }

        // Com este botao é possivel remover um exame selecionado na dataGridViewExames
        private void buttonApagarExame_Click(object sender, EventArgs e)
        {
            
            int indexParaRemover = dataGridViewExames.CurrentCell.RowIndex;
            if (indexParaRemover >= 0)
            {
                DialogResult result = MessageBox.Show("Tem a certeza que pretende remover o Exame seleccionado?", "Alerta:", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    ClasseExames.removerDaBaseDados(datahelper, indexParaRemover);
                }
            }
            else
            {
                MessageBox.Show("Alerta: Não selecionou nenhum exame. Tente novamente!");
            }
        }

        // Atualiza a dataGridViewExames uma vez que ela nao atualiza sozinha
        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            datahelper = new DataHelper();
            DataView dataView = datahelper.DataSet.Tables[DataHelper.DATATABLE_EXAMES].DefaultView;
            dataView.RowFilter = string.Format("[{0}] = '{1}'", DataHelper.EXAME_CLIENTE_ID, clienteParaEditar.Id);
            dataGridViewExames.DataSource = dataView;
            dataGridViewExames.AutoGenerateColumns = true;
            dataGridViewExames.AutoResizeColumns();
        }

        private void buttonNovoExame_Click(object sender, EventArgs e)
        {
            FazerExame novoExame = new FazerExame(clienteParaEditar);
            novoExame.ShowDialog();
        }
    }
}
