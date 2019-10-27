using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login_teste.Modelo;
using MySql.Data.MySqlClient;
using System.Threading;

namespace Login_teste.View
{
    public partial class NewLogin : Form
    {
        Thread th;
        public NewLogin()
        {
            InitializeComponent();
        }

        private void Usuario_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProjetoEntrar controle = new ProjetoEntrar();
            String mensagem = controle.criar(txtUser.Text, txtSenha.Text, txtConfSenha.Text);
            if(controle.existe)
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                th = new Thread(AbrirLogin);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }

        private void AbrirLogin()
        {
            Application.Run(new Login());
        }

        private void TxtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
