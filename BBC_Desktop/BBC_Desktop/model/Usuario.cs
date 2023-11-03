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
        private string username, senha;

        public string Username { get => username; set => username = value; }
        public string Senha { get => senha; set => senha = value; }

        public Usuario() { }

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
                MySqlCommand cadastrar = new MySqlCommand("insert into BBC_User (username, senha) values ('" +
                    username + "', '" + senha + "')", Conexao.con);
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
    }
}
