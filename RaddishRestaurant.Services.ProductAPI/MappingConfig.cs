using AutoMapper;
using RaddishRestaurant.Services.ProductAPI.Models;
using RaddishRestaurant.Services.ProductAPI.Models.Dto;

namespace RaddishRestaurant.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>();
                config.CreateMap<Product, Product>();
                config.CreateMap<Product, Product>();
                config.CreateMap<Product, ProductDto>();
            });
            return mappingConfig;
        }
    }
}
