using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelVeiculos.Model
{
    class Aluguel
    {
        public Veiculo Veiculo { get; set; }
        
        public Cliente Cliente { get; set; }

        public int Diarias { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataFim { get; set; }

        public Aluguel(Veiculo veiculo, Cliente cliente, int diarias, DateTime dataInicio)
        {
            Veiculo = veiculo;
            Cliente = cliente;
            Diarias = diarias;
            DataInicio = dataInicio;
            DataFim = dataInicio.AddDays(diarias);
        }

        public double CalcularValorAluguel()
        {
            return this.Diarias * this.Veiculo.CalcularValorDiaria(this.Cliente.Idade);
        }
    }
}
