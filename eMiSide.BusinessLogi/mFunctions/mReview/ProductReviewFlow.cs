using eDomain.mModels.mReview;
using eMiSide.BusinessLogic.mInterfaces;

namespace eMiSide.BusinessLogic.Functions.Review
{
    public class ProductReviewFlow : IProductReviewActions
    {
        public ProductReviewDto CreateProductReviewAction(ProductReviewDto review) => review;
        public List<ProductReviewDto> GetProductReviewsByProductIdAction(int productId) => new();
        public bool DeleteProductReviewAction(int id) => false;
    }
}