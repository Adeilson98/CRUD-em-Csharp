using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_teste.CRUD
{
    class Supercombo
    {
        int telefone, rg, numero;
        string nome, endereco, cpf, celular, sexo;
        DateTime nascimento;

        public int Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        public int Rg
        {
            get { return rg; }
            set { rg = value; }
        }
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }
        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        public DateTime Nascimento
        {
            get { return nascimento; }
            set { nascimento = value; }
        }
    }
}
