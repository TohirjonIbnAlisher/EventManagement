
namespace Event_Management.Services.EventManagementServices
{
    public partial class EventManagementServices
    {
        public async Task RegisteredSeat(int room_id, int seatNumber)
        {
            await eventManagementBroker.RegisteredSeat(room_id, seatNumber);
        }

    }
}
