using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login_teste.Cadastrar;
using MySql.Data.MySqlClient;

namespace Login_teste.View
{
    public partial class dtgConsulta : Form
    {
        public object CadastroDataSet { get; private set; }

        public dtgConsulta()
        {
            InitializeComponent();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        public void DtgConsul_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgConsul = new DataGridView();
        }

        private void DtgConsulta_Load(object sender, EventArgs e)
        {
            string strProvider = "server=localhost;user id=root;port=3306;database=table_logar";

            string strSql = "select * from table_logar.cadastro;";


            MySqlConnection con = new MySqlConnection(strProvider);

            MySqlCommand cmd = new MySqlCommand(strSql, con);


            con.Open();


            cmd.CommandType = CommandType.Text;

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);


            DataTable clientes = new DataTable();


            da.Fill(clientes);


            dtgConsul.DataSource = clientes;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
