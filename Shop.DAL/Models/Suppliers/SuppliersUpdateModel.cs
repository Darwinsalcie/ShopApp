

namespace ShopApp.DAL.Models.Suppliers
{
    public class SuplliersUpdateModel : SuppliersModel
    {
     
        public DateTime? modify_date { get; set; }
        public int? modify_user { get; set; }
       
    }
}
