using BusinessObject.Models;
using DataAcess.DAO;
using DataAcess.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public void AddEmployee(Employee _Employee) => EmployeeDAO.Instance.AddEmployee(_Employee);

        public Employee GetEmployeeById(string id) => EmployeeDAO.Instance.GetEmployeeById(id);

        public IEnumerable<Employee> GetEmployeeList() => EmployeeDAO.Instance.GetEmployeeList();

        public void RemoveEmployee(Employee _Employee) => EmployeeDAO.Instance.RemoveEmployee(_Employee);

        public IEnumerable<Employee> SearchEmployeeByDepartmentName(string searchStr) => EmployeeDAO.Instance.SearchEmployeeByDepartmentName(searchStr);

        public void UpdateEmployee(Employee _Employee) => EmployeeDAO.Instance.UpdateEmployee(_Employee);
    }
}
