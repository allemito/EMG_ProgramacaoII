using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMG_Trabalho
{
    public enum GenderType { Masculino, Feminino };
    public enum DesportoType { Sim, Não};

   public class ClasseCliente
    {
       private String nome;
       private decimal idade;
       private double altura;
       private float peso;
       private GenderType genero;
       private double imc; // indice de massa corporal
       private DesportoType desporto;
       private long id;
       List<ClasseExames> exames;

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }
        public decimal Idade
        {
            get
            {
                return idade;
            }

            set
            {
                idade = value;
            }
        }
        public double Altura
        {
            get
            {
                return altura;
            }

            set
            {
                if (altura >= 0)
                {
                    altura = value;
                }
                else System.Windows.Forms.MessageBox.Show("Erro: Introduza uma altura valida");
            }
        }
        public float Peso
        {
            get
            {
                return peso;
            }

            set
            {
                if (peso >= 0)
                {
                    peso = value;
                }
                else System.Windows.Forms.MessageBox.Show("Erro: Introduza um peso valido");
            }
        }
        public double Imc
        {
            get
            {
                return imc;
            }
            set
            {
                imc = value;
            }
        } 
        public GenderType Genero
        {
            get
            {
                return genero;
            }

            set
            {
                genero = value;
            }
        }
        public DesportoType Desporto
        {
            get
            {
                return desporto;
            }

            set
            {
                desporto = value;
            }
        }
        public long Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public ClasseCliente(string nome, decimal idade, double altura, float peso, GenderType genero, DesportoType desporto, double imc)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Altura = altura;
            this.Peso = peso;
            this.Genero = genero;
            this.Desporto = desporto;
            this.Imc = imc;     
            this.Id = Utils.CurrentTimeMillis();
        }
        public ClasseCliente(string nome, decimal idade, double altura, float peso, GenderType genero, DesportoType desporto, double imc, long id)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Altura = altura;
            this.Peso = peso;
            this.Genero = genero;
            this.Desporto = desporto;
            this.Imc = imc;
            this.Id = id;
        }

        // CRUD

        // Create: Adicionar clientes à base de dados
        public static void AdicionarParaDataBase(DataHelper datahelper, ClasseCliente cliente)
        {
            DataRow datarow = datahelper.TableClientes.NewRow();
        
            datarow[DataHelper.CLIENTE_NOME] = cliente.Nome;
            datarow[DataHelper.CLIENTE_IDADE] = cliente.Idade;
            datarow[DataHelper.CLIENTE_GENERO] = cliente.Genero;
            datarow[DataHelper.CLIENTE_PESO] = cliente.Peso;
            datarow[DataHelper.CLIENTE_ALTURA] = cliente.Altura;
            datarow[DataHelper.CLIENTE_IMC] = cliente.Imc;
            datarow[DataHelper.CLIENTE_DESPORTO] = cliente.Desporto;
            datarow[DataHelper.CLIENTE_ID] = cliente.Id;

            datahelper.TableClientes.Rows.Add(datarow);
            datahelper.Guardar();
        }

        //Read: Le os clientes selecionados na base de dados
        public static ClasseCliente lerNaBaseDados(DataHelper datahelper, int index)
        {
            ClasseCliente cliente;

            DataRow datarow = datahelper.TableClientes.Rows[index];

            cliente = new ClasseCliente(
                 (String)datarow[DataHelper.CLIENTE_NOME],
                 decimal.Parse((String)datarow[DataHelper.CLIENTE_IDADE]),
                 double.Parse((String)datarow[DataHelper.CLIENTE_ALTURA]),
                 float.Parse((String)datarow[DataHelper.CLIENTE_PESO]),
                 parseGender((String)datarow[DataHelper.CLIENTE_GENERO]),
                 parseDesporto((String)datarow[DataHelper.CLIENTE_DESPORTO]),
                 double.Parse((String)datarow[DataHelper.CLIENTE_IMC]), 
                 long.Parse((String)datarow[DataHelper.CLIENTE_ID]));

            return cliente;
        }

        // Edit: Editar clientes ja existentes na base de dados
        public static void editarNaBaseDados(DataHelper datahelper, ClasseCliente cliente, int index)
        {
            DataRow datarow = datahelper.TableClientes.Rows[index];

            datarow[DataHelper.CLIENTE_NOME] = cliente.Nome;
            datarow[DataHelper.CLIENTE_IDADE] = cliente.Idade;
            datarow[DataHelper.CLIENTE_GENERO] = cliente.Genero;
            datarow[DataHelper.CLIENTE_PESO] = cliente.Peso;
            datarow[DataHelper.CLIENTE_ALTURA] = cliente.Altura;
            datarow[DataHelper.CLIENTE_IMC] = cliente.Imc;
            datarow[DataHelper.CLIENTE_DESPORTO] = cliente.Desporto;
            datarow[DataHelper.CLIENTE_ID] = cliente.Id;

            datahelper.Guardar();
        }

        // Remove: Remover clientes que se encontram na base de dados
        public static void removerDaBaseDados(DataHelper datahelper, int indexParaRemover)
        {
            datahelper.TableClientes.Rows.RemoveAt(indexParaRemover);
            datahelper.Guardar();
        }

        public static List<ClasseCliente> getClientesLista(DataHelper datahelper)
        {

            List<ClasseCliente> clientes = new List<ClasseCliente>();

            foreach (DataRow dataRow in datahelper.TableClientes.Rows)
            {

                String nome = (String)dataRow[DataHelper.CLIENTE_NOME];
                decimal idade = decimal.Parse((String)dataRow[DataHelper.CLIENTE_IDADE]);
                double altura = double.Parse((String)dataRow[DataHelper.CLIENTE_ALTURA]);
                float peso = float.Parse((String)dataRow[DataHelper.CLIENTE_PESO]);
                GenderType genero = parseGender((String)dataRow[DataHelper.CLIENTE_GENERO]);
                DesportoType desporto = parseDesporto((String)dataRow[DataHelper.CLIENTE_DESPORTO]);
                double imc = double.Parse((String)dataRow[DataHelper.CLIENTE_IMC]);
                long id = long.Parse((String)dataRow[DataHelper.CLIENTE_ID]);
                GenderType gender = parseGender((String)dataRow[DataHelper.CLIENTE_GENERO]);

                clientes.Add(new ClasseCliente(nome, idade, altura, peso, genero, desporto, imc, id));
            }

            return clientes;
        }

        public static List<ClasseExames> getExames(DataHelper datahelper, long id)
        {
            List<ClasseExames> exames = new List<ClasseExames>();
            DataView dataView = datahelper.DataSet.Tables[DataHelper.DATATABLE_EXAMES].DefaultView;

            dataView.RowFilter = string.Format("{0} = '{1}'", DataHelper.EXAME_CLIENTE_ID, id);
            foreach (DataRowView drv in dataView)
            {
                DataRow row = drv.Row;
                string nome = (string)row[DataHelper.EXAME_NOME];
                long clienteId = long.Parse((string)row[DataHelper.EXAME_CLIENTE_ID]);
                string exameMedia = (string)row[DataHelper.EXAME_EXAME_MEDIA];
                ClasseExames exame  = new ClasseExames(nome, clienteId, exameMedia);
                exames.Add(exame);
            }
            return exames;

        }

        // Converter GenderType em string para utilizar no Read
        public static GenderType parseGender(String strGender)
        {
            if (strGender.CompareTo("Masculino") == 0)
            {
                return GenderType.Masculino;
            }
            else
            {
                return GenderType.Feminino;
            }
        }

        // Converter DesportoType em string para utilizar no Read
        public static DesportoType parseDesporto(String strDesporto)
        {
            if (strDesporto.CompareTo("Sim") == 0)
            {
                return DesportoType.Sim;
            }
            else
            {
                return DesportoType.Não;
            }
        }

        // Converter ExameType
        public static ExameType parseExame(String strExame)
        {
            if (strExame.CompareTo("MusculoRelaxado") == 0)
            {
                return ExameType.Musculo_Relaxado;
            }
            else
            {
                return ExameType.Musculo_Exercicio;
            }
        }
    }
}
