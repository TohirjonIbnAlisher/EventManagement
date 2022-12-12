using Event_Management.Models.EventManagementModels;

namespace Event_Management.Brokers.EventManagementBroker
{
    public partial interface IEventManagementBroker
    {
        public Task InsertNewRoom(Room room);
        public Task UpdateRoom(Room room);
        public Task DeleteRoom(int numberRoom);

        public Task<List<Room>> SelectAllRoom();

    }
}
