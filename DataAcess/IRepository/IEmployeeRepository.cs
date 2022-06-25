using BusinessObject.Models;
using System.Collections.Generic;

namespace DataAcess.IRepository
{
    public interface IEmployeeRepository
    {
        public IEnumerable<Employee> GetEmployeeList();
        public Employee GetEmployeeById(string id);
        public void AddEmployee(Employee _Employee);
        public void UpdateEmployee(Employee _Employee);
        public void RemoveEmployee(Employee _Employee);
        public IEnumerable<Employee> SearchEmployeeByDepartmentName(string searchStr);
    }
}
