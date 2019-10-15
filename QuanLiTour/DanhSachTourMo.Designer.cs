namespace QuanLiTour
{
    partial class DanhSachTourMo
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
            this.btn_ThemTourMo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ThemTourMo
            // 
            this.btn_ThemTourMo.Location = new System.Drawing.Point(21, 12);
            this.btn_ThemTourMo.Name = "btn_ThemTourMo";
            this.btn_ThemTourMo.Size = new System.Drawing.Size(168, 40);
            this.btn_ThemTourMo.TabIndex = 0;
            this.btn_ThemTourMo.Tag = "MH001";
            this.btn_ThemTourMo.Text = "Thêm tour";
            this.btn_ThemTourMo.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(212, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 40);
            this.button1.TabIndex = 1;
            this.button1.Tag = "MH001";
            this.button1.Text = "Thêm tour";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(416, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 40);
            this.button2.TabIndex = 2;
            this.button2.Tag = "MH001";
            this.button2.Text = "Thêm tour";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // DanhSachTourMo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 404);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_ThemTourMo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DanhSachTourMo";
            this.Tag = "MH002";
            this.Text = "DanhSachTourMo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MH_DanhSachTourMo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ThemTourMo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

    }
}