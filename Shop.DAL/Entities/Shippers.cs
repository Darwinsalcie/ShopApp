
using ShopApp.DAL.Core;

namespace ShopApp.DAL.Entities
{
    public class Shippers: Person
    {
        public int shipperid { get; set; }
        public string name { get; set; }
    }
}
