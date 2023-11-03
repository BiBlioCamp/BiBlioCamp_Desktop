using BBC_Desktop.connection;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBC_Desktop.model
{
    internal class Cliente
    {
        private string email, senha, nome, telefone;
        int ra;
        byte[] foto;

        public Cliente(string email, string senha, string nome, string telefone, int ra, byte[] foto)
        {
            this.Email = email;
            this.Senha = senha;
            this.Nome = nome;
            this.Telefone = telefone;
            this.Ra = ra;
            this.Foto = foto;
        }

        public string Email { get => email; set => email = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public int Ra { get => ra; set => ra = value; }
        public byte[] Foto { get => foto; set => foto = value; }

        public bool cadastrarCliente()
        {
            bool cadastro = false;
            try
            {
                Conexao.con.Open();
                MySqlCommand cadastra = new MySqlCommand("insert into BBC_Cliente (nome, email, senha, telefone, ra, foto)" +
                    "values ('" + nome + "', '" + email + "', '" + senha + "', '" + telefone + "', " + ra + ", @foto)", Conexao.con);
                cadastra.Parameters.AddWithValue("foto", this.foto);
                cadastra.ExecuteNonQuery();
                cadastro = true;
            }
            finally
            {
                Conexao.con.Close();
            }
            return cadastro;
        }
    }
}
