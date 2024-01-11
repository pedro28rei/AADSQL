namespace AADSQL
{
    partial class Interface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Atributos
        System.Windows.Forms.Button MostrarTabelaBotao;
        System.Windows.Forms.DataGridView DataGridDados;
        #endregion

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MostrarTabelaBotao = new System.Windows.Forms.Button();
            this.DataGridDados = new System.Windows.Forms.DataGridView();
            this.NomeTabela = new System.Windows.Forms.TextBox();
            this.RemoverClienteBotao = new System.Windows.Forms.Button();
            this.NIFREMOVE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InserirClienteContactoBotao = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DataNascC = new System.Windows.Forms.TextBox();
            this.NIFC = new System.Windows.Forms.TextBox();
            this.NomeC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DescContacto = new System.Windows.Forms.TextBox();
            this.ContactoTipo = new System.Windows.Forms.TextBox();
            this.MostrarNumContact = new System.Windows.Forms.Button();
            this.AlterarCliente = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDados)).BeginInit();
            this.SuspendLayout();
            // 
            // MostrarTabelaBotao
            // 
            this.MostrarTabelaBotao.Location = new System.Drawing.Point(9, 339);
            this.MostrarTabelaBotao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MostrarTabelaBotao.Name = "MostrarTabelaBotao";
            this.MostrarTabelaBotao.Size = new System.Drawing.Size(139, 49);
            this.MostrarTabelaBotao.TabIndex = 1;
            this.MostrarTabelaBotao.Text = "Mostrar";
            this.MostrarTabelaBotao.UseVisualStyleBackColor = true;
            this.MostrarTabelaBotao.Click += new System.EventHandler(this.MostrarDadosButton_Click);
            // 
            // DataGridDados
            // 
            this.DataGridDados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridDados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridDados.Location = new System.Drawing.Point(83, 396);
            this.DataGridDados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DataGridDados.Name = "DataGridDados";
            this.DataGridDados.RowHeadersWidth = 51;
            this.DataGridDados.RowTemplate.Height = 24;
            this.DataGridDados.Size = new System.Drawing.Size(1027, 191);
            this.DataGridDados.TabIndex = 2;
            // 
            // NomeTabela
            // 
            this.NomeTabela.Location = new System.Drawing.Point(243, 350);
            this.NomeTabela.Name = "NomeTabela";
            this.NomeTabela.Size = new System.Drawing.Size(362, 26);
            this.NomeTabela.TabIndex = 3;
            // 
            // RemoverClienteBotao
            // 
            this.RemoverClienteBotao.Location = new System.Drawing.Point(-1, 192);
            this.RemoverClienteBotao.Name = "RemoverClienteBotao";
            this.RemoverClienteBotao.Size = new System.Drawing.Size(139, 49);
            this.RemoverClienteBotao.TabIndex = 10;
            this.RemoverClienteBotao.Text = "Remover";
            this.RemoverClienteBotao.UseVisualStyleBackColor = true;
            this.RemoverClienteBotao.Click += new System.EventHandler(this.RemoverButton_Click);
            // 
            // NIFREMOVE
            // 
            this.NIFREMOVE.Location = new System.Drawing.Point(190, 203);
            this.NIFREMOVE.Name = "NIFREMOVE";
            this.NIFREMOVE.Size = new System.Drawing.Size(237, 26);
            this.NIFREMOVE.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "NIF";
            // 
            // InserirClienteContactoBotao
            // 
            this.InserirClienteContactoBotao.Location = new System.Drawing.Point(12, 46);
            this.InserirClienteContactoBotao.Name = "InserirClienteContactoBotao";
            this.InserirClienteContactoBotao.Size = new System.Drawing.Size(149, 63);
            this.InserirClienteContactoBotao.TabIndex = 14;
            this.InserirClienteContactoBotao.Text = "Inserir Cliente e Contacto";
            this.InserirClienteContactoBotao.UseVisualStyleBackColor = true;
            this.InserirClienteContactoBotao.Click += new System.EventHandler(this.InserirClienteContactoButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Data Nasc.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "NIF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Nome";
            // 
            // DataNascC
            // 
            this.DataNascC.Location = new System.Drawing.Point(243, 114);
            this.DataNascC.Name = "DataNascC";
            this.DataNascC.Size = new System.Drawing.Size(362, 26);
            this.DataNascC.TabIndex = 17;
            // 
            // NIFC
            // 
            this.NIFC.Location = new System.Drawing.Point(243, 64);
            this.NIFC.Name = "NIFC";
            this.NIFC.Size = new System.Drawing.Size(362, 26);
            this.NIFC.TabIndex = 16;
            // 
            // NomeC
            // 
            this.NomeC.Location = new System.Drawing.Point(243, 11);
            this.NomeC.Name = "NomeC";
            this.NomeC.Size = new System.Drawing.Size(362, 26);
            this.NomeC.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(611, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Desc. Contacto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(622, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Tipo Contacto";
            // 
            // DescContacto
            // 
            this.DescContacto.Location = new System.Drawing.Point(736, 93);
            this.DescContacto.Name = "DescContacto";
            this.DescContacto.Size = new System.Drawing.Size(362, 26);
            this.DescContacto.TabIndex = 22;
            // 
            // ContactoTipo
            // 
            this.ContactoTipo.Location = new System.Drawing.Point(736, 40);
            this.ContactoTipo.Name = "ContactoTipo";
            this.ContactoTipo.Size = new System.Drawing.Size(362, 26);
            this.ContactoTipo.TabIndex = 21;
            // 
            // MostrarNumContact
            // 
            this.MostrarNumContact.Location = new System.Drawing.Point(654, 339);
            this.MostrarNumContact.Name = "MostrarNumContact";
            this.MostrarNumContact.Size = new System.Drawing.Size(260, 49);
            this.MostrarNumContact.TabIndex = 26;
            this.MostrarNumContact.Text = "Mostrar nº contactos por cliente";
            this.MostrarNumContact.UseVisualStyleBackColor = true;
            // 
            // AlterarCliente
            // 
            this.AlterarCliente.Location = new System.Drawing.Point(502, 192);
            this.AlterarCliente.Name = "AlterarCliente";
            this.AlterarCliente.Size = new System.Drawing.Size(130, 67);
            this.AlterarCliente.TabIndex = 27;
            this.AlterarCliente.Text = "Alterar dados do cliente";
            this.AlterarCliente.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(654, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "Data Nasc.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(691, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "NIF";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(691, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "Nome";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(748, 295);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(362, 26);
            this.textBox1.TabIndex = 30;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(748, 245);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(362, 26);
            this.textBox2.TabIndex = 29;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(748, 192);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(362, 26);
            this.textBox3.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(691, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 20);
            this.label10.TabIndex = 35;
            this.label10.Text = "ID";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(748, 146);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(362, 26);
            this.textBox4.TabIndex = 34;
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 618);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.AlterarCliente);
            this.Controls.Add(this.MostrarNumContact);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DescContacto);
            this.Controls.Add(this.ContactoTipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DataNascC);
            this.Controls.Add(this.NIFC);
            this.Controls.Add(this.NomeC);
            this.Controls.Add(this.InserirClienteContactoBotao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NIFREMOVE);
            this.Controls.Add(this.RemoverClienteBotao);
            this.Controls.Add(this.NomeTabela);
            this.Controls.Add(this.DataGridDados);
            this.Controls.Add(this.MostrarTabelaBotao);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Interface";
            this.Text = "InterfaceAAD";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NomeTabela;
        private System.Windows.Forms.Button RemoverClienteBotao;
        private System.Windows.Forms.TextBox NIFREMOVE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button InserirClienteContactoBotao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DataNascC;
        private System.Windows.Forms.TextBox NIFC;
        private System.Windows.Forms.TextBox NomeC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DescContacto;
        private System.Windows.Forms.TextBox ContactoTipo;
        private System.Windows.Forms.Button MostrarNumContact;
        private System.Windows.Forms.Button AlterarCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox4;
    }
}

