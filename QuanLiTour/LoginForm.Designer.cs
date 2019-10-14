namespace QuanLiTour
{
    partial class LoginForm
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
            this.btn_DangNhap = new DevComponents.DotNetBar.ButtonX();
            this.btn_Huy = new DevComponents.DotNetBar.ButtonX();
            this.lbl_TenDangNhap = new DevComponents.DotNetBar.LabelX();
            this.lbl_MatKhau = new DevComponents.DotNetBar.LabelX();
            this.chiNhapSo1 = new ThietKeControls.ChiNhapSo();
            this.SuspendLayout();
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_DangNhap.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_DangNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_DangNhap.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btn_DangNhap.Font = new System.Drawing.Font("Times New Roman", 7.8F);
            this.btn_DangNhap.Location = new System.Drawing.Point(160, 230);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(172, 45);
            this.btn_DangNhap.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_DangNhap.TabIndex = 0;
            this.btn_DangNhap.Text = "Đăng nhập";
            this.btn_DangNhap.TextColor = System.Drawing.Color.White;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // btn_Huy
            // 
            this.btn_Huy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Huy.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Huy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Huy.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btn_Huy.Font = new System.Drawing.Font("Times New Roman", 7.8F);
            this.btn_Huy.Location = new System.Drawing.Point(380, 230);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(172, 45);
            this.btn_Huy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Huy.TabIndex = 1;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.TextColor = System.Drawing.Color.White;
            // 
            // lbl_TenDangNhap
            // 
            // 
            // 
            // 
            this.lbl_TenDangNhap.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_TenDangNhap.Location = new System.Drawing.Point(160, 93);
            this.lbl_TenDangNhap.Name = "lbl_TenDangNhap";
            this.lbl_TenDangNhap.Size = new System.Drawing.Size(75, 23);
            this.lbl_TenDangNhap.TabIndex = 2;
            this.lbl_TenDangNhap.Text = "labelX1";
            // 
            // lbl_MatKhau
            // 
            // 
            // 
            // 
            this.lbl_MatKhau.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_MatKhau.Location = new System.Drawing.Point(160, 156);
            this.lbl_MatKhau.Name = "lbl_MatKhau";
            this.lbl_MatKhau.Size = new System.Drawing.Size(75, 23);
            this.lbl_MatKhau.TabIndex = 3;
            this.lbl_MatKhau.Text = "labelX2";
            // 
            // chiNhapSo1
            // 
            this.chiNhapSo1.Location = new System.Drawing.Point(299, 93);
            this.chiNhapSo1.Name = "chiNhapSo1";
            this.chiNhapSo1.Size = new System.Drawing.Size(234, 23);
            this.chiNhapSo1.TabIndex = 4;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 318);
            this.Controls.Add(this.chiNhapSo1);
            this.Controls.Add(this.lbl_MatKhau);
            this.Controls.Add(this.lbl_TenDangNhap);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_DangNhap);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btn_DangNhap;
        private DevComponents.DotNetBar.ButtonX btn_Huy;
        private DevComponents.DotNetBar.LabelX lbl_TenDangNhap;
        private DevComponents.DotNetBar.LabelX lbl_MatKhau;
        private ThietKeControls.ChiNhapSo chiNhapSo1;


    }
}