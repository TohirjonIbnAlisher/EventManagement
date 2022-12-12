using Event_Management.Models.EventManagementModels;
using System.Data.SqlClient;

namespace Event_Management.Brokers.EventManagementBroker
{
    public partial interface IEventManagementBroker
    {
        public Task Registered(Users user);

    }
}
