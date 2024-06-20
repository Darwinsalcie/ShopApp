

using ShopApp.DAL.Core;
using System.ComponentModel.DataAnnotations;

namespace ShopApp.DAL.Entities
{
    public class Customers : Person
    {
        [Key]
        public int custid { get; set; }
        public string companyname { get; set; }
        public string contactname { get; set; }
        public string contacttitle { get; set; }
        public string email { get; set; }


    }
}