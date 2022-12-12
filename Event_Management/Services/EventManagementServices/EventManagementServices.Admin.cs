
using Event_Management.Models.EventManagementModels;

namespace Event_Management.Services.EventManagementServices
{
    public partial class EventManagementServices
    {
        public async Task InsertNewRoom(string name, int numberRoom, int capacity)
        {
            Room room = new Room(
                name, numberRoom, capacity);
            await eventManagementBroker.InsertNewRoom(room);
        }
        public async Task UpdateRoom(string name, int numberRoom, int capacity)
        {
            Room room = new Room(
                name, numberRoom, capacity);
            await eventManagementBroker.UpdateRoom(room);
        }

        public async Task Delete( int id)
        {
            await eventManagementBroker.DeleteRoom(id);
        }

        public async Task<List<Room>> SelectAllRoom(int id)
        {
            return await eventManagementBroker.SelectAllRoom();
        }
    }
}
