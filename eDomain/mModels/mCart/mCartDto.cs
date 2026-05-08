namespace eDomain.mModels.mCart
{
    public class CartItem
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }

    public class CartDto
    {
        public int Id { get; set; }
        public List<CartItem> Items { get; set; } = new();
    }
}