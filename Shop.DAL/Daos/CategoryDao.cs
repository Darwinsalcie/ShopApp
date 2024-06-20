
using ShopApp.DAL.Context;
using ShopApp.DAL.Entities;
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

            var category = this.context.Categories.Find(categoryid);

            CategoriesModel model = new CategoriesModel()
            {
                categoryid = category.categoryid,
                categoryName = category.categoryname,
                description = category.description

            };


            return model;
        }
        public List<CategoriesModel> GetCategories()
        {
            return context.Categories
                          .Where(cat => !cat.deleted)
                          .Select(cat => new CategoriesModel
                          {
                              categoryid = cat.categoryid,
                              categoryName = cat.categoryname,
                              description = cat.description
                          }).ToList();
        }

        public void RemoveCategory(CategoriesRemoveModel categoryRemove)
        {

            Categories categoryToDelete = this.context.Categories.Find(categoryRemove.categoryid);


            categoryToDelete.deleted = categoryRemove.Deleted;
            categoryToDelete.delete_date = categoryRemove.DeleteDate;
            categoryToDelete.delete_user = categoryRemove.DeleteUser;

            this.context.Categories.Update(categoryToDelete);
            this.context.SaveChanges();

        }

        public void SaveCategory(CategoriesAddModel categorySave)
        {
            ArgumentNullException.ThrowIfNull(categorySave, nameof(categorySave));

            Categories category = new()
            {
                categoryname = categorySave.categoryName,
                description = categorySave.description,
                creation_date = categorySave.creation_date,
                creation_user = categorySave.creation_user
            };

            this.context.Categories.Add(category);
            this.context.SaveChanges();
        }

        public void UpdateCategory(CategoriesUpdateModel updateModel)
        {
            Categories CategoryToUpdate = this.context.Categories.Find(updateModel.categoryid);

            CategoryToUpdate.categoryname = updateModel.categoryName;
            CategoryToUpdate.description = updateModel.description;
            CategoryToUpdate.modify_date = updateModel.ModifyDate;
            CategoryToUpdate.modify_user = updateModel.ModifyUser;

            this.context.Categories.Update(CategoryToUpdate);
            this.context.SaveChanges();
        }
    }
}