using System.Collections.Generic;
using System.Linq;
using StaycationDemo.Models.Abstractions;

namespace StaycationDemo.Models.Repositories
{
    public class MockUserRepository : IUserRepository
    {
        public IEnumerable<User> AllUsers => 
            new List<User>
            {
                new User {FirstName = "Maxwell", LastName = "Agu", Email = "maxwellebuka.agu@gmail.com", Password = "max2020%"},
                new User {FirstName = "Obinna", LastName = "Byron", Email = "obinnalion@gmail.com", Password = "lion20%"},
                new User {FirstName = "Maxwell", LastName = "Ebuka", Email = "maxchangehub@gmail.com", Password = "ebuka2020%"},
                new User {FirstName = "Steve", LastName = "Lampard", Email = "kingofball@gmail.com", Password = "kguyliuho**"}
            };

        public User GetUserByEmailAndPassword(string email, string password)
        {
            User user = null; 
            foreach (var p in AllUsers)
            {
                if (p.Email == email)
                    user = p;
            }
            return user;                                                                                                                                                                                                                                                                                                                                                                                                            
        }

        public bool SaveCustomer(User customer)
        {
            bool isSaved = false;
			foreach (var p in AllUsers)
			{
                if (customer.Email == p.Email) return isSaved;
                
			}
            AllUsers.Append(customer);
			isSaved = true;
			return isSaved;
		}
    }
}
