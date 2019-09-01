using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Login_teste.CRUD.Model;
using MySql.Data.MySqlClient;

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
    }
}
