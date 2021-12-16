using AluguelVeiculos.Model;
using AluguelVeiculos.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelVeiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ler veiculos do arquivo
            List<Veiculo> veiculosDisponiveis = PersistenciaDados.ReadVeiculos();

            //Mostrar veiculos disponiveis
            EntradaSaidaPadrao.Mensagem("Veiculos disponiveis");
            int i = 1;
            foreach (Veiculo v in veiculosDisponiveis)
            {
                EntradaSaidaPadrao.Mensagem($"[{i}] - " + v.Nome + " " + v.ValorDiaria);
                i++;
            }

            //Escolher veiculo
            int opcaoVeiculo = -1;
            while (opcaoVeiculo > veiculosDisponiveis.Count || opcaoVeiculo < 0)
            {
                opcaoVeiculo = EntradaSaidaPadrao.ReadInt("Escolha pelo numero: ");
            }

            Veiculo escolhido = veiculosDisponiveis[opcaoVeiculo - 1];

            //Obter tipo de cliente
            int tipoCliente = -1;
            while (tipoCliente > 2 || tipoCliente < 1)
            {
                tipoCliente = EntradaSaidaPadrao.ReadInt("Tipo de cliente (1 PF | 2 PJ): ");
            }

            //Obter nome e documento
            string nomeCliente = EntradaSaidaPadrao.ReadString("Nome: ");
            int idadeCliente = EntradaSaidaPadrao.ReadInt("Idade: ");

            string tipoDocumento = string.Empty;
            if (tipoCliente == 1)
            {
                tipoDocumento = "CPF";
            }
            else if (tipoCliente == 2)
            {
                tipoDocumento = "CNPJ";
            }

            string documentoCliente = EntradaSaidaPadrao.ReadString($"{tipoDocumento}: ");

            Cliente cliente = null;
            if (tipoCliente == 1)
            {
                cliente = new PessoaFisica(nomeCliente, idadeCliente, documentoCliente);
            }
            else if (tipoCliente == 2)
            {
                cliente = new PessoaJuridica(nomeCliente, idadeCliente, documentoCliente);
            }

            //Obter diarias
            int diarias = EntradaSaidaPadrao.ReadInt("Quantidade de diarias: ");

            //Criar aluguel
            Aluguel contrato = new Aluguel(escolhido, cliente, diarias, DateTime.Now);

            //Exibir valor total
            EntradaSaidaPadrao.Mensagem("Valor total: " + contrato.CalcularValorAluguel().ToString());

            //Gravar alugueis no arquivo
            PersistenciaDados.WriteAluguel(contrato);

            Console.ReadLine();
        }
    }
}
