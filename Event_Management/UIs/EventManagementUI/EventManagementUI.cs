
using Event_Management.Services.EventManagementServices;

namespace Event_Management.UIs.EventManagementUI
{
    public class EventManagementUI
    {
        private readonly IEventManagementServices eventManagementService;

        public EventManagementUI(IEventManagementServices eventManagementService)
        {
            this.eventManagementService = eventManagementService;   
        }


    }
}
