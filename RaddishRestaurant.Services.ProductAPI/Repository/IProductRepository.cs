using RaddishRestaurant.Services.ProductAPI.Models.Dto;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RaddishRestaurant.Services.ProductAPI.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductDto>> GetProducts();
        Task<ProductDto> GetProductById(int productId);

        Task<ProductDto> CreateUpdateProduct(ProductDto productDto);
        Task<bool> DeleteProduct(int productId);
    }
}
