using eDomain.mModels.mOrder;

namespace eMiSide.BusinessLogic.mInterfaces
{
    public interface IOrderActions
    {
        List<OrderDto> GetUserOrdersByIdAction(int userId);
        OrderDto? GetOrderByIdAction(int id);
        OrderDto? UpdateOrderStatusAction(int id, string newStatus);
        OrderDto CreateOrderAction(OrderDto order);
    }
}
