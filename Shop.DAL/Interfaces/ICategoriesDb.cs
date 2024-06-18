


using ShopApp.DAL.Models.Categories;

namespace ShopApp.DAL.Interfaces
{
    public interface ICategoriesDb
    {
        CategoriesModel GetCategoriesById(int categoryid);
        List<CategoriesModel> GetCategories();


        void SaveCategory(CategoriesAddModel categoryAdd);
        void UpdateCategory(CategoriesUpdateModel categoryUpdate);
        void RemoveCategory(CategoriesRemoveModel categoryRemove);

    }
}
