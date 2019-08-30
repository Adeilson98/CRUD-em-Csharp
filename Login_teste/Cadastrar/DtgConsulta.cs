using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Login_teste.Eminem;
using MySql.Data.MySqlClient;
using System.Data;

namespace Login_teste.Cadastrar
{
    class DtgConsulta
    {
        public static void CriandoDataAdapter()
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;port=3306;database=table_logar");
            MySqlCommand comando = new MySqlCommand("select * from table_logar.cadastro;", conn);
            MySqlDataAdapter dtg = new MySqlDataAdapter(comando);
        }
    }
}
