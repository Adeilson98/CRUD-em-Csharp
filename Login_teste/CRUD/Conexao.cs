using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Login_teste.CRUD
{
    public class Conexao
    {
        string conecta = "server=localhost;user id=root;port=3306;database=table_dados";
        protected MySqlConnection conexao = null;

        //abrir conexao

        public void AbrirBanco()
        {
            try
            {
                conexao = new MySqlConnection(conecta);
                conexao.Open();
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        //fechar conexao
        public void FecharBanco()
        {
            try
            {
                conexao = new MySqlConnection(conecta);
                conexao.Close();
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
    }
}
