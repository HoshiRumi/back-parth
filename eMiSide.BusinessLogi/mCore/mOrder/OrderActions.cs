using eDomain.mEntities.mOrder;
using eDomain.mModels.mOrder;
using eMiSide.DataAccess.Context;
using Microsoft.EntityFrameworkCore;

namespace eMiSide.BusinessLogic.Core.Order
{
    public class OrderActions
    {
        public List<OrderDto> GetByUserId(int userId)
        {
            using (var db = new AppDbContext())
            {
                return db.Orders
                    .Include(o => o.Items)
                    .Where(o => o.UserId == userId)
                    .Select(o => new OrderDto
                    {
                        Id = o.Id,
                        UserId = o.UserId,
                        Status = o.Status,
                        TotalPrice = o.TotalPrice,
                        ShippingAddress = o.ShippingAddress,
                        CreatedAt = o.CreatedAt
                    }).ToList();
            }
        }

        public OrderDto? GetById(int id)
        {
            using (var db = new AppDbContext())
            {
                var o = db.Orders.Include(o => o.Items).FirstOrDefault(o => o.Id == id);
                if (o == null) return null;
                return new OrderDto
                {
                    Id = o.Id,
                    UserId = o.UserId,
                    Status = o.Status,
                    TotalPrice = o.TotalPrice,
                    ShippingAddress = o.ShippingAddress,
                    CreatedAt = o.CreatedAt
                };
            }
        }

        public OrderDto? UpdateStatus(int id, string newStatus)
        {
            using (var db = new AppDbContext())
            {
                var order = db.Orders.FirstOrDefault(o => o.Id == id);
                if (order == null) return null;
                order.Status = newStatus;
                db.SaveChanges();
                return new OrderDto
                {
                    Id = order.Id,
                    UserId = order.UserId,
                    Status = order.Status,
                    TotalPrice = order.TotalPrice
                };
            }
        }

        public OrderDto Create(OrderDto order)
        {
            using (var db = new AppDbContext())
            {
                var newOrder = new OrderData
                {
                    UserId = order.UserId,
                    Status = order.Status,
                    TotalPrice = order.TotalPrice,
                    ShippingAddress = order.ShippingAddress,
                    CreatedAt = DateTime.UtcNow
                };
                db.Orders.Add(newOrder);
                db.SaveChanges();
                order.Id = newOrder.Id;
                return order;
            }
        }
    }
}