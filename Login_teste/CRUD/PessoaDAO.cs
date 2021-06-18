using Login_teste.CRUD.Model;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Login_teste.CRUD
{
    public class PessoaDAO : Conexao
    {
        MySqlCommand comando = null;

        public void salvar(Pessoa pessoa)
        {
            try
            {
                AbrirBanco();

                comando = new MySqlCommand("INSERT INTO table_dados.cadastro (Nome, Nascimento, Sexo, RG, CPF, endereco, numero, bairro, CEP, cidade, celular, telefone) VALUES (@nome, @nascimento, @sexo, @RG, @CPF, @endereco, @numero, @bairro, @CEP, @cidade, @celular, @telefone)", conexao);
                comando.Parameters.AddWithValue("@nome", pessoa.Nome);
                comando.Parameters.AddWithValue("@nascimento", pessoa.Nascimento);
                comando.Parameters.AddWithValue("@sexo", pessoa.Sexo);
                comando.Parameters.AddWithValue("@RG", pessoa.Rg);
                comando.Parameters.AddWithValue("@CPF", pessoa.Cpf);
                comando.Parameters.AddWithValue("@endereco", pessoa.Endereco);
                comando.Parameters.AddWithValue("@numero", pessoa.Numero);
                comando.Parameters.AddWithValue("@bairro", pessoa.Bairro);
                comando.Parameters.AddWithValue("@CEP", pessoa.Cep);
                comando.Parameters.AddWithValue("@cidade", pessoa.Cidade);
                comando.Parameters.AddWithValue("@celular", pessoa.Celular);
                comando.Parameters.AddWithValue("@telefone", pessoa.Telefone);

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
        public DataTable listar()
        {
            try
            {
                AbrirBanco();

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();

                comando = new MySqlCommand("SELECT * FROM table_logar.cadastro ORDER BY nome", conexao);

                da.SelectCommand = comando;

                da.Fill(dt);

                return dt;
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
        public void editar(Pessoa pessoa)
        {
            try
            {
                AbrirBanco();

                comando = new MySqlCommand("UPDATE table_logar.cadastro SET nome = @nome, nascimento = @nascimento, sexo = @sexo, RG = @RG, CPF = @CPF, endereco = @endereco, numero = @numero, bairro = @bairro, CEP = @CEP, cidade = @cidade, celular = @celular, telefoneres = @telefoneres WHERE ID = @ID", conexao);
                comando.Parameters.AddWithValue("@ID", pessoa.ID);
                comando.Parameters.AddWithValue("@nome", pessoa.Nome);
                comando.Parameters.AddWithValue("@nascimento", pessoa.Nascimento);
                comando.Parameters.AddWithValue("@sexo", pessoa.Sexo);
                comando.Parameters.AddWithValue("@RG", pessoa.Rg);
                comando.Parameters.AddWithValue("@CPF", pessoa.Cpf);
                comando.Parameters.AddWithValue("@endereco", pessoa.Endereco);
                comando.Parameters.AddWithValue("@numero", pessoa.Numero);
                comando.Parameters.AddWithValue("@bairro", pessoa.Bairro);
                comando.Parameters.AddWithValue("@CEP", pessoa.Cep);
                comando.Parameters.AddWithValue("@cidade", pessoa.Cidade);
                comando.Parameters.AddWithValue("@celular", pessoa.Celular);
                comando.Parameters.AddWithValue("@telefoneres", pessoa.Telefone);

                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
        public void excluir(Pessoa pessoa)
        {
            try
            {
                AbrirBanco();

                comando = new MySqlCommand("DELETE FROM table_logar.cadastro WHERE ID = @ID", conexao);
                comando.Parameters.AddWithValue("@ID", pessoa.ID);

                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
        public DataTable Pesquisar(Pessoa pessoa)
        {
            try
            {
                AbrirBanco();

                MySqlDataAdapter da = new MySqlDataAdapter();
                DataTable dt = new DataTable();

                comando = new MySqlCommand("select * from table_logar.cadastro WHERE nome LIKE '%' @nome '%' ORDER BY nome", conexao);
                comando.Parameters.AddWithValue("@nome", pessoa.Nome);

                da.SelectCommand = comando;
                da.Fill(dt);

                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
