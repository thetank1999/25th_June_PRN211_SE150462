using BusinessObject.Context;
using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.DAO
{
    public class EmployeeDAO
    {
        #region [ Using Singleton ]
        private static EmployeeDAO instance = null;
        public static readonly object instanceLock = new object();
        public static EmployeeDAO Instance {
            get {
                lock (instanceLock) {
                    if (instance == null) {
                        instance = new EmployeeDAO();
                    }
                    return instance;
                }
            }
        }
        #endregion
        #region [ public methods - CRUD ]
        public IEnumerable<Employee> GetEmployeeList() {
            var EmployeeList = new List<Employee>();
            try {
                using var context = new EmployeeJobTitleContext();
                EmployeeList = context.Employees.ToList();
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
            return EmployeeList;
        }

        public Employee GetEmployeeById(string id) {
            Employee _tempEmployee = null;
            try {
                using var context = new EmployeeJobTitleContext();
                _tempEmployee = context.Employees.FirstOrDefault(x => x.EmployeeId == id);
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
            return _tempEmployee;
        }

        public void AddEmployee(Employee _Employee) {
            try {
                var _tempEmployee = this.GetEmployeeById(_Employee.EmployeeId);
                if (_tempEmployee == null) {
                    using var context = new EmployeeJobTitleContext();
                    //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[User] ON");
                    //context.Database.OpenConnection();
                    context.Employees.Add(_Employee);
                    context.SaveChanges();
                } else {
                    throw new Exception("The Employee Id is already existed.");
                }
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
        }

        public void UpdateEmployee(Employee _Employee) {
            try {
                Employee tempEmployee = this.GetEmployeeById(_Employee.EmployeeId);
                if (tempEmployee != null) {
                    using var context = new EmployeeJobTitleContext();
                    context.Employees.Update(_Employee);
                    context.SaveChanges();

                } else {
                    throw new Exception("The Employee Id is not existed.");

                }
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
        }

        public void RemoveEmployee(Employee _Employee) {
            try {
                Employee _tempEmployee = this.GetEmployeeById(_Employee.EmployeeId);
                if (_tempEmployee != null) {
                    using var context = new EmployeeJobTitleContext();
                    context.Employees.Remove(_tempEmployee);
                    context.SaveChanges();
                } else {
                    throw new Exception("The Employee Id is not existed.");
                }
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
        }
        #endregion

        #region [ Search By Department Name ]
        public IEnumerable<Employee> SearchEmployeeByDepartmentName(string searchStr) {
            var EmployeeList = new List<Employee>();
            try {
                using var context = new EmployeeJobTitleContext();
                EmployeeList = context.Employees.Where(x => x.DepartmentName.Contains(searchStr)).ToList();
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
            return EmployeeList;
        }
        #endregion
    }
}
