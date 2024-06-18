

using ShopApp.DAL.Core;

namespace ShopApp.DAL.Entities
{
    public class Customers : Person
    {
        public int custid { get; set; }
        public string companyname { get; set; }
        public string contactname { get; set; }
        public string contacttitle { get; set; }
        public string email { get; set; }


    }
}