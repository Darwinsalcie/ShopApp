namespace ShopApp.DAL.Models.Categories
{
    public class CategoriesUpdateModel : CategoriesModel
    {
        public DateTime? ModifyDate { get; set; }
        public int? ModifyUser { get; set; }
    }
}
