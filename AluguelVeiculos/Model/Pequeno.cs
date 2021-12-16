using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelVeiculos.Model
{
    class Pequeno : Veiculo
    {
        private double aliquota = 0.5;

        public override double CalcularValorDiaria(int idadeCondutor)
        {
            return base.ValorDiaria + (idadeCondutor * this.aliquota);
        }

        public Pequeno() : base() { }

        public Pequeno(string nome, string marca, string placa, string documento, int ano, double valorDiaria) : base(nome, marca, placa, documento, ano, valorDiaria) { }
    }
}
