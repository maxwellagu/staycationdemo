using StaycationDemo.Models.Abstractions;
using System.Collections.Generic;

namespace StaycationDemo.Models.Repositories
{
    public class UserRepository : IUserRepository
    {
        public IEnumerable<User> AllUsers => throw new System.NotImplementedException();

        public User GetUserByEmailAndPassword(string email, string password)
        {
            throw new System.NotImplementedException();
        }

        public bool SaveCustomer(User user)
        {
            throw new System.NotImplementedException();
        }
    }
}
