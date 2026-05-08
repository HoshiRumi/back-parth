using eDomain.mModels.mOrder;

namespace eMiSide.BusinessLogic.Core.Order
{
    public class OrderActions
    {
        private static List<OrderDto> _orders = new();
        private static int _nextId = 1;

        public List<OrderDto> GetByUserId(int userId) =>
            _orders.Where(o => o.UserId == userId).ToList();

        public OrderDto? GetById(int id) =>
            _orders.FirstOrDefault(o => o.Id == id);

        public OrderDto? UpdateStatus(int id, string newStatus)
        {
            var order = _orders.FirstOrDefault(o => o.Id == id);
            if (order == null) return null;
            order.Status = newStatus;
            return order;
        }

        public OrderDto Create(OrderDto order)
        {
            order.Id = _nextId++;
            _orders.Add(order);
            return order;
        }
    }
}