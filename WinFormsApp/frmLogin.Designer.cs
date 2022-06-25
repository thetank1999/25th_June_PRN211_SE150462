namespace WinFormsApp
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label_Login_Title = new System.Windows.Forms.Label();
            this.label_Login_IdEmail = new System.Windows.Forms.Label();
            this.label_Login_Password = new System.Windows.Forms.Label();
            this.tB_Login_IdEmail = new System.Windows.Forms.TextBox();
            this.tB_Login_Password = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Login_Title
            // 
            this.label_Login_Title.AutoSize = true;
            this.label_Login_Title.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Login_Title.Location = new System.Drawing.Point(295, 9);
            this.label_Login_Title.Name = "label_Login_Title";
            this.label_Login_Title.Size = new System.Drawing.Size(192, 36);
            this.label_Login_Title.TabIndex = 0;
            this.label_Login_Title.Text = "Welcome Back";
            // 
            // label_Login_IdEmail
            // 
            this.label_Login_IdEmail.AutoSize = true;
            this.label_Login_IdEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Login_IdEmail.Location = new System.Drawing.Point(202, 132);
            this.label_Login_IdEmail.Name = "label_Login_IdEmail";
            this.label_Login_IdEmail.Size = new System.Drawing.Size(116, 25);
            this.label_Login_IdEmail.TabIndex = 1;
            this.label_Login_IdEmail.Text = "Id Or Email: ";
            // 
            // label_Login_Password
            // 
            this.label_Login_Password.AutoSize = true;
            this.label_Login_Password.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Login_Password.Location = new System.Drawing.Point(202, 189);
            this.label_Login_Password.Name = "label_Login_Password";
            this.label_Login_Password.Size = new System.Drawing.Size(102, 25);
            this.label_Login_Password.TabIndex = 2;
            this.label_Login_Password.Text = "Password: ";
            // 
            // tB_Login_IdEmail
            // 
            this.tB_Login_IdEmail.Location = new System.Drawing.Point(354, 126);
            this.tB_Login_IdEmail.Name = "tB_Login_IdEmail";
            this.tB_Login_IdEmail.Size = new System.Drawing.Size(250, 31);
            this.tB_Login_IdEmail.TabIndex = 3;
            // 
            // tB_Login_Password
            // 
            this.tB_Login_Password.Location = new System.Drawing.Point(354, 199);
            this.tB_Login_Password.Name = "tB_Login_Password";
            this.tB_Login_Password.PasswordChar = '*';
            this.tB_Login_Password.Size = new System.Drawing.Size(250, 31);
            this.tB_Login_Password.TabIndex = 4;
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Login.Location = new System.Drawing.Point(312, 294);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(112, 34);
            this.btn_Login.TabIndex = 5;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 419);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.tB_Login_Password);
            this.Controls.Add(this.tB_Login_IdEmail);
            this.Controls.Add(this.label_Login_Password);
            this.Controls.Add(this.label_Login_IdEmail);
            this.Controls.Add(this.label_Login_Title);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Login_Title;
        private System.Windows.Forms.Label label_Login_IdEmail;
        private System.Windows.Forms.Label label_Login_Password;
        private System.Windows.Forms.TextBox tB_Login_IdEmail;
        private System.Windows.Forms.TextBox tB_Login_Password;
        private System.Windows.Forms.Button btn_Login;
    }
}
