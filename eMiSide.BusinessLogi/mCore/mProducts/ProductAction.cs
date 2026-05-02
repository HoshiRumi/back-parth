using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eDomain.mModels.mProduct;

namespace eMiSide.BusinessLogic.Core.Products
{
    public class ProductAction
    {
        private static List<ProductDto> _products = new();
        private static int _nextId = 1;

        public List<ProductDto> GetAll() => _products;

        public ProductDto? GetById(int id) =>
            _products.FirstOrDefault(p => p.Id == id);

        public bool Create(ProductDto product)
        {
            product.Id = _nextId++;
            _products.Add(product);
            return true;
        }

        public bool Update(ProductDto product)
        {
            var existing = _products.FirstOrDefault(p => p.Id == product.Id);
            if (existing == null) return false;
            existing.Name = product.Name;
            existing.Description = product.Description;
            existing.Price = product.Price;
            existing.Stock = product.Stock;
            existing.ImageUrl = product.ImageUrl;
            return true;
        }

        public bool Delete(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product == null) return false;
            _products.Remove(product);
            return true;
        }
    }
}