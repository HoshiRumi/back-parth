using eMiSide.BusinessLogic.Functions.Auth;
using eMiSide.BusinessLogic.Functions.Cart;
using eMiSide.BusinessLogic.Functions.Order;
using eMiSide.BusinessLogic.Functions.Products;
using eMiSide.BusinessLogic.Functions.Review;
using eMiSide.BusinessLogic.Functions.User;
using eMiSide.BusinessLogic.Interfaces;
using eMiSide.BusinessLogic.mInterfaces;
namespace eMiSide.BusinessLogic
{
    public class BusinessLogic
    {
        public IAuthActions GetAuthActions() => new AuthFlow();
        public IProduct GetProductActions() => new ProductFlow();
        public ICartActions GetCartActions() => new CartFlow();
        public IOrderActions GetOrderActions() => new OrderFlow();
        public IProductReviewActions GetProductReviewActions() => new ProductReviewFlow();
        public IUserActions GetUserActions() => new UserFlow();
    }
}