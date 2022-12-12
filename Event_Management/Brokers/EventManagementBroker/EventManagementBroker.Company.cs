
using Event_Management.Models.EventManagementModels;
using System.Data.SqlClient;
using System.Data;
using Event_Management.Brokers.EventManagementBroker.Helper;

namespace Event_Management.Brokers.EventManagementBroker
{
    public partial class EventManagementBroker
    {
       
        public async Task<List<Room>> SelectAllEmptyRooms()
        {
            using var connection = await GetConnection();
            using var command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = EventManagementHelper.SelectAllEmptyRooms;


            await connection.OpenAsync();
            using var dataReader = await command.ExecuteReaderAsync();

            List<Room> result = new List<Room>();
            while (await dataReader.ReadAsync())
            {
                Room room = new Room
                (
                    dataReader.GetString(1),
                    dataReader.GetInt32(2),
                    dataReader.GetInt32(3),
                    dataReader.GetBoolean(4)
                );
            }
            return result;
        }

        public async Task<List<(int,bool)>> StatisticsOfSeat()
        {
            using var connection = await GetConnection();
            using var command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = EventManagementHelper.StatisticsSeat;


            await connection.OpenAsync();
            using var dataReader = await command.ExecuteReaderAsync();

            List<(int,bool)> result = new List<(int,bool)>();
            while (await dataReader.ReadAsync())
            {
                result.Add((dataReader.GetInt32(0), dataReader.GetBoolean(2));
            }
            return result;

        }

        

    }
}
