

using ShopApp.DAL.Core;

namespace ShopApp.DAL.Entities
{
    public class Suppliers : BaseEntity
    {
        public int supplierid { get; set; }
        public string companyname { get; set; }
        public string contactname { get; set; }
        public string contacttitle { get; set; }
        public string? fax { get; set; }
    }
}
