

using ShopApp.DAL.Models.Customers;

namespace ShopApp.DAL.Interfaces
{
    public interface ICustomersDb
    {
        CustomerModel GetCustomersyId(int customerid);
        List<CustomerModel> GetCustomers();


        void SaveCategory(CustomerAddModel customerAdd);
        void UpdateCategory(CustomerUpdateModel customerUpdate);
        void RemoveCategory(CustomerRemoveModel customerRemove);

    }
}
