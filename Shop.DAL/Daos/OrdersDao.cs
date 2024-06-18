


using ShopApp.DAL.Context;
using ShopApp.DAL.Interfaces;

using ShopApp.DAL.Models.Orders;

namespace ShopApp.DAL.Daos
{
    public class Orders : IOrdersDb
    {
        private readonly ShopAppContext context;

        public Orders(ShopAppContext context)
        {
            this.context = context;
        }

        public OrdersModel GetOrdersById(int ordersid)
        {
            throw new NotImplementedException();
        }
        public List<OrdersModel> GetOrders()
        {
            throw new NotImplementedException();
        }


        public void RemoveOrders(OrdersRemoveModel ordersRemove)
        {
            throw new NotImplementedException();
        }

        public void SaveOrders(OrdersAddModel ordersAdd)
        {
            throw new NotImplementedException();
        }

        public void UpdateOrders(OrdersUpdateModel ordersUpdate)
        {
            throw new NotImplementedException();
        }
    }
}