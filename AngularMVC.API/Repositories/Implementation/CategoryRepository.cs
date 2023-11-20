using AngularMVC.API.Data;
using AngularMVC.API.Models.Domain;
using AngularMVC.API.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace AngularMVC.API.Repositories.Implementation
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext dbContext;

        public CategoryRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Category> CategoryAsync(Category category)
        {
            await dbContext.Categories.AddAsync(category);
            await dbContext.SaveChangesAsync();
            return (category);
        }
    }
}
