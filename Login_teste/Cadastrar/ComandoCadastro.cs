using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Login_teste.Eminem;
using MySql.Data.MySqlClient;

namespace Login_teste.Cadastrar
{
    class ComandoCadastro
    {
        public bool tem = false;
        public String mensagem = "";
        MySqlCommand cmd = new MySqlCommand();
        Conexao con = new Conexao();

        public string Cadastro(String nome, String nascimento, String rg, String cpf, String endereco, String numero, String celular, String telefoneres)
        {
            DateTime? nascimentro = null;

            cmd.CommandText = "INSERT INTO table_logar.cadastro (nome, nascimento, RG, CPF, endereco, numero, celular, telefoneres) VALUES (@nome, @nascimento, @RG, @CPF, @endereco, @numero, @celular, @telefoneres)";
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@nascimento", nascimento);
            cmd.Parameters.AddWithValue("@RG", rg);
            cmd.Parameters.AddWithValue("@CPF", cpf);
            cmd.Parameters.AddWithValue("@endereco", endereco);
            cmd.Parameters.AddWithValue("@numero", numero);
            cmd.Parameters.AddWithValue("@celular", celular);
            cmd.Parameters.AddWithValue("@telefoneres", telefoneres);
            tem = true;

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
                this.mensagem = "Dados cadastrados com Sucesso!";
            }
            catch (MySqlException)
            {

                this.mensagem = "Erro com o banco de Dados!!!";
            }
            return mensagem;
        }
    }
}
