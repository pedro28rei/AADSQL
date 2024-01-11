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
        /// Abre a conexao com a base de dados
        /// </summary>
        /// <returns></returns>
        public bool AbrirConexao()
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
        /// Fecha a conexao com a base de dados
        /// </summary>
        public void FecharConexao()
        {
            baseDeDados.Close();
        }


        /*
         * Assim teriamos espaço para alterar dados
         * Assim teriamos espaço para alterar dados
         * Deveriamos remover este metodo, ja que temos adicionar cliente e contacto
         * Deveriamos remover este metodo, ja que temos adicionar cliente e contacto
         * Deveriamos remover este metodo, ja que temos adicionar cliente e contacto
         * Deveriamos remover este metodo, ja que temos adicionar cliente e contacto
         * Deveriamos remover este metodo, ja que temos adicionar cliente e contacto
         * Deveriamos remover este metodo, ja que temos adicionar cliente e contacto
         * Assim teriamos espaço para alterar dados
         * Assim teriamos espaço para alterar dados
         */



        /// <summary>
        /// Executa a stored procedure AdicionarClienteEContactos, recebendo como parametros o nome,nif,data de nascimento,tipo de contacto e descrição do contacto
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="nif"></param>
        /// <param name="dataNasc"></param>
        /// <param name="tipoContacto"></param>
        /// <param name="descContacto"></param>
        /// <returns></returns>
        public bool InsereDadosClienteContacto(string nome, string nif, string dataNasc, string tipoContacto, string descContacto)
        {
            string storedProcedure = string.Format("AdicionarClienteEContactos");
            using (SqlCommand checkCommand = new SqlCommand($"SELECT COUNT(*) FROM Cliente WHERE CNIF = {nif}", baseDeDados))
            {
                try
                {
                    int count = (int)checkCommand.ExecuteScalar();

                    if (count == 0)
                    {
                        using (var command = new SqlCommand(storedProcedure, baseDeDados){ CommandType = CommandType.StoredProcedure })
                        {
                            command.Parameters.Add(new SqlParameter("@Cnome", nome));
                            command.Parameters.Add(new SqlParameter("CNIF", nif));
                            command.Parameters.Add(new SqlParameter("@CDataNasc", dataNasc));
                            command.Parameters.Add(new SqlParameter("@CCDados", descContacto));
                            command.Parameters.Add(new SqlParameter("@DescricaoTC", tipoContacto));
                            command.ExecuteNonQuery();
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
        /// Remove um Cliente atraves do seu nif
        /// </summary>
        /// <param name="nif"></param>
        /// <returns></returns>
        public bool RemoverCliente(string nif)
        {
            string comando = string.Format($"DECLARE @ClientId INT SELECT @ClientId = CID FROM Cliente WHERE CNIF = {nif} DELETE FROM ContactoCliente WHERE CID = @ClientId DELETE FROM Cliente WHERE CNIF = {nif};");
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
        /// Recebendo uma string, mostra os dados de uma tabela
        /// </summary>
        /// <param name="dadosMostrar"></param>
        public DataGridView MostrarTabela(string dadosMostrar, DataGridView auxDataGrid)
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
