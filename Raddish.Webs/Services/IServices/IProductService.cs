using Raddish.Webs.Models;
using System.Threading.Tasks;

namespace Raddish.Webs.Services.IServices
{
    public interface IProductService:IBaseService
    {
        Task<T> GetAllProductsAsync<T>();
        Task<T> GetProductsByIdAsync<T>(int id);
        Task<T> CreateProductAsync<T>(ProductDto productDto);
        Task<T> UpdateProductAsync<T>(ProductDto productDto);
        Task<T> DeleteProductAsync<T>(int id);
    }
}
