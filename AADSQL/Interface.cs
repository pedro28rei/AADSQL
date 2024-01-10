using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AADSQL
{
    public partial class Interface : Form
    {
        SQL baseDados;
        public Interface()
        {
            InitializeComponent();

            baseDados = new SQL("FABIO\\MSSQLSERVER01", "FABIO\\user", "AAD");
            if (baseDados.AbrirConexao())
                MessageBox.Show("Conectado");
            else
                MessageBox.Show("Falha na conexão");
            FormClosing += Interface_FormClosing;
        }

        /// <summary>
        /// Quando a app fecha, a conexão com a base de dados é encerrada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Interface_FormClosing(object sender, FormClosingEventArgs e)
        {
            baseDados.FecharConexao();
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
        /// Ao apertar no botao InserirDados, este envia o nome, nif e data que o user escreveu para o metodo InsereDadosCliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InserirDadosButton_Click(object sender, EventArgs e)
        {
            string nome = Nome.Text;
            string nif = NIFADD.Text;
            string dataNasc = DataNasc.Text;
            baseDados.InsereDadosCliente(nome,nif,dataNasc);
        }
        /// <summary>
        /// Ao clicar no botão, mostra os dados da tabela escrita pelo user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MostrarDadosButton_Click(object sender, EventArgs e)
        {
            DataGridDados.DataSource = null;
            string aux = NomeTabela.Text;
            baseDados.MostrarTabela(aux, DataGridDados);
        }
        /// <summary>
        /// Ao apertar o botao de remover um cliente, este recebe o nif escrito pelo user e envia para o metodo RemoverCliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoverButton_Click(object sender, EventArgs e)
        {
            string nif = NIFREMOVE.Text;
            baseDados.RemoverCliente(nif);
        }
        /// <summary>
        /// Quando aperta o botao de inserir clientes e contacto, este recebe as strings escritas pelo utilizador e envia para o metodo InsereDadosClienteContacto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InserirClienteContactoButton_Click(object sender, EventArgs e)
        {
            string nome = NomeC.Text;
            string nif = NIFC.Text;
            string dataNasc = DataNascC.Text;
            string tipoContacto = ContactoTipo.Text;
            string descContacto = DescContacto.Text;
            baseDados.InsereDadosClienteContacto(nome,nif,dataNasc,tipoContacto,descContacto);
        }
    }
}
