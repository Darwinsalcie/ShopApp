namespace ShopApp.DAL.Models.Categories
{
    public class CategoriesRemoveModel : CategoriesModel
    {
        public DateTime? DeleteDate { get; set; }
        public int? DeleteUser { get; set; }
        public bool Deleted { get; set; }
    }
}
