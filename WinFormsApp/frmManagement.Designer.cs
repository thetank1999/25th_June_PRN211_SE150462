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
            this.empName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yoB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DptName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobTitleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tB_Management_DptSearch = new System.Windows.Forms.TextBox();
            this.label_Management_Search = new System.Windows.Forms.Label();
            this.btn_Management_Update = new System.Windows.Forms.Button();
            this.btn_Management_Delete = new System.Windows.Forms.Button();
            this.label_Management_Title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Management_Emp)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Management_AddEmp
            // 
            this.btn_Management_AddEmp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Management_AddEmp.Location = new System.Drawing.Point(856, 164);
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
            this.DGV_Management_Emp.Size = new System.Drawing.Size(967, 354);
            this.DGV_Management_Emp.TabIndex = 1;
            this.DGV_Management_Emp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Management_Emp_CellClick);
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
            this.btn_Management_Update.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Management_Update.Location = new System.Drawing.Point(856, 88);
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
            this.btn_Management_Delete.Location = new System.Drawing.Point(856, 12);
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
            this.label_Management_Title.Location = new System.Drawing.Point(164, 33);
            this.label_Management_Title.Name = "label_Management_Title";
            this.label_Management_Title.Size = new System.Drawing.Size(91, 25);
            this.label_Management_Title.TabIndex = 6;
            this.label_Management_Title.Text = "Welcome";
            // 
            // frmManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 650);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn empName;
        private System.Windows.Forms.DataGridViewTextBoxColumn yoB;
        private System.Windows.Forms.DataGridViewTextBoxColumn DptName;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobTitleId;
        private System.Windows.Forms.TextBox tB_Management_DptSearch;
        private System.Windows.Forms.Label label_Management_Search;
        private System.Windows.Forms.Button btn_Management_Update;
        private System.Windows.Forms.Button btn_Management_Delete;
        private System.Windows.Forms.Label label_Management_Title;
    }
}