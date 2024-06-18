namespace ShopApp.DAL.Models.Customers
{
    public class CustomerUpdateModel : CustomerModel
    {
        public DateTime? modify_date { get; set; }
        public int? modify_user { get; set; }
    }
}
