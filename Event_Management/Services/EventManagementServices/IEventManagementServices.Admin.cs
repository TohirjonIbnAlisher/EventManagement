
using Event_Management.Models.EventManagementModels;

namespace Event_Management.Services.EventManagementServices
{
    public partial interface IEventManagementServices
    {
        public Task InsertNewRoom(string name, int numberRoom, int capacity);

        public Task UpdateRoom(string name, int numberRoom, int capacity);

        public Task Delete(int id);

        public Task<List<Room>> SelectAllRoom(int id);

    }
}
