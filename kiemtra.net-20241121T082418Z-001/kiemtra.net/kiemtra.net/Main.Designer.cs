namespace kiemtra.net
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.danhMucSanPhamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMucSanPhamToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMucKhachHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đơnHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngKêDoanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMucSanPhamToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // danhMucSanPhamToolStripMenuItem
            // 
            this.danhMucSanPhamToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMucSanPhamToolStripMenuItem1,
            this.danhMucKhachHangToolStripMenuItem,
            this.đơnHangToolStripMenuItem});
            this.danhMucSanPhamToolStripMenuItem.Name = "danhMucSanPhamToolStripMenuItem";
            this.danhMucSanPhamToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.danhMucSanPhamToolStripMenuItem.Text = "Menu";
            this.danhMucSanPhamToolStripMenuItem.Click += new System.EventHandler(this.danhMucSanPhamToolStripMenuItem_Click);
            // 
            // danhMucSanPhamToolStripMenuItem1
            // 
            this.danhMucSanPhamToolStripMenuItem1.Name = "danhMucSanPhamToolStripMenuItem1";
            this.danhMucSanPhamToolStripMenuItem1.Size = new System.Drawing.Size(197, 22);
            this.danhMucSanPhamToolStripMenuItem1.Text = "Danh mục Sản Phẩm";
            this.danhMucSanPhamToolStripMenuItem1.Click += new System.EventHandler(this.danhMucSanPhamToolStripMenuItem1_Click);
            // 
            // danhMucKhachHangToolStripMenuItem
            // 
            this.danhMucKhachHangToolStripMenuItem.Name = "danhMucKhachHangToolStripMenuItem";
            this.danhMucKhachHangToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.danhMucKhachHangToolStripMenuItem.Text = "Danh mục Khách Hàng";
            this.danhMucKhachHangToolStripMenuItem.Click += new System.EventHandler(this.danhMucKhachHangToolStripMenuItem_Click);
            // 
            // đơnHangToolStripMenuItem
            // 
            this.đơnHangToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngKêDoanhThuToolStripMenuItem});
            this.đơnHangToolStripMenuItem.Name = "đơnHangToolStripMenuItem";
            this.đơnHangToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.đơnHangToolStripMenuItem.Text = "Đơn Hàng";
            this.đơnHangToolStripMenuItem.Click += new System.EventHandler(this.đơnHangToolStripMenuItem_Click);
            // 
            // thôngKêDoanhThuToolStripMenuItem
            // 
            this.thôngKêDoanhThuToolStripMenuItem.Name = "thôngKêDoanhThuToolStripMenuItem";
            this.thôngKêDoanhThuToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.thôngKêDoanhThuToolStripMenuItem.Text = "Thống kê Doanh Thu";
            this.thôngKêDoanhThuToolStripMenuItem.Click += new System.EventHandler(this.thôngKêDoanhThuToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhMucSanPhamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMucSanPhamToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem danhMucKhachHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đơnHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngKêDoanhThuToolStripMenuItem;
    }
}