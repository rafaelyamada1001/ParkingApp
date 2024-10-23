using MySql.Data.MySqlClient;
using ParkingApp.Management;


namespace ParkingApp.DataBase
{
    public class BancoDados
    {
        private string connectionString = "Server=localhost;Database=teste;User ID=root;Password=1234;";
        public void SalvarCliente(Cliente cliente)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO Clientes (Nome, Sobrenome, Telefone) VALUES (@Nome, @Sobrenome, @Telefone)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();

                    command.Parameters.AddWithValue("@Nome", cliente.Nome);
                    command.Parameters.AddWithValue("@Sobrenome", cliente.Sobrenome);
                    command.Parameters.AddWithValue("@Telefone", cliente.Telefone);

                    command.ExecuteNonQuery();
                }
            }
        }
        public void EntradaVeiculo(Veiculo veiculo)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query =
                    ("INSERT INTO MovGer Cliente_Id, Placa, HoraEntrada)" +
                    " VALUES (@Cliente_Id, @Placa, @HoraEntrada)");

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();

                    //command.Parameters.AddWithValue("@Cliente_Id", cliente.Id);
                    command.Parameters.AddWithValue("@Placa", veiculo.PlacaVeiculo);
                    command.Parameters.AddWithValue("@HoraEntrada", veiculo.HoraEntrada);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void SaidaVeiculo(string placa, DateTime HoraSaida, double Permanencia, decimal Valor)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query =
                    "UPDATE MovGer (HoraSaida, Permanencia, Valor)" +
                    " VALUES (@HoraSaida, @Permanencia, @Valor)" +
                    "WHERE Placa = @Placa";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();

                    command.Parameters.AddWithValue("@Placa", placa);
                    command.Parameters.AddWithValue("@HoraSaida", HoraSaida);
                    command.Parameters.AddWithValue("@Permanencia", Permanencia);
                    command.Parameters.AddWithValue("@Valor", Valor);

                    command.ExecuteNonQuery();
                }


            }
        }
    }
}