using eDomain.mEntities.mReview;
using eDomain.mModels.mReview;
using eMiSide.DataAccess.Context;

namespace eMiSide.BusinessLogic.Core.Review
{
    public class ProductReviewActions
    {
        public ProductReviewDto Create(ProductReviewDto review)
        {
            using (var db = new AppDbContext())
            {
                var newReview = new ReviewData
                {
                    UserId = review.UserId,
                    ProductId = review.ProductId,
                    Rating = review.Rating,
                    Comment = review.Comment,
                    CreatedAt = DateTime.UtcNow
                };
                db.Reviews.Add(newReview);
                db.SaveChanges();
                review.Id = newReview.Id;
                return review;
            }
        }

        public List<ProductReviewDto> GetByProductId(int productId)
        {
            using (var db = new AppDbContext())
            {
                return db.Reviews
                    .Where(r => r.ProductId == productId)
                    .Select(r => new ProductReviewDto
                    {
                        Id = r.Id,
                        UserId = r.UserId,
                        ProductId = r.ProductId,
                        Rating = r.Rating,
                        Comment = r.Comment
                    }).ToList();
            }
        }

        public bool Delete(int id)
        {
            using (var db = new AppDbContext())
            {
                var review = db.Reviews.FirstOrDefault(r => r.Id == id);
                if (review == null) return false;
                db.Reviews.Remove(review);
                db.SaveChanges();
                return true;
            }
        }
    }
}