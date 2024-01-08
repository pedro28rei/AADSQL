/*
*	<copyright file="SQL" company="IPCA">
*	</copyright>
* 	<author>Fabio</author>
*   <date>2024 1/8/2024 11:28:33 AM</date>
*	<description></description>
**/

using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AADSQL
{
    /// <summary>
    /// Purpose: 
    /// Created by: Fabio
    /// Created on: 2024 1/8/2024 11:28:33 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>

    public class SQL
    {
        #region ATRIBUTOS
        private SqlConnection baseDeDados;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES
        /// <summary>
        /// Construtor por omissão
        /// </summary>
        public SQL()
        {

        }

        /// <summary>
        /// Construtor com parametros de datasource , userid e initualcatalog
        /// </summary>
        /// <param name="source"></param>
        /// <param name="user"></param>
        /// <param name="catalog"></param>
        public SQL(string source, string user, string catalog)
        {
            SqlConnectionStringBuilder novaConexao = new SqlConnectionStringBuilder();
            novaConexao.DataSource = source;
            novaConexao.UserID = user;
            novaConexao.IntegratedSecurity = true;
            novaConexao.InitialCatalog = catalog;
            baseDeDados = new SqlConnection(novaConexao.ConnectionString);
        }

        #endregion

        #region PROPRIEDADES

        #endregion


        #region OPERADORES

        #endregion

        #region OVERRIDES

        #endregion

        #region OUTROS METODOS
        /// <summary>
        /// Conexão à base de dados
        /// </summary>
        /// <returns></returns>
        public bool Conectar()
        {
            try
            {
                baseDeDados.Open();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }
        /// <summary>
        /// Fechar conexão à base de dados
        /// </summary>
        public void FecharConexao()
        {
            baseDeDados.Close();
        }

    /// <summary>
    /// Insere dados à tabela clientes
    /// </summary>
    /// <param name="nome"></param>
    /// <param name="nif"></param>
    /// <param name="dataNasc"></param>
    /// <returns></returns>
        public bool InsereDados(string nome, string nif,string dataNasc)
        {
            string comando = string.Format("insert into Cliente(Cnome,CNIF,CDataNasc) values('{0}',{1},'{2}');",nome,nif,dataNasc);
            using (SqlCommand checkCommand = new SqlCommand($"SELECT COUNT(*) FROM Cliente WHERE CNIF = {nif}", baseDeDados))
            {
                try
                {
                    int count = (int)checkCommand.ExecuteScalar();

                    if (count == 0)
                    {
                        using (SqlCommand inserirDados = new SqlCommand(comando, baseDeDados))
                        {
                            inserirDados.ExecuteNonQuery();
                        }
                    }
                    return true;
                }
                catch (SqlException)
                {
                }
            }
            return false;
        }
        /// <summary>
        /// Remove um Cliente atravez do nif
        /// </summary>
        /// <param name="nif"></param>
        /// <returns></returns>
        public bool RemoverCliente(string nif)
        {
            string comando = string.Format("DELETE FROM Cliente WHERE CNIF = {0};",nif);
            using (SqlCommand checkCommand = new SqlCommand($"SELECT COUNT(*) FROM Cliente WHERE CNIF = {nif}", baseDeDados))
            {
                try
                {
                    int count = (int)checkCommand.ExecuteScalar();

                    if (count > 0)
                    {
                        using (SqlCommand inserirDados = new SqlCommand(comando, baseDeDados))
                        {
                            inserirDados.ExecuteNonQuery();
                        }
                    }
                    return true;
                }
                catch (SqlException)
                {
                }
            }
            return false;
        }


        /// <summary>
        /// Dado nome de uma tabela mostra todos os dados
        /// </summary>
        /// <param name="dadosMostrar"></param>
        public DataGridView MostrarDados(string dadosMostrar, DataGridView auxDataGrid)
        {
            if (dadosMostrar == string.Empty) return null;
            SqlCommand mostraDados = new SqlCommand($"Select * from {dadosMostrar};", baseDeDados);

            var adaptadorDados = new SqlDataAdapter(mostraDados);
            var auxDataSet = new DataSet();

            adaptadorDados.Fill(auxDataSet);

            if (auxDataSet.Tables.Count > 0)
            {
                auxDataGrid.DataSource = auxDataSet.Tables[0];
                auxDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                auxDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            else
                auxDataGrid = null;

            return auxDataGrid;

        }
        #endregion

        #region DESCONSTRUTOR
        /// <summary>
        /// O desconstrutor.
        /// </summary>
        ~SQL()
        {

        }
        #endregion
        #endregion
    }
}
