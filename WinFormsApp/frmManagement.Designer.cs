namespace WinFormsApp
{
    partial class frmManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btn_Management_AddEmp = new System.Windows.Forms.Button();
            this.DGV_Management_Emp = new System.Windows.Forms.DataGridView();
            this.EmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yoB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DptName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobTitleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tB_Management_DptSearch = new System.Windows.Forms.TextBox();
            this.label_Management_Search = new System.Windows.Forms.Label();
            this.btn_Management_Update = new System.Windows.Forms.Button();
            this.btn_Management_Delete = new System.Windows.Forms.Button();
            this.label_Management_Title = new System.Windows.Forms.Label();
            this.tB_Management_EmpName = new System.Windows.Forms.TextBox();
            this.tB_Management_DptName = new System.Windows.Forms.TextBox();
            this.cB_Manament_JobTitle = new System.Windows.Forms.ComboBox();
            this.label_Management_YoB = new System.Windows.Forms.Label();
            this.label_Management_JobTitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_Management_ = new System.Windows.Forms.Label();
            this.mTB_Management_YoB = new System.Windows.Forms.MaskedTextBox();
            this.tB_Manament_Id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Management_Emp)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Management_AddEmp
            // 
            this.btn_Management_AddEmp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Management_AddEmp.Location = new System.Drawing.Point(1005, 161);
            this.btn_Management_AddEmp.Name = "btn_Management_AddEmp";
            this.btn_Management_AddEmp.Size = new System.Drawing.Size(123, 70);
            this.btn_Management_AddEmp.TabIndex = 0;
            this.btn_Management_AddEmp.Text = "Add a new Employee";
            this.btn_Management_AddEmp.UseVisualStyleBackColor = true;
            this.btn_Management_AddEmp.Click += new System.EventHandler(this.btn_Management_AddEmp_Click);
            // 
            // DGV_Management_Emp
            // 
            this.DGV_Management_Emp.AllowUserToAddRows = false;
            this.DGV_Management_Emp.AllowUserToDeleteRows = false;
            this.DGV_Management_Emp.AllowUserToOrderColumns = true;
            this.DGV_Management_Emp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Management_Emp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeId,
            this.empName,
            this.yoB,
            this.DptName,
            this.JobTitleId});
            this.DGV_Management_Emp.Location = new System.Drawing.Point(12, 285);
            this.DGV_Management_Emp.MultiSelect = false;
            this.DGV_Management_Emp.Name = "DGV_Management_Emp";
            this.DGV_Management_Emp.ReadOnly = true;
            this.DGV_Management_Emp.RowHeadersWidth = 62;
            this.DGV_Management_Emp.RowTemplate.Height = 33;
            this.DGV_Management_Emp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Management_Emp.Size = new System.Drawing.Size(1116, 354);
            this.DGV_Management_Emp.TabIndex = 1;
            this.DGV_Management_Emp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Management_Emp_CellClick);
            // 
            // EmployeeId
            // 
            this.EmployeeId.HeaderText = "Id";
            this.EmployeeId.MinimumWidth = 8;
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.ReadOnly = true;
            this.EmployeeId.Width = 150;
            // 
            // empName
            // 
            this.empName.HeaderText = "Name";
            this.empName.MinimumWidth = 8;
            this.empName.Name = "empName";
            this.empName.ReadOnly = true;
            this.empName.Width = 250;
            // 
            // yoB
            // 
            this.yoB.HeaderText = "Year of Birth";
            this.yoB.MinimumWidth = 8;
            this.yoB.Name = "yoB";
            this.yoB.ReadOnly = true;
            this.yoB.Width = 150;
            // 
            // DptName
            // 
            this.DptName.HeaderText = "Department Name";
            this.DptName.MinimumWidth = 8;
            this.DptName.Name = "DptName";
            this.DptName.ReadOnly = true;
            this.DptName.Width = 250;
            // 
            // JobTitleId
            // 
            this.JobTitleId.HeaderText = "JobTitle";
            this.JobTitleId.MinimumWidth = 8;
            this.JobTitleId.Name = "JobTitleId";
            this.JobTitleId.ReadOnly = true;
            this.JobTitleId.Width = 250;
            // 
            // tB_Management_DptSearch
            // 
            this.tB_Management_DptSearch.Location = new System.Drawing.Point(550, 248);
            this.tB_Management_DptSearch.Name = "tB_Management_DptSearch";
            this.tB_Management_DptSearch.Size = new System.Drawing.Size(169, 31);
            this.tB_Management_DptSearch.TabIndex = 2;
            this.tB_Management_DptSearch.TextChanged += new System.EventHandler(this.tB_Management_DptSearch_TextChanged);
            // 
            // label_Management_Search
            // 
            this.label_Management_Search.AutoSize = true;
            this.label_Management_Search.Location = new System.Drawing.Point(738, 251);
            this.label_Management_Search.Name = "label_Management_Search";
            this.label_Management_Search.Size = new System.Drawing.Size(240, 25);
            this.label_Management_Search.TabIndex = 3;
            this.label_Management_Search.Text = "Search By Department Name";
            // 
            // btn_Management_Update
            // 
            this.btn_Management_Update.Enabled = false;
            this.btn_Management_Update.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Management_Update.Location = new System.Drawing.Point(1005, 85);
            this.btn_Management_Update.Name = "btn_Management_Update";
            this.btn_Management_Update.Size = new System.Drawing.Size(123, 70);
            this.btn_Management_Update.TabIndex = 4;
            this.btn_Management_Update.Text = "Update Employee";
            this.btn_Management_Update.UseVisualStyleBackColor = true;
            this.btn_Management_Update.Click += new System.EventHandler(this.btn_Management_Update_Click);
            // 
            // btn_Management_Delete
            // 
            this.btn_Management_Delete.Enabled = false;
            this.btn_Management_Delete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Management_Delete.Location = new System.Drawing.Point(1006, 9);
            this.btn_Management_Delete.Name = "btn_Management_Delete";
            this.btn_Management_Delete.Size = new System.Drawing.Size(122, 70);
            this.btn_Management_Delete.TabIndex = 5;
            this.btn_Management_Delete.Text = "Delete Employee";
            this.btn_Management_Delete.UseVisualStyleBackColor = true;
            this.btn_Management_Delete.Click += new System.EventHandler(this.btn_Management_Delete_Click);
            // 
            // label_Management_Title
            // 
            this.label_Management_Title.AutoSize = true;
            this.label_Management_Title.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Management_Title.Location = new System.Drawing.Point(184, 9);
            this.label_Management_Title.Name = "label_Management_Title";
            this.label_Management_Title.Size = new System.Drawing.Size(91, 25);
            this.label_Management_Title.TabIndex = 6;
            this.label_Management_Title.Text = "Welcome";
            // 
            // tB_Management_EmpName
            // 
            this.tB_Management_EmpName.Location = new System.Drawing.Point(231, 150);
            this.tB_Management_EmpName.Name = "tB_Management_EmpName";
            this.tB_Management_EmpName.Size = new System.Drawing.Size(150, 31);
            this.tB_Management_EmpName.TabIndex = 7;
            // 
            // tB_Management_DptName
            // 
            this.tB_Management_DptName.Location = new System.Drawing.Point(231, 200);
            this.tB_Management_DptName.Name = "tB_Management_DptName";
            this.tB_Management_DptName.Size = new System.Drawing.Size(150, 31);
            this.tB_Management_DptName.TabIndex = 9;
            // 
            // cB_Manament_JobTitle
            // 
            this.cB_Manament_JobTitle.FormattingEnabled = true;
            this.cB_Manament_JobTitle.Location = new System.Drawing.Point(691, 198);
            this.cB_Manament_JobTitle.Name = "cB_Manament_JobTitle";
            this.cB_Manament_JobTitle.Size = new System.Drawing.Size(182, 33);
            this.cB_Manament_JobTitle.TabIndex = 10;
            // 
            // label_Management_YoB
            // 
            this.label_Management_YoB.AutoSize = true;
            this.label_Management_YoB.Location = new System.Drawing.Point(565, 150);
            this.label_Management_YoB.Name = "label_Management_YoB";
            this.label_Management_YoB.Size = new System.Drawing.Size(111, 25);
            this.label_Management_YoB.TabIndex = 11;
            this.label_Management_YoB.Text = "Year of Birth:";
            // 
            // label_Management_JobTitle
            // 
            this.label_Management_JobTitle.AutoSize = true;
            this.label_Management_JobTitle.Location = new System.Drawing.Point(565, 198);
            this.label_Management_JobTitle.Name = "label_Management_JobTitle";
            this.label_Management_JobTitle.Size = new System.Drawing.Size(76, 25);
            this.label_Management_JobTitle.TabIndex = 12;
            this.label_Management_JobTitle.Text = "JobTitle:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Department Name:";
            // 
            // label_Management_
            // 
            this.label_Management_.AutoSize = true;
            this.label_Management_.Location = new System.Drawing.Point(101, 150);
            this.label_Management_.Name = "label_Management_";
            this.label_Management_.Size = new System.Drawing.Size(63, 25);
            this.label_Management_.TabIndex = 14;
            this.label_Management_.Text = "Name:";
            // 
            // mTB_Management_YoB
            // 
            this.mTB_Management_YoB.Location = new System.Drawing.Point(691, 147);
            this.mTB_Management_YoB.Mask = "0000";
            this.mTB_Management_YoB.Name = "mTB_Management_YoB";
            this.mTB_Management_YoB.Size = new System.Drawing.Size(182, 31);
            this.mTB_Management_YoB.TabIndex = 15;
            this.mTB_Management_YoB.ValidatingType = typeof(int);
            // 
            // tB_Manament_Id
            // 
            this.tB_Manament_Id.Location = new System.Drawing.Point(231, 105);
            this.tB_Manament_Id.Name = "tB_Manament_Id";
            this.tB_Manament_Id.Size = new System.Drawing.Size(150, 31);
            this.tB_Manament_Id.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Id:";
            // 
            // frmManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 650);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tB_Manament_Id);
            this.Controls.Add(this.mTB_Management_YoB);
            this.Controls.Add(this.label_Management_);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_Management_JobTitle);
            this.Controls.Add(this.label_Management_YoB);
            this.Controls.Add(this.cB_Manament_JobTitle);
            this.Controls.Add(this.tB_Management_DptName);
            this.Controls.Add(this.tB_Management_EmpName);
            this.Controls.Add(this.label_Management_Title);
            this.Controls.Add(this.btn_Management_Delete);
            this.Controls.Add(this.btn_Management_Update);
            this.Controls.Add(this.label_Management_Search);
            this.Controls.Add(this.tB_Management_DptSearch);
            this.Controls.Add(this.DGV_Management_Emp);
            this.Controls.Add(this.btn_Management_AddEmp);
            this.Name = "frmManagement";
            this.Text = "frmManagement";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Management_Emp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Management_AddEmp;
        private System.Windows.Forms.DataGridView DGV_Management_Emp;
        private System.Windows.Forms.TextBox tB_Management_DptSearch;
        private System.Windows.Forms.Label label_Management_Search;
        private System.Windows.Forms.Button btn_Management_Update;
        private System.Windows.Forms.Button btn_Management_Delete;
        private System.Windows.Forms.Label label_Management_Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn empName;
        private System.Windows.Forms.DataGridViewTextBoxColumn yoB;
        private System.Windows.Forms.DataGridViewTextBoxColumn DptName;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobTitleId;
        private System.Windows.Forms.TextBox tB_Management_EmpName;
        private System.Windows.Forms.TextBox tB_Management_DptName;
        private System.Windows.Forms.ComboBox cB_Manament_JobTitle;
        private System.Windows.Forms.Label label_Management_YoB;
        private System.Windows.Forms.Label label_Management_JobTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_Management_;
        private System.Windows.Forms.MaskedTextBox mTB_Management_YoB;
        private System.Windows.Forms.TextBox tB_Manament_Id;
        private System.Windows.Forms.Label label1;
    }
}