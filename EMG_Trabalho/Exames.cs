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
        // Modelo de dados
        DataHelper datahelper;

        public Exames(ClasseCliente cliente)
        {
            InitializeComponent();
            datahelper = new DataHelper();
            dataGridViewExames.DataSource = datahelper.DataSet;
            dataGridViewExames.DataMember = DataHelper.DATATABLE_EXAMES;
            dataGridViewExames.AutoGenerateColumns = true;
            dataGridViewExames.AutoResizeColumns();
        }

        // Com este buotao somos redirecionados para uma nova forma para conectar a um dispositivo de bluetooth
        private async void buttonEmparelhar_Click(object sender, EventArgs e)
        {
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
                    ClasseCliente.removerDaBaseDados(datahelper, indexParaRemover);
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
            dataGridViewExames.DataSource = datahelper.DataSet;
            dataGridViewExames.DataMember = DataHelper.DATATABLE_EXAMES;
            dataGridViewExames.AutoGenerateColumns = true;
        }

        private void buttonNovoExame_Click(object sender, EventArgs e)
        {
            FazerExame novoExame = new FazerExame();
            novoExame.ShowDialog();
        }
    }
}
