using BBC_Desktop.connection;
using BBC_Desktop.model;
using MySql.Data.MySqlClient;
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
    public partial class frmConsultarAtualizarCliente : Form
    {
        public frmConsultarAtualizarCliente(bool consulta)
        {
            InitializeComponent();
            atualizaDataGridView();

            if (consulta)
            {
                gpbAtualizar.Enabled = false;
            }
        }

        private void atualizaDataGridView()
        {
            Cliente cliente = new Cliente();
            try
            {
                MySqlDataReader rCliente = cliente.consultaTodosClientes();
                dgwCliente.Rows.Clear();
                while (rCliente.Read())
                {
                    dgwCliente.Rows.Add(rCliente["ra"].ToString(), rCliente["nome"].ToString(), rCliente["email"].ToString(), rCliente["telefone"].ToString());
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

        private void lblAlterarSenha_Click(object sender, EventArgs e)
        {
            frmAlterarSenhaCliente frmAlter = new frmAlterarSenhaCliente();
            frmAlter.Show();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && txtEmail.Text != "" && mkdTelefone.Text != "(  )     -    ")
            {
                int ra = int.Parse(dgwCliente.SelectedRows[0].Cells[0].Value.ToString());
                Cliente cliente = new Cliente(ra, txtNome.Text, txtEmail.Text, mkdTelefone.Text);
                if (cliente.atualizarCliente())
                {
                    MessageBox.Show("Cliente atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK);
                    limpar();
                }
                else
                {
                    MessageBox.Show("Falha ao atualizar Cliente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nenhum campo pode estar vazio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgwCliente_SelectionChanged(object sender, EventArgs e)
        {
            string nome = dgwCliente.SelectedRows[0].Cells[1].Value.ToString();
            txtNome.Text = nome;
            string email = dgwCliente.SelectedRows[0].Cells[2].Value.ToString();
            txtEmail.Text = email;
            string telefone = dgwCliente.SelectedRows[0].Cells[3].Value.ToString();
            mkdTelefone.Text = telefone;
        }

        public void limpar()
        {
            txtEmail.Text = "";
            txtNome.Text = "";
            mkdTelefone.Text = "";
        }
    }
}
