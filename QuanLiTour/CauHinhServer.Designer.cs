namespace QuanLiTour
{
    partial class CauHinhServer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Thoat = new DevComponents.DotNetBar.ButtonX();
            this.btn_DangNhapServer = new DevComponents.DotNetBar.ButtonX();
            this.cbo_TenData = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbo_TenServer = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txt_Password = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_TenDangNhap = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbl_TenDangNhap = new DevComponents.DotNetBar.LabelX();
            this.lbl_MatKhau = new DevComponents.DotNetBar.LabelX();
            this.lbl_TenData = new DevComponents.DotNetBar.LabelX();
            this.lbl_TenServer = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Thoat.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Thoat.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btn_Thoat.Location = new System.Drawing.Point(342, 279);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(92, 40);
            this.btn_Thoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Thoat.TabIndex = 19;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.TextColor = System.Drawing.Color.White;
            // 
            // btn_DangNhapServer
            // 
            this.btn_DangNhapServer.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_DangNhapServer.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_DangNhapServer.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btn_DangNhapServer.Location = new System.Drawing.Point(110, 279);
            this.btn_DangNhapServer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_DangNhapServer.Name = "btn_DangNhapServer";
            this.btn_DangNhapServer.Size = new System.Drawing.Size(184, 40);
            this.btn_DangNhapServer.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_DangNhapServer.TabIndex = 18;
            this.btn_DangNhapServer.Text = "Đăng nhập";
            this.btn_DangNhapServer.TextColor = System.Drawing.Color.White;
            this.btn_DangNhapServer.Click += new System.EventHandler(this.btn_DangNhapServer_Click);
            // 
            // cbo_TenData
            // 
            this.cbo_TenData.DisplayMember = "Text";
            this.cbo_TenData.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_TenData.FormattingEnabled = true;
            this.cbo_TenData.ItemHeight = 16;
            this.cbo_TenData.Location = new System.Drawing.Point(231, 216);
            this.cbo_TenData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbo_TenData.Name = "cbo_TenData";
            this.cbo_TenData.Size = new System.Drawing.Size(204, 22);
            this.cbo_TenData.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_TenData.TabIndex = 17;
            // 
            // cbo_TenServer
            // 
            this.cbo_TenServer.DisplayMember = "Text";
            this.cbo_TenServer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_TenServer.FormattingEnabled = true;
            this.cbo_TenServer.ItemHeight = 16;
            this.cbo_TenServer.Location = new System.Drawing.Point(231, 65);
            this.cbo_TenServer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbo_TenServer.Name = "cbo_TenServer";
            this.cbo_TenServer.Size = new System.Drawing.Size(204, 22);
            this.cbo_TenServer.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_TenServer.TabIndex = 16;
            this.cbo_TenServer.DropDown += new System.EventHandler(this.cbo_TenServer_DropDown);
            this.cbo_TenServer.SelectedIndexChanged += new System.EventHandler(this.cbo_TenServer_SelectedIndexChanged);
            // 
            // txt_Password
            // 
            // 
            // 
            // 
            this.txt_Password.Border.Class = "TextBoxBorder";
            this.txt_Password.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Password.Location = new System.Drawing.Point(231, 162);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PreventEnterBeep = true;
            this.txt_Password.Size = new System.Drawing.Size(203, 20);
            this.txt_Password.TabIndex = 15;
            // 
            // txt_TenDangNhap
            // 
            // 
            // 
            // 
            this.txt_TenDangNhap.Border.Class = "TextBoxBorder";
            this.txt_TenDangNhap.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_TenDangNhap.Location = new System.Drawing.Point(231, 113);
            this.txt_TenDangNhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_TenDangNhap.Name = "txt_TenDangNhap";
            this.txt_TenDangNhap.PreventEnterBeep = true;
            this.txt_TenDangNhap.Size = new System.Drawing.Size(203, 20);
            this.txt_TenDangNhap.TabIndex = 14;
            // 
            // lbl_TenDangNhap
            // 
            // 
            // 
            // 
            this.lbl_TenDangNhap.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_TenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenDangNhap.Location = new System.Drawing.Point(110, 113);
            this.lbl_TenDangNhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbl_TenDangNhap.Name = "lbl_TenDangNhap";
            this.lbl_TenDangNhap.Size = new System.Drawing.Size(92, 19);
            this.lbl_TenDangNhap.TabIndex = 13;
            this.lbl_TenDangNhap.Text = "Tên đăng nhập";
            // 
            // lbl_MatKhau
            // 
            // 
            // 
            // 
            this.lbl_MatKhau.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_MatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MatKhau.Location = new System.Drawing.Point(110, 160);
            this.lbl_MatKhau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbl_MatKhau.Name = "lbl_MatKhau";
            this.lbl_MatKhau.Size = new System.Drawing.Size(92, 19);
            this.lbl_MatKhau.TabIndex = 12;
            this.lbl_MatKhau.Text = "Mật khẩu";
            // 
            // lbl_TenData
            // 
            // 
            // 
            // 
            this.lbl_TenData.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_TenData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenData.Location = new System.Drawing.Point(110, 215);
            this.lbl_TenData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbl_TenData.Name = "lbl_TenData";
            this.lbl_TenData.Size = new System.Drawing.Size(92, 19);
            this.lbl_TenData.TabIndex = 11;
            this.lbl_TenData.Text = "Tên data";
            // 
            // lbl_TenServer
            // 
            // 
            // 
            // 
            this.lbl_TenServer.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_TenServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenServer.Location = new System.Drawing.Point(110, 65);
            this.lbl_TenServer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbl_TenServer.Name = "lbl_TenServer";
            this.lbl_TenServer.Size = new System.Drawing.Size(92, 19);
            this.lbl_TenServer.TabIndex = 10;
            this.lbl_TenServer.Text = "Server name";
            // 
            // CauHinhServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_DangNhapServer);
            this.Controls.Add(this.cbo_TenData);
            this.Controls.Add(this.cbo_TenServer);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_TenDangNhap);
            this.Controls.Add(this.lbl_TenDangNhap);
            this.Controls.Add(this.lbl_MatKhau);
            this.Controls.Add(this.lbl_TenData);
            this.Controls.Add(this.lbl_TenServer);
            this.Name = "CauHinhServer";
            this.Size = new System.Drawing.Size(544, 375);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btn_Thoat;
        private DevComponents.DotNetBar.ButtonX btn_DangNhapServer;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_TenData;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_TenServer;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Password;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_TenDangNhap;
        private DevComponents.DotNetBar.LabelX lbl_TenDangNhap;
        private DevComponents.DotNetBar.LabelX lbl_MatKhau;
        private DevComponents.DotNetBar.LabelX lbl_TenData;
        private DevComponents.DotNetBar.LabelX lbl_TenServer;
    }
}
