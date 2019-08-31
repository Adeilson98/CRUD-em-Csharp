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
using Login_teste.CRUD;
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

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            ClasseBLL bll = new ClasseBLL();

            try
            {
                dtgConsul.DataSource = bll.ExibirDadosBD();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Exibir Banco de Dados" + erro);
            }
        }
    }
}
