

using ShopApp.DAL.Models.Shippers;

namespace ShopApp.DAL.Interfaces
{
    public interface IShippersDb
    {
        ShippersModel GetShippersById(int shippersid);
        List<ShippersModel> GetShippers();


        void SaveShippers(ShippersAddModel shippersAdd);
        void UpdateShippers(ShippersUpdateModel shippersUpdate);
        void RemoveShippers(ShippersRemoveModel shippersRemove);

    }
}
