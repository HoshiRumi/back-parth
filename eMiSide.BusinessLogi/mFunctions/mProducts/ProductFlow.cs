using eDomain.mModels.mProduct;
using eMiSide.BusinessLogic.Core.Products;
using eMiSide.BusinessLogic.Interfaces;
using eMiSide.BusinessLogic.mInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMiSide.BusinessLogic.Functions.Products
{
    public class ProductFlow : IProduct
    {
        private readonly ProductAction _actions = new();

        public List<ProductDto> GetAllProductsAction() =>
            _actions.GetAll();

        public ProductDto? GetProductByIdAction(int id) =>
            _actions.GetById(id);

        public bool ResponceProductCreateAction(ProductDto product) =>
            _actions.Create(product);

        public bool ResponceProductUpdateAction(ProductDto product) =>
            _actions.Update(product);

        public bool ResponceProductDeleteAction(int id) =>
            _actions.Delete(id);
    }
}