using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdoptAPet.Models
{
    public interface ICategoryRepository
    {
        IQueryable<Category> Categories { get; }
        void AddCategory(Category newCategory);
        void EditCategory(Category category);
        Category DeleteCategory(int categoryID);
    }
}
