using ParkingApp.DataBase;

namespace ParkingApp.Management
{
    public class Estacionamento
    {
        private List<Veiculo> veiculos = new List<Veiculo>();
        private decimal valorHora;
        public int Vagas { get; set; }
        public Estacionamento(int vagas, decimal valor)
        {
            valorHora = valor;
            Vagas = vagas;
        }


        public void AdicionarVeiculo(string placa)
        {
            if (string.IsNullOrEmpty(placa))
            {
                Console.WriteLine("Campo não pode ser vazio!");
                return;
            }
            if (veiculos.Count >= Vagas)
            {
                Console.WriteLine("Estacionamento cheio!");
                return;
            }
            var veiculo = new Veiculo(placa);
            veiculos.Add(veiculo);
            Console.WriteLine($"Veículo {placa} adicionado ao estacionamento às {veiculo.HoraEntrada}.");
            var banco = new BancoDados();
            banco.EntradaVeiculo(veiculo);
        }

        public void RemoverVeiculo(string placa)
        {
            var veiculo = veiculos.FirstOrDefault(veiculos => veiculos.PlacaVeiculo == placa);

            if (veiculo == null)
            {
                Console.WriteLine("Veículo não encontrado.");
                return;
            }
            var horaSaida = DateTime.Now;
            var horasEstacionadas = (horaSaida - veiculo.HoraEntrada).TotalHours;
            var valorTotal = (decimal)horasEstacionadas * valorHora;

            veiculos.Remove(veiculo);
            var banco = new BancoDados();
            banco.SaidaVeiculo(placa, horaSaida, horasEstacionadas, valorTotal);
            Console.WriteLine($"Veículo {placa} removido do estacionamento.");
            Console.WriteLine($"Entrada: {veiculo.HoraEntrada} | Saída: {horaSaida} | Valor Total: R${valorTotal} ");
        }

        public void ListarVeiculos()
        {
            if (veiculos.Count == 0)
            {
                Console.WriteLine("Nenhum veículo estacionado.");
                return;
            }
            Console.WriteLine($"Veículos estacionados:{veiculos.Count}");
            foreach (var veiculos in veiculos)
            {
                Console.WriteLine($"- Placa: {veiculos.PlacaVeiculo}, Entrada: {veiculos.HoraEntrada}");
            }
        }

        public void VagasDesocupadas()
        {
            Console.WriteLine($"{(Vagas - veiculos.Count)}");
        }
    }
}
