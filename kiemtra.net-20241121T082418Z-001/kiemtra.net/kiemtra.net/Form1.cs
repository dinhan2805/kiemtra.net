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
    
    public partial class Form1 : Form
    {
        Ketnoi kn = new Ketnoi();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = string.Format(
               "select * from NguoiDung where tendangnhap = '{0}' and matkhau= '{1}'",
               textBox1.Text, textBox2.Text
               );
            DataSet ds = kn.LayDuLieu(query);
            if (ds.Tables[0].Rows.Count == 1)
            {
                MessageBox.Show("Tài Khoản Đăng Nhập Thành Công ! ");
                textBox1.Text = "";
                textBox2.Text = "";

                Main mn = new Main();
                this.Hide();
                mn.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Đăng Nhập Thất Bại !");
            }
        }
    }
}
