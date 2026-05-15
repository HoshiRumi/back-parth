using eDomain.mModels.mProduct;
using eMiSide.BusinessLogic.Interfaces;
using eMiSide.BusinessLogic.mInterfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eMiSide.Api.Controller
{
    [Route("api/product")]
    [ApiController]
    [Authorize]
    public class ProductController : ControllerBase
    {
        private IProduct _product;

        public ProductController()
        {
            var bl = new BusinessLogic.BusinessLogic();
            _product = bl.GetProductActions();
        }

        [HttpGet("getAll")]
        [AllowAnonymous]
        public IActionResult GetAllProducts() =>
            Ok(_product.GetAllProductsAction());

        [HttpGet("{id}")]
        [AllowAnonymous]
        public IActionResult Get(int id) =>
            Ok(_product.GetProductByIdAction(id));

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult Create([FromBody] ProductDto product) =>
            Ok(_product.ResponceProductCreateAction(product));

        [HttpPut]
        [Authorize(Roles = "Admin")]
        public IActionResult Update([FromBody] ProductDto product) =>
            Ok(_product.ResponceProductUpdateAction(product));

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int id) =>
            Ok(_product.ResponceProductDeleteAction(id));
    }
}