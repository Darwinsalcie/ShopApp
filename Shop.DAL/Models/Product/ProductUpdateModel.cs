

namespace ShopApp.DAL.Models.Product
{
    public class ProductUpdateModel : ProductModel
    {

  
        public DateTime? modify_date { get; set; }
        public int? modify_user { get; set; }
   
    }
}
