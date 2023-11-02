using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using Estacionamento.View;

namespace Estacionamento.Model
{
    public class Funcionalidades
    {
        //Instancias necessarias
        Mensagens mensagens = new Mensagens();

        private decimal precoIncial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Funcionalidades(decimal precoIncial, decimal precoPorHora)
        {
            this.precoIncial = precoIncial;
            this.precoPorHora = precoPorHora;
        }

        public Funcionalidades()
        {

        }

        public void CadastrarVeiculos()
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine("Digite a placa do veículo para estacionar: ");
                veiculos.Add(Console.ReadLine() ?? throw new ArgumentNullException("A placa não pode ser nula."));
                Console.Clear();
                mensagens.Novamente();
            }
        }

        public void ListarViculos()
        {
            Console.Clear();
            while (true)
            {
                if (veiculos.Count() == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Não tem nenhum veículo estacionado.");
                    Console.ResetColor();
                    mensagens.Novamente();
                }else{
                    foreach(string item in veiculos){

                        Console.WriteLine(item);

                    }
                }
            }
        }
    }
}