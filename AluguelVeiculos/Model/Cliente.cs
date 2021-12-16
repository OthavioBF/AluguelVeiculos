using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelVeiculos.Model
{
    abstract class Cliente
    {
        protected Cliente(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public Cliente()
        {

        }

        public string Nome { get; set; }

        public int Idade { get; set; }

        public override string ToString()
        {
            return $"Nome {this.Nome} - Idade {this.Idade}";
        }
    }
}
