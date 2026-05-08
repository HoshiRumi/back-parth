using eDomain.mModels.mCart;

namespace eMiSide.BusinessLogic.mInterfaces
{
    public interface ICartActions
    {
        CartDto? GetCartAction();
        CartDto? AddItemToCartAction(CartItem item);
        CartDto? UpdateCartItemAction(int itemId, CartItem item);
        bool DeleteCartItemAction(int itemId);
        bool ClearCartAction();
    }
}