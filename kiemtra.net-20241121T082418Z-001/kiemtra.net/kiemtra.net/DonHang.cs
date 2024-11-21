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
    public partial class DonHang : Form
    {
        Ketnoi kn = new Ketnoi();
        public DonHang()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void DonHang_Load(object sender, EventArgs e)
        {
            button5.PerformClick();
        }
        public void getData()
        {
            string query = "select * from DonHang";
            DataSet ds = kn.LayDuLieu(query);           
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clear();
            getData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                string query = string.Format(
                "insert into DonHang values(N'{0}', N'{1} ', N'{2}', N'{3} ', N'{4}')",
                textBox2.Text,
                textBox3.Text,
                textBox4.Text,
                textBox5.Text,
                textBox6.Text

                );
                bool kt = kn.ThucThi(query);
                if (kt == true)
                {
                    button5.PerformClick();
                }
                else
                {
                    MessageBox.Show("Thêm Mới Thất Bại ! ");
                }
            }
            else
            {
                MessageBox.Show("Hãy Nhập Liệu Đầy Đủ ! ");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                "update DonHang set id = N'{1}',khachhangid=N'{2}',sanphamid=N'{3}',soluong=N'{4}',ngaymua=N'{5}' where MaHD = '{0}'",
                textBox2.Text,
                textBox3.Text,
                textBox4.Text,
                textBox5.Text,
                textBox6.Text
                );
            bool kt = kn.ThucThi(query);
            if (kt == true)
            {
                MessageBox.Show("Sửa Thành Công ! ");
                button5.PerformClick();
            }
            else
            {
                MessageBox.Show("Sửa Thất Bại ! ");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = string.Format(
               "delete from DonHang where id = '{0}'",
               textBox2.Text
               );
            bool kt = kn.ThucThi(query);
            if (kt == true)
            {
                MessageBox.Show("Xóa Thành Công ! ");
                button5.PerformClick();
            }
            else
            {
                MessageBox.Show("Xóa Thất Bại ! ");
            }
        }
        public void Clear()
        {
            button2.Enabled = true;
            textBox2.Enabled = true;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                textBox2.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = true;
                button4.Enabled = true;
                textBox2.Text = dataGridView1.Rows[r].Cells["id"].Value.ToString();
                textBox3.Text = dataGridView1.Rows[r].Cells["khachhangid"].Value.ToString();
                textBox4.Text = dataGridView1.Rows[r].Cells["sanphamid"].Value.ToString();
                textBox5.Text = dataGridView1.Rows[r].Cells["soluong"].Value.ToString();
                textBox6.Text = dataGridView1.Rows[r].Cells["ngaymua"].Value.ToString();



            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = String.Format("select * from DonHang where id=  '{0}'",
    textBox1.Text
    );
            DataSet ds = kn.LayDuLieu(query);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
