using StaycationDemo.Models.Abstractions;
using System.Collections.Generic;

namespace StaycationDemo.Models.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories => throw new System.NotImplementedException();
    }
}
