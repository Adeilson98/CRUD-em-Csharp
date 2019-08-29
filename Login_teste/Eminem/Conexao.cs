using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using MySql.Data;
using MySql.Data.Entity;
using System.Data;
using System.Data.Entity;
using System.Data.SqlTypes;
using System.Data.Sql;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


// esta classe esta responsavel por conectar com o banco de dados 

namespace Login_teste.Eminem
{
    public class Conexao
    {
        MySqlConnection  con = new MySqlConnection();
        public Conexao()
        {
            con.ConnectionString = @"server=localhost;user id=root;port=3306;database=table_logar";
        }
        public MySqlConnection conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public void desconectar()
        {
            if(con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
