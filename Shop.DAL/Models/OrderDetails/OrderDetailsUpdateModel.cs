

namespace ShopApp.DAL.Models.OrderDetails
{
    public class OrderDetailsUpdateModel : OrderDetailsModel
    {
 
        public DateTime? modify_date { get; set; }
        public int? modify_user { get; set; }

    }
}
