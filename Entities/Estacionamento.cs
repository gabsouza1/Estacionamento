using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoEstacionamento.Entities
{
    public class Estacionamento
    {
        private decimal PrecoInicial { get; set; }
        private decimal PrecoPorHora { get; set; }

        private readonly List<string> Veiculos = [];

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            PrecoInicial = precoInicial;
            PrecoPorHora = precoPorHora;
        }
        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            var placa = Console.ReadLine() ?? "";
            if (placa != string.Empty)
            {
                Veiculos.Add(placa);
            }
            else
            {
                Console.WriteLine("Digite um valor válido");
            }

        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine() ?? "";
            if (Veiculos.Any(x => x.ToUpper() == placa.ToUpper()) && placa != string.Empty)
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = PrecoInicial + PrecoPorHora * horas;
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");

                Veiculos.Remove(placa);
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            if (Veiculos.Any())
            {
                Console.WriteLine("Lista de Veículos");
                foreach (var veiculo in Veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados");
            }
        }

        public void ProcurarVeiculo()
        {
            Console.WriteLine("Digite a placa do carro");
            string placa = Console.ReadLine() ?? "";
            if (Veiculos.Any(x => x.ToUpper() == placa.ToUpper()) && placa != string.Empty)
            {
                Console.WriteLine("Veículo encontrado");
            }
            else
            {
                Console.WriteLine("Veículo não encontrado");
            }
        }
    }
}
