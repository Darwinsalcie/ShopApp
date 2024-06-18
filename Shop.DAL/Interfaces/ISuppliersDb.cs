
using ShopApp.DAL.Models.Suppliers;

namespace ShopApp.DAL.Interfaces
{
    public interface ISuppliersDb
    {
        SuppliersModel GetSuppliersById(int shippersid);
        List<SuppliersModel> GetSuppliers();


        void SaveSuppliers(SuplliersAddModel shippersAdd);
        void UpdateShippers(SuplliersUpdateModel shippersUpdate);
        void RemoveShippers(SuplliersRemoveModel shippersRemove);

    }
}
