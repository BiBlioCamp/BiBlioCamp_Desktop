using BBC_Desktop.connection;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBC_Desktop.model
{
    internal class Livro
    {
        private string titulo, autor, editora, data, classe;
        byte[] foto;
        private int codigo;

        public Livro(string titulo, string autor, string editora, string data, string classe, byte[] foto)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.editora = editora;
            this.data = data;
            this.classe = classe;
            this.foto = foto;
        }

        public Livro(string titulo, string autor, string editora, string data, string classe, int codigo)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.editora = editora;
            this.data = data;
            this.classe = classe;
            this.codigo = codigo;
        }

        public Livro(string titulo, string autor, string editora, string data, string classe)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.editora = editora;
            this.data = data;
            this.classe = classe;
        }

        public Livro()
        {
        }
        public Livro(string titulo)
        {
            this.titulo = titulo;
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Editora { get => editora; set => editora = value; }
        public string Data { get => data; set => data = value; }
        public string Classe { get => classe; set => classe = value; }
        public byte[] Foto { get => foto; set => foto = value; }
        public int Codigo { get => codigo; set => codigo = value; }

        public bool cadastrarLivro()
        {
            bool cad = false;
            try
            {
                Conexao.con.Open();
                MySqlCommand cadastro = new MySqlCommand("insert into BBC_Livro (titulo, autor, editora, data, classificacao, foto)" +
                    " values ('" + titulo + "','" + autor + "','" + editora + "','" + data + "','" + classe + "', @foto)", Conexao.con);
                cadastro.Parameters.AddWithValue("foto", this.foto);
                cadastro.ExecuteNonQuery();
                cad = true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Conexao.con.Close();
            }

            return cad;
        }

        public bool atualizarLivro()
        {
            bool cad = false;
            try
            {
                Conexao.con.Open();
                MySqlCommand atualiza = new MySqlCommand("update BBC_Livro set titulo = '" + titulo + "', autor = '" + autor +
                    "', editora = '" + editora + "', data = '" + data + "', classificacao = '" + classe + "' where codigo = " +
                    codigo, Conexao.con);
                atualiza.ExecuteNonQuery();
                cad = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Conexao.con.Close();
            }

            return cad;
        }

        public MySqlDataReader consultarTodosLivros()
        {
            MySqlDataReader consulta = null;
            try
            {
                Conexao.con.Open();
                MySqlCommand consultar = new MySqlCommand("select * from BBC_Livro", Conexao.con);
                consulta = consultar.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return consulta;
        }

        public int consultarIdLivro()
        {
            MySqlDataReader consulta;
            int id = 0;
            try
            {
                Conexao.con.Open();
                MySqlCommand consultar = new MySqlCommand("select * from BBC_Livro where titulo = '" + titulo + "' and autor = '"
                    + autor + "' and editora = '" + editora + "' and data = '" + data + "' and classificacao = '" + classe +
                    "'", Conexao.con);
                consulta = consultar.ExecuteReader();
                if(consulta.Read())
                {
                    id = int.Parse(consulta["codigo"].ToString());
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

            return id;
        }

        public MySqlDataReader consultarLivro()
        {
            MySqlDataReader consulta = null;
            try
            {
                Conexao.con.Open();
                MySqlCommand consultar = new MySqlCommand("select * from BBC_Livro where titulo like '%" + titulo + "%'", Conexao.con);
                consulta = consultar.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return consulta;
        }
    }
}
