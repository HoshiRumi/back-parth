using eDomain.mEntities.mRefs;

namespace eDomain.mEntities.mOrder
{
    public class OrderData : SharedFields
    {
        public int UserId { get; set; }
        public decimal TotalPrice { get; set; }
        public string Status { get; set; } = "Pending";
        public string ShippingAddress { get; set; } = string.Empty;
        public List<OrderItemData> Items { get; set; } = new();
    }
}