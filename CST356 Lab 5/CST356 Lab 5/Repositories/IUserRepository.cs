using System.Collections.Generic;
using CST356_Lab_5.Data.Entities;

namespace CST356_Lab_5.Repositories
{
    public interface IUserRepository
    {
        User GetUser(int id);

        IEnumerable<User> GetAllUsers();

        void SaveUser(User user);

        void UpdateUser(User user);

        void DeleteUser(int id);
    }
}
