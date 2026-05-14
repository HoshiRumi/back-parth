using eDomain.mModels.mOrder;
using eMiSide.BusinessLogic.Core.Order;
using eMiSide.BusinessLogic.mInterfaces;

namespace eMiSide.BusinessLogic.Functions.Order
{
    public class OrderFlow : IOrderActions
    {
        private readonly OrderActions _actions = new();
        public List<OrderDto> GetUserOrdersByIdAction(int userId) => _actions.GetByUserId(userId);
        public OrderDto? GetOrderByIdAction(int id) => _actions.GetById(id);
        public OrderDto? UpdateOrderStatusAction(int id, string newStatus) => _actions.UpdateStatus(id, newStatus);
        public OrderDto CreateOrderAction(OrderDto order) => _actions.Create(order);
    }
}