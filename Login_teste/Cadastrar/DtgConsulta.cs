﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Login_teste.Eminem;
using MySql.Data.MySqlClient;
using System.Data;
using Login_teste.View;
using System.Windows.Forms;

namespace Login_teste.Cadastrar
{
    public class DtgConsulta
    {
        public static void CriandoDataAdapter()
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;port=3306;database=table_dados");
            MySqlCommand comando = new MySqlCommand("select * from table_dados.cadastro;", conn);
            MySqlDataAdapter dtg = new MySqlDataAdapter(comando);

            DataSet CadastroDataSet;

            CadastroDataSet = new DataSet();
            dtg.Fill(CadastroDataSet, "table_dados.cadastro");

            BindingSource bsCadastro = new BindingSource();
            bsCadastro.DataSource = CadastroDataSet;
            bsCadastro.DataMember = "table_dados.cadastro";

            
        }
    }
}
