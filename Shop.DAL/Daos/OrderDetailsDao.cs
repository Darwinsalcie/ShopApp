
using ShopApp.DAL.Context;
using ShopApp.DAL.Interfaces;
using ShopApp.DAL.Models.OrderDetails;

namespace ShopApp.DAL.Daos
{
    public class OrderDetailsDao : IOrderDetailsDb
    {
        private readonly ShopAppContext context;

        public OrderDetailsDao(ShopAppContext context )
        {
            this.context = context;
        }

        public OrderDetailsModel GetOrderDetailsById(int orderdetailsid)
        {
            throw new NotImplementedException();
        }
        public List<OrderDetailsModel> GetOrderDetails()
        {
            throw new NotImplementedException();
        }


        public void RemoveOrderDetails(OrderDetailsRemoveModel orderdetailsRemove)
        {
            throw new NotImplementedException();
        }

        public void SaveOrderDetails(OrderDetailsAddModel orderdetailsAdd)
        {
            throw new NotImplementedException();
        }

        public void UpdateOrderDetails(OrderDetailsUpdateModel orderdetailsUpdate)
        {
            throw new NotImplementedException();
        }
    }
}