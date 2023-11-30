using System.Collections.Generic;
using Wema.BIT.Models;

namespace Wema.BIT.IRepository
{
    public interface IUser
    {
        string AddUser(UserList userList);
        List<UserList> GetAllUser();
        void EditUser(int userId);
        void DeleteUser(int userId);
        void ViewUser(int userId);
        int AddNumber(int a, int b);
    }
}
