namespace ParkingApp.Management
{
    public class Estacionamento
    {
        private List<Veiculo> veiculos = new List<Veiculo>();
        private decimal valorHora;
        public int vagas;

        public Estacionamento(int vagas, decimal valor)
        {
            valor = valorHora;
            this.vagas = vagas;
        }



        public void AdicionarVeiculo(string placa)
        {
            var veiculo = new Veiculo(placa);
            veiculos.Add(veiculo);
            Console.WriteLine($"Veículo {placa} adicionado ao estacionamento.");
        }

        public void RemoverVeiculo(string placa)
        {


        }
        public void ListarVeiculos()
        {
            if (veiculos.Count == 0)
            {
                Console.WriteLine("Nenhum veículo estacionado.");
                return;
            }

            Console.WriteLine($"Veículos estacionados:{veiculos.Count}");
            foreach (var v in veiculos)
            {
                Console.WriteLine($"- {v.PlacaVeiculo}, Entrada: {v.HoraEntrada}");
            }
        }
    }
}
