using static DesafioFundamentos.Models.Veiculo;



namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            
            // Implementado!!
            Console.WriteLine("Digite a placa do veículo para estacionar:");

            string placa = Console.ReadLine();
            veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Implementado!!

            string placa = Console.ReadLine();
  

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
               
                // Implementado!!

                var consumo = Console.ReadLine();
                int horas = Convert.ToInt32(consumo);
                {
                    if (horas <= 1)
                    {
                        horas = 0;
                    }   
                }
                decimal valorTotal = precoInicial + (precoPorHora * horas);
               
                // Implementado!!

                Console.ReadLine();
                veiculos.Remove(placa);


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
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
               
                // Implementado!!

                for (int i = 0; i < veiculos.Count; i++)
                {
                    Console.WriteLine($"veiculo na vaga {i} com a placa {veiculos[i]}");
                }

            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}