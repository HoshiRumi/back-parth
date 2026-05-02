using eDomain.mEntities.mRefs;
using eDomain.mEnums;

namespace eDomain.mEntities.mProduct
{
    public class ProductData : SharedFields
    {
        public int CategoryId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public ProductStatus Status { get; set; } = ProductStatus.Available;
    }
}