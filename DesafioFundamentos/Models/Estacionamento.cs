namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }
        /// <summary>
        /// Adiciona um cadastro através da placa do veículo
        /// </summary>
        public void AdicionarVeiculo()
        {
            //OK
            Console.WriteLine("Digite a placa do veículo para estacionar:");

            string placaDoVeículo = Console.ReadLine();
            if (placaDoVeículo == "")
            {

                Console.WriteLine("Erro ao cadastrar veículo: A placa do carro não pode ser vazia.");

            }
            else if (veiculos.Any(x => x.ToUpper() == placaDoVeículo.ToUpper()))
            {

                Console.WriteLine($"Erro ao cadastrar veículo: A placa {placaDoVeículo} já está cadastrada.");

            }
            else
            {

                veiculos.Add(placaDoVeículo);
                Console.WriteLine($"Veículo de placa {placaDoVeículo} cadastrado com sucesso!");

            }
        }
        /// <summary>
        /// Remove um veículo da lista de veículos
        /// </summary>
        public void RemoverVeiculo()
        {

            Console.WriteLine("Digite a placa do veículo para remover:");

            //OK
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {

                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                //OK
                string horasEmString = Console.ReadLine();
                int horas = 0;
                decimal valorTotal = 0;

                if (int.TryParse(horasEmString, out horas))
                {

                    //OK
                    valorTotal = precoInicial + (precoPorHora * horas);
                    veiculos.Remove(placa);
                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");

                }
                else
                {

                    Console.WriteLine("Tipo incongruente: As horas devem ser inteiros");

                }

            }
            else
            {

                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");

            }

        }
        /// <summary>
        /// Lista os veículos cadastrados.
        /// </summary>
        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                //OK
                foreach (string veículo in veiculos)
                {

                    Console.WriteLine(veículo);

                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
