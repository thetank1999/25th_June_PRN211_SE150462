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
        IEnumerable<JobTitle> _jobTitleList;
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
                this.DisableInputs();
                this.Auto_LoadDataIntoCB();
                this.Auto_LoadDataIntoDGV();
            } else {
                label_Management_Title.Text = "Sorry but you don't have the permission to access these informations.";
            }
            
            
        }


        #region [ Search ]
        private void tB_Management_DptSearch_TextChanged(object sender, EventArgs e) {
            var searchStr = tB_Management_DptSearch.Text;
            _employeeList = _employeeRepository.SearchEmployeeByDepartmentName(searchStr);
            this.LoadDataIntoDGV(_employeeList);
        }
        #endregion
        #region [ CRUD without R <(") ]
        private void btn_Management_AddEmp_Click(object sender, EventArgs e) {
            if (btn_Management_AddEmp.Text.Contains("Add")) {
                this.ClearInputs();
                this.EnableInputs();
                btn_Management_AddEmp.Text = "Save";
            } else {
                if (tB_Management_EmpName.Text.Equals("")
                    ||tB_Management_DptName.Text.Equals("")
                    ||mTB_Management_YoB.Text.Equals("")
                    ||cB_Manament_JobTitle.SelectedItem.Equals("")
                    ||tB_Manament_Id.Text.Equals("") ){
                    MessageBox.Show("Invalid Input.");
                }else {
                    var tempEmp = new Employee();
                    tempEmp.EmployeeId = tB_Manament_Id.Text;
                    tempEmp.EmployeeName = tB_Management_EmpName.Text;
                    tempEmp.DepartmentName = tB_Management_DptName.Text;
                    tempEmp.YearOfBirth = Int32.Parse(mTB_Management_YoB.Text);
                    var tempJobTitle = (JobTitle) cB_Manament_JobTitle.SelectedItem;
                    tempEmp.JobTitleId = tempJobTitle.JobTitleId;
                    _employeeRepository.AddEmployee(tempEmp);
                    MessageBox.Show("Added Successfully.");

                    btn_Management_AddEmp.Text = "Add a new Employee";
                    this.ClearInputs();
                    this.DisableInputs();
                    this.Auto_LoadDataIntoDGV();
                }
            }
        }
        
        private void btn_Management_Update_Click(object sender, EventArgs e) {
            if (btn_Management_Update.Text.Contains("Update")) {
                btn_Management_Update.Text = "Save";
                this.EnableInputs();
            } else {
                if (tB_Management_EmpName.Text.Equals("")
                    ||tB_Management_DptName.Text.Equals("")
                    ||mTB_Management_YoB.Text.Equals("")
                    ||cB_Manament_JobTitle.SelectedItem.Equals("")) {
                    MessageBox.Show("Invalid Input");
                } else {
                    var stringTemp = DGV_Management_Emp.SelectedRows[0].Cells[0].Value.ToString();
                    var temp = _employeeRepository.GetEmployeeById(stringTemp);
                    temp.EmployeeName = tB_Management_DptName.Text;
                    temp.DepartmentName = tB_Management_DptName.Text;
                    temp.YearOfBirth = Int32.Parse(mTB_Management_YoB.Text);
                    var tempJobTitle = (JobTitle)cB_Manament_JobTitle.SelectedItem;
                    temp.JobTitleId = tempJobTitle.JobTitleId;
                    _employeeRepository.UpdateEmployee(temp);
                    this.ClearInputs();
                    this.DisableInputs();
                    this.Auto_LoadDataIntoDGV();
                    btn_Management_Update.Text = "Update Employee";
                }
            }
        }

        private void btn_Management_Delete_Click(object sender, EventArgs e) {
            DialogResult _dialogResult;
            _dialogResult = MessageBox.Show("Do you really want to delete chosen Member?", "Management", (MessageBoxButtons)MessageBoxDefaultButton.Button1);
            if (_dialogResult == DialogResult.OK) {
                var temp = _employeeRepository.GetEmployeeById(DGV_Management_Emp.SelectedRows[0].Cells[0].Value.ToString());
                _employeeRepository.RemoveEmployee(temp);
                this.Auto_LoadDataIntoDGV();
            }
        }
        #endregion

        #region [ DGV on click event ]
        private void DGV_Management_Emp_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (DGV_Management_Emp.SelectedRows.Count == 1) {
                btn_Management_Delete.Enabled = true;
                btn_Management_Update.Enabled = true;
                this.Auto_LoadDataIntoInputs();
            } else {
                btn_Management_Delete.Enabled = false;
                btn_Management_Update.Enabled = false;
            }
        }

       
        #endregion

        #region [Inputs Functions]
        private void DisableInputs() {
            tB_Manament_Id.Enabled = false;
            tB_Management_DptName.Enabled = false;
            tB_Management_EmpName.Enabled = false;
            mTB_Management_YoB.Enabled = false;
            cB_Manament_JobTitle.Enabled = false;
        }

        private void EnableInputs() {
            tB_Manament_Id.Enabled = true;
            tB_Management_DptName.Enabled = true;
            tB_Management_EmpName.Enabled = true;
            mTB_Management_YoB.Enabled = true;
            cB_Manament_JobTitle.Enabled = true;
        }

        private void ClearInputs() {
            tB_Manament_Id.Clear();
            tB_Management_DptName.Clear();
            tB_Management_EmpName.Clear();
            mTB_Management_YoB.Clear();
            cB_Manament_JobTitle.SelectedIndex = 0;
        }
        #endregion

        #region [Load Data]
        private void Auto_LoadDataIntoDGV() {
            _employeeList = _employeeRepository.GetEmployeeList();
            this.LoadDataIntoDGV(_employeeList);
        }
        private void LoadDataIntoDGV(IEnumerable<Employee> _employeeList) {
            DGV_Management_Emp.Rows.Clear();
            foreach (var emp in _employeeList) {
                DGV_Management_Emp.Rows.Add(emp.EmployeeId, emp.EmployeeName, emp.YearOfBirth, emp.DepartmentName, _jobTitleRepository.GetJobTitleById(emp.JobTitleId).JobTitleName);
            }
        }
        
        private void Auto_LoadDataIntoInputs() {
            var temp = _employeeRepository.GetEmployeeById(DGV_Management_Emp.SelectedRows[0].Cells[0].Value.ToString());
            tB_Manament_Id.Text = temp.EmployeeId;
            tB_Management_EmpName.Text = temp.EmployeeName;
            tB_Management_DptName.Text = temp.DepartmentName;
            mTB_Management_YoB.Text = temp.YearOfBirth.ToString();
            cB_Manament_JobTitle.SelectedValue = _jobTitleRepository.GetJobTitleById(temp.JobTitleId);
        }
        private void Auto_LoadDataIntoCB() {
            _jobTitleList = _jobTitleRepository.GetJobTitleList();
            foreach (var jobTitle in _jobTitleList) {
                cB_Manament_JobTitle.Items.Add(jobTitle);
            }
        }
        #endregion
    }
}
