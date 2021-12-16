using AluguelVeiculos.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelVeiculos.Util
{
    class PersistenciaDados
    {
        private static string GetRootPath()
        {
            string path = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
            path = Directory.GetParent(Directory.GetParent(path).FullName).FullName;

            return path;
        }

        public static List<Veiculo> ReadVeiculos()
        {
            List<Veiculo> veiculos = null;
            try
            {
                StreamReader file = new StreamReader(GetRootPath() + "/veiculos.txt");
                string ln;

                veiculos = new List<Veiculo>();
                while ((ln = file.ReadLine()) != null)
                {
                    string[] veiculo = ln.Split(' ');

                    Veiculo v = null;
                    if (veiculo[6].Equals(Veiculo.PEQUENO))
                    {
                        v = new Pequeno(veiculo[0], veiculo[1], veiculo[2], veiculo[3], Convert.ToInt32(veiculo[4]), Convert.ToDouble(veiculo[5]));
                    }
                    else if (veiculo[6].Equals(Veiculo.MEDIO))
                    {
                        v = new Medio(veiculo[0], veiculo[1], veiculo[2], veiculo[3], Convert.ToInt32(veiculo[4]), Convert.ToDouble(veiculo[5])); ;
                    }
                    else if (veiculo[6].Equals(Veiculo.GRANDE))
                    {
                        v = new Grande(veiculo[0], veiculo[1], veiculo[2], veiculo[3], Convert.ToInt32(veiculo[4]), Convert.ToDouble(veiculo[5])); ;
                    }
                    else
                    {
                        throw new Exception("Erro na leitura do arquivo");
                    }

                    veiculos.Add(v);
                }

                file.Close();
            }
            catch (Exception)
            {
                EntradaSaidaPadrao.Mensagem("Arquivo nao encontrado");

                throw;
            }

            return veiculos;
        }

        public static void WriteAluguel(Aluguel a)
        {
            try
            {
                StreamWriter writer = new StreamWriter(GetRootPath() + $"/saida_{DateTime.Now.ToString("dd_MM_yyyy_hh_mm_ss")}.txt");

                writer.WriteLine("Contrato de aluguel");
                writer.WriteLine("Inicio: " + a.DataInicio);
                writer.WriteLine("Fim: " + a.DataFim);

                writer.WriteLine("Valor total: " + a.CalcularValorAluguel());

                writer.WriteLine("Veiculo: " + a.Veiculo);
                writer.WriteLine("Cliente: " + a.Cliente);

                writer.Flush();
                writer.Close();
            }
            catch (Exception)
            {
                EntradaSaidaPadrao.Mensagem("Nao foi possivel gravar os dados");

                throw;
            }
        }
    }
}
