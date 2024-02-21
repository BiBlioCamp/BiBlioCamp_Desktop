using BBC_Desktop.connection;
using BBC_Desktop.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBC_Desktop.view
{
    public partial class frmConsultarAtualizarUsuario : Form
    {
        public frmConsultarAtualizarUsuario(bool consulta)
        {
            InitializeComponent();
            atualizaDataGridView();
            if (consulta)
            {
                groupBox1.Enabled = false;
            }
        }
        private void atualizaDataGridView()
        {
            Usuario usuario = new Usuario();
            try
            {
                MySqlDataReader rUsuario = usuario.consultaTodosUsuarios();
                dgwUsuario.Rows.Clear();
                while (rUsuario.Read())
                {
                    dgwUsuario.Rows.Add(rUsuario["username"].ToString(), rUsuario["email"].ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Conexao.con.Close();
            }
        }

        private void lblSenha_Click(object sender, EventArgs e)
        {
            //cria uma mensagem
            /*MailMessage mail = new MailMessage();

            //define os endereços
            mail.From = new MailAddress("jgamec2019@gmail.com");
            mail.To.Add(txtEmail.Text);

            //define o conteúdo
            mail.Subject = "Alterar senha";
            mail.Body = "Seu código para alterar sua senha no programa BiBlioCamp dirigido pelos estudantes do Cotil (UNICAMP): 1313";

            //envia a mensagem
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Send(mail);*/

            frmAlterarSenhaUsuario frmAlter = new frmAlterarSenhaUsuario();
            frmAlter.Show();
        }

        private void btnAtualizar_Click_1(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && txtEmail.Text != "")
            {
                string username = dgwUsuario.SelectedRows[0].Cells[0].Value.ToString();
                Usuario usuario = new Usuario(username, txtUsername.Text, txtEmail.Text);
                if (usuario.atualizarUsuario())
                {
                    MessageBox.Show("Usuario atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK);
                    txtUsername.Text = "";
                    txtEmail.Text = "";
                    atualizaDataGridView();
                }
                else
                {
                    MessageBox.Show("Falha ao atualizar Usuario!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nenhum campo pode estar vazio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgwUsuario_SelectionChanged(object sender, EventArgs e)
        {
            string nome = dgwUsuario.SelectedRows[0].Cells[0].Value.ToString();
            txtUsername.Text = nome;
            string email = dgwUsuario.SelectedRows[0].Cells[1].Value.ToString();
            txtEmail.Text = email;
        }
    }
}
