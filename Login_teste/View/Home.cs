using Login_teste.CRUD;
using Login_teste.CRUD.Model;
using System;
using System.Windows.Forms;
using System.Threading;

namespace Login_teste.View
{
    public partial class Home : Form
    {
        Thread th;
        public Home()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }
        private void LimparTxt()
        {
            txtNome.Clear();
            comboBox1.SelectedIndex = -1;
            txtRG.Clear();
            txtCPF.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtCEP.Clear();
            txtCidade.Clear();
            txtCelular.Clear();
            txtTelefone.Clear();
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
            pessoa.Bairro = txtBairro.Text;
            pessoa.Cep = txtCEP.Text;
            pessoa.Cidade = txtCidade.Text;
            pessoa.Celular = txtCelular.Text;
            pessoa.Telefone = txtTelefone.Text;


            pessoaBLL.salvar(pessoa);

            MessageBox.Show("Cadastro Realizado!");
            LimparTxt();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(AbrirLogin);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void AbrirLogin()
        {
            Application.Run(new Login());
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
            LimparTxt();
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
            this.Close();
            th = new Thread(NovaConsulta);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void NovaConsulta()
        {
            Application.Run(new dtgConsulta());
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
