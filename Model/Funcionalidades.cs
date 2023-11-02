using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace Estacionamento.Model
{
    public class Funcionalidades
    {
        public Funcionalidades()
        {

        }
        public Funcionalidades(decimal precoIncial, decimal precoPorHora)
        {
            this.PrecoInicial = precoIncial;
            this.PrecoPorHora = precoPorHora;
        }

        private decimal _precoInicial;
        private decimal _precoPorHora;
        private List<string> _veiculos = new List<string>();

        public decimal PrecoInicial { get => _precoInicial; set => _precoInicial = value; }
        public decimal PrecoPorHora { get => _precoPorHora; set => _precoPorHora = value; }
        public List<string> Veiculos { get => _veiculos; set => _veiculos = value; }

        public void CadastrarVeiculos()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar\n"+
                              "Lembre-se de seguir o formato de 3 letras e 4 numeros como o do exemplo xxx-0000:");
            string formatar = Console.ReadLine() ?? throw new ArgumentNullException("A placa não pode ser nula.");
            Veiculos.Add(formatar.ToUpper());
        }

        public void RemoverVeiculo()
        {
            if (ListarViculos())
            {

                Console.WriteLine("Digite o veículo que deseja remover: ");
                string placa = Console.ReadLine() ?? throw new ArgumentNullException("A placa não pode ser vazia.");
                if (Veiculos.Contains(placa.ToUpper()))
                {
                    Console.WriteLine("Quantas horas ele passou no estacionamento ? ");
                    int horas = Convert.ToInt32(Console.ReadLine());
                    Veiculos.Remove(placa.ToUpper());
                    Console.WriteLine($"O veículo {placa.ToUpper()} foi removido com sucesso e o valor do estacionamento ficou R$ {(PrecoPorHora * horas) + PrecoInicial}");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Digite um veículo válido.");
                    Console.ResetColor();
                }
            }
        }

        public bool ListarViculos()
        {
            if (Veiculos.Count() == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Não tem nenhum veículo estacionado.");
                Console.ResetColor();
                return false;
            }
            else
            {
                foreach (string item in Veiculos)
                {

                    Console.WriteLine(item);

                }
                return true;
            }

        }
    }
}