using eDomain.mModels.mReview;

namespace eMiSide.BusinessLogic.Core.Review
{
    public class ProductReviewActions
    {
        private static List<ProductReviewDto> _reviews = new();
        private static int _nextId = 1;

        public ProductReviewDto Create(ProductReviewDto review)
        {
            review.Id = _nextId++;
            _reviews.Add(review);
            return review;
        }

        public List<ProductReviewDto> GetByProductId(int productId) =>
            _reviews.Where(r => r.ProductId == productId).ToList();

        public bool Delete(int id)
        {
            var review = _reviews.FirstOrDefault(r => r.Id == id);
            if (review == null) return false;
            _reviews.Remove(review);
            return true;
        }
    }
}