namespace ParkingApp.Management
{
    public static class GerenciadorOpcoes
    {
        public static void GerEstacionamento()
        {
            var estacionamento = new Estacionamento(10, 5.00m);
            while (true)
            {
                Console.WriteLine("\nSistema de Estacionamento");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("1 - Estacionar carro");
                Console.WriteLine("2 - Retirar carro");
                Console.WriteLine("3 - Listar carros estacionados");
                Console.WriteLine("4 - Exibir vagas disponíveis");

                Console.Write("Escolha uma opção: ");
                string registerPark = Console.ReadLine();

                switch (registerPark)
                {
                    case "0":
                        return;
                    case "1":
                        Console.WriteLine("Digite a Placa do Carro");
                        var placa = Console.ReadLine();
                        if(placa == null)
                        {
                            Console.WriteLine("Valor não pode ser nulo");
                        }                      
                        estacionamento.AdicionarVeiculo(placa);
                        break;
                    case "2":
                        Console.Write("Digite a placa do veículo: ");
                        placa = Console.ReadLine();
                        estacionamento.RemoverVeiculo(placa);
                        break;
                    case "3":
                        estacionamento.ListarVeiculos();
                        break;
                    case "4":
                        Console.WriteLine($"Vagas Disponíveis:");
                        break;
                }
            }
        }
    }
}
