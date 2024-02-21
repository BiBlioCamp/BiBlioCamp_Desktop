using BBC_Desktop.model;
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
    public partial class frmCadastrarUsuario : Form
    {
        public frmCadastrarUsuario()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text != "" && txtConfirmarSenha.Text != "" && txtUsername.Text != "" && txtEmail.Text != "")
            {
                if (txtSenha.Text == txtConfirmarSenha.Text)
                {
                    Usuario user = new Usuario(txtUsername.Text, txtSenha.Text, txtEmail.Text);
                    if (user.cadastrarUsuario())
                    {
                        MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK);
                        limpar();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao cadastrar usuário!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("As senhas não coincidem!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Nenhum campo pode estar vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void limpar()
        {
            txtUsername.Text = "";
            txtSenha.Text = "";
            txtConfirmarSenha.Text = "";
            txtEmail.Text = "";
        }
    }
}
