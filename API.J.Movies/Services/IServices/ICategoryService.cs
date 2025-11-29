using API.J.Movies.DAL.Dtos.Category;
using API.J.Movies.DAL.Models;

namespace API.J.Movies.Services.IServices
{
    public interface ICategoryService
    {
        Task<ICollection<CategoryDto>> GetCategoriesAsync();
        Task<CategoryDto> GetCategoryAsync(int id);
        Task<CategoryDto> CreateCategoryAsync(CategoryCreateUpdateDto categoryDto);
        Task<CategoryDto> UpdateCategoryAsync(CategoryCreateUpdateDto dto, int id);
        Task<bool> DeleteCategoryAsync(int id);
        Task<bool> CategoryExistsByIdAsync(int id);
        Task<bool> CategoryExistsByNameAsync(string name);
    }

}
