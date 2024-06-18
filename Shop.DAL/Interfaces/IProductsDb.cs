


using ShopApp.DAL.Models.Product;

namespace ShopApp.DAL.Interfaces
{
    public interface IProductsDb
    {
        ProductModel GetProductById(int productid);
        List<ProductModel> GetProduct();


        void SaveProduct(ProductAddtModel productAdd);
        void UpdateProduct(ProductUpdateModel productUpdate);
        void RemoveProduct(ProductRemoveModel productRemove);

    }
}
