namespace QuanLiTour
{
    partial class MH_ChuongTrinhTour
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView_ChuongTrinhTour = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MACHUONGTRINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATOUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAKHACHSAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENCHUONGTRINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHITIET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_XoaCT = new DevComponents.DotNetBar.ButtonX();
            this.btn_SuaCT = new DevComponents.DotNetBar.ButtonX();
            this.btn_ThemCT = new DevComponents.DotNetBar.ButtonX();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX4 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX5 = new DevComponents.DotNetBar.ButtonX();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ChuongTrinhTour)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView_ChuongTrinhTour, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.6474F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.3526F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(979, 519);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView_ChuongTrinhTour
            // 
            this.dataGridView_ChuongTrinhTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ChuongTrinhTour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MACHUONGTRINH,
            this.MATOUR,
            this.MAKHACHSAN,
            this.TENCHUONGTRINH,
            this.NGAY,
            this.CHITIET});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_ChuongTrinhTour.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_ChuongTrinhTour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_ChuongTrinhTour.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridView_ChuongTrinhTour.Location = new System.Drawing.Point(3, 296);
            this.dataGridView_ChuongTrinhTour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_ChuongTrinhTour.Name = "dataGridView_ChuongTrinhTour";
            this.dataGridView_ChuongTrinhTour.RowTemplate.Height = 24;
            this.dataGridView_ChuongTrinhTour.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_ChuongTrinhTour.Size = new System.Drawing.Size(973, 221);
            this.dataGridView_ChuongTrinhTour.TabIndex = 4;
            this.dataGridView_ChuongTrinhTour.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ChuongTrinhTour_CellContentClick);
            // 
            // MACHUONGTRINH
            // 
            this.MACHUONGTRINH.DataPropertyName = "MACHUONGTRINH";
            this.MACHUONGTRINH.HeaderText = "Mã chương trình";
            this.MACHUONGTRINH.Name = "MACHUONGTRINH";
            // 
            // MATOUR
            // 
            this.MATOUR.DataPropertyName = "MATOUR";
            this.MATOUR.HeaderText = "Mã Tour";
            this.MATOUR.Name = "MATOUR";
            // 
            // MAKHACHSAN
            // 
            this.MAKHACHSAN.DataPropertyName = "MAKHACHSAN";
            this.MAKHACHSAN.HeaderText = "Mã khách sạn";
            this.MAKHACHSAN.Name = "MAKHACHSAN";
            // 
            // TENCHUONGTRINH
            // 
            this.TENCHUONGTRINH.DataPropertyName = "TENCHUONGTRINH";
            this.TENCHUONGTRINH.HeaderText = "Tên chương trình";
            this.TENCHUONGTRINH.Name = "TENCHUONGTRINH";
            // 
            // NGAY
            // 
            this.NGAY.DataPropertyName = "NGAY";
            this.NGAY.HeaderText = "Ngày";
            this.NGAY.Name = "NGAY";
            // 
            // CHITIET
            // 
            this.CHITIET.DataPropertyName = "CHITIET";
            this.CHITIET.HeaderText = "Chi tiết";
            this.CHITIET.Name = "CHITIET";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.65169F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.34831F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(973, 237);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.50559F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.49441F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 229F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 310F));
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 70);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.57281F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.42719F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(967, 164);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 7;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.5F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 218F));
            this.tableLayoutPanel4.Controls.Add(this.buttonX5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.buttonX4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.buttonX3, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_ThemCT, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_SuaCT, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_XoaCT, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(967, 42);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // btn_XoaCT
            // 
            this.btn_XoaCT.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_XoaCT.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_XoaCT.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btn_XoaCT.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_XoaCT.Location = new System.Drawing.Point(244, 4);
            this.btn_XoaCT.Margin = new System.Windows.Forms.Padding(4);
            this.btn_XoaCT.Name = "btn_XoaCT";
            this.btn_XoaCT.Size = new System.Drawing.Size(121, 34);
            this.btn_XoaCT.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_XoaCT.Symbol = "";
            this.btn_XoaCT.SymbolColor = System.Drawing.Color.MediumAquamarine;
            this.btn_XoaCT.TabIndex = 1;
            this.btn_XoaCT.Tag = "MH001";
            this.btn_XoaCT.Text = "      Thêm";
            this.btn_XoaCT.TextColor = System.Drawing.Color.White;
            // 
            // btn_SuaCT
            // 
            this.btn_SuaCT.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_SuaCT.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_SuaCT.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btn_SuaCT.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_SuaCT.Location = new System.Drawing.Point(121, 4);
            this.btn_SuaCT.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SuaCT.Name = "btn_SuaCT";
            this.btn_SuaCT.Size = new System.Drawing.Size(115, 34);
            this.btn_SuaCT.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_SuaCT.Symbol = "";
            this.btn_SuaCT.SymbolColor = System.Drawing.Color.MediumAquamarine;
            this.btn_SuaCT.TabIndex = 2;
            this.btn_SuaCT.Tag = "MH001";
            this.btn_SuaCT.Text = "      Thêm";
            this.btn_SuaCT.TextColor = System.Drawing.Color.White;
            // 
            // btn_ThemCT
            // 
            this.btn_ThemCT.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_ThemCT.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_ThemCT.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btn_ThemCT.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_ThemCT.Location = new System.Drawing.Point(4, 4);
            this.btn_ThemCT.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ThemCT.Name = "btn_ThemCT";
            this.btn_ThemCT.Size = new System.Drawing.Size(109, 34);
            this.btn_ThemCT.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_ThemCT.Symbol = "";
            this.btn_ThemCT.SymbolColor = System.Drawing.Color.MediumAquamarine;
            this.btn_ThemCT.TabIndex = 3;
            this.btn_ThemCT.Tag = "MH001";
            this.btn_ThemCT.Text = "      Thêm";
            this.btn_ThemCT.TextColor = System.Drawing.Color.White;
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.buttonX3.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonX3.Location = new System.Drawing.Point(598, 4);
            this.buttonX3.Margin = new System.Windows.Forms.Padding(4);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(129, 34);
            this.buttonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX3.Symbol = "";
            this.buttonX3.SymbolColor = System.Drawing.Color.MediumAquamarine;
            this.buttonX3.TabIndex = 4;
            this.buttonX3.Tag = "MH001";
            this.buttonX3.Text = "      Thêm";
            this.buttonX3.TextColor = System.Drawing.Color.White;
            // 
            // buttonX4
            // 
            this.buttonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.buttonX4.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonX4.Location = new System.Drawing.Point(507, 4);
            this.buttonX4.Margin = new System.Windows.Forms.Padding(4);
            this.buttonX4.Name = "buttonX4";
            this.buttonX4.Size = new System.Drawing.Size(83, 34);
            this.buttonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX4.Symbol = "";
            this.buttonX4.SymbolColor = System.Drawing.Color.MediumAquamarine;
            this.buttonX4.TabIndex = 5;
            this.buttonX4.Tag = "MH001";
            this.buttonX4.Text = "      Thêm";
            this.buttonX4.TextColor = System.Drawing.Color.White;
            // 
            // buttonX5
            // 
            this.buttonX5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonX5.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.buttonX5.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonX5.Location = new System.Drawing.Point(373, 4);
            this.buttonX5.Margin = new System.Windows.Forms.Padding(4);
            this.buttonX5.Name = "buttonX5";
            this.buttonX5.Size = new System.Drawing.Size(126, 34);
            this.buttonX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX5.Symbol = "";
            this.buttonX5.SymbolColor = System.Drawing.Color.MediumAquamarine;
            this.buttonX5.TabIndex = 6;
            this.buttonX5.Tag = "MH001";
            this.buttonX5.Text = "      Thêm";
            this.buttonX5.TextColor = System.Drawing.Color.White;
            // 
            // MH_ChuongTrinhTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 519);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MH_ChuongTrinhTour";
            this.Text = "MH_ChuongTrinhTour";
            this.Load += new System.EventHandler(this.MH_ChuongTrinhTour_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ChuongTrinhTour)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridView_ChuongTrinhTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn MACHUONGTRINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATOUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKHACHSAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENCHUONGTRINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAY;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHITIET;
        private DevComponents.DotNetBar.ButtonX buttonX5;
        private DevComponents.DotNetBar.ButtonX buttonX4;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private DevComponents.DotNetBar.ButtonX btn_ThemCT;
        private DevComponents.DotNetBar.ButtonX btn_SuaCT;
        private DevComponents.DotNetBar.ButtonX btn_XoaCT;
    }
}