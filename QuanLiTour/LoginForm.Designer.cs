﻿namespace QuanLiTour
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
            this.lbl_TenDangNhap = new DevComponents.DotNetBar.LabelX();
            this.txt_TenDangNhap = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbl_MatKhau = new DevComponents.DotNetBar.LabelX();
            this.txt_MatKhau = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_DangNhap = new DevComponents.DotNetBar.ButtonX();
            this.btn_Thoat = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // lbl_TenDangNhap
            // 
            // 
            // 
            // 
            this.lbl_TenDangNhap.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_TenDangNhap.ForeColor = System.Drawing.Color.Black;
            this.lbl_TenDangNhap.Location = new System.Drawing.Point(94, 64);
            this.lbl_TenDangNhap.Name = "lbl_TenDangNhap";
            this.lbl_TenDangNhap.Size = new System.Drawing.Size(137, 23);
            this.lbl_TenDangNhap.TabIndex = 1;
            this.lbl_TenDangNhap.Text = "Tên đăng nhập";
            // 
            // txt_TenDangNhap
            // 
            // 
            // 
            // 
            this.txt_TenDangNhap.Border.Class = "TextBoxBorder";
            this.txt_TenDangNhap.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_TenDangNhap.Location = new System.Drawing.Point(253, 66);
            this.txt_TenDangNhap.Multiline = true;
            this.txt_TenDangNhap.Name = "txt_TenDangNhap";
            this.txt_TenDangNhap.PreventEnterBeep = true;
            this.txt_TenDangNhap.Size = new System.Drawing.Size(273, 28);
            this.txt_TenDangNhap.TabIndex = 5;
            // 
            // lbl_MatKhau
            // 
            // 
            // 
            // 
            this.lbl_MatKhau.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_MatKhau.ForeColor = System.Drawing.Color.Black;
            this.lbl_MatKhau.Location = new System.Drawing.Point(94, 129);
            this.lbl_MatKhau.Name = "lbl_MatKhau";
            this.lbl_MatKhau.Size = new System.Drawing.Size(75, 23);
            this.lbl_MatKhau.TabIndex = 6;
            this.lbl_MatKhau.Text = "Mật khẩu";
            // 
            // txt_MatKhau
            // 
            // 
            // 
            // 
            this.txt_MatKhau.Border.Class = "TextBoxBorder";
            this.txt_MatKhau.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_MatKhau.Location = new System.Drawing.Point(253, 131);
            this.txt_MatKhau.Multiline = true;
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.PreventEnterBeep = true;
            this.txt_MatKhau.Size = new System.Drawing.Size(273, 28);
            this.txt_MatKhau.TabIndex = 7;
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_DangNhap.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_DangNhap.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btn_DangNhap.Location = new System.Drawing.Point(94, 238);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(245, 49);
            this.btn_DangNhap.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_DangNhap.TabIndex = 8;
            this.btn_DangNhap.Text = "Đăng nhập";
            this.btn_DangNhap.TextColor = System.Drawing.Color.White;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Thoat.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Thoat.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btn_Thoat.Location = new System.Drawing.Point(403, 238);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(123, 49);
            this.btn_Thoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Thoat.TabIndex = 9;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.TextColor = System.Drawing.Color.White;
            // 
            // LoginForm
            // 
            this.Appearance.ForeColor = System.Drawing.Color.White;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 357);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.txt_MatKhau);
            this.Controls.Add(this.lbl_MatKhau);
            this.Controls.Add(this.txt_TenDangNhap);
            this.Controls.Add(this.lbl_TenDangNhap);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lbl_TenDangNhap;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_TenDangNhap;
        private DevComponents.DotNetBar.LabelX lbl_MatKhau;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_MatKhau;
        private DevComponents.DotNetBar.ButtonX btn_DangNhap;
        private DevComponents.DotNetBar.ButtonX btn_Thoat;








    }
}