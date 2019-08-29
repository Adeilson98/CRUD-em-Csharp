using Login_teste.Eminem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

//este programa vai pegar a resposta do formulário ComandoLogin e mandar essa resposta pro formulario Login

namespace Login_teste.Modelo
{
    public class ProjetoEntrar
    {
        public bool existe;
        public String mensagem = "";
        public bool acessar (String login, String senha)
        {
            ComandoLogin comando = new ComandoLogin();
            existe = comando.VrfLogin(login, senha);
            if(!comando.mensagem.Equals(""))
            {
                this.mensagem = comando.mensagem;
            }
            return existe;
        }
        public String criar (String login, String senha, String VrfSenha)
        {
            ComandoLogin comando = new ComandoLogin();
            this.mensagem = comando.cadastrar(login, senha, VrfSenha);
            if(comando.tem)
            {
                this.existe = true;
            }
            return mensagem;
        }
    }
}
