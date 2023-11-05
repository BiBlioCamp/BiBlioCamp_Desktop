namespace BBC_Desktop.view
{
    partial class frmConsultarAtualizarLivro
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarAtualizarLivro));
            this.dgwLivros = new System.Windows.Forms.DataGridView();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbAtualizar = new System.Windows.Forms.GroupBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mkdData = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbClasse = new System.Windows.Forms.ComboBox();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLivros)).BeginInit();
            this.gpbAtualizar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwLivros
            // 
            this.dgwLivros.AllowUserToAddRows = false;
            this.dgwLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwLivros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titulo,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgwLivros.Location = new System.Drawing.Point(12, 14);
            this.dgwLivros.MultiSelect = false;
            this.dgwLivros.Name = "dgwLivros";
            this.dgwLivros.ReadOnly = true;
            this.dgwLivros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwLivros.Size = new System.Drawing.Size(544, 175);
            this.dgwLivros.TabIndex = 0;
            this.dgwLivros.SelectionChanged += new System.EventHandler(this.dgwLivros_SelectionChanged);
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Autor";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Editora";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Data";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Classificação";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // gpbAtualizar
            // 
            this.gpbAtualizar.Controls.Add(this.btnAtualizar);
            this.gpbAtualizar.Controls.Add(this.btnLimpar);
            this.gpbAtualizar.Controls.Add(this.label4);
            this.gpbAtualizar.Controls.Add(this.label5);
            this.gpbAtualizar.Controls.Add(this.label6);
            this.gpbAtualizar.Controls.Add(this.mkdData);
            this.gpbAtualizar.Controls.Add(this.label7);
            this.gpbAtualizar.Controls.Add(this.label8);
            this.gpbAtualizar.Controls.Add(this.cbbClasse);
            this.gpbAtualizar.Controls.Add(this.txtEditora);
            this.gpbAtualizar.Controls.Add(this.txtAutor);
            this.gpbAtualizar.Controls.Add(this.txtTitulo);
            this.gpbAtualizar.Location = new System.Drawing.Point(12, 195);
            this.gpbAtualizar.Name = "gpbAtualizar";
            this.gpbAtualizar.Size = new System.Drawing.Size(544, 213);
            this.gpbAtualizar.TabIndex = 3;
            this.gpbAtualizar.TabStop = false;
            this.gpbAtualizar.Text = "Atualizar";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(85, 172);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(361, 20);
            this.btnAtualizar.TabIndex = 23;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(309, 145);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(137, 20);
            this.btnLimpar.TabIndex = 22;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Classificação:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Editora:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Autor:";
            // 
            // mkdData
            // 
            this.mkdData.Location = new System.Drawing.Point(158, 109);
            this.mkdData.Mask = "00/00/0000";
            this.mkdData.Name = "mkdData";
            this.mkdData.Size = new System.Drawing.Size(66, 20);
            this.mkdData.TabIndex = 15;
            this.mkdData.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(83, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Titulo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(83, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Lançamento:";
            // 
            // cbbClasse
            // 
            this.cbbClasse.FormattingEnabled = true;
            this.cbbClasse.Items.AddRange(new object[] {
            "Romance",
            "Novela",
            "Conto",
            "Crônica",
            "Poema",
            "Canção",
            "Drama",
            "Historico",
            "Teatro de vanguarda",
            "Fantasia",
            "Ficção científica",
            "Distopia",
            "Ação e aventura",
            "Ficção Policial",
            "Horror",
            "Thriller e Suspense",
            "Realismo mágico",
            "Graphic Novel",
            "Infantil",
            "Memórias e autobiografia",
            "Biografia",
            "Gastronomia",
            "Arte e Fotografia",
            "Autoajuda",
            "Viagem",
            "Crimes Reais",
            "Humor",
            "Ensaios",
            "Guias & Como fazer",
            "Religião e Espiritualidade",
            "Humanidades e Ciências Sociais",
            "Tecnologia e Ciência"});
            this.cbbClasse.Location = new System.Drawing.Point(308, 109);
            this.cbbClasse.Name = "cbbClasse";
            this.cbbClasse.Size = new System.Drawing.Size(138, 21);
            this.cbbClasse.TabIndex = 16;
            // 
            // txtEditora
            // 
            this.txtEditora.Location = new System.Drawing.Point(132, 146);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(160, 20);
            this.txtEditora.TabIndex = 14;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(124, 73);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(322, 20);
            this.txtAutor.TabIndex = 13;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(124, 35);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(322, 20);
            this.txtTitulo.TabIndex = 12;
            // 
            // frmConsultarAtualizarLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 418);
            this.Controls.Add(this.gpbAtualizar);
            this.Controls.Add(this.dgwLivros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultarAtualizarLivro";
            this.Text = "Consultar ou Atualizar Livro";
            ((System.ComponentModel.ISupportInitialize)(this.dgwLivros)).EndInit();
            this.gpbAtualizar.ResumeLayout(false);
            this.gpbAtualizar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwLivros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox gpbAtualizar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mkdData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbClasse;
        private System.Windows.Forms.TextBox txtEditora;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtTitulo;
    }
}