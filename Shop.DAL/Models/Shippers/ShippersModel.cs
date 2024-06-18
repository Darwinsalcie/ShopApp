

namespace ShopApp.DAL.Models.Shippers
{
    public class ShippersModel
    {
 
        public string address { get; set; }
        public string city { get; set; }
        public string? region { get; set; }
        public string? postalcode { get; set; }
        public string country { get; set; }
        public string phone { get; set; }
        public int shipperid { get; set; }
        public string name { get; set; }
    }
}
