

using ShopApp.DAL.Context;
using ShopApp.DAL.Interfaces;
using ShopApp.DAL.Models.Employees;

namespace ShopApp.DAL.Daos
{
    public class EmployeesDao : IEmployeesDb
    {
        private readonly ShopAppContext context;

        public EmployeesDao(ShopAppContext context)
        {
            this.context = context;
        }

        public EmployeesModel GetEmployeesById(int employeeid)
        {
            throw new NotImplementedException();
        }
        public List<EmployeesModel> GetEmployees()
        {
            throw new NotImplementedException();
        }


        public void RemoveEmployees(EmployeesRemoveModel employeeRemove)
        {
            throw new NotImplementedException();
        }

        public void SaveEmployees(EmployeesAddModel employeeAdd)
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployees(EmployeesUpdateModel employeeUpdate)
        {
            throw new NotImplementedException();
        }
    }
}