using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    public class Contato
    {
        public Contato()
        {
            this.Codigo = 0;
            this.Nome = "";
            this.Email = "";
            this.Telefone = "";
            this.Rua = "";
            this.Bairro = "";
            this.Cidade = "";
            this.Estado = "";
            this.Cep = "";
        }

        public Contato(int codigo, string nome, string email, string telefone, string rua, string bairro, string cidade, string estado, string cep)
        {
            this.Codigo = codigo;
            this.Email = email;
            this.Telefone = telefone;
            this.Rua = rua;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Estado = estado;
            this.Cep = cep;
        }

        private int con_cod;
        private string con_nome, con_email, con_fone, con_rua, con_bairro, con_cidade, con_estado, con_cep;

        public int Codigo
        {
            get { return this.con_cod; }
            set { this.con_cod = value; }
        }
        public string Nome
        {
            get { return this.con_nome; }
            set { this.con_nome = value; }
        }
        public string Email
        {
            get { return this.con_email; }
            set { this.con_email = value; }
        }
        public string Telefone
        {
            get { return this.con_fone; }
            set { this.con_fone = value; }
        }
        public string Rua
        {
            get { return this.con_rua; }
            set { this.con_rua = value; }
        }
        public string Bairro
        {
            get { return this.con_bairro; }
            set { this.con_bairro = value; }
        }
        public string Cidade
        {
            get { return this.con_cidade; }
            set { this.con_cidade = value; }
        }
        public string Estado
        {
            get { return this.con_estado; }
            set { this.con_estado = value; }
        }
        public string Cep
        {
            get { return this.con_cep; }
            set { this.con_cep = value; }
        }

    }
}
