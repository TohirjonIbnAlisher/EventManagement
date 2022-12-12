
using Event_Management.Models.EventManagementModels;

namespace Event_Management.Services.EventManagementServices
{
    public partial class EventManagementServices
    {
        public async Task<List<Room>> SelectAllEmptyRooms()
        {
            return await eventManagementBroker.SelectAllEmptyRooms();
        }

        public async Task<List<(int, bool)>> StatisticsOfSeat()
        {
            return await eventManagementBroker.StatisticsOfSeat();
        }

        public async Task Registered(string username, string password, string tellNumber, string role)
        {
            Users user = new Users
            (username, password, tellNumber, role);

            await eventManagementBroker.Registered(user);
        }



    }
}
