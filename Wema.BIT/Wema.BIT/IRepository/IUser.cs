using System.Collections.Generic;
using Wema.BIT.Models;

namespace Wema.BIT.IRepository
{
    public interface IUser
    {
        string AddUser(UserList userList);   
        List<UserList> GetAllUser();
        void EditUser();
        void DeleteUser();
        void ViewUser();
        int AddNumber(int a, int b);
    }

}
