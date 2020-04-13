using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdoptAPet.Models
{
    public class EFCategoryRepository : ICategoryRepository
    {
        private ApplicationDbContext context;

        public EFCategoryRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Category> Categories => context.Categories;
        async public void AddCategory(Category newCategory)
        {
            context.Categories.Add(newCategory);
            await context.SaveChangesAsync();
        }

        async public void EditCategory(Category category)
        {
            if (category.CategoryID == 0)
            {
                context.Categories.Add(category);
            }
            else
            {
                Category dbEntry = context.Categories
                .FirstOrDefault(c => c.CategoryID == category.CategoryID);
                if (dbEntry != null)
                {
                    dbEntry.Name = category.Name;
                }
            }
            await context.SaveChangesAsync();

        }

        public Category DeleteCategory(int categoryID)
        {
            Category dbEntry = context.Categories
            .FirstOrDefault(c => c.CategoryID == categoryID);
            if (dbEntry != null)
            {
                context.Categories.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}
