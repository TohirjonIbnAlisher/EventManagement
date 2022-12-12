
using System.Data.SqlClient;
using System.Data;
using Event_Management.Brokers.EventManagementBroker.Helper;
using Event_Management.Models.EventManagementModels;

namespace Event_Management.Brokers.EventManagementBroker
{
    public partial class EventManagementBroker
    {
        public async Task InsertNewRoom(Room room)
        {
            await UpdateAndInsert(EventManagementHelper.InsertRoom, room);
        }

        public async Task UpdateRoom(Room room)
        {
            await UpdateAndInsert(EventManagementHelper.UpdateRoom, room);
        }

        public async Task DeleteRoom(int numberRoom)
        {
            using var connection = await GetConnection();
            using var command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = EventManagementHelper.DeleteRoom;

            command.Parameters.Add(new SqlParameter("@name", numberRoom));
          

            await connection.OpenAsync();
            using var dataReader = await command.ExecuteReaderAsync();
        }

        public async Task<List<Room>> SelectAllRoom()
        {
            using var connection = await GetConnection();
            using var command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = EventManagementHelper.UpdateRoom;

            await connection.OpenAsync();
            using var dataReader = await command.ExecuteReaderAsync();
            
            List<Room> result = new List<Room>();
            while(await dataReader.ReadAsync())
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

        private async Task UpdateAndInsert(string option,Room room)
        {
            using var connection = await GetConnection();
            using var command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = option;

            command.Parameters.Add(new SqlParameter("@name", room.Name));
            command.Parameters.Add(new SqlParameter("@capacity", room.Capacity));
            command.Parameters.Add(new SqlParameter("@numberRoom", room.NumberRoom));

            await connection.OpenAsync();
            using var dataReader = await command.ExecuteReaderAsync();
        }


    }
}
