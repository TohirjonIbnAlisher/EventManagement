
using Event_Management.Brokers.EventManagementBroker.Helper;
using Event_Management.Models.EventManagementModels;
using System.Data.SqlClient;
using System.Data;

namespace Event_Management.Brokers.EventManagementBroker
{
    public partial class EventManagementBroker
    {
        public async Task RegisteredSeat(int room_id,int seatNumber)
        {
            using var connection = await GetConnection();
            using var command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = EventManagementHelper.RegisteredSeat;

            command.Parameters.Add(new SqlParameter("@room_id", room_id));
            command.Parameters.Add(new SqlParameter("@numberSeat", seatNumber));

            await connection.OpenAsync();
            using var dataReader = await command.ExecuteReaderAsync();
        }
    }
}
