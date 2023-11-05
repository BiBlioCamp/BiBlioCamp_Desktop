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
    public partial class frmCadastrarLivro : Form
    {
        public frmCadastrarLivro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ConverterFoto() != null && txtAutor.Text != "" && txtEditora.Text != "" && txtTitulo.Text != "" && mkdData.Text != ""
                && cbbClasse.Text != "")
            {
                byte[] foto = ConverterFoto();
                Livro livro = new Livro(txtTitulo.Text, txtAutor.Text, txtEditora.Text, mkdData.Text, cbbClasse.Text, foto);

                if(livro.cadastrarLivro())
                {
                    MessageBox.Show("Livro cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK);
                    limpar();
                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar livro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nenhum campo pode estar vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void limpar()
        {
            txtAutor.Text = "";
            txtTitulo.Text = "";
            txtEditora.Text = "";
            mkdData.Text = "";
            cbbClasse.Text = "";
        }

        private byte[] ConverterFoto()
        {
            byte[] bArray = null;
            using (var stream = new System.IO.MemoryStream())
            {
                if (ptbFoto.Image != null)
                {
                    ptbFoto.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    stream.Seek(0, System.IO.SeekOrigin.Begin);
                    bArray = new byte[stream.Length];
                    stream.Read(bArray, 0, System.Convert.ToInt32(stream.Length));
                }
                else
                {
                    MessageBox.Show("Insira uma imagem para continuar o cadastro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            return bArray;
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Title = "Abrir Foto";
            dialog.Filter = "JPG (*.jpg)|*.jpg" + "|All files (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ptbFoto.Image = new Bitmap(dialog.OpenFile());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possivel carregar a foto: " + ex.Message);
                }
            }
            dialog.Dispose();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }
    }
}
