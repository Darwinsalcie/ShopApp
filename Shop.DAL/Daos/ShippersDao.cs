

using ShopApp.DAL.Context;
using ShopApp.DAL.Interfaces;
using ShopApp.DAL.Models.Shippers;

namespace ShopApp.DAL.Daos
{
    public class ShippersDao : IShippersDb
    {
        private readonly ShopAppContext context;

        public ShippersDao(ShopAppContext context)
        {
            this.context = context;
        }

        public ShippersModel GetShippersById(int shippersid)
        {
            throw new NotImplementedException();
        }
        public List<ShippersModel> GetShippers()
        {
            throw new NotImplementedException();
        }
        public void RemoveShippers(ShippersRemoveModel shippersRemove)
        {
            throw new NotImplementedException();
        }

        public void SaveShippers(ShippersAddModel shippersAdd)
        {
            throw new NotImplementedException();
        }

        public void UpdateShippers(ShippersUpdateModel shippersUpdate)
        {
            throw new NotImplementedException();
        }
    }
}