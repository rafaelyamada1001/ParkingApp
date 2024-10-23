namespace ParkingApp.Management
{
    public class Veiculo
    {
        public Veiculo(string placa)
        {
            PlacaVeiculo = placa;
            HoraEntrada = DateTime.Now;
        }
        public string PlacaVeiculo { get; set; }
        public DateTime HoraEntrada { get; set; }
    }
}
