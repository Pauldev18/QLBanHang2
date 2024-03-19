using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp.View
{
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        DBConnect DBConnect = new DBConnect();
        public Form2()
        {
            InitializeComponent();
        }
        private void load_data()
        {
            DBConnect.loaddatagridview(dataGridViewX1, "SELECT * FROM TblKhachHang");
            dataGridViewX1.Columns[0].HeaderText = "Mã khách hàng";
            dataGridViewX1.Columns[1].HeaderText = "Tên khách hàng";
            dataGridViewX1.Columns[2].HeaderText = "Địa chỉ";
            dataGridViewX1.Columns[3].HeaderText = "Số điện thoại";

            dataGridViewX1.Columns[0].Width = 115;
            dataGridViewX1.Columns[1].Width = 115;
            dataGridViewX1.Columns[2].Width = 104;

            dataGridViewX1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewX1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewX1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewX1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
        }
        public void Tangmakhachhang()
        {
            string m;
            try
            {
                DBConnect DBConnect = new DBConnect();
                DBConnect.Connect();
                SqlCommand cmd = new SqlCommand("SELECT * FROM TblKhachHang ORDER BY Makhachhang DESC", DBConnect.Con);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                m = dt.Rows[0]["Makhachhang"].ToString();
                int n = Convert.ToInt32(m.Substring(2)) + 1;
                if (n <= 9)
                    m = "KH00" + n;
                else
                    if (n <= 99)
                    m = "KH0" + n;
                else
                    m = "KH" + n;
            }
            catch
            {
                m = "KH001";
            }
            txtmakh.Text = m;
        }
        void setnull()
        {
            txtmakh.Text = "";
            txttenkh.Text = "";
            txtdiachi.Text = "";
            txtsodt.Text = "";
         
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            this.StyleManager = metroStyleManager1;
            metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Default;
            metroStyleManager1.Style = MetroFramework.MetroColorStyle.Green;
            txtmakh.Enabled = false;
            txttenkh.Enabled = false;
            txtdiachi.Enabled = false;
            txtsodt.Enabled = false;
            btnluu.Enabled = false;
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
           
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            Tangmakhachhang();
            txttenkh.Enabled = true;
            txtdiachi.Enabled = true;
            txtsodt.Enabled = true;
            txttenkh.Focus();
            btnluu.Enabled = true;
            btnthem.Enabled = false;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            
            if (txttenkh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttenkh.Focus();
                return;
            }
            if (txtdiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdiachi.Focus();
                return;
            }
            if (txtsodt.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtsodt.Focus();
                return;
            }
            string insert = "insert into TblKhachHang values(N'" + txtmakh.Text + "',N'" + txttenkh.Text + "',N'" + txtdiachi.Text + "',N'" + txtsodt.Text + "')";
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
            if (txtmakh.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE TblKhachHang WHERE Makhachhang=N'" + txtmakh.Text + "'";
                DBConnect.thucthisql(sql);
            }
            setnull();
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtmakh.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txttenkh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttenkh.Focus();
                return;
            }
            if (txtdiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdiachi.Focus();
                return;
            }
            if (txtsodt.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtsodt.Focus();
                return;
            }
            string update = "UPDATE TblKhachHang SET  Tenkhachhang=N'" + txttenkh.Text.Trim().ToString() + "'" + "," +
                "Diachi=N'" + txtdiachi.Text.Trim().ToString() + "'," +
                "Dienthoai='" + txtsodt.Text.ToString() + "' " +
                "WHERE Makhachhang=N'" + txtmakh.Text + "'";
            DBConnect.thucthisql(update);
            setnull();
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            load_data();
            setnull();
            btnthem.Enabled = true;
            btnluu.Enabled = false;
            btnview.Enabled = true;
            btnxoa.Enabled = false;
            dataGridViewX1.Visible = true;
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            setnull();
            txttenkh.Enabled = false;
            txtdiachi.Enabled = false;
            txtsodt.Enabled = false;
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
                txtmakh.Text = row.Cells[0].Value.ToString();
                txttenkh.Text = row.Cells[1].Value.ToString();
                txtdiachi.Text = row.Cells[2].Value.ToString();
                txtsodt.Text = row.Cells[3].Value.ToString();
            }
            txttenkh.Enabled = true;
            txtdiachi.Enabled = true;
            txtsodt.Enabled = true;
            btnluu.Enabled = false;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
        }

        private void txtsodt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
