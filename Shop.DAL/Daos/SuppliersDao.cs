

using ShopApp.DAL.Context;
using ShopApp.DAL.Interfaces;
using ShopApp.DAL.Models.Suppliers;

namespace ShopApp.DAL.Daos
{
    public class SuppliersDao : ISuppliersDb
    {
        private readonly ShopAppContext context;

        public SuppliersDao(ShopAppContext context)
        {
            this.context = context;
        }
        public SuppliersModel GetSuppliersById(int shippersid)
        {
            throw new NotImplementedException();
        }

        public List<SuppliersModel> GetSuppliers()
        {
            throw new NotImplementedException();
        }
        public void RemoveShippers(SuplliersRemoveModel shippersRemove)
        {
            throw new NotImplementedException();
        }

        public void SaveSuppliers(SuplliersAddModel shippersAdd)
        {
            throw new NotImplementedException();
        }

        public void UpdateShippers(SuplliersUpdateModel shippersUpdate)
        {
            throw new NotImplementedException();
        }
    }
}