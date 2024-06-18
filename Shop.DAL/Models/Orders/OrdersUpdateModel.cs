

namespace ShopApp.DAL.Models.Orders
{
    public class OrdersUpdateModel : OrdersModel
    {
        public DateTime? modify_date { get; set; }
        public int? modify_user { get; set; }
    }

}
