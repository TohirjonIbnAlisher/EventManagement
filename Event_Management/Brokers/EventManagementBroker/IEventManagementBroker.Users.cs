
namespace Event_Management.Brokers.EventManagementBroker
{
    public partial interface IEventManagementBroker
    {
        public Task RegisteredSeat(int room_id, int seatNumber);

    }
}
