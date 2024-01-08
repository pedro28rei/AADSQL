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
        System.Windows.Forms.Button InserirDadosButton;
        System.Windows.Forms.Button MostrarDadosButton;
        System.Windows.Forms.DataGridView dataGridDados;
        #endregion

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InserirDadosButton = new System.Windows.Forms.Button();
            this.MostrarDadosButton = new System.Windows.Forms.Button();
            this.dataGridDados = new System.Windows.Forms.DataGridView();
            this.NomeTabela = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.TextBox();
            this.NIFADD = new System.Windows.Forms.TextBox();
            this.DataNasc = new System.Windows.Forms.TextBox();
            this.CNome = new System.Windows.Forms.Label();
            this.CNIF = new System.Windows.Forms.Label();
            this.CDataNasc = new System.Windows.Forms.Label();
            this.RemoverButton = new System.Windows.Forms.Button();
            this.NIFREMOVE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDados)).BeginInit();
            this.SuspendLayout();
            // 
            // InserirDadosButton
            // 
            this.InserirDadosButton.Location = new System.Drawing.Point(33, 87);
            this.InserirDadosButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InserirDadosButton.Name = "InserirDadosButton";
            this.InserirDadosButton.Size = new System.Drawing.Size(139, 49);
            this.InserirDadosButton.TabIndex = 0;
            this.InserirDadosButton.Text = "Inserir";
            this.InserirDadosButton.UseVisualStyleBackColor = true;
            this.InserirDadosButton.Click += new System.EventHandler(this.InserirDadosButton_Click);
            // 
            // MostrarDadosButton
            // 
            this.MostrarDadosButton.Location = new System.Drawing.Point(33, 231);
            this.MostrarDadosButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MostrarDadosButton.Name = "MostrarDadosButton";
            this.MostrarDadosButton.Size = new System.Drawing.Size(139, 49);
            this.MostrarDadosButton.TabIndex = 1;
            this.MostrarDadosButton.Text = "Mostrar";
            this.MostrarDadosButton.UseVisualStyleBackColor = true;
            this.MostrarDadosButton.Click += new System.EventHandler(this.MostrarDadosButton_Click);
            // 
            // dataGridDados
            // 
            this.dataGridDados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridDados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDados.Location = new System.Drawing.Point(83, 318);
            this.dataGridDados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridDados.Name = "dataGridDados";
            this.dataGridDados.RowHeadersWidth = 51;
            this.dataGridDados.RowTemplate.Height = 24;
            this.dataGridDados.Size = new System.Drawing.Size(1027, 191);
            this.dataGridDados.TabIndex = 2;
            // 
            // NomeTabela
            // 
            this.NomeTabela.Location = new System.Drawing.Point(267, 254);
            this.NomeTabela.Name = "NomeTabela";
            this.NomeTabela.Size = new System.Drawing.Size(362, 26);
            this.NomeTabela.TabIndex = 3;
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(267, 42);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(362, 26);
            this.Nome.TabIndex = 4;
            // 
            // NIFADD
            // 
            this.NIFADD.Location = new System.Drawing.Point(267, 95);
            this.NIFADD.Name = "NIFADD";
            this.NIFADD.Size = new System.Drawing.Size(362, 26);
            this.NIFADD.TabIndex = 5;
            // 
            // DataNasc
            // 
            this.DataNasc.Location = new System.Drawing.Point(267, 145);
            this.DataNasc.Name = "DataNasc";
            this.DataNasc.Size = new System.Drawing.Size(362, 26);
            this.DataNasc.TabIndex = 6;
            // 
            // CNome
            // 
            this.CNome.AutoSize = true;
            this.CNome.Location = new System.Drawing.Point(210, 45);
            this.CNome.Name = "CNome";
            this.CNome.Size = new System.Drawing.Size(51, 20);
            this.CNome.TabIndex = 7;
            this.CNome.Text = "Nome";
            // 
            // CNIF
            // 
            this.CNIF.AutoSize = true;
            this.CNIF.Location = new System.Drawing.Point(210, 101);
            this.CNIF.Name = "CNIF";
            this.CNIF.Size = new System.Drawing.Size(35, 20);
            this.CNIF.TabIndex = 8;
            this.CNIF.Text = "NIF";
            // 
            // CDataNasc
            // 
            this.CDataNasc.AutoSize = true;
            this.CDataNasc.Location = new System.Drawing.Point(173, 151);
            this.CDataNasc.Name = "CDataNasc";
            this.CDataNasc.Size = new System.Drawing.Size(88, 20);
            this.CDataNasc.TabIndex = 9;
            this.CDataNasc.Text = "Data Nasc.";
            // 
            // RemoverButton
            // 
            this.RemoverButton.Location = new System.Drawing.Point(682, 87);
            this.RemoverButton.Name = "RemoverButton";
            this.RemoverButton.Size = new System.Drawing.Size(139, 49);
            this.RemoverButton.TabIndex = 10;
            this.RemoverButton.Text = "Remover";
            this.RemoverButton.UseVisualStyleBackColor = true;
            this.RemoverButton.Click += new System.EventHandler(this.RemoverButton_Click);
            // 
            // NIFREMOVE
            // 
            this.NIFREMOVE.Location = new System.Drawing.Point(873, 98);
            this.NIFREMOVE.Name = "NIFREMOVE";
            this.NIFREMOVE.Size = new System.Drawing.Size(237, 26);
            this.NIFREMOVE.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(827, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "NIF";
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 562);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NIFREMOVE);
            this.Controls.Add(this.RemoverButton);
            this.Controls.Add(this.CDataNasc);
            this.Controls.Add(this.CNIF);
            this.Controls.Add(this.CNome);
            this.Controls.Add(this.DataNasc);
            this.Controls.Add(this.NIFADD);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.NomeTabela);
            this.Controls.Add(this.dataGridDados);
            this.Controls.Add(this.MostrarDadosButton);
            this.Controls.Add(this.InserirDadosButton);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Interface";
            this.Text = "InterfaceAAD";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NomeTabela;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.TextBox NIFADD;
        private System.Windows.Forms.TextBox DataNasc;
        private System.Windows.Forms.Label CNome;
        private System.Windows.Forms.Label CNIF;
        private System.Windows.Forms.Label CDataNasc;
        private System.Windows.Forms.Button RemoverButton;
        private System.Windows.Forms.TextBox NIFREMOVE;
        private System.Windows.Forms.Label label1;
    }
}

