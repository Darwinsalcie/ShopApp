

namespace ShopApp.DAL.Models.Suppliers
{
    public class SuplliersRemoveModel : SuppliersModel
    {
    
        public int? delete_user { get; set; }
        public DateTime? delete_date { get; set; }
        public bool deleted { get; set; }
    }
}
