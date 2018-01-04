﻿using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace EMG_Trabalho
{
   public class DataHelper
    {
        public static string DATATABLE_CLIENTES = "Ficha de Clientes:";
        public static string CLIENTE_NOME = "Nome";
        public static string CLIENTE_IDADE = "Idade";
        public static string CLIENTE_GENERO = "Genero";
        public static string CLIENTE_PESO = "Peso";
        public static string CLIENTE_ALTURA = "Altura";
        public static string CLIENTE_IMC = "IMC";
        public static string CLIENTE_DESPORTO = "Pratica Desporto";

        public static string DATATABLE_EXAMES = "Lista de Exames:";
        public static string EXAME_TIPOEXAME = "Tipo de Exame:";


        DataSet dataSet;
        DataTable tableClientes;
        DataTable tableExames;

        public DataTable TableClientes
        {
            get
            {
                return tableClientes;
            }

            set
            {
                tableClientes = value;
            }
        }
        public DataSet DataSet
        {
            get
            {
                return dataSet;
            }

            set
            {
                dataSet = value;
            }
        }
        public DataTable TableExames
        {
            get
            {
                return tableExames;
            }

            set
            {
                tableExames = value;
            }
        }

        String FICHEIRO = "EMG.xml";

        public DataHelper()
        {
            DataSet = new DataSet("EMG_dataset");

            TableClientes = new DataTable(DATATABLE_CLIENTES);
            TableClientes.Columns.Add(CLIENTE_NOME);
            TableClientes.Columns.Add(CLIENTE_IDADE);
            TableClientes.Columns.Add(CLIENTE_GENERO);
            TableClientes.Columns.Add(CLIENTE_PESO);
            TableClientes.Columns.Add(CLIENTE_ALTURA);
            TableClientes.Columns.Add(CLIENTE_IMC);
            TableClientes.Columns.Add(CLIENTE_DESPORTO);

            TableExames = new DataTable(DATATABLE_EXAMES);
            TableClientes.Columns.Add(EXAME_TIPOEXAME);

            DataSet.Tables.Add(TableClientes);
            DataSet.Tables.Add(TableExames);

            Carregar(); 
        }

        public void Guardar()
        {
            DataSet.WriteXml(FICHEIRO);
        }

        public void Carregar()
        {
            try
            {
                DataSet.ReadXml(FICHEIRO);
            }
            catch (FileNotFoundException e)
            {

            }
        }
    }
}
