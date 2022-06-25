using BusinessObject.Models;
using DataAcess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class frmManagement : Form
    {   
        EmployeeRepository _employeeRepository = new EmployeeRepository();
        IEnumerable<Employee> _employeeList;
        JobTitleRepository _jobTitleRepository= new JobTitleRepository();

        public frmManagement() {
            InitializeComponent();
        }

        public frmManagement(Dbaccount dbAccount) {
            InitializeComponent();
            if (dbAccount.AccountRole == 1 || dbAccount.AccountRole == 2) {
                if (dbAccount.AccountRole == 1) {
                    label_Management_Title.Text = $"Welcom Back, Admin {dbAccount.FullName}" ;
                } else {
                    label_Management_Title.Text = $"Welcom Back, Manager {dbAccount.FullName}";
                }
                
                _employeeList = _employeeRepository.GetEmployeeList();
                this.LoadDataIntoDGV(_employeeList);
            } else {
                label_Management_Title.Text = $"Sorry but you don't have the permission to access these informations.";
            }
            
            
        }

        #region [Load Data]
        private void LoadDataIntoDGV(IEnumerable<Employee> _employeeList) {
            DGV_Management_Emp.Rows.Clear();
            foreach (var emp in _employeeList ) {
                DGV_Management_Emp.Rows.Add(emp.EmployeeName, emp.YearOfBirth, emp.DepartmentName, _jobTitleRepository.GetJobTitleById(emp.JobTitleId).JobTitleName);
            }
        }
        #endregion

        private void tB_Management_DptSearch_TextChanged(object sender, EventArgs e) {
            var searchStr = tB_Management_DptSearch.Text;
            _employeeList = _employeeRepository.SearchEmployeeByDepartmentName(searchStr);
            this.LoadDataIntoDGV(_employeeList);
        }

        private void btn_Management_AddEmp_Click(object sender, EventArgs e) {
            frmMember frmMember = new frmMember("add");
            frmMember.Show();
        }

        private void btn_Management_Update_Click(object sender, EventArgs e) {
            frmMember frmMember = new frmMember("update");
            frmMember.Show();
        }

        private void btn_Management_Delete_Click(object sender, EventArgs e) {
            DialogResult _dialogResult;
            _dialogResult = MessageBox.Show("Do you really want to delete chosen Member?", "Management", (MessageBoxButtons)MessageBoxDefaultButton.Button1);
            if (_dialogResult == DialogResult.OK) {

            }
        }

        private void DGV_Management_Emp_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (DGV_Management_Emp.SelectedRows.Count == 1) {
                btn_Management_Delete.Enabled = true;
            } else {
                btn_Management_Delete.Enabled = false;
            }
        }
    }
}
