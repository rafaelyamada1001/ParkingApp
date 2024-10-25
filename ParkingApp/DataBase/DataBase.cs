using MySql.Data.MySqlClient;
using ParkingApp.Management;



namespace ParkingApp.DataBase
{
    public class BancoDados
    {
        private string connectionString = "Server=localhost;Database=teste;User ID=root;Password=1234;";
        
        public void EntradaVeiculo(Veiculo veiculo)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string insertQuery = "INSERT INTO MovGer (Placa, HoraEntrada) " +
                    "VALUES (@Placa, @HoraEntrada)";

                using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                {
                    connection.Open();

                    command.Parameters.AddWithValue("@Placa", veiculo.PlacaVeiculo);
                    command.Parameters.AddWithValue("@HoraEntrada", veiculo.HoraEntrada);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void SaidaVeiculo(string placa, DateTime horaSaida, double horasEstacionadas, double minutosEstacionados, decimal Valor)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string updateQuery =
                    "UPDATE MovGer SET HoraSaida = @HoraSaida, PermanenciaHora = @PermanenciaHora, PermanenciaMin = @PermanenciaMin, Valor = @Valor" +                   
                    " WHERE Placa = @Placa and HoraSaida is null";

                using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                {
                    connection.Open();

                    command.Parameters.AddWithValue("@Placa", placa);
                    command.Parameters.AddWithValue("@HoraSaida", horaSaida);
                    command.Parameters.AddWithValue("@PermanenciaHora", Math.Round(horasEstacionadas));
                    command.Parameters.AddWithValue("@PermanenciaMin", minutosEstacionados);
                    command.Parameters.AddWithValue("@Valor", Valor.ToString("F2"));

                    command.ExecuteNonQuery();
                    command.ExecuteReader();
                }
            }
        }
    }
}