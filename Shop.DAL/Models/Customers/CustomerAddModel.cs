namespace ShopApp.DAL.Models.Customers
{
    public class CustomerAddModel : CustomerModel
    {
        public DateTime creation_date { get; set; }
        public int creation_user { get; set; }
    }
    
}
