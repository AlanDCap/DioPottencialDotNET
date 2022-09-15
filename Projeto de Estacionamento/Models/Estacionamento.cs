namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoPorHora = 2;
        private List<Veiculo> veiculos = new List<Veiculo>();

        public Estacionamento()
        {

        }
        /// <summary>
        /// Adiciona um veículo à lista de veículos do estacionamento
        /// </summary>
        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            
            //Verifica se a placa inserido contém sete caracteres
            while (placa.Length != 7)
            {
                Console.WriteLine("A placa deve conter 7 caracteres");
                placa = Console.ReadLine();
            }

            //Instancia um novo veículo e adiciona à lista
            Veiculo v = new Veiculo(placa);
            veiculos.Add(v);
        }
        /// <summary>
        /// Remove o veículo da lista de veículos no estacionamento e calcula o preço a ser pago 
        /// </summary>
        public void RemoverVeiculo()
        {
            if (veiculos.Count != 0)
            {
                Console.WriteLine("Selecione o veículo para remover:");
                int count = 1;

                foreach (Veiculo v in veiculos)
                {
                    Console.WriteLine($"{count} - {v.Placa}. || Horário de entrada: {v.Entrada.ToString("t")}");
                    count++;
                }
                int opcao = int.Parse(Console.ReadLine());
                int indice = opcao - 1;

                DateTime horaSaida = DateTime.Now;
                TimeSpan permanencia = horaSaida.Subtract(veiculos[indice].Entrada);
                decimal valorTotal = (decimal)Math.Ceiling(permanencia.TotalHours) * precoPorHora;
                Console.WriteLine($"O veículo {veiculos[indice].Placa} foi removido e o preço total foi de: R$ {Math.Round(valorTotal, 2)}");
                veiculos.Remove(veiculos[indice]);
            }
            else
                Console.WriteLine("Estacionamento vazio!");
        }
        public void ListarVeiculos()
        {
            if (veiculos.Count != 0)
            {
                int count = 1;
                Console.WriteLine("N || Placa   | Entrada");
                foreach (Veiculo v in veiculos)
                {
                    Console.WriteLine($"{count} || {v.Placa} | {v.Entrada.ToString("t")}");
                    count++;
                }
            }
            else
                Console.Write("Estacionamento vazio");
        }

        public void AjustarPreco()
        {
            Console.WriteLine($"O preço atual é {this.precoPorHora}.\nDigite o novo valor cobrado por hora");
            this.precoPorHora = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"O novo preço registrado é {this.precoPorHora}");
        }
    }
}
