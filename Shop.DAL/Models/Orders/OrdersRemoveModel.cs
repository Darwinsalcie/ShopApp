


namespace ShopApp.DAL.Models.Orders
{
    public class OrdersRemoveModel : OrdersModel
    {
        public int? delete_user { get; set; }
        public DateTime? delete_date { get; set; }
        public bool deleted { get; set; }
            
     }
}
