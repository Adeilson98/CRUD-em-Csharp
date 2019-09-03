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
using Login_teste.CRUD.Model;
using MySql.Data.MySqlClient;

namespace Login_teste.View
{
    public partial class dtgConsulta : Form
    {
        public object CadastroDataSet { get; private set; }

        public dtgConsulta()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            listar();
        }
        private void listar()
        {
            PessoaBLL pessoaBLL = new PessoaBLL();

            dataGridView1.DataSource = pessoaBLL.listar();
        }
        private void editar(Pessoa pessoa)
        {
            PessoaBLL pessoaBLL = new PessoaBLL();

            pessoa.ID = Convert.ToInt32(txtID.Text);
            pessoa.Nome = txtNome.Text;
            pessoa.Nascimento = dateTimePicker1.Value;
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

            pessoaBLL.editar(pessoa);

            MessageBox.Show("Editado com Sucesso!");

            listar();
        }
        private void excluir(Pessoa pessoa)
        {
            PessoaBLL pessoaBLL = new PessoaBLL();

            pessoa.ID = Convert.ToInt32(txtID.Text);

            pessoaBLL.excluir(pessoa);

            MessageBox.Show("Cadastro Excluido com Sucesso!");

            listar();
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
           dataGridView1 = new DataGridView();
        }

        private void DtgConsulta_Load(object sender, EventArgs e)
        {

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            editar(pessoa);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            ClasseBLL bll = new ClasseBLL();

            try
            {
                dataGridView1.DataSource = bll.ExibirDadosBD();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Exibir Banco de Dados" + erro);
            }
        }

        private void DtgConsul_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtNome.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                comboBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtRG.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtCPF.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txtEndereco.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                txtNumero.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                txtBairro.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                txtCEP.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                txtCidade.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                txtCelular.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                txtTelefone.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();

            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            excluir(pessoa);
        }
    }
}
