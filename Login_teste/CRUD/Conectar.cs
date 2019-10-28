using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Login_teste.CRUD.Model;

namespace Login_teste.CRUD
{
    class Conectar // Esta classe e responsavel por fazer conexao com o banco de dados.
    {
        string conectarBD = "server=localhost;user id=root;port=3306;database=table_logar";

        MySqlConnection conexao = null;
        MySqlCommand comando;

        public DataTable Exibir()
        {
            try
            {
                conexao = new MySqlConnection(conectarBD);
                comando = new MySqlCommand("select * from table_logar.cadastro;", conexao);

                MySqlDataAdapter Da = new MySqlDataAdapter();
                Da.SelectCommand = comando;

                DataTable Dt = new DataTable();

                Da.Fill(Dt);

                return Dt;
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
    }
}
