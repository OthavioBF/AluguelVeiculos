using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelVeiculos.Model
{
    class PessoaFisica : Cliente
    {
        public PessoaFisica(string nome, int idade, string cpf) : base(nome, idade)
        {
            CPF = cpf;
        }

        public PessoaFisica()
        {

        }

        public string CPF { get; set; }

        public override string ToString()
        {
            return base.ToString() + $" - CPF: {this.CPF}";
        }
    }
}
