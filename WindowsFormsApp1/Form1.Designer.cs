namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.MatKhau = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(120, 101);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(102, 16);
            this.UserName.TabIndex = 3;
            this.UserName.Text = "Tên Đăng Nhập";
            this.UserName.Click += new System.EventHandler(this.UserName_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(235, 96);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(270, 22);
            this.txtUserName.TabIndex = 2;
            // 
            // MatKhau
            // 
            this.MatKhau.AutoSize = true;
            this.MatKhau.Location = new System.Drawing.Point(120, 178);
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.Size = new System.Drawing.Size(62, 16);
            this.MatKhau.TabIndex = 5;
            this.MatKhau.Text = "Mật Khẩu";
            this.MatKhau.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(235, 173);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(270, 22);
            this.txtpassword.TabIndex = 4;
            this.txtpassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(293, 227);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(134, 34);
            this.btnDangNhap.TabIndex = 6;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.MatKhau);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.txtUserName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label MatKhau;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnDangNhap;
    }
}

