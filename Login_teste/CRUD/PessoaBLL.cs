using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Login_teste.CRUD.Model;
using MySql.Data.MySqlClient;
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
    }
}
