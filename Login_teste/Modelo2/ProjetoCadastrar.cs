using Login_teste.Cadastrar;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_teste.Modelo2
{
    class ProjetoCadastrar
    {
        public bool existe;
        public String mensagem = "";

        public String Cadastro(String nome, String nascimento, String rg, String cpf, String endereco, String numero, String celular, String telefoneres)
        {
            ComandoCadastro comando = new ComandoCadastro();
            this.mensagem = comando.Cadastro(nome, nascimento, rg, cpf, endereco, numero, celular, telefoneres);

            if (comando.tem)
            {
                this.existe = true;
            }
            return mensagem;
        }
    }
}
