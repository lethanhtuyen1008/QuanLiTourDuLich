namespace QuanLiTour
{
    partial class MH_PhanQuyen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.qL_NguoiDungNhomNguoiDungTableAdapter1 = new PhanQuyen.QLNguoiDungDTableAdapters.QL_NguoiDungNhomNguoiDungTableAdapter();
            this.tableLayoutPanel_Container = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView_NguoiDung = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.TenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_NHomNguoiDung = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.cbo_NhomNguoiDung = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_ThemUser_Nhom = new DevComponents.DotNetBar.ButtonX();
            this.btn_XoaUser_Nhom = new DevComponents.DotNetBar.ButtonX();
            this.tableLayoutPanel_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NHomNguoiDung)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // qL_NguoiDungNhomNguoiDungTableAdapter1
            // 
            this.qL_NguoiDungNhomNguoiDungTableAdapter1.ClearBeforeFill = true;
            // 
            // tableLayoutPanel_Container
            // 
            this.tableLayoutPanel_Container.ColumnCount = 3;
            this.tableLayoutPanel_Container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.29032F));
            this.tableLayoutPanel_Container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.70968F));
            this.tableLayoutPanel_Container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 422F));
            this.tableLayoutPanel_Container.Controls.Add(this.dataGridView_NguoiDung, 0, 1);
            this.tableLayoutPanel_Container.Controls.Add(this.dataGridView_NHomNguoiDung, 2, 1);
            this.tableLayoutPanel_Container.Controls.Add(this.cbo_NhomNguoiDung, 2, 0);
            this.tableLayoutPanel_Container.Controls.Add(this.tableLayoutPanel1, 1, 1);
            this.tableLayoutPanel_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Container.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Container.Name = "tableLayoutPanel_Container";
            this.tableLayoutPanel_Container.RowCount = 2;
            this.tableLayoutPanel_Container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.67361F));
            this.tableLayoutPanel_Container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.32639F));
            this.tableLayoutPanel_Container.Size = new System.Drawing.Size(955, 393);
            this.tableLayoutPanel_Container.TabIndex = 0;
            // 
            // dataGridView_NguoiDung
            // 
            this.dataGridView_NguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_NguoiDung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenDangNhap,
            this.TinhTrang,
            this.MatKhau});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_NguoiDung.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_NguoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_NguoiDung.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridView_NguoiDung.Location = new System.Drawing.Point(3, 52);
            this.dataGridView_NguoiDung.Name = "dataGridView_NguoiDung";
            this.dataGridView_NguoiDung.RowTemplate.Height = 24;
            this.dataGridView_NguoiDung.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_NguoiDung.Size = new System.Drawing.Size(453, 338);
            this.dataGridView_NguoiDung.TabIndex = 0;
            // 
            // TenDangNhap
            // 
            this.TenDangNhap.DataPropertyName = "TenDangNhap";
            this.TenDangNhap.HeaderText = "Tên đăng nhập";
            this.TenDangNhap.Name = "TenDangNhap";
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.Name = "TinhTrang";
            // 
            // MatKhau
            // 
            this.MatKhau.DataPropertyName = "MatKhau";
            this.MatKhau.HeaderText = "Mật khẩu";
            this.MatKhau.Name = "MatKhau";
            // 
            // dataGridView_NHomNguoiDung
            // 
            this.dataGridView_NHomNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_NHomNguoiDung.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_NHomNguoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_NHomNguoiDung.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridView_NHomNguoiDung.Location = new System.Drawing.Point(535, 52);
            this.dataGridView_NHomNguoiDung.Name = "dataGridView_NHomNguoiDung";
            this.dataGridView_NHomNguoiDung.RowTemplate.Height = 24;
            this.dataGridView_NHomNguoiDung.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_NHomNguoiDung.Size = new System.Drawing.Size(417, 338);
            this.dataGridView_NHomNguoiDung.TabIndex = 1;
            // 
            // cbo_NhomNguoiDung
            // 
            this.cbo_NhomNguoiDung.DisplayMember = "Text";
            this.cbo_NhomNguoiDung.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_NhomNguoiDung.FormattingEnabled = true;
            this.cbo_NhomNguoiDung.ItemHeight = 16;
            this.cbo_NhomNguoiDung.Location = new System.Drawing.Point(535, 3);
            this.cbo_NhomNguoiDung.Name = "cbo_NhomNguoiDung";
            this.cbo_NhomNguoiDung.Size = new System.Drawing.Size(269, 22);
            this.cbo_NhomNguoiDung.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_NhomNguoiDung.TabIndex = 3;
            this.cbo_NhomNguoiDung.DropDown += new System.EventHandler(this.cbo_NhomNguoiDung_DropDown);
            this.cbo_NhomNguoiDung.SelectedIndexChanged += new System.EventHandler(this.cbo_NhomNguoiDung_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btn_ThemUser_Nhom, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_XoaUser_Nhom, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(462, 52);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.41935F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.58065F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 182F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(67, 338);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btn_ThemUser_Nhom
            // 
            this.btn_ThemUser_Nhom.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_ThemUser_Nhom.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_ThemUser_Nhom.Location = new System.Drawing.Point(3, 92);
            this.btn_ThemUser_Nhom.Name = "btn_ThemUser_Nhom";
            this.btn_ThemUser_Nhom.Size = new System.Drawing.Size(61, 60);
            this.btn_ThemUser_Nhom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_ThemUser_Nhom.Symbol = "";
            this.btn_ThemUser_Nhom.TabIndex = 0;
            this.btn_ThemUser_Nhom.Click += new System.EventHandler(this.btn_ThemUser_Nhom_Click);
            // 
            // btn_XoaUser_Nhom
            // 
            this.btn_XoaUser_Nhom.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_XoaUser_Nhom.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_XoaUser_Nhom.Location = new System.Drawing.Point(3, 158);
            this.btn_XoaUser_Nhom.Name = "btn_XoaUser_Nhom";
            this.btn_XoaUser_Nhom.Size = new System.Drawing.Size(61, 61);
            this.btn_XoaUser_Nhom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_XoaUser_Nhom.Symbol = "";
            this.btn_XoaUser_Nhom.TabIndex = 1;
            this.btn_XoaUser_Nhom.Click += new System.EventHandler(this.btn_XoaUser_Nhom_Click);
            // 
            // MH_NhomNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 393);
            this.Controls.Add(this.tableLayoutPanel_Container);
            this.Name = "MH_NhomNguoiDung";
            this.Text = "Nhóm người dùng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MH_NhomNguoiDung_Load);
            this.tableLayoutPanel_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NHomNguoiDung)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PhanQuyen.QLNguoiDungDTableAdapters.QL_NguoiDungNhomNguoiDungTableAdapter qL_NguoiDungNhomNguoiDungTableAdapter1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Container;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridView_NguoiDung;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridView_NHomNguoiDung;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevComponents.DotNetBar.ButtonX btn_ThemUser_Nhom;
        private DevComponents.DotNetBar.ButtonX btn_XoaUser_Nhom;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_NhomNguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
    }
}