using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using eDomain.mModels.mProduct;

namespace eMiSide.BusinessLogic.Interfaces
{
    public interface IProduct
    {
        List<ProductDto> GetAllProductsAction();
        ProductDto? GetProductByIdAction(int id);
        bool ResponceProductCreateAction(ProductDto product);
        bool ResponceProductUpdateAction(ProductDto product);
        bool ResponceProductDeleteAction(int id);
    }
}