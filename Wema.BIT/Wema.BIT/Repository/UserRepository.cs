using System;
using System.Collections.Generic;
using Wema.BIT.IRepository;
using Wema.BIT.Models;

namespace Wema.BIT.Repository
{
    public class UserRepository : IUser
    {
        private List<UserList> users;

        public UserRepository()
        {
            users = new List<UserList>();
        }

        public string AddUser(UserList userList)  
        {
            users.Add(userList);
            return "User added successfully";
        }

        public List<UserList> GetAllUser()
        {
            return users;
        }

        public void ViewUser(int userId)
        {
            var user = users.Find(u => u.UserId == userId);
            if (user != null)
            {
                Console.WriteLine($"User ID: {user.UserId}, UserName: {user.UserName}, Email: {user.Email}");
            }
            else
            {
                Console.WriteLine("User not found.");
            }
        }

        public void EditUser(int userId)
        {
            var user = users.Find(u => u.UserId == userId);
            if (user != null)
            {
                // Display current user details
                Console.WriteLine($"Current details of User ID: {user.UserId}, UserName: {user.UserName}, Email: {user.Email}");

                // Ask for new details
                Console.Write("Enter new User Name: ");
                string newUserName = Console.ReadLine();

                Console.Write("Enter new Email: ");
                string newEmail = Console.ReadLine();

                // Update user details if new details are provided
                if (!string.IsNullOrWhiteSpace(newUserName))
                {
                    user.UserName = newUserName;
                }

                if (!string.IsNullOrWhiteSpace(newEmail))
                {
                    user.Email = newEmail;
                }

                Console.WriteLine("User details updated successfully.");
            }
            else
            {
                Console.WriteLine("User not found. Cannot edit.");
            }
        }


        public void DeleteUser(int userId)
        {
            var user = users.Find(u => u.UserId == userId);
            if (user != null)
            {
                Console.WriteLine($"User ID: {user.UserId}, UserName: {user.UserName}, Email: {user.Email}");
                users.Remove(user); // Remove the user from the list if found
                Console.WriteLine("User deleted successfully.");
            }
            else
            {
                Console.WriteLine("User not found. Deletion failed.");
            }
        }

        public int AddNumber(int a, int b)
        {
            return a + b;
        }
    }
}
