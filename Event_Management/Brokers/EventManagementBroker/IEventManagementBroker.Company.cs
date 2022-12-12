using Event_Management.Models.EventManagementModels;

namespace Event_Management.Brokers.EventManagementBroker
{
    public partial interface IEventManagementBroker
    {
        public Task<List<Room>> SelectAllEmptyRooms();

        public Task<List<(int, bool)>> StatisticsOfSeat();


    }
}
