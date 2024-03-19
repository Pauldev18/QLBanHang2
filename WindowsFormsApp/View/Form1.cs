using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        DBConnect DBConnect = new DBConnect();
        public Form1()
        {
            InitializeComponent();
        }
        private void load_data()
        {
            DBConnect.loaddatagridview(dataGridViewX1, "SELECT * FROM TblLoaiSanPham");
            dataGridViewX1.Columns[0].HeaderText = "Mã Loại Sản Phẩm";
            dataGridViewX1.Columns[1].HeaderText = "Tên Loại Sản Phẩm";

            dataGridViewX1.Columns[0].Width = 165;
            dataGridViewX1.Columns[1].Width = 165;

            dataGridViewX1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewX1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewX1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
         
        }
        public void Tangmaloaisanpham()
        {
            string m;
            try
            {
                DBConnect DBConnect = new DBConnect();
                DBConnect.Connect();
                SqlCommand cmd = new SqlCommand("SELECT * FROM TblLoaiSanPham ORDER BY Maloaisp DESC", DBConnect.Con);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                m = dt.Rows[0]["Maloaisp"].ToString();
                int n = Convert.ToInt32(m.Substring(2)) + 1;
                if (n <= 9)
                    m = "ML00" + n;
                else
                    if (n <= 99)
                    m = "ML0" + n;
                else
                    m = "ML" + n;
            }
            catch
            {
                m = "ML001";
            }
            textBoxX1.Text = m;
        }
        void setnull()
        {
            textBoxX1.Text = "";
            textBoxX2.Text = "";
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.StyleManager = metroStyleManager1;
            metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Default;
            metroStyleManager1.Style = MetroFramework.MetroColorStyle.Green;
            textBoxX1.Enabled = false;
            btnluu.Enabled = false;
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            Tangmaloaisanpham();
            textBoxX1.Enabled = true;
            btnluu.Enabled = true;
            btnthem.Enabled = false;
            dataGridViewX1.Visible = true;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            
            if (textBoxX2.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên loại sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxX2.Focus();
                return;
            }
            string insert = "insert into TblLoaiSanPham values(N'" + textBoxX1.Text + "',N'" + textBoxX2.Text + "')";
            DBConnect.thucthisql(insert);
            setnull();
            btnluu.Enabled = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (dataGridViewX1.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (textBoxX1.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE TblLoaiSanPham WHERE Maloaisp=N'" + textBoxX1.Text + "'";
                DBConnect.thucthisql(sql);
            }
            setnull();
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (textBoxX1.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (textBoxX2.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên loại sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttenloaisp.Focus();
                return;
            }
            string update = "UPDATE TblLoaiSanPham SET  Tenloaisp=N'" + textBoxX2.Text.Trim().ToString() + "'" +
                "WHERE Maloaisp=N'" + textBoxX1.Text + "'";
            DBConnect.thucthisql(update);
            setnull();
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            load_data();
            setnull();
            textBoxX1.Enabled = false;
            btnthem.Enabled = true;
            btnluu.Enabled = false;
            btnview.Enabled = true;
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            dataGridViewX1.Visible = true;
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            setnull();
            textBoxX1.Enabled = false;
            txttenloaisp.Enabled = false;
            btnluu.Enabled = false;
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            dataGridViewX1.Visible = false;
        }
        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewX1.Rows[e.RowIndex];
                textBoxX1.Text = row.Cells[0].Value.ToString();
                textBoxX2.Text = row.Cells[1].Value.ToString();
            }
            textBoxX1.Enabled = true;
            btnluu.Enabled = false;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
        }
    }
}
