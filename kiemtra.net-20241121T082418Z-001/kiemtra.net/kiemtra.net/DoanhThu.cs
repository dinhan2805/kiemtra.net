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
    public partial class DoanhThu : Form
    {
        public DoanhThu()
        {
            InitializeComponent();
        }
        Ketnoi kn = new Ketnoi();
        void Getdata()
        {
            string query = String.Format("select *from DonHang where ngaymua between '{0} ' and '{1} '",
                dateTimePicker1.Value.ToString("yyyy/MM/dd"),
                dateTimePicker2.Value.ToString("yyyy/MM/dd")
                );
            DataSet ds = kn.LayDuLieu(query);
            dataGridView1.DataSource = ds.Tables[0];
        }
        void TongThu()
        {
            string query = String.Format("SELECT YEAR(ngaymua) AS Year, MONTH(ngaymua) AS Month, SUM(soluong * gia) AS Revenue FROM ĐơnHàng JOIN SảnPhẩm ON ĐơnHàng.sanphamid = SảnPhẩm.id GROUP BY YEAR(ngaymua), MONTH(ngaymua)",
                dateTimePicker1.Value.ToString("yyyy/MM/dd"),
                dateTimePicker2.Value.ToString("yyyy/MM/dd")
                );
            DataSet ds = kn.LayDuLieu(query);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Getdata();
            TongThu();
        }
    }
}
