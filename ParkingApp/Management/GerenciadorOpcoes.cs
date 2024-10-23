using ParkingApp.DataBase;

namespace ParkingApp.Management
{
    public static class GerenciadorOpcoes
    {
        public static void GerEstacionamento()
        {
            var estacionamento = new Estacionamento(10, 5.00m);        

            while (true)
            {
                Console.WriteLine("0 - Sair");
                Console.WriteLine("1 - Estacionar carro");
                Console.WriteLine("2 - Retirar carro");
                Console.WriteLine("3 - Listar carros estacionados");
                Console.WriteLine("4 - Exibir vagas disponíveis");
                Console.WriteLine("5 - Cadastrar Cliente");

                Console.Write("Escolha uma opção:");
                string registerPark = Console.ReadLine();

                switch (registerPark)
                {
                    case "0":
                        return;
                    case "1":
                        Console.Write("Digite a Placa do Veículo:");
                        var placa = Console.ReadLine();
                        Console.Write("Digite o Id do Cliente:");
                        v = Console.ReadLine();                       
                        estacionamento.AdicionarVeiculo(placa);
                        
                        
                        break;
                    case "2":
                        Console.Write("Digite a placa do Veículo:");
                        placa = Console.ReadLine();
                        estacionamento.RemoverVeiculo(placa);
                        break;
                    case "3":
                        estacionamento.ListarVeiculos();
                        break;
                    case "4":
                        estacionamento.VagasDesocupadas();
                        break;
                    case "5":
                        Console.Write("Nome:");
                        var nome = Console.ReadLine();
                        Console.Write("Sobrenome:");
                        var sobrenome = Console.ReadLine();
                        Console.Write("telefone:");
                        var telefone = Console.ReadLine();
                        var cliente = new Cliente(nome, sobrenome, telefone);
                        //var bancoDeDados = new BancoDados();
                        //bancoDeDados.SalvarCliente(cliente);
                        cliente.CadastrarCliente();
                        break;
                    default: 
                        Console.WriteLine("Opção inválida digite novamente");
                        break;
                }
            }
        }
    }
}

