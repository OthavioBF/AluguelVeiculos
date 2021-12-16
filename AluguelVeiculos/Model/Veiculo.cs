using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelVeiculos
{
    abstract class Veiculo
    {
        public static string PEQUENO = "P";

        public static string MEDIO = "M";

        public static string GRANDE = "G";

        public Veiculo() { }

        protected Veiculo(string nome, string marca, string placa, string documento, int ano, double valorDiaria)
        {
            Nome = nome;
            Marca = marca;
            Placa = placa;
            Documento = documento;
            Ano = ano;
            ValorDiaria = valorDiaria;
        }

        public string Nome { get; set; }

        public string Marca { get; set; }

        public string Placa { get; set; }

        public string Documento { get; set; }

        public int Ano { get; set; }

        public double ValorDiaria { get; set; }

        public abstract double CalcularValorDiaria(int idadeCondutor);

        public override string ToString()
        {
            return $"Nome {this.Nome} - Marca {this.Marca} - Placa {this.Placa} - Documento {this.Documento} - Ano {this.Ano}";
        }
    }
}
