using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelVeiculos.Model
{
    class Grande : Veiculo
    {
        private double aliquota = 2.5;

        public override double CalcularValorDiaria(int idadeCondutor)
        {
            return base.ValorDiaria + (idadeCondutor * this.aliquota);
        }

        public Grande() : base() { }

        public Grande(string nome, string marca, string placa, string documento, int ano, double valorDiaria) : base(nome, marca, placa, documento, ano, valorDiaria) { }
    }
}
