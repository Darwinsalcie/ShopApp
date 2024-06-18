


using ShopApp.DAL.Models.OrderDetails;

namespace ShopApp.DAL.Interfaces
{
    public interface IOrderDetailsDb
    {
        OrderDetailsModel GetOrderDetailsById(int orderdetailsid);
        List<OrderDetailsModel> GetOrderDetails();


        void SaveOrderDetails(OrderDetailsAddModel orderdetailsAdd);
        void UpdateOrderDetails(OrderDetailsUpdateModel orderdetailsUpdate);
        void RemoveOrderDetails(OrderDetailsRemoveModel orderdetailsRemove);

    }
}
