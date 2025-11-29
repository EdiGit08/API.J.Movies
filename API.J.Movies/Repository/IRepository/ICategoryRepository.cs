using API.J.Movies.DAL.Models;

namespace API.J.Movies.Repository.IRepository
{
    public interface ICategoryRepository
    {
        Task<ICollection<Category>> GetCategoriesAsync(); //Me retorna una lista de categorias
        Task<Category> GetCategoryAsync(int id); //Me retorna una categoria en especifico
        Task<bool> CategoryExistsByIdAsync(int id); //Verifica si una categoria existe por id
        Task<bool> CategoryExistsByNameAsync(string name); //Verifica si una categoria existe por nombre
        Task<bool> CreateCategoryAsync(Category category); //Crea una nueva categoria
        Task<bool> UpdateCategoryAsync(Category category); //Actualiza una categoria
        Task<bool> DeleteCategoryAsync(int id); //Elimina una categoria buscando por id
    }
}
