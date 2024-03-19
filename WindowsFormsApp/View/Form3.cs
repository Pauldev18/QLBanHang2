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
    public partial class Form3 : MetroFramework.Forms.MetroForm
    {
        DBConnect DBConnect = new DBConnect();
        public Form3()
        {
            InitializeComponent();
        }
        private void load_data()
        {
            DBConnect.loaddatagridview(dataGridViewX1, "SELECT * FROM TblNhanVien");
            dataGridViewX1.Columns[0].HeaderText = "Mã nhân viên";
            dataGridViewX1.Columns[1].HeaderText = "Tên nhân viên";
            dataGridViewX1.Columns[2].HeaderText = "Giới tính";
            dataGridViewX1.Columns[3].HeaderText = "Địa chỉ";
            dataGridViewX1.Columns[4].HeaderText = "Số điện thoại";
            dataGridViewX1.Columns[5].HeaderText = "Ngày sinh";

            dataGridViewX1.Columns[0].Width = 105;
            dataGridViewX1.Columns[1].Width = 105;
            dataGridViewX1.Columns[2].Width = 80;
            dataGridViewX1.Columns[3].Width = 112;

            dataGridViewX1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewX1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewX1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewX1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewX1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
          
        }
        public void Tangmanhanvien()
        {
            string m;
            try
            {
                DBConnect DBConnect = new DBConnect();
                DBConnect.Connect();
                SqlCommand cmd = new SqlCommand("SELECT * FROM TblNhanVien ORDER BY Manhanvien DESC", DBConnect.Con);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                m = dt.Rows[0]["Manhanvien"].ToString();
                int n = Convert.ToInt32(m.Substring(2)) + 1;
                if (n <= 9)
                    m = "NV00" + n;
                else
                    if (n <= 99)
                    m = "NV0" + n;
                else
                    m = "NV" + n;
            }
            catch
            {
                m = "NV001";
            }
            txtmanhanvien.Text = m;
        }
        void setnull()
        {
            txtmanhanvien.Text = "";
            txttennhanvien.Text = "";
            txtdiachi.Text = "";
            txtsodienthoai.Text = "";
            txtngaysinh.Text = "";
            ckboxgioitinh.Checked = false;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            this.StyleManager = metroStyleManager1;
            metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Default;
            metroStyleManager1.Style = MetroFramework.MetroColorStyle.Green;
            txttennhanvien.Enabled = false;
            ckboxgioitinh.Enabled = false;
            txtdiachi.Enabled = false;
            txtsodienthoai.Enabled = false;
            txtngaysinh.Enabled = false;
            btnluu.Enabled = false;
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            Tangmanhanvien();
            txttennhanvien.Enabled = true;
            ckboxgioitinh.Enabled = true;
            txtdiachi.Enabled = true;
            txtsodienthoai.Enabled = true;
            txtngaysinh.Enabled = true;
            txttennhanvien.Focus();
            btnluu.Enabled = true;
            btnthem.Enabled = false;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (txttennhanvien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttennhanvien.Focus();
                return;
            }
            sql = "SELECT Manhanvien FROM TblNhanVien WHERE Manhanvien=N'" + txtmanhanvien.Text.Trim() + "'";
            if (ckboxgioitinh.Checked == true)
            {
                gt = "Nam";
            }
            else
            {
                gt = "Nữ";
            }
            if (txtdiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdiachi.Focus();
                return;
            }
            if (txtsodienthoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtsodienthoai.Focus();
                return;
            }
            if (txtngaysinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtngaysinh.Focus();
                return;
            }
            string insert = "insert into TblNhanVien values(N'" + txtmanhanvien.Text + "',N'" + txttennhanvien.Text + "',N'" + gt + "'" +
                ",N'" + txtdiachi.Text + "',N'" + txtsodienthoai.Text + "',N'" + txtngaysinh.Text + "')";
            DBConnect.thucthisql(insert);
            DBConnect.thucthisql(sql);
            setnull();
            btnluu.Enabled = false;
            btnthem.Enabled = true;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (dataGridViewX1.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmanhanvien.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE TblNhanVien WHERE Manhanvien=N'" + txtmanhanvien.Text + "'";
                DBConnect.thucthisql(sql);
            }
            setnull();
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (txtmanhanvien.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txttennhanvien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttennhanvien.Focus();
                return;
            }
            sql = "SELECT Manhanvien FROM TblNhanVien WHERE Manhanvien=N'" + txtmanhanvien.Text.Trim() + "'";
            if (ckboxgioitinh.Checked == true)
            {
                gt = "Nam";
            }
            else
            {
                gt = "Nữ";
            }
            if (txtdiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdiachi.Focus();
                return;
            }
            if (txtsodienthoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtsodienthoai.Focus();
                return;
            }
            if (txtngaysinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtngaysinh.Focus();
                return;
            }
            string update = "UPDATE TblNhanVien SET  Tennhanvien=N'" + txttennhanvien.Text.Trim().ToString() + "'" + "," +
                "Gioitinh=N'" + gt + "',Diachi=N'" + txtdiachi.Text.Trim().ToString() + "'," +
                "Dienthoai='" + txtsodienthoai.Text.ToString() + "'," +
                "Ngaysinh='" + txtngaysinh.Text.ToString() +
                   "' WHERE Manhanvien=N'" + txtmanhanvien.Text + "'";
            DBConnect.thucthisql(update);
            DBConnect.thucthisql(sql);
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
            txttennhanvien.Enabled = false;
            ckboxgioitinh.Enabled = false;
            txtdiachi.Enabled = false;
            txtsodienthoai.Enabled = false;
            txtngaysinh.Enabled = false;
            btnthem.Enabled = true;
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
                txtmanhanvien.Text = row.Cells[0].Value.ToString();
                txttennhanvien.Text = row.Cells[1].Value.ToString();
                ckboxgioitinh.Text = row.Cells[2].Value.ToString();
                txtdiachi.Text = row.Cells[3].Value.ToString();
                txtsodienthoai.Text = row.Cells[4].Value.ToString();
                txtngaysinh.Text = row.Cells[5].Value.ToString();
            }
            txttennhanvien.Enabled = true;
            ckboxgioitinh.Enabled = true;
            txtdiachi.Enabled = true;
            txtsodienthoai.Enabled = true;
            txtngaysinh.Enabled = true;
            btnluu.Enabled = false;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
        }

        private void txtsodienthoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
