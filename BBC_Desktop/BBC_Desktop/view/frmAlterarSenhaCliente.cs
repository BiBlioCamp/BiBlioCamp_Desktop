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

namespace BBC_Desktop.view
{
    public partial class frmAlterarSenhaCliente : Form
    {
        public frmAlterarSenhaCliente()
        {
            InitializeComponent();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtConfirmarSenha.Text != "" && txtSenha.Text != "" && txtRa.Text != "")
            {
                if (txtSenha.Text == txtConfirmarSenha.Text)
                {
                    Cliente cliente = new Cliente(int.Parse(txtRa.Text), txtSenha.Text);
                    if (cliente.consultarCliente() == false)
                    {
                        if (cliente.consultarExistencia())
                        {
                            if (cliente.alterarSenha())
                            {
                                MessageBox.Show("Senha alterada com sucesso!", "Sucesso", MessageBoxButtons.OK);
                                limpar();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Falha ao alterar senha!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Esse cliente não existe!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("A nova senha não pode ser igual a antiga!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("As senhas não coincidem!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Nenhum campo pode estar vazio!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void limpar()
        {
            txtConfirmarSenha.Text = "";
            txtSenha.Text = "";
            txtRa.Text = "";
        }

        private void txtRa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }
    }
}
