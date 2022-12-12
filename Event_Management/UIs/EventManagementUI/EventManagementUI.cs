
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

        private async Task Menu()
        {
            Console.WriteLine("1.Admin bo'lib kirish\n" +
                "2.Company\n" +
                "3.User");

            int key = int.Parse(Console.ReadLine());    

            switch()
        }

    }
}
