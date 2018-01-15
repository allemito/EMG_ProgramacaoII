using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMG_Trabalho
{
    public enum ExameType { Musculo_Relaxado, Musculo_Exercicio}

   
   public class ClasseExames
    {

        private String nome;
        private long id;
        private long clienteId;
        private string mediaExame;

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
        public long ClienteId
        {
            get
            {
                return clienteId;
            }

            set
            {
                clienteId = value;
            }
        }
        public string MediaExame
        {
            get
            {
                return mediaExame;
            }

            set
            {
                mediaExame = value;
            }
        }


 

        public ClasseExames(String nome, long clienteId, String exame)
        {
            this.Nome = nome;
            this.MediaExame = exame;
            this.ClienteId = clienteId;
            this.id = Utils.CurrentTimeMillis();
        }

        public static void AdicionarExameParaDataBase(DataHelper datahelper, ClasseExames exames)
        {
            DataRow datarow = datahelper.TableExames.NewRow();

            datarow[DataHelper.EXAME_NOME] = exames.Nome;
            datarow[DataHelper.EXAME_EXAME_MEDIA] = exames.MediaExame;
            datarow[DataHelper.EXAME_CLIENTE_ID] = exames.ClienteId;
            datahelper.TableExames.Rows.Add(datarow);
            datahelper.Guardar();
        }

        public static void removerDaBaseDados(DataHelper datahelper, long id)
        {
            foreach (DataRow dr in datahelper.TableExames.Rows)
            {
                if (id == long.Parse((String)dr[DataHelper.EXAME_CLIENTE_ID]))
                {
                    datahelper.TableExames.Rows.Remove(dr);
                    return;
                }
            }
            datahelper.Guardar();
        }
    }
}
