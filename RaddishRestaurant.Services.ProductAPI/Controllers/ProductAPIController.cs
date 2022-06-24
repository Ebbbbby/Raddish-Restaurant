using Microsoft.AspNetCore.Mvc;
using RaddishRestaurant.Services.ProductAPI.Models.Dto;
using RaddishRestaurant.Services.ProductAPI.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RaddishRestaurant.Services.ProductAPI.Controllers
{
    [Route("api/products")]

    
    public class ProductAPIController : Controller
    {
        protected ResponseDto _response;
        private IProductRepository _productRepository;
        public ProductAPIController(IProductRepository productRepository)

        {
            _productRepository = productRepository;
            this._response = new ResponseDto();  
        }
        [HttpGet]
      public async Task<object> Get()
        {
            try
            {
      
            IEnumerable<ProductDto> productsDtos = await _productRepository.GetProducts();
                _response.Result = productsDtos;    
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>()
                {
                    ex.ToString()
                };
            }
            return _response;
      }



        [HttpGet]
        [Route("{id}")]
        public async Task<object> Get(int id)
        {
            try
            {
                ProductDto productsDto= await _productRepository.GetProductById(id);
                _response.Result = productsDto;
            }
            catch (Exception ex)
            {

                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>()
                {
                    ex.ToString()
                };
            }
            return _response;
        }
    }
}
