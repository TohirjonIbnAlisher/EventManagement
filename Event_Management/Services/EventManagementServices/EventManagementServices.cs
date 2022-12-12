

using Event_Management.Brokers.EventManagementBroker;

namespace Event_Management.Services.EventManagementServices
{
    public partial class EventManagementServices : IEventManagementServices
    {
        public readonly IEventManagementBroker eventManagementBroker;
        public EventManagementServices(IEventManagementBroker eventManagementBroker)
        {
            this.eventManagementBroker = eventManagementBroker;
        }

        
    }
}
