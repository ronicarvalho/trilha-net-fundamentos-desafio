using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial;
decimal precoPorHora;

do
{
    Console.Clear();
    Console.WriteLine("Seja bem vindo ao sistema de estacionamento! \n Digite o preço inicial:");
    var valorPrecoInicial = Console.ReadLine();
    decimal.TryParse(valorPrecoInicial, out precoInicial);
} while (precoInicial <= 0);

do
{
    Console.Clear();
    Console.WriteLine("Agora digite o preço por hora:");
    var valorPrecoPorHora = Console.ReadLine();
    decimal.TryParse(valorPrecoPorHora, out precoPorHora);
} while(precoPorHora <= 0);

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
var es = Estacionamento.of(precoInicial, precoPorHora);
var exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.Clear();
Console.WriteLine("O programa se encerrou");
