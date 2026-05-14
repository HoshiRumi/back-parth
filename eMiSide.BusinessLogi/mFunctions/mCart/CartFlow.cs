using eDomain.mModels.mCart;
using eMiSide.BusinessLogic.mInterfaces;
using eMiSide.BusinessLogic.Core.Cart;

namespace eMiSide.BusinessLogic.Functions.Cart
{
    public class CartFlow : ICartActions
    {
        private readonly CartActions _actions = new();
        public CartDto? GetCartAction() => _actions.GetCart();
        public CartDto? AddItemToCartAction(CartItem item) => _actions.AddItem(item);
        public CartDto? UpdateCartItemAction(int itemId, CartItem item) => _actions.UpdateItem(itemId, item);
        public bool DeleteCartItemAction(int itemId) => _actions.DeleteItem(itemId);
        public bool ClearCartAction() => _actions.ClearCart();
    }
}