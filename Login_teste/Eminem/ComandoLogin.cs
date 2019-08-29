using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Login_teste.Modelo;
using MySql.Data.MySqlClient;


//este programa tem por objetivo verificar no banco de dados se existe o login e senha

namespace Login_teste.Eminem
{
    class ComandoLogin
    {
        public bool tem = false;
        public String mensagem = "";
        MySqlCommand cmd = new MySqlCommand();
        Conexao con = new Conexao();
        MySqlDataReader dr;

        public bool VrfLogin(String login, String senha)
        {
            cmd.CommandText = "select * from table_logar.logins where login = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    tem = true;
                }
                con.desconectar();
                dr.Close();
            }
            catch (MySqlException)
            {

                this.mensagem = "Erro com o BD!";
            }
            return tem;
        }

        public String cadastrar(String login, String senha, String VrfSenha)
        {
            tem = false;
            if (senha.Equals(VrfSenha))
            {
                cmd.CommandText = "INSERT INTO table_logar.logins (login, senha) VALUES (@login, @senha)";
                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@senha", senha);
                tem = true;

                try
                {
                    cmd.Connection = con.conectar();
                    cmd.ExecuteNonQuery();
                    con.desconectar();
                    this.mensagem = "Cadastrado Com Sucesso!!";
                }
                catch (MySqlException)
                {

                    this.mensagem = "Erro com o banco de Dados!!!";
                }
            }
            else
            {
                this.mensagem = "Senhas nao correspondem";
            }
            return mensagem;
        } 
    }
}
