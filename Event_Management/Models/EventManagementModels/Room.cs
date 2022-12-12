
namespace Event_Management.Models.EventManagementModels
{
    public class Room
    {
        public Room(string name,int numberRoom,int capacity)
        {
            Name= name;
            NumberRoom= numberRoom;
            Capacity= capacity;
        }

        public Room(string name, int numberRoom, int capacity,bool isOrdered)
        {
            Name = name;
            NumberRoom = numberRoom;
            Capacity = capacity;
            IsOrdered = isOrdered;
        }

        public string Name { get;}
        public int NumberRoom { get;}
        public int Capacity { get;}
        public bool IsOrdered { get;}
    }
}
