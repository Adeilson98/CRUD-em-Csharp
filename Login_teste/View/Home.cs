using Login_teste.Modelo2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_teste.View
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ProjetoCadastrar controle = new ProjetoCadastrar();
            String mensagem = controle.Cadastro(txtNome.Text, dtNascimento.CustomFormat, txtRG.Text, txtCPF.Text, txtEndereco.Text, txtNumero.Text, txtCelular.Text, txtTelefone.Text);
            if (controle.existe)
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCelular_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void TxtCPF_TextChanged(object sender, EventArgs e)
        {

        }


        private void TxtTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void DtNascimento_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
