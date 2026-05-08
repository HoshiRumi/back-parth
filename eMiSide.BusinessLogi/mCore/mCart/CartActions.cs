using eDomain.mModels.mCart;

namespace eMiSide.BusinessLogic.Core.Cart
{
	public class CartActions
	{
		private static CartDto _cart = new() { Id = 1 };

		public CartDto? GetCart() => _cart;

		public CartDto? AddItem(CartItem item)
		{
			_cart.Items.Add(item);
			return _cart;
		}

		public CartDto? UpdateItem(int itemId, CartItem item)
		{
			if (itemId < 0 || itemId >= _cart.Items.Count) return null;
			_cart.Items[itemId] = item;
			return _cart;
		}

		public bool DeleteItem(int itemId)
		{
			if (itemId < 0 || itemId >= _cart.Items.Count) return false;
			_cart.Items.RemoveAt(itemId);
			return true;
		}

		public bool ClearCart()
		{
			_cart.Items.Clear();
			return true;
		}
	}
}