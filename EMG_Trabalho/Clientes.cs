using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMG_Trabalho
{
    public partial class Clientes : Form
    {
        // Modelo de dados
        DataHelper datahelper;
       
        public Clientes()
        {
            InitializeComponent();
            datahelper = new DataHelper();
            dataGridViewClientes.DataSource = datahelper.DataSet;
            dataGridViewClientes.DataMember = DataHelper.DATATABLE_CLIENTES;
            dataGridViewClientes.AutoGenerateColumns = true;
            dataGridViewClientes.AutoResizeColumns();
        }

        // Com este botao é possivel adicionar um novo cliente
        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            AdicionarClientes adicionarCliente = new AdicionarClientes();
            adicionarCliente.buttonGravarAlteracoes.Enabled = false;
            adicionarCliente.ShowDialog();  
        }
        
        // Com este botao é possivel editar um cliente selecionado pelo utilizador
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            AdicionarClientes editarCliente = new AdicionarClientes();
            editarCliente.buttonGravar.Enabled = false;
            editarCliente.Index = dataGridViewClientes.CurrentCell.RowIndex; 
            int index = dataGridViewClientes.CurrentCell.RowIndex;
            if ( index >= 0)
            {
                DialogResult result = MessageBox.Show("Tem a certeza que pretende editar o cliente seleccionado?", "Alerta:", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    editarCliente.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione um cliente!");
            }
        }

        // Com este botao é possivel remover uma linha/Cliente na dataGridViewClientes conforme selecionado
        private void buttonApagar_Click(object sender, EventArgs e)
        {
            int indexParaRemover = dataGridViewClientes.CurrentCell.RowIndex;
            if (indexParaRemover >= 0)
            {
                DialogResult result = MessageBox.Show("Tem a certeza que pretende remover o Cliente seleccionado?", "Alerta:", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    ClasseCliente.removerDaBaseDados(datahelper, indexParaRemover);
                }
            }
            else
            {
                MessageBox.Show("Alerta: Não selecionou nenhum cliente. Tente novamente!");
            }
        }

        // O objetivo deste botao é fazer uma atualizaçao da dataGridViewClientes uma vez que ela nao atualiza sozinha
        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            datahelper = new DataHelper();
            dataGridViewClientes.DataSource = datahelper.DataSet;
            dataGridViewClientes.DataMember = DataHelper.DATATABLE_CLIENTES;
            dataGridViewClientes.AutoGenerateColumns = true;
        }

        private void dataGridViewClientes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = dataGridViewClientes.CurrentCell.RowIndex;
            if (index >= 0)
            {
                ClasseCliente cliente = ClasseCliente.lerNaBaseDados(datahelper, index);
                Exames exames = new Exames(cliente);
                exames.ShowDialog();
            }
        }

        // Com este botao coseguimos exportar os dados dos clientes para o formato SPSS (.sav)
        private void buttonExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.FileName = "*";
            sv.DefaultExt = "sav";
            sv.ValidateNames = true;

            sv.Filter = "SAV File (.sav)|*.sav";
            ;
            if (sv.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine(sv.FileName);
                StreamWriter sw = new StreamWriter(sv.FileName);
                List<ClasseCliente> clientes = ClasseCliente.getClientesLista(datahelper);
                foreach (ClasseCliente c in clientes)
                {
                    Console.WriteLine(c.Id);
                    foreach (ClasseExames m in ClasseCliente.getExames(datahelper, c.Id))
                    {
                        sw.WriteLine(c.Nome + "; " +
                            c.Idade + "; " +
                            c.Altura + "; " +
                            c.Peso + "; " +
                            c.Genero + "; " +
                            c.Desporto + "; " +
                            c.Imc + "; " +
                            m.Nome + "; " +
                            m.MediaExame + "; "
                            );
                    }
                }
                sw.Flush();
                sw.Close();

            }
        }
    }
}
