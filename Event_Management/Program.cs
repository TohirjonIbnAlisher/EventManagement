using Event_Management.Brokers.EventManagementBroker;
using Event_Management.Services.EventManagementServices;

namespace Event_Management
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            
        }

        private static IEventManagementServices GetObject()
        {
            IEventManagementBroker eventManagementBroker = new EventManagementBroker();

            return new EventManagementServices(eventManagementBroker);
        }
    }
}