using BBC_Desktop.connection;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBC_Desktop.model
{
    internal class Usuario
    {
        private string username, senha, email;

        public string Username { get => username; set => username = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Email { get => email; set => email = value; }

        public Usuario() { }

        public Usuario(string username) {
            Username = username;
        }

        public Usuario(string username, string senha, string email)
        {
            Username = username;
            Senha = senha;
            Email = email;
        }

        public Usuario(string username, string senha)
        {
            Username = username;
            Senha = senha;
        }

        public bool cadastrarUsuario()
        {
            bool cadastro = false;
            try
            {
                Conexao.con.Open();
                MySqlCommand cadastrar = new MySqlCommand("insert into BBC_User (username, senha, email) values ('" +
                    username + "', '" + senha + "','" + email + "')", Conexao.con);
                cadastrar.ExecuteNonQuery();
                cadastro = true;
            }
            finally
            {
                Conexao.con.Close();
            }
            return cadastro;
        }

        public bool consultarUsuario()
        {
            bool consulta = false;
            try
            {
                Conexao.con.Open();
                MySqlCommand consultar = new MySqlCommand("select * from BBC_User where username = '" + username + "' and senha = '" + 
                    senha + "'", Conexao.con);
                MySqlDataReader resultado = consultar.ExecuteReader();
                if (resultado.Read())
                {
                    consulta = true;
                }
            }
            finally
            {
                Conexao.con.Close();
            }
            return consulta;
        }

        public bool consultarUser()
        {
            bool consulta = false;
            try
            {
                Conexao.con.Open();
                MySqlCommand consultar = new MySqlCommand("select * from BBC_User where username = '" + username + "'", Conexao.con);
                MySqlDataReader resultado = consultar.ExecuteReader();
                if (resultado.Read())
                {
                    consulta = true;
                }
            }
            finally
            {
                Conexao.con.Close();
            }
            return consulta;
        }

        public MySqlDataReader consultarUsername()
        {
            MySqlDataReader resultado = null;

            try
            {
                Conexao.con.Open();
                MySqlCommand consultar = new MySqlCommand("select * from BBC_User where username like '%" + username + "%'", Conexao.con);
                resultado = consultar.ExecuteReader();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return resultado;
        }

        public bool alterarSenha()
        {
            bool alterou = false;
            try
            {
                Conexao.con.Open();
                MySqlCommand altera = new MySqlCommand("update BBC_User set senha = '" + senha + "' where username = '"
                    + username + "'", Conexao.con);
                altera.ExecuteNonQuery();
                alterou = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Conexao.con.Close();
            }
            
            return alterou;
        }

        public bool atualizarUsuario()
        {
            bool alterou = false;
            try
            {
                Conexao.con.Open();
                MySqlCommand altera = new MySqlCommand("update BBC_User set username = '" + senha + "', email = '" + email + 
                    "' where username = '" + username + "'", Conexao.con);
                altera.ExecuteNonQuery();
                alterou = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Conexao.con.Close();
            }

            return alterou;
        }

        public MySqlDataReader consultaTodosUsuarios()
        {
            MySqlDataReader resultado = null;
            try
            {
                Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select * from BBC_User", Conexao.con);
                resultado = consulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return resultado;
        }
    }
}
