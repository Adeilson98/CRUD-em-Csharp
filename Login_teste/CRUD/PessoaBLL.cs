using Login_teste.CRUD.Model;
using System;
using System.Data;

namespace Login_teste.CRUD
{
    class PessoaBLL
    {
        PessoaDAO pessoaDAO = new PessoaDAO();

        public void salvar(Pessoa pessoa)
        {
            try
            {
                pessoaDAO.salvar(pessoa);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
        public DataTable listar()
        {
            try
            {
                DataTable dt = new DataTable();

                dt = pessoaDAO.listar();

                return dt;
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
        public void editar(Pessoa pessoa)
        {
            try
            {
                pessoaDAO.editar(pessoa);
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
                pessoaDAO.excluir(pessoa);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
    }
}
