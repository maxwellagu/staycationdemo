using System.Collections.Generic;
using StaycationDemo.Models.Abstractions;

namespace StaycationDemo.Models.Repositories
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Houses with beauty backyard", Description="Enjoy the most comfortable backyard"},
                new Category{CategoryId=2, CategoryName="Hotels with large living room", Description="Large excusit living room"},
                new Category{CategoryId=3, CategoryName="Apartments with kitchen set", Description="Amazing beautiful kitchen for you."}
            };
    }
}
