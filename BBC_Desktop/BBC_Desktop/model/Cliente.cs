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

        public Cliente(int ra, string nome, string email, string telefone)
        {
            this.Email = email;
            this.Nome = nome;
            this.Telefone = telefone;
            this.Ra = ra;
        }

        public Cliente(int ra, string senha)
        {
            this.Senha = senha;
            this.Ra = ra;
        }

        public Cliente()
        {

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

        public bool consultarCliente()
        {
            bool achou = false;
            MySqlDataReader resultado;
            try
            {
                Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select * from BBC_Cliente where ra = " + ra + " and senha = '"
                    + senha + "'", Conexao.con);
                resultado = consulta.ExecuteReader();
                if (resultado.Read())
                {
                    achou = true;
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

            return achou;
        }

        public bool alterarSenha()
        {
            bool alterou = false;
            try
            {
                Conexao.con.Open();
                MySqlCommand altera = new MySqlCommand("update BBC_Cliente set senha = '" + senha + "' where ra = " + ra, Conexao.con);
                altera.ExecuteNonQuery();
                alterou = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally 
            {
                Conexao.con.Close(); 
            }

            return alterou;
        }

        public bool atualizarCliente()
        {
            bool atualizou = false;
            try
            {
                Conexao.con.Open();
                MySqlCommand atualiza = new MySqlCommand("update BBC_Cliente set nome = '" + nome + "', email = '" + email + 
                    "', telefone = '" + telefone + "' where ra = " + ra, Conexao.con);
                atualiza.ExecuteNonQuery();
                atualizou = true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Conexao.con.Close();
            }

            return atualizou;
        }

        public MySqlDataReader consultaTodosClientes()
        {
            MySqlDataReader resultado = null;
            try
            {
                Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select * from BBC_Cliente", Conexao.con);
                resultado = consulta.ExecuteReader();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return resultado;
        }
    }
}
