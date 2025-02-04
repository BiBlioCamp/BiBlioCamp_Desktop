﻿using BBC_Desktop.model;
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
    public partial class frmAlterarSenhaUsuario : Form
    {
        public frmAlterarSenhaUsuario()
        {
            InitializeComponent();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtConfirmarSenha.Text != "" && txtSenha.Text != "" && txtUsuario.Text != "")
            {
                if (txtSenha.Text == txtConfirmarSenha.Text)
                {
                    Usuario usuario = new Usuario(txtUsuario.Text, txtSenha.Text);
                    if (usuario.consultarUsuario() == false)
                    {
                        if (usuario.consultarUser())
                        {
                            if (usuario.alterarSenha())
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
                            MessageBox.Show("Esse usuário não existe!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            txtUsuario.Text = "";
        }
    }
}
