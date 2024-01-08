using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Window;

namespace AADSQL
{
    public partial class Interface : Form
    {
        SQL baseDados;
        public Interface()
        {
            InitializeComponent();

            baseDados = new SQL("FABIO\\MSSQLSERVER01", "FABIO\\user", "AAD");
            if (baseDados.Conectar())
                MessageBox.Show("Conectado");
            else
                MessageBox.Show("Falha na conexão");
            FormClosing += Interface_FormClosing;
        }

        /// <summary>
        /// Quando a aplicação encerrar será fechada a conexão.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Interface_FormClosing(object sender, FormClosingEventArgs e)
        {
            baseDados.FecharConexao();
        }

        /// <summary>
        /// Ao clicar no botão, insere dados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InserirDadosButton_Click(object sender, EventArgs e)
        {
            string nome = Nome.Text;
            string nif = NIFADD.Text;
            string dataNasc = DataNasc.Text;
            baseDados.InsereDados(nome,nif,dataNasc);
        }
        /// <summary>
        /// Ao clicar no botão, mostra dados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MostrarDadosButton_Click(object sender, EventArgs e)
        {
            dataGridDados.DataSource = null;
            string aux = NomeTabela.Text;
            baseDados.MostrarDados(aux, dataGridDados);


        }

        private void RemoverButton_Click(object sender, EventArgs e)
        {
            string nif = NIFREMOVE.Text;
            baseDados.RemoverCliente(nif);
        }

    }
}
