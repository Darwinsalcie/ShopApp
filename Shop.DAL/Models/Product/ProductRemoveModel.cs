

namespace ShopApp.DAL.Models.Product
{
    public class ProductRemoveModel : ProductModel
    {
      
        public bool discontinued { get; set; }
        public int? delete_user { get; set; }
        public DateTime? delete_date { get; set; }
        public bool deleted { get; set; }
    }
}
