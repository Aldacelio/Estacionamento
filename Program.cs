using Estacionamento.Model;

Console.OutputEncoding = System.Text.Encoding.UTF8;

//preenchendo os valores base
decimal precoInicial, precoPorHora;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento :)\n" +
                  "Digite o preço inicial: ");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o preço por hora: ");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

Console.Clear();

// //Instancias necessarias
Funcionalidades funcionalidades = new Funcionalidades(precoInicial, precoPorHora);

//Para manter o loop
while (true)
{

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
            funcionalidades.CadastrarVeiculos();
            break;
        case "2":
            funcionalidades.RemoverVeiculo();
            break;
        case "3":
            funcionalidades.ListarViculos();
            break;
        case "0":
            Environment.Exit(0);
            break;
        default:
            break;
    }

    Console.WriteLine("Presione qualquer tecla para continuar.");
    Console.ReadKey();
    Console.Clear();

}