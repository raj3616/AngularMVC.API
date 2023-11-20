using AngularMVC.API.Models.Domain;

namespace AngularMVC.API.Repositories.Interface
{
    public interface ICategoryRepository
    {
        Task<Category> CategoryAsync(Category category);
    }
}
