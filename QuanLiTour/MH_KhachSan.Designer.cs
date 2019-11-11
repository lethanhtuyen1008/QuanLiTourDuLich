namespace QuanLiTour
{
    partial class MH_KhachSan
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
            this.dataGridView_KhachSan = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel_TacVuKhachSan = new System.Windows.Forms.TableLayoutPanel();
            this.button_ThemKhachSan = new DevComponents.DotNetBar.ButtonX();
            this.btn_SuaKhachSan = new DevComponents.DotNetBar.ButtonX();
            this.btn_XoaKhachSan = new DevComponents.DotNetBar.ButtonX();
            this.btn_LuuKhachSan = new DevComponents.DotNetBar.ButtonX();
            this.btn_TimKhachSan = new DevComponents.DotNetBar.ButtonX();
            this.txt_TimKhachSan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_TTKhachSan = new System.Windows.Forms.TableLayoutPanel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.cbo_MaKhachSan = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbo_MaTinh = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txt_TenKhachSan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_KhachSan)).BeginInit();
            this.tableLayoutPanel_TacVuKhachSan.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel_TTKhachSan.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.34702F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.65298F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView_KhachSan, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel_TacVuKhachSan, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.28767F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.71233F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 416F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1399, 667);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView_KhachSan
            // 
            this.dataGridView_KhachSan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_KhachSan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_KhachSan.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_KhachSan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_KhachSan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridView_KhachSan.Location = new System.Drawing.Point(190, 254);
            this.dataGridView_KhachSan.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_KhachSan.Name = "dataGridView_KhachSan";
            this.dataGridView_KhachSan.Size = new System.Drawing.Size(1205, 409);
            this.dataGridView_KhachSan.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaKhachSan";
            this.Column1.HeaderText = "Mã khách sạn";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaTinh";
            this.Column2.HeaderText = "Mã tỉnh";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TenKhachSan";
            this.Column3.HeaderText = "Tên khách sạn";
            this.Column3.Name = "Column3";
            // 
            // tableLayoutPanel_TacVuKhachSan
            // 
            this.tableLayoutPanel_TacVuKhachSan.ColumnCount = 6;
            this.tableLayoutPanel_TacVuKhachSan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.58934F));
            this.tableLayoutPanel_TacVuKhachSan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.41066F));
            this.tableLayoutPanel_TacVuKhachSan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 208F));
            this.tableLayoutPanel_TacVuKhachSan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 215F));
            this.tableLayoutPanel_TacVuKhachSan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel_TacVuKhachSan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 159F));
            this.tableLayoutPanel_TacVuKhachSan.Controls.Add(this.button_ThemKhachSan, 0, 0);
            this.tableLayoutPanel_TacVuKhachSan.Controls.Add(this.btn_SuaKhachSan, 1, 0);
            this.tableLayoutPanel_TacVuKhachSan.Controls.Add(this.btn_XoaKhachSan, 2, 0);
            this.tableLayoutPanel_TacVuKhachSan.Controls.Add(this.btn_LuuKhachSan, 3, 0);
            this.tableLayoutPanel_TacVuKhachSan.Controls.Add(this.btn_TimKhachSan, 4, 0);
            this.tableLayoutPanel_TacVuKhachSan.Controls.Add(this.txt_TimKhachSan, 5, 0);
            this.tableLayoutPanel_TacVuKhachSan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TacVuKhachSan.Location = new System.Drawing.Point(190, 4);
            this.tableLayoutPanel_TacVuKhachSan.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel_TacVuKhachSan.Name = "tableLayoutPanel_TacVuKhachSan";
            this.tableLayoutPanel_TacVuKhachSan.RowCount = 1;
            this.tableLayoutPanel_TacVuKhachSan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_TacVuKhachSan.Size = new System.Drawing.Size(1205, 50);
            this.tableLayoutPanel_TacVuKhachSan.TabIndex = 3;
            this.tableLayoutPanel_TacVuKhachSan.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // button_ThemKhachSan
            // 
            this.button_ThemKhachSan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_ThemKhachSan.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_ThemKhachSan.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.button_ThemKhachSan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_ThemKhachSan.Location = new System.Drawing.Point(4, 4);
            this.button_ThemKhachSan.Margin = new System.Windows.Forms.Padding(4);
            this.button_ThemKhachSan.Name = "button_ThemKhachSan";
            this.button_ThemKhachSan.Size = new System.Drawing.Size(197, 42);
            this.button_ThemKhachSan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.button_ThemKhachSan.Symbol = "";
            this.button_ThemKhachSan.SymbolColor = System.Drawing.Color.MediumTurquoise;
            this.button_ThemKhachSan.TabIndex = 1;
            this.button_ThemKhachSan.Text = "    Thêm";
            this.button_ThemKhachSan.TextColor = System.Drawing.Color.Black;
            // 
            // btn_SuaKhachSan
            // 
            this.btn_SuaKhachSan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_SuaKhachSan.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_SuaKhachSan.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btn_SuaKhachSan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_SuaKhachSan.Location = new System.Drawing.Point(209, 4);
            this.btn_SuaKhachSan.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SuaKhachSan.Name = "btn_SuaKhachSan";
            this.btn_SuaKhachSan.Size = new System.Drawing.Size(209, 42);
            this.btn_SuaKhachSan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_SuaKhachSan.Symbol = "";
            this.btn_SuaKhachSan.SymbolColor = System.Drawing.Color.MediumAquamarine;
            this.btn_SuaKhachSan.TabIndex = 2;
            this.btn_SuaKhachSan.Text = "    Sửa";
            this.btn_SuaKhachSan.TextColor = System.Drawing.Color.White;
            // 
            // btn_XoaKhachSan
            // 
            this.btn_XoaKhachSan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_XoaKhachSan.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_XoaKhachSan.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btn_XoaKhachSan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_XoaKhachSan.Location = new System.Drawing.Point(426, 4);
            this.btn_XoaKhachSan.Margin = new System.Windows.Forms.Padding(4);
            this.btn_XoaKhachSan.Name = "btn_XoaKhachSan";
            this.btn_XoaKhachSan.Size = new System.Drawing.Size(200, 42);
            this.btn_XoaKhachSan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_XoaKhachSan.Symbol = "";
            this.btn_XoaKhachSan.SymbolColor = System.Drawing.Color.Red;
            this.btn_XoaKhachSan.TabIndex = 3;
            this.btn_XoaKhachSan.Text = "    Xóa";
            this.btn_XoaKhachSan.TextColor = System.Drawing.Color.White;
            // 
            // btn_LuuKhachSan
            // 
            this.btn_LuuKhachSan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_LuuKhachSan.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_LuuKhachSan.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btn_LuuKhachSan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_LuuKhachSan.Location = new System.Drawing.Point(634, 4);
            this.btn_LuuKhachSan.Margin = new System.Windows.Forms.Padding(4);
            this.btn_LuuKhachSan.Name = "btn_LuuKhachSan";
            this.btn_LuuKhachSan.Size = new System.Drawing.Size(207, 42);
            this.btn_LuuKhachSan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_LuuKhachSan.Symbol = "";
            this.btn_LuuKhachSan.SymbolColor = System.Drawing.Color.White;
            this.btn_LuuKhachSan.TabIndex = 4;
            this.btn_LuuKhachSan.Text = "    Lưu";
            this.btn_LuuKhachSan.TextColor = System.Drawing.Color.White;
            // 
            // btn_TimKhachSan
            // 
            this.btn_TimKhachSan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_TimKhachSan.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_TimKhachSan.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btn_TimKhachSan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_TimKhachSan.Location = new System.Drawing.Point(849, 4);
            this.btn_TimKhachSan.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TimKhachSan.Name = "btn_TimKhachSan";
            this.btn_TimKhachSan.Size = new System.Drawing.Size(192, 42);
            this.btn_TimKhachSan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_TimKhachSan.Symbol = "";
            this.btn_TimKhachSan.SymbolColor = System.Drawing.Color.Aqua;
            this.btn_TimKhachSan.TabIndex = 5;
            this.btn_TimKhachSan.Text = "    Tìm";
            this.btn_TimKhachSan.TextColor = System.Drawing.Color.White;
            // 
            // txt_TimKhachSan
            // 
            // 
            // 
            // 
            this.txt_TimKhachSan.Border.Class = "TextBoxBorder";
            this.txt_TimKhachSan.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_TimKhachSan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_TimKhachSan.Location = new System.Drawing.Point(1049, 4);
            this.txt_TimKhachSan.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TimKhachSan.Multiline = true;
            this.txt_TimKhachSan.Name = "txt_TimKhachSan";
            this.txt_TimKhachSan.PreventEnterBeep = true;
            this.txt_TimKhachSan.Size = new System.Drawing.Size(152, 42);
            this.txt_TimKhachSan.TabIndex = 6;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 373F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel_TTKhachSan, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(190, 62);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1205, 184);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // tableLayoutPanel_TTKhachSan
            // 
            this.tableLayoutPanel_TTKhachSan.ColumnCount = 2;
            this.tableLayoutPanel_TTKhachSan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.57927F));
            this.tableLayoutPanel_TTKhachSan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.42073F));
            this.tableLayoutPanel_TTKhachSan.Controls.Add(this.labelX1, 0, 0);
            this.tableLayoutPanel_TTKhachSan.Controls.Add(this.labelX2, 0, 1);
            this.tableLayoutPanel_TTKhachSan.Controls.Add(this.labelX3, 0, 2);
            this.tableLayoutPanel_TTKhachSan.Controls.Add(this.cbo_MaKhachSan, 1, 0);
            this.tableLayoutPanel_TTKhachSan.Controls.Add(this.cbo_MaTinh, 1, 1);
            this.tableLayoutPanel_TTKhachSan.Controls.Add(this.txt_TenKhachSan, 1, 2);
            this.tableLayoutPanel_TTKhachSan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TTKhachSan.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel_TTKhachSan.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel_TTKhachSan.Name = "tableLayoutPanel_TTKhachSan";
            this.tableLayoutPanel_TTKhachSan.RowCount = 4;
            this.tableLayoutPanel_TTKhachSan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_TTKhachSan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_TTKhachSan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel_TTKhachSan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel_TTKhachSan.Size = new System.Drawing.Size(824, 176);
            this.tableLayoutPanel_TTKhachSan.TabIndex = 0;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX1.Location = new System.Drawing.Point(4, 4);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(161, 42);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Mã khách sạn";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX2.Location = new System.Drawing.Point(4, 54);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(161, 42);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Mã tỉnh";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX3.Location = new System.Drawing.Point(4, 104);
            this.labelX3.Margin = new System.Windows.Forms.Padding(4);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(161, 45);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "Tên khách sạn";
            // 
            // cbo_MaKhachSan
            // 
            this.cbo_MaKhachSan.DisplayMember = "Text";
            this.cbo_MaKhachSan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbo_MaKhachSan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_MaKhachSan.FormattingEnabled = true;
            this.cbo_MaKhachSan.ItemHeight = 30;
            this.cbo_MaKhachSan.Location = new System.Drawing.Point(173, 4);
            this.cbo_MaKhachSan.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_MaKhachSan.Name = "cbo_MaKhachSan";
            this.cbo_MaKhachSan.Size = new System.Drawing.Size(647, 36);
            this.cbo_MaKhachSan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_MaKhachSan.TabIndex = 3;
            // 
            // cbo_MaTinh
            // 
            this.cbo_MaTinh.DisplayMember = "Text";
            this.cbo_MaTinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbo_MaTinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_MaTinh.FormattingEnabled = true;
            this.cbo_MaTinh.ItemHeight = 30;
            this.cbo_MaTinh.Location = new System.Drawing.Point(173, 54);
            this.cbo_MaTinh.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_MaTinh.Name = "cbo_MaTinh";
            this.cbo_MaTinh.Size = new System.Drawing.Size(647, 36);
            this.cbo_MaTinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_MaTinh.TabIndex = 4;
            // 
            // txt_TenKhachSan
            // 
            // 
            // 
            // 
            this.txt_TenKhachSan.Border.Class = "TextBoxBorder";
            this.txt_TenKhachSan.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_TenKhachSan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_TenKhachSan.Location = new System.Drawing.Point(173, 104);
            this.txt_TenKhachSan.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenKhachSan.Multiline = true;
            this.txt_TenKhachSan.Name = "txt_TenKhachSan";
            this.txt_TenKhachSan.PreventEnterBeep = true;
            this.txt_TenKhachSan.Size = new System.Drawing.Size(647, 45);
            this.txt_TenKhachSan.TabIndex = 5;
            // 
            // MH_KhachSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 667);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MH_KhachSan";
            this.Text = "MH_KhachSan";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_KhachSan)).EndInit();
            this.tableLayoutPanel_TacVuKhachSan.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel_TTKhachSan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridView_KhachSan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TacVuKhachSan;
        private DevComponents.DotNetBar.ButtonX button_ThemKhachSan;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TTKhachSan;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_MaKhachSan;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_MaTinh;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_TenKhachSan;
        private DevComponents.DotNetBar.ButtonX btn_SuaKhachSan;
        private DevComponents.DotNetBar.ButtonX btn_XoaKhachSan;
        private DevComponents.DotNetBar.ButtonX btn_LuuKhachSan;
        private DevComponents.DotNetBar.ButtonX btn_TimKhachSan;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_TimKhachSan;

    }
}