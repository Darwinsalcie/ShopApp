

namespace ShopApp.DAL.Models.OrderDetails
{
    public class OrderDetailsAddModel : OrderDetailsModel
    {
 
        public DateTime creation_date { get; set; }
        public int creation_user { get; set; }

    }
}
