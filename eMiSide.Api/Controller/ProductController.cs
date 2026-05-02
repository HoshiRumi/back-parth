using eDomain.mModels.mProduct;
using eMiSide.BusinessLogic.Interfaces;
using eMiSide.BusinessLogic.mInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace eMiSide.Api.Controller
{
    [Route("api/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProduct _product;

        public ProductController()
        {
            var bl = new BusinessLogic.BusinessLogic();
            _product = bl.GetProductActions();
        }

        [HttpGet("getAll")]
        public IActionResult GetAllProducts() =>
            Ok(_product.GetAllProductsAction());

        [HttpGet("{id}")]
        public IActionResult Get(int id) =>
            Ok(_product.GetProductByIdAction(id));

        [HttpPost]
        public IActionResult Create([FromBody] ProductDto product) =>
            Ok(_product.ResponceProductCreateAction(product));

        [HttpPut]
        public IActionResult Update([FromBody] ProductDto product) =>
            Ok(_product.ResponceProductUpdateAction(product));

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) =>
            Ok(_product.ResponceProductDeleteAction(id));
    }
}