using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Estacionamento.Model;

namespace Estacionamento.View
{
    public class Mensagens
    {
        public void ValoresInciais()
        {
            decimal precoIncial = 0, precoPorHora = 0;

            Console.WriteLine("Seja bem vindo ao sistema de estacionamento|\n" +
                              "Digite o preço inicial: ");
            precoIncial = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o preço por hora: ");
            precoPorHora = Convert.ToDecimal(Console.ReadLine());

            Console.Clear();

            // //Instancias necessarias
            // Funcionalidades funcionalidades = new Funcionalidades(precoIncial,precoPorHora);
        }


        public int Menu()
        {
            //Instancias necessarias
            Funcionalidades funcionalidades = new Funcionalidades();

            Console.Clear();
            Console.WriteLine("Digite a opção desejada: \n" +
                              "1 - Cadastrar veículo\n" +
                              "2 - Remover veículo\n" +
                              "3 - Listar veículos\n" +
                              "0 - Encerrar");
            string opcao = Console.ReadLine() ?? throw new ArgumentNullException("Não pode ser um vazio.");

            switch (opcao)
            {
                case "1":
                    Console.Clear();
                    funcionalidades.CadastrarVeiculos();
                    break;
                case "2":
                    break;
                case "3":
                    funcionalidades.ListarViculos();
                    break;
                case "0":
                    break;
                default:
                    break;
            }


            return 0;
        }

        public void Novamente()
        {
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("\nO que deseja fazer agora ?\n" +
                                      "1 - Realizar a mesma opção\n" +
                                      "2 - Menu principal\n" +
                                      "0 - Encerrar programa");
                string opcao = Console.ReadLine() ?? throw new ArgumentNullException("A opção não pode ser vazia.");
                Console.Clear();
                switch (opcao)
                {
                    case "1":
                        loop = false;
                        break;
                    case "2":
                        loop = false;
                        Menu();
                        break;
                    case "0":
                        loop = false;
                        Environment.Exit(0);
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Digite uma opção válida!");
                        Console.ResetColor();
                        break;
                }
            }

        }
    }
}