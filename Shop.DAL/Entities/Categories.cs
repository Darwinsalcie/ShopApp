

using ShopApp.DAL.Core;
using System.ComponentModel.DataAnnotations;

namespace ShopApp.DAL.Entities
{
    public class Categories : BaseEntity
    {
        [Key]
        public int categoryid { get; set; }
        public string categoryname { get; set; }
        public string description { get; set; }

        
    }
}





