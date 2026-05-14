using eDomain.mModels.mReview;
using eMiSide.BusinessLogic.Core.Review;
using eMiSide.BusinessLogic.mInterfaces;

namespace eMiSide.BusinessLogic.Functions.Review
{
    public class ProductReviewFlow : IProductReviewActions
    {
        private readonly ProductReviewActions _actions = new();
        public ProductReviewDto CreateProductReviewAction(ProductReviewDto review) => _actions.Create(review);
        public List<ProductReviewDto> GetProductReviewsByProductIdAction(int productId) => _actions.GetByProductId(productId);
        public bool DeleteProductReviewAction(int id) => _actions.Delete(id);
    }
}