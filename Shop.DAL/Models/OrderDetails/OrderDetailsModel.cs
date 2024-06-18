

namespace ShopApp.DAL.Models.OrderDetails
{
    public class OrderDetailsModel
    {
        public int orderid { get; set; }
        public int productid { get; set; }
        public decimal unitprice { get; set; }
        public short qty { get; set; }
   
    }
}
