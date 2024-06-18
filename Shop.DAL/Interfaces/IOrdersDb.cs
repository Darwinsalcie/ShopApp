


using ShopApp.DAL.Models.Orders;

namespace ShopApp.DAL.Interfaces
{
    public interface IOrdersDb
    {
        OrdersModel GetOrdersById(int ordersid);
        List<OrdersModel> GetOrders();


        void SaveOrders(OrdersAddModel ordersAdd);
        void UpdateOrders(OrdersUpdateModel ordersUpdate);
        void RemoveOrders(OrdersRemoveModel ordersRemove);

    }
}
