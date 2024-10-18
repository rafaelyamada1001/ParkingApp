namespace ParkingApp.Management
{
    public class Veiculo
    {
        public Veiculo(string Placa)
        {
            PlacaVeiculo = Placa;
            HoraEntrada = DateTime.Now;
        }
        public string PlacaVeiculo { get; set; }
        public DateTime HoraEntrada { get; set; }
    }
}
