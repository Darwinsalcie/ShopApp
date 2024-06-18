namespace ShopApp.DAL.Models.Customers
{
    public class CustomerRemoveModel : CustomerModel
    {
        public int? delete_user { get; set; }
        public DateTime? delete_date { get; set; }
        public bool deleted { get; set; }
    }
}
