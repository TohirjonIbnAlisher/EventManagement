
using Event_Management.Models.EventManagementModels;

namespace Event_Management.Services.EventManagementServices
{
    public partial interface IEventManagementServices
    {
        public Task RegisteredSeat(int room_id, int seatNumber);

    }
}
