using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Login_teste.CRUD.Model;
using MySql.Data.MySqlClient;

namespace Login_teste.CRUD
{
    public class PessoaDAO: Conexao
    {
        MySqlCommand comando = null;

        public void salvar(Pessoa pessoa)
        {
            try
            {
                AbrirBanco();

                comando = new MySqlCommand("INSERT INTO table_logar.cadastro (nome, nascimento, sexo, RG, CPF, endereco, numero, celular, telefoneres) VALUES (@nome, @nascimento, @sexo, @RG, @CPF, @endereco, @numero, @celular, @telefoneres)", conexao);
                comando.Parameters.AddWithValue("@nome", pessoa.Nome);
                comando.Parameters.AddWithValue("@nascimento", pessoa.Nascimento);
                comando.Parameters.AddWithValue("@sexo", pessoa.Sexo);
                comando.Parameters.AddWithValue("@RG", pessoa.Rg);
                comando.Parameters.AddWithValue("@CPF", pessoa.Cpf);
                comando.Parameters.AddWithValue("@endereco", pessoa.Endereco);
                comando.Parameters.AddWithValue("@numero", pessoa.Numero);
                comando.Parameters.AddWithValue("@celular", pessoa.Celular);
                comando.Parameters.AddWithValue("@telefoneres", pessoa.Telefone);

                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharBanco();
            }
        }
    }
}
