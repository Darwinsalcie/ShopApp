
using ShopApp.DAL.Context;
using ShopApp.DAL.Interfaces;
using ShopApp.DAL.Models.Categories;

namespace ShopApp.DAL.Daos
{
    public class CategoryDao : ICategoriesDb
    {
        private readonly ShopAppContext context;

        public CategoryDao(ShopAppContext context)
        {
            this.context = context;
        }
        public CategoriesModel GetCategoriesById(int categoryid)
        {
            throw new NotImplementedException();
        }
        public List<CategoriesModel> GetCategories()
        {
            throw new NotImplementedException();
        }

 

        public void RemoveCategory(CategoriesRemoveModel categoryRemove)
        {
            throw new NotImplementedException();
        }

        public void SaveCategory(CategoriesAddModel categoryAdd)
        {
            throw new NotImplementedException();
        }

        public void UpdateCategory(CategoriesUpdateModel categoryUpdate)
        {
            throw new NotImplementedException();
        }
    }
}