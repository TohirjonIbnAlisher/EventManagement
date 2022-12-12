
using Event_Management.Models.EventManagementModels;

namespace Event_Management.Services.EventManagementServices
{
    public partial interface IEventManagementServices
    {
        public Task<List<(int, bool)>> StatisticsOfSeat();
        public Task<List<Room>> SelectAllEmptyRooms();
        public Task Registered(string username, string password, string tellNumber, string role);
    }
}
