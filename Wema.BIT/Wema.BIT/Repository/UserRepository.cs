using System;
using System.Collections.Generic;
using Wema.BIT.IRepository;
using Wema.BIT.Models;

namespace Wema.BIT.Repository
{
    public class UserRepository : IUser
    {
        public int AddNumber(int a, int b)
        {
            return a + b;
        }

        public string AddUser(UserList userList)
        {
            // Simulating adding a user (replace with actual implementation)
            Console.WriteLine($"Adding user: {userList.UserName} - {userList.Email}");
            return "User added successfully";
        }

        public void DeleteUser()
        {
            // Implement logic to delete a user
        }

        public void EditUser()
        {
            // Implement logic to edit user details
        }

        public void ViewUser()
        {
            // Implement logic to view user details
        }

        public List<UserList> GetAllUser()
        {
            // Implement logic to get all users
            return new List<UserList>();
        }
    }
}
