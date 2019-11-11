namespace QuanLiTour
{
    partial class MH_DanhSachTourMo
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
            this.tableLayoutPanel_DSTourMo = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel_DSTourMo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_DSTourMo
            // 
            this.tableLayoutPanel_DSTourMo.ColumnCount = 1;
            this.tableLayoutPanel_DSTourMo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.76786F));
            this.tableLayoutPanel_DSTourMo.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel_DSTourMo.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_DSTourMo.Name = "tableLayoutPanel_DSTourMo";
            this.tableLayoutPanel_DSTourMo.RowCount = 2;
            this.tableLayoutPanel_DSTourMo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.28302F));
            this.tableLayoutPanel_DSTourMo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.71698F));
            this.tableLayoutPanel_DSTourMo.Size = new System.Drawing.Size(1183, 373);
            this.tableLayoutPanel_DSTourMo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách tour mở";
            // 
            // DanhSachTourMo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(835, 530);
            this.Controls.Add(this.tableLayoutPanel_DSTourMo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DanhSachTourMo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Tag = "MH002";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MH_DanhSachTourMo_Load);
            this.tableLayoutPanel_DSTourMo.ResumeLayout(false);
            this.tableLayoutPanel_DSTourMo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_DSTourMo;
        private System.Windows.Forms.Label label1;


    }
}