using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelVeiculos.Model
{
    class Medio : Veiculo
    {
        private double aliquota = 1.5;

        public override double CalcularValorDiaria(int idadeCondutor)
        {
            return base.ValorDiaria + (idadeCondutor  * this.aliquota);
        }

        public Medio() : base() { }

        public Medio(string nome, string marca, string placa, string documento, int ano, double valorDiaria) : base(nome, marca, placa, documento, ano, valorDiaria) { }
    }
}
