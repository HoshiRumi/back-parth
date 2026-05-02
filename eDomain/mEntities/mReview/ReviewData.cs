using eDomain.mEntities.mRefs;

namespace eDomain.mEntities.mReview
{
    public class ReviewData : SharedFields
    {
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; } = string.Empty;
    }
}