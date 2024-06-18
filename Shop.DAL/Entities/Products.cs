

using ShopApp.DAL.Core;

namespace ShopApp.DAL.Entities
{
    public class Products : BaseEntity
    {
        public int productid { get; set; }
        public string productname { get; set; }
        public int supplierid { get; set; }
        public int categoryid { get; set; }
        public decimal unitprice { get; set; }
        public bool discontinued { get; set; }
    }
}
