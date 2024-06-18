

using ShopApp.DAL.Context;
using ShopApp.DAL.Interfaces;
using ShopApp.DAL.Models.Customers;

namespace ShopApp.DAL.Daos
{
    public class CustomersDao : ICustomersDb
    {
        private readonly ShopAppContext context;
        public CustomersDao(ShopAppContext context)
        {
            this.context = context;
        }


        public CustomerModel GetCustomersyId(int customerid)
        {
            throw new NotImplementedException();
        }
        public List<CustomerModel> GetCustomers()
        {
            throw new NotImplementedException();
        }



        public void RemoveCategory(CustomerRemoveModel customerRemove)
        {
            throw new NotImplementedException();
        }

        public void SaveCategory(CustomerAddModel customerAdd)
        {
            throw new NotImplementedException();
        }

        public void UpdateCategory(CustomerUpdateModel customerUpdate)
        {
            throw new NotImplementedException();
        }
    }
}