using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Raddish.Webs.Models;
using Raddish.Webs.Services.IServices;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Raddish.Webs.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public async Task<IActionResult>Index()
        {
            List<ProductDto> list = new List<ProductDto>();
            var response = await _productService.GetAllProductsAsync<ResponseDto>();
            if (response != null && response.IsSuccess)
            {
            list=JsonConvert.DeserializeObject<List<ProductDto>>(Convert.ToString(response.Result));
            }

            return View(list);
        }
    }
}
