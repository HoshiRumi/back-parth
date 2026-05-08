using eDomain.mModels.mOrder;
using eMiSide.BusinessLogic.mInterfaces;

namespace eMiSide.BusinessLogic.Functions.Order
{
    public class OrderFlow : IOrderActions
    {
        public List<OrderDto> GetUserOrdersByIdAction(int userId) => new();
        public OrderDto? GetOrderByIdAction(int id) => null;
        public OrderDto? UpdateOrderStatusAction(int id, string newStatus) => null;
        public OrderDto CreateOrderAction(OrderDto order) => order;
    }
}