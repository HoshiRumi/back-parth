using eDomain.mEntities.mProduct;
using eDomain.mModels.mProduct;
using eMiSide.DataAccess.Context;

namespace eMiSide.BusinessLogic.Core.Products
{
    public class ProductAction
    {
        public List<ProductDto> GetAll()
        {
            using (var db = new AppDbContext())
            {
                return db.Products.Select(p => new ProductDto
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    Price = p.Price,
                    Stock = p.Stock,
                    ImageUrl = p.ImageUrl,
                    Status = p.Status
                }).ToList();
            }
        }

        public ProductDto? GetById(int id)
        {
            using (var db = new AppDbContext())
            {
                var p = db.Products.FirstOrDefault(p => p.Id == id);
                if (p == null) return null;
                return new ProductDto
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    Price = p.Price,
                    Stock = p.Stock,
                    ImageUrl = p.ImageUrl,
                    Status = p.Status
                };
            }
        }

        public bool Create(ProductDto product)
        {
            using (var db = new AppDbContext())
            {
                db.Products.Add(new ProductData
                {
                    Name = product.Name,
                    Description = product.Description,
                    Price = product.Price,
                    Stock = product.Stock,
                    ImageUrl = product.ImageUrl,
                    Status = product.Status,
                    CreatedAt = DateTime.UtcNow
                });
                db.SaveChanges();
                return true;
            }
        }

        public bool Update(ProductDto product)
        {
            using (var db = new AppDbContext())
            {
                var existing = db.Products.FirstOrDefault(p => p.Id == product.Id);
                if (existing == null) return false;
                existing.Name = product.Name;
                existing.Description = product.Description;
                existing.Price = product.Price;
                existing.Stock = product.Stock;
                existing.ImageUrl = product.ImageUrl;
                existing.Status = product.Status;
                db.SaveChanges();
                return true;
            }
        }

        public bool Delete(int id)
        {
            using (var db = new AppDbContext())
            {
                var product = db.Products.FirstOrDefault(p => p.Id == id);
                if (product == null) return false;
                db.Products.Remove(product);
                db.SaveChanges();
                return true;
            }
        }
    }
}