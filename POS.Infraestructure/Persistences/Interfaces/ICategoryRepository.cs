using POS.Domain.Entities;
using POS.Infraestructure.Commons.Bases.Requests;
using POS.Infraestructure.Commons.Bases.Responses;

namespace POS.Infraestructure.Persistences.Interfaces
{
    public interface ICategoryRepository
    {
        Task<BaseEntityResponse<Category>> ListCategories(BaseFiltersRequest request);
        Task<IEnumerable<Category>> ListSelectCategories();
        Task<Category> CategoryById(int categoryId);
        Task<bool> RegisterCategory(Category category);
        Task<bool> EditCategory(Category category);
        Task<bool> RemoveCategory(int categoryId);
    }
}
