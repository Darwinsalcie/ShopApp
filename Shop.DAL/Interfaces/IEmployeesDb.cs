


using ShopApp.DAL.Models.Employees;

namespace ShopApp.DAL.Interfaces
{
    public interface IEmployeesDb
    {
        EmployeesModel GetEmployeesById(int employeeid);
        List<EmployeesModel> GetEmployees();


        void SaveEmployees(EmployeesAddModel employeeAdd);
        void UpdateEmployees(EmployeesUpdateModel employeeUpdate);
        void RemoveEmployees(EmployeesRemoveModel employeeRemove);

    }
}
