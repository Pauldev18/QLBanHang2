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
    public partial class Form8 : MetroFramework.Forms.MetroForm
    {
        DBConnect DBConnect = new DBConnect();
        public Form8()
        {
            InitializeComponent();
        }
        private void load_data()
        {
            DBConnect.loaddatagridview(dataGridViewX1, "SELECT * FROM TblLogin");
            dataGridViewX1.Columns[0].HeaderText = "ID";
            dataGridViewX1.Columns[1].HeaderText = "Tên đăng nhập";
            dataGridViewX1.Columns[2].HeaderText = "Mật khẩu";
            dataGridViewX1.Columns[3].HeaderText = "Quyền";

            dataGridViewX1.Columns[0].Width = 100;
            dataGridViewX1.Columns[1].Width = 120;

            dataGridViewX1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewX1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewX1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }
        public void Tangma()
        {
            string m;
            try
            {
                DBConnect DBConnect = new DBConnect();
                DBConnect.Connect();
                SqlCommand cmd = new SqlCommand("SELECT * FROM TblLogin ORDER BY Id DESC", DBConnect.Con);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                m = dt.Rows[0]["Id"].ToString();
                int n = Convert.ToInt32(m.Substring(2)) + 1;
                if (n <= 9)
                    m = "TK00" + n;
                else
                    if (n <= 99)
                    m = "TK0" + n;
                else
                    m = "TK" + n;
            }
            catch
            {
                m = "TK001";
            }
            textBoxX1.Text = m;
        }
        void setnull()
        {
            textBoxX1.Text = "";
            textBoxX2.Text = "";
            textBoxX3.Text = "";
            txtquyen.Text = "";

        }
        private void Form8_Load(object sender, EventArgs e)
        {
            this.StyleManager = metroStyleManager1;
            metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Default;
            metroStyleManager1.Style = MetroFramework.MetroColorStyle.Green;
            textBoxX1.Enabled = false;
            textBoxX2.Enabled = false;
            textBoxX3.Enabled = false;
            txtquyen.Enabled = false;
            btnluu.Enabled = false;
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            Tangma();
            
            textBoxX2.Enabled = true;
            textBoxX3.Enabled = true;
            txtquyen.Enabled = true;
            
            btnluu.Enabled = true;
            btnthem.Enabled = false;
            dataGridViewX1.Visible = true;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {

            if (textBoxX2.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxX2.Focus();
                return;
            }
            if (textBoxX3.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxX3.Focus();
                return;
            }
            if (txtquyen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn phân quyền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtquyen.Focus();
                return;
            }
            string insert = "insert into TblLogin values(N'" + textBoxX1.Text + "',N'" + textBoxX2.Text + "',N'" + textBoxX3.Text + "',N'" + txtquyen.Text + "')";
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
                sql = "DELETE TblLogin WHERE Id=N'" + textBoxX1.Text + "'";
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
                MessageBox.Show("Bạn phải nhập tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxX2.Focus();
                return;
            }
            if (textBoxX3.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxX3.Focus();
                return;
            }
            if (txtquyen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn phân quyền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtquyen.Focus();
                return;
            }
            string update = "UPDATE TblLogin SET  TenDangNhap=N'" + textBoxX2.Text.Trim().ToString() + "'" + "," +
                 "MatKhau=N'" + textBoxX3.Text.Trim().ToString() + "'," +
                 "Quyen='" + txtquyen.Text+ "' " +
                 "WHERE Id=N'" + textBoxX1.Text + "'";
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
            textBoxX2.Enabled = false;
            textBoxX3.Enabled = false;
            txtquyen.Enabled = false;
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
                textBoxX3.Text = row.Cells[2].Value.ToString();
                txtquyen.Text = row.Cells[3].Value.ToString();
            }
            
            textBoxX2.Enabled = true;
            textBoxX3.Enabled = true;
            txtquyen.Enabled = true;
            btnluu.Enabled = false;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
        }
    }
}
