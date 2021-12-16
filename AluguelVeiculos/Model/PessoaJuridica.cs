using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelVeiculos.Model
{
    class PessoaJuridica : Cliente
    {
        public PessoaJuridica(string nome, int idade, string cnpj) : base(nome, idade)
        {
            CNPJ = cnpj;
        }

        public PessoaJuridica()
        {

        }

        public string CNPJ { get; set; }

        public override string ToString()
        {
            return base.ToString() + $" - CNPJ: {this.CNPJ}";
        }
    }
}
