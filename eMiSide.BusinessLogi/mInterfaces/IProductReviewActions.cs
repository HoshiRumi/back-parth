using eDomain.mModels.mReview;

namespace eMiSide.BusinessLogic.mInterfaces
{
    public interface IProductReviewActions
    {
        ProductReviewDto CreateProductReviewAction(ProductReviewDto review);
        List<ProductReviewDto> GetProductReviewsByProductIdAction(int productId);
        bool DeleteProductReviewAction(int id);
    }
}