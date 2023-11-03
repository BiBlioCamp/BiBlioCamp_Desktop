using BBC_Desktop.model;
using System;
using System.Collections;
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
    public partial class frmCadastrarCliente : Form
    {
        public frmCadastrarCliente()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ConverterFoto() != null && txtEmail.Text != "" && txtNome.Text != "" && txtRa.Text != "")
            {
                byte[] foto = ConverterFoto();
                Cliente cliente = new Cliente(txtEmail.Text, txtSenha.Text, txtNome.Text, mkdTelefone.Text,
                    int.Parse(txtRa.Text), foto);

                try
                {
                    if (cliente.cadastrarCliente())
                    {
                        MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK);
                        limpar();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao cadastrar cliente!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Nenhum campo pode estar vazio!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        public void limpar()
        {
            txtRa.Text = "";
            txtNome.Text = "";
            txtEmail.Text = "";
            txtSenha.Text = "";
            mkdTelefone.Text = "";
            ptbFoto.Image = null;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
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
    }
}
