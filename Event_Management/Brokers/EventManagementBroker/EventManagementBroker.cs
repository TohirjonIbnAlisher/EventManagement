using Event_Management.Brokers.EventManagementBroker.Helper;
using Event_Management.Models.EventManagementModels;
using System.Data;
using System.Data.SqlClient;

namespace Event_Management.Brokers.EventManagementBroker
{
    public partial class EventManagementBroker : IEventManagementBroker
    {
        private async Task<SqlConnection> GetConnection()
        {
            string connectionString = @"Server=(localdb)\mssqllocaldb; Database=EventManagement;";

            return new SqlConnection(connectionString);
        }

        public async Task Registered(Users user)
        {
            using var connection = await GetConnection();
            using var command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = EventManagementHelper.Registered;

            command.Parameters.Add(new SqlParameter("@name", user.UserName));
            command.Parameters.Add(new SqlParameter("@password", user.Password));
            command.Parameters.Add(new SqlParameter("@tell", user.TellNumber));
            command.Parameters.Add(new SqlParameter("@role", user.Role));

            await connection.OpenAsync();
            using var dataReader = await command.ExecuteReaderAsync();
        }
    }
}
