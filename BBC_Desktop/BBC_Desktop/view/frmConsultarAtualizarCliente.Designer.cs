namespace BBC_Desktop.view
{
    partial class frmConsultarAtualizarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarAtualizarCliente));
            this.dgwCliente = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbAtualizar = new System.Windows.Forms.GroupBox();
            this.lblAlterarSenha = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.mkdTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscarNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCliente)).BeginInit();
            this.gpbAtualizar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwCliente
            // 
            this.dgwCliente.AllowUserToAddRows = false;
            this.dgwCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Email,
            this.Column2});
            this.dgwCliente.Location = new System.Drawing.Point(21, 39);
            this.dgwCliente.MultiSelect = false;
            this.dgwCliente.Name = "dgwCliente";
            this.dgwCliente.ReadOnly = true;
            this.dgwCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwCliente.Size = new System.Drawing.Size(444, 114);
            this.dgwCliente.TabIndex = 1;
            this.dgwCliente.SelectionChanged += new System.EventHandler(this.dgwCliente_SelectionChanged);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "RA";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nome";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Telefone";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // gpbAtualizar
            // 
            this.gpbAtualizar.Controls.Add(this.lblAlterarSenha);
            this.gpbAtualizar.Controls.Add(this.btnAtualizar);
            this.gpbAtualizar.Controls.Add(this.mkdTelefone);
            this.gpbAtualizar.Controls.Add(this.label4);
            this.gpbAtualizar.Controls.Add(this.label3);
            this.gpbAtualizar.Controls.Add(this.txtEmail);
            this.gpbAtualizar.Controls.Add(this.txtNome);
            this.gpbAtualizar.Controls.Add(this.label2);
            this.gpbAtualizar.Location = new System.Drawing.Point(12, 159);
            this.gpbAtualizar.Name = "gpbAtualizar";
            this.gpbAtualizar.Size = new System.Drawing.Size(464, 131);
            this.gpbAtualizar.TabIndex = 2;
            this.gpbAtualizar.TabStop = false;
            this.gpbAtualizar.Text = "Informações para atualizar";
            // 
            // lblAlterarSenha
            // 
            this.lblAlterarSenha.AutoSize = true;
            this.lblAlterarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlterarSenha.Location = new System.Drawing.Point(384, 107);
            this.lblAlterarSenha.Name = "lblAlterarSenha";
            this.lblAlterarSenha.Size = new System.Drawing.Size(69, 13);
            this.lblAlterarSenha.TabIndex = 7;
            this.lblAlterarSenha.Text = "Alterar senha";
            this.lblAlterarSenha.Click += new System.EventHandler(this.lblAlterarSenha_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(9, 81);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(444, 23);
            this.btnAtualizar.TabIndex = 6;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // mkdTelefone
            // 
            this.mkdTelefone.Location = new System.Drawing.Point(370, 54);
            this.mkdTelefone.Mask = "(00)00000-0000";
            this.mkdTelefone.Name = "mkdTelefone";
            this.mkdTelefone.Size = new System.Drawing.Size(83, 20);
            this.mkdTelefone.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(50, 54);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(256, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(50, 28);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(403, 20);
            this.txtNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome:";
            // 
            // txtBuscarNome
            // 
            this.txtBuscarNome.Location = new System.Drawing.Point(62, 13);
            this.txtBuscarNome.Name = "txtBuscarNome";
            this.txtBuscarNome.Size = new System.Drawing.Size(403, 20);
            this.txtBuscarNome.TabIndex = 9;
            this.txtBuscarNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarNome_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome:";
            // 
            // frmConsultarAtualizarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 303);
            this.Controls.Add(this.txtBuscarNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpbAtualizar);
            this.Controls.Add(this.dgwCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultarAtualizarCliente";
            this.Text = "Consultar ou atualizar cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgwCliente)).EndInit();
            this.gpbAtualizar.ResumeLayout(false);
            this.gpbAtualizar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgwCliente;
        private System.Windows.Forms.GroupBox gpbAtualizar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAlterarSenha;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.MaskedTextBox mkdTelefone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.TextBox txtBuscarNome;
        private System.Windows.Forms.Label label1;
    }
}