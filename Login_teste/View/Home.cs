using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Login_teste.Cadastrar;
using Login_teste.CRUD;
using Login_teste.CRUD.Model;

namespace Login_teste.View
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }
        private void salvar(Pessoa pessoa)
        {
            PessoaBLL pessoaBLL = new PessoaBLL();

            pessoa.Nome = txtNome.Text;
            pessoa.Nascimento = dtNascimento.Value;
            pessoa.Sexo = comboBox1.Text;
            pessoa.Rg = txtRG.Text;
            pessoa.Cpf = txtCPF.Text;
            pessoa.Endereco = txtEndereco.Text;
            pessoa.Numero = txtNumero.Text;
            pessoa.Celular = txtCelular.Text;
            pessoa.Telefone = txtTelefone.Text;

            pessoaBLL.salvar(pessoa);

            MessageBox.Show("Cadastro Realizado!");
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            salvar(pessoa);
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

        private void NovaConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dtgConsulta entrar = new dtgConsulta();
            entrar.Show();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
