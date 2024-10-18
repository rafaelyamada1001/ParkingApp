using ParkingApp.Management;

namespace ParkingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var estacionamento = new Estacionamento(10, 5.00m);

            while (true)
            {
                Console.WriteLine("\nSistema de Estacionamento");
                Console.WriteLine("1 - Estacionar carro");
                Console.WriteLine("2 - Retirar carro");
                Console.WriteLine("3 - Exibir vagas disponíveis");
                Console.WriteLine("4 - Listar carros estacionados");
                Console.WriteLine("5 - Sair");

                Console.Write("Escolha uma opção: ");
                string registerPark = Console.ReadLine();

                switch (registerPark)
                {
                    case "1":
                        Console.WriteLine("Digite a Placa do Carro");
                        string PlacaEntrada = Console.ReadLine();
                        Veiculo newVehicle = new Veiculo(PlacaEntrada);                       
                        break;

                }
            }
        }
    }
}
