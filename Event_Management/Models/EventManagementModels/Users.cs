
namespace Event_Management.Models.EventManagementModels
{
    public class Users
    {
        public Users(string username,string password,string tellNumber,string role)
        { 
            UserName= username;
            Password= password;
            Role= role;
            TellNumber= tellNumber;
        }
        public Users(string username, string password, string tellNumber, string role,int id)
        {
            UserName = username;
            Password = password;
            Role = role;
            TellNumber = tellNumber;
            Id = id;
        }
        public int Id { get; }
        public string UserName { get;}
        public string Password { get;}
        public string Role { get;}
        public string TellNumber{ get;}
    }
}
