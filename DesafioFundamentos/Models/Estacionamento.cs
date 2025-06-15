namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private readonly decimal _precoInicial = 0;
        private readonly decimal _precoPorHora = 0;
        private readonly List<string> _veiculos = new();

        private Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            _precoInicial = precoInicial;
            _precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            var placa = "";
            
            do
            {
                Console.Clear();
                Console.WriteLine("Digite a placa do veículo para estacionar:");
                placa = Console.ReadLine();
            } while (placa is null or { Length: 0 } or { Length: > 7 }); // pattern matching
                
            _veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            if (!_veiculos.Any())
            {
                Console.WriteLine("Desculpe, não há veículos estacionados no momento!");
                return;
            }

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*
            var placa = "";
            do
            {
                Console.Clear();
                Console.WriteLine("Digite a placa do veículo para remover:");
                placa = Console.ReadLine();
            } while (placa is null or { Length: 0 } or { Length: > 7 }); // pattern matching

            // Verifica se o veículo existe
            if (_veiculos.Any(x => string.Equals(x, placa, StringComparison.OrdinalIgnoreCase))) // evitamos a utilização de ToUpper duas vezes
            {
                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // *IMPLEMENTE AQUI*

                decimal horas;

                do
                {
                    Console.Clear();
                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                    var quantidadeHoras = Console.ReadLine();
                    decimal.TryParse(quantidadeHoras, out horas);
                } while (horas == 0); // pattern matching

                
                var valorTotal = _precoInicial + (_precoPorHora * horas);

                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTE AQUI*

                _veiculos.Remove(placa); 

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (_veiculos.Any())
            {
                Console.Clear();
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*
                _veiculos.ForEach(x => Console.WriteLine(x)); // mais pratico porque as listas são pequenas
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }

        public static Estacionamento of(decimal precoInicial, decimal precoPorHora) =>
            new Estacionamento(precoInicial, precoPorHora);
    }
}
