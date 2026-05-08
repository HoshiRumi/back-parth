using eDomain.mModels.mCart;
using eMiSide.BusinessLogic.mInterfaces;

namespace eMiSide.BusinessLogic.Functions.Cart
{
    public class CartFlow : ICartActions
    {
        public CartDto? GetCartAction() => null;
        public CartDto? AddItemToCartAction(CartItem item) => null;
        public CartDto? UpdateCartItemAction(int itemId, CartItem item) => null;
        public bool DeleteCartItemAction(int itemId) => false;
        public bool ClearCartAction() => false;
    }
}