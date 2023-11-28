namespace Wema.BIT.Models // You might want to create a dedicated namespace for models
{
    public class UserList
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        // Other properties related to a user

        // Constructor (optional)
        public UserList(int userId, string userName, string email)
        {
            UserId = userId;
            UserName = userName;
            Email = email;
            // Initialize other properties if needed
        }

        // Default constructor (optional)
        public UserList()
        {
            // Default constructor
        }
    }
}
