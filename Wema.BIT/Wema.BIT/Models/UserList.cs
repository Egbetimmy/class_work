namespace Wema.BIT.Models
{
    public class UserList
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }

        public UserList(int userId, string userName, string email)
        {
            UserId = userId;
            UserName = userName;
            Email = email;
        }

        public UserList()
        {
            // Default constructor
        }
    }
}
