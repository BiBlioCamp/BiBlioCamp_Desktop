
namespace BBC_Desktop
{
    partial class frmBiBliocamp
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBiBliocamp));
            this.mspBiBliocamp = new System.Windows.Forms.MenuStrip();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeLivroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarLivrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarLivroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpbLogin = new System.Windows.Forms.GroupBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.mspBiBliocamp.SuspendLayout();
            this.gpbLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // mspBiBliocamp
            // 
            this.mspBiBliocamp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuárioToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.livroToolStripMenuItem});
            this.mspBiBliocamp.Location = new System.Drawing.Point(0, 0);
            this.mspBiBliocamp.Name = "mspBiBliocamp";
            this.mspBiBliocamp.Size = new System.Drawing.Size(1094, 24);
            this.mspBiBliocamp.TabIndex = 1;
            this.mspBiBliocamp.Text = "menuStrip1";
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarUsuárioToolStripMenuItem,
            this.consultarUsuárioToolStripMenuItem,
            this.atualizarUsuárioToolStripMenuItem});
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.usuárioToolStripMenuItem.Text = "Usuário";
            // 
            // cadastrarUsuárioToolStripMenuItem
            // 
            this.cadastrarUsuárioToolStripMenuItem.Name = "cadastrarUsuárioToolStripMenuItem";
            this.cadastrarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.cadastrarUsuárioToolStripMenuItem.Text = "Cadastrar Usuário";
            this.cadastrarUsuárioToolStripMenuItem.Click += new System.EventHandler(this.cadastrarUsuárioToolStripMenuItem_Click);
            // 
            // consultarUsuárioToolStripMenuItem
            // 
            this.consultarUsuárioToolStripMenuItem.Name = "consultarUsuárioToolStripMenuItem";
            this.consultarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.consultarUsuárioToolStripMenuItem.Text = "Consultar Usuário";
            this.consultarUsuárioToolStripMenuItem.Click += new System.EventHandler(this.consultarUsuárioToolStripMenuItem_Click);
            // 
            // atualizarUsuárioToolStripMenuItem
            // 
            this.atualizarUsuárioToolStripMenuItem.Name = "atualizarUsuárioToolStripMenuItem";
            this.atualizarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.atualizarUsuárioToolStripMenuItem.Text = "Atualizar Usuário";
            this.atualizarUsuárioToolStripMenuItem.Click += new System.EventHandler(this.atualizarUsuárioToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarClienteToolStripMenuItem,
            this.consultarClienteToolStripMenuItem,
            this.alterarClienteToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // cadastrarClienteToolStripMenuItem
            // 
            this.cadastrarClienteToolStripMenuItem.Name = "cadastrarClienteToolStripMenuItem";
            this.cadastrarClienteToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.cadastrarClienteToolStripMenuItem.Text = "Cadastrar Cliente";
            this.cadastrarClienteToolStripMenuItem.Click += new System.EventHandler(this.cadastrarClienteToolStripMenuItem_Click);
            // 
            // consultarClienteToolStripMenuItem
            // 
            this.consultarClienteToolStripMenuItem.Name = "consultarClienteToolStripMenuItem";
            this.consultarClienteToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.consultarClienteToolStripMenuItem.Text = "Consultar Cliente";
            this.consultarClienteToolStripMenuItem.Click += new System.EventHandler(this.consultarClienteToolStripMenuItem_Click);
            // 
            // alterarClienteToolStripMenuItem
            // 
            this.alterarClienteToolStripMenuItem.Name = "alterarClienteToolStripMenuItem";
            this.alterarClienteToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.alterarClienteToolStripMenuItem.Text = "Atualizar Cliente";
            this.alterarClienteToolStripMenuItem.Click += new System.EventHandler(this.alterarClienteToolStripMenuItem_Click);
            // 
            // livroToolStripMenuItem
            // 
            this.livroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeLivroToolStripMenuItem,
            this.consultarLivrosToolStripMenuItem,
            this.atualizarLivroToolStripMenuItem});
            this.livroToolStripMenuItem.Name = "livroToolStripMenuItem";
            this.livroToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.livroToolStripMenuItem.Text = "Livro";
            // 
            // cadastroDeLivroToolStripMenuItem
            // 
            this.cadastroDeLivroToolStripMenuItem.Name = "cadastroDeLivroToolStripMenuItem";
            this.cadastroDeLivroToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.cadastroDeLivroToolStripMenuItem.Text = "Cadastrar Livro";
            this.cadastroDeLivroToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeLivroToolStripMenuItem_Click);
            // 
            // consultarLivrosToolStripMenuItem
            // 
            this.consultarLivrosToolStripMenuItem.Name = "consultarLivrosToolStripMenuItem";
            this.consultarLivrosToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.consultarLivrosToolStripMenuItem.Text = "Consultar Livros";
            this.consultarLivrosToolStripMenuItem.Click += new System.EventHandler(this.consultarLivrosToolStripMenuItem_Click);
            // 
            // atualizarLivroToolStripMenuItem
            // 
            this.atualizarLivroToolStripMenuItem.Name = "atualizarLivroToolStripMenuItem";
            this.atualizarLivroToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.atualizarLivroToolStripMenuItem.Text = "Atualizar Livro";
            this.atualizarLivroToolStripMenuItem.Click += new System.EventHandler(this.atualizarLivroToolStripMenuItem_Click);
            // 
            // gpbLogin
            // 
            this.gpbLogin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gpbLogin.Controls.Add(this.lblSenha);
            this.gpbLogin.Controls.Add(this.btnEntrar);
            this.gpbLogin.Controls.Add(this.label1);
            this.gpbLogin.Controls.Add(this.txtSenha);
            this.gpbLogin.Controls.Add(this.txtUsername);
            this.gpbLogin.Controls.Add(this.lblAdmin);
            this.gpbLogin.Location = new System.Drawing.Point(328, 156);
            this.gpbLogin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gpbLogin.Name = "gpbLogin";
            this.gpbLogin.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gpbLogin.Size = new System.Drawing.Size(418, 257);
            this.gpbLogin.TabIndex = 5;
            this.gpbLogin.TabStop = false;
            this.gpbLogin.Text = "Login";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(79, 194);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(102, 13);
            this.lblSenha.TabIndex = 5;
            this.lblSenha.Text = "Esqueceu a senha?";
            this.lblSenha.Click += new System.EventHandler(this.lblSenha_Click_1);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(82, 168);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(262, 23);
            this.btnEntrar.TabIndex = 4;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 3;
            this.label1.Tag = "";
            this.label1.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(124, 117);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(220, 20);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.Text = "B1nair3";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(124, 65);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(220, 20);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Text = "Carrilho";
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.Location = new System.Drawing.Point(63, 65);
            this.lblAdmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(57, 16);
            this.lblAdmin.TabIndex = 0;
            this.lblAdmin.Text = "Usuário:";
            // 
            // frmBiBliocamp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1094, 604);
            this.Controls.Add(this.gpbLogin);
            this.Controls.Add(this.mspBiBliocamp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mspBiBliocamp;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmBiBliocamp";
            this.Text = "BiBlioCamp";
            this.mspBiBliocamp.ResumeLayout(false);
            this.mspBiBliocamp.PerformLayout();
            this.gpbLogin.ResumeLayout(false);
            this.gpbLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mspBiBliocamp;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem livroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeLivroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarLivrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarLivroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarClienteToolStripMenuItem;
        private System.Windows.Forms.GroupBox gpbLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.ToolStripMenuItem consultarUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarUsuárioToolStripMenuItem;
    }
}

