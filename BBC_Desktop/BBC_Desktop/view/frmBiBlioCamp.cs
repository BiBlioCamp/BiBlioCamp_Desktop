using BBC_Desktop.connection;
using BBC_Desktop.model;
using BBC_Desktop.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBC_Desktop
{
    public partial class frmBiBliocamp : Form
    {
        public frmBiBliocamp()
        {
            InitializeComponent();
            if (Conexao.getConexao("143.106.241.3", "cl202235", "cl202235", "cl*17062007"))
                Console.WriteLine("Conectado!");
            else 
                Console.WriteLine("Erro de conexão!");
            mspBiBliocamp.Enabled = false;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = new Usuario(txtUsername.Text, txtSenha.Text);
                if (usuario.consultarUsuario())
                {
                    //MessageBox.Show("Bem vindo " + txtUsername.Text + "!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gpbLogin.Visible = false;
                    mspBiBliocamp.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Senha ou usuário incorreto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void cadastrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrarCliente cadastrarCliente = new frmCadastrarCliente();
            cadastrarCliente.MdiParent = this;
            cadastrarCliente.Show();
        }

        private void cadastrarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrarUsuario cadastrarUsuario = new frmCadastrarUsuario();
            cadastrarUsuario.MdiParent = this;
            cadastrarUsuario.Show();
        }

        private void cadastroDeLivroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrarLivro cadastrarLivro = new frmCadastrarLivro();
            cadastrarLivro.MdiParent = this;
            cadastrarLivro.Show();
        }

        private void consultarLivrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarAtualizarLivro conAttLivro = new frmConsultarAtualizarLivro();
            conAttLivro.MdiParent = this;
            conAttLivro.Show();
        }

        private void atualizarLivroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarAtualizarLivro conAttLivro = new frmConsultarAtualizarLivro();
            conAttLivro.MdiParent = this;
            conAttLivro.Show();
        }

        private void lblSenha_Click(object sender, EventArgs e)
        {
            frmAlterarSenhaUsuario alterarSenha = new frmAlterarSenhaUsuario();
            alterarSenha.MdiParent = this;
            alterarSenha.Show();
        }

        private void consultarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarAtualizarCliente consultaAltera = new frmConsultarAtualizarCliente();
            consultaAltera.MdiParent = this;
            consultaAltera.Show();
        }

        private void alterarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarAtualizarCliente consultaAltera = new frmConsultarAtualizarCliente();
            consultaAltera.MdiParent = this;
            consultaAltera.Show();
        }
    }
}
