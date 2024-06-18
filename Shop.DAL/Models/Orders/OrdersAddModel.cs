

namespace ShopApp.DAL.Models.Orders
{
    public class OrdersAddModel : OrdersModel
    {
  
        public DateTime creation_date { get; set; }
        public int creation_user { get; set; }

    }
}
