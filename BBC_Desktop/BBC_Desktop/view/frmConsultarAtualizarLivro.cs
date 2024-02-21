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
    public partial class frmConsultarAtualizarLivro : Form
    {
        public frmConsultarAtualizarLivro(bool consulta)
        {
            InitializeComponent();
            atualizaDataGridView();

            if (consulta)
            {
                gpbAtualizar.Enabled = false;
            }
        }

        public void atualizaDataGridView()
        {
            Livro livro = new Livro();
            try
            {
                MySqlDataReader rLivro = livro.consultarTodosLivros();

                dgwLivros.Rows.Clear();
                while (rLivro.Read())
                {
                    dgwLivros.Rows.Add(rLivro["titulo"].ToString(), rLivro["autor"].ToString(), rLivro["editora"].ToString(),
                        rLivro["data"].ToString(), rLivro["classificacao"].ToString());
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        public void limpar()
        {
            txtAutor.Text = "";
            txtTitulo.Text = "";
            txtEditora.Text = "";
            mkdData.Text = "";
            cbbClasse.Text = "";
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (txtAutor.Text != "" && txtEditora.Text != "" && txtTitulo.Text != "" && mkdData.Text != ""
                && cbbClasse.Text != "")
            {
                string titulo = dgwLivros.SelectedRows[0].Cells[0].Value.ToString();
                string autor = dgwLivros.SelectedRows[0].Cells[1].Value.ToString();
                string editora = dgwLivros.SelectedRows[0].Cells[2].Value.ToString();
                string data = dgwLivros.SelectedRows[0].Cells[3].Value.ToString();
                string classificacao = dgwLivros.SelectedRows[0].Cells[4].Value.ToString();

                Livro livro = new Livro(titulo, autor, editora, data, classificacao);
                int id = livro.consultarIdLivro();

                Livro livroNovo = new Livro(txtTitulo.Text, txtAutor.Text, txtEditora.Text, mkdData.Text, cbbClasse.Text, id);
                if (livroNovo.atualizarLivro())
                {
                    MessageBox.Show("Livro atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK);
                    atualizaDataGridView();
                    limpar();
                }
                else
                {
                    MessageBox.Show("Falha ao atualizar livro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nenhum campo pode ser atualizado para vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgwLivros_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                String titulo = dgwLivros.SelectedRows[0].Cells[0].Value.ToString();
                String autor = dgwLivros.SelectedRows[0].Cells[1].Value.ToString();
                String editora = dgwLivros.SelectedRows[0].Cells[2].Value.ToString();
                String data = dgwLivros.SelectedRows[0].Cells[3].Value.ToString();
                String classificacao = dgwLivros.SelectedRows[0].Cells[4].Value.ToString();
                txtTitulo.Text = titulo;
                txtAutor.Text = autor;
                txtEditora.Text = editora;
                mkdData.Text = data;
                cbbClasse.Text = classificacao;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void txtBuscarTitulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Livro livro = new Livro(txtBuscarTitulo.Text);
            MySqlDataReader rLivro;
            try
            {
                rLivro = livro.consultarLivro();

                dgwLivros.Rows.Clear();
                while (rLivro.Read())
                {
                    dgwLivros.Rows.Add(rLivro["titulo"].ToString(), rLivro["autor"].ToString(), rLivro["editora"].ToString(),
                        rLivro["data"].ToString(), rLivro["classificacao"].ToString());
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
    }
}
