using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kiemtra.net
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void danhMucSanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void danhMucSanPhamToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            sp.ShowDialog();
        }

        private void danhMucKhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.ShowDialog();
        }

        private void đơnHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DonHang dh = new DonHang();
            dh.ShowDialog();
        }

        private void thôngKêDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoanhThu dt = new DoanhThu();
            dt.ShowDialog();
        }
    }
}
