
using ShopApp.DAL.Context;
using ShopApp.DAL.Interfaces;
using ShopApp.DAL.Models.Product;

namespace ShopApp.DAL.Daos
{
    public class ProductsDao : IProductsDb
    {
        private readonly ShopAppContext context;

        public ProductsDao(ShopAppContext context)
        {
            this.context = context;
        }
        public ProductModel GetProductById(int productid)
        {
            throw new NotImplementedException();
        }
        public List<ProductModel> GetProduct()
        {
            throw new NotImplementedException();
        }
        public void RemoveProduct(ProductRemoveModel productRemove)
        {
            throw new NotImplementedException();
        }

        public void SaveProduct(ProductAddtModel productAdd)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(ProductUpdateModel productUpdate)
        {
            throw new NotImplementedException();
        }
    }
}