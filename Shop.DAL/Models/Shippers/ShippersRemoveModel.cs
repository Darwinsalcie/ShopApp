

namespace ShopApp.DAL.Models.Shippers
{
    public class ShippersRemoveModel : ShippersModel
    {
 
        public int? delete_user { get; set; }
        public DateTime? delete_date { get; set; }
        public bool deleted { get; set; }
 
    }
}
