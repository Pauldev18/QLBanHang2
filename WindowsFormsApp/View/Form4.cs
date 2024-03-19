using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp.View
{
    public partial class Form4 : MetroFramework.Forms.MetroForm
    {
        DBConnect DBConnect = new DBConnect();
        public Form4()
        {
            InitializeComponent();
        }
        private void load_data()
        {
            DBConnect.loaddatagridview(dataGridViewX1, "SELECT * FROM TblSanPham");

            dataGridViewX1.Columns[0].HeaderText = "  Mã sản phẩm";
            dataGridViewX1.Columns[1].HeaderText = "Tên sản phẩm";
            dataGridViewX1.Columns[2].HeaderText = "Mã loại sản phẩm";
            dataGridViewX1.Columns[3].HeaderText = " Số lượng";
            dataGridViewX1.Columns[4].HeaderText = "Đơn giá nhập";
            dataGridViewX1.Columns[5].HeaderText = "  Đơn giá bán ";
            dataGridViewX1.Columns[6].HeaderText = "Hình ảnh";
            dataGridViewX1.Columns[7].HeaderText = "Ghi chú";

            dataGridViewX1.Columns[0].Width = 109;
            dataGridViewX1.Columns[1].Width = 276;
            dataGridViewX1.Columns[2].Width = 125;
            dataGridViewX1.Columns[3].Width = 80;
            dataGridViewX1.Columns[4].Width = 104;
            dataGridViewX1.Columns[5].Width = 104;
            dataGridViewX1.Columns[6].Width = 230;
            dataGridViewX1.Columns[7].Width = 120;

            dataGridViewX1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewX1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewX1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewX1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewX1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewX1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewX1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewX1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewX1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }
        public void Tangmasanpham()
        {
            string m;
            try
            {
                DBConnect DBConnect = new DBConnect();
                DBConnect.Connect();
                SqlCommand cmd = new SqlCommand("SELECT * FROM TblSanPham ORDER BY Masanpham DESC", DBConnect.Con);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                m = dt.Rows[0]["Masanpham"].ToString();
                int n = Convert.ToInt32(m.Substring(2)) + 1;
                if (n <= 9)
                    m = "SP00" + n;
                else
                    if (n <= 99)
                    m = "SP0" + n;
                else
                    m = "SP" + n;
            }
            catch
            {
                m = "SP001";
            }
            txtMaHang.Text = m;
        }
        void setnull()
        {
            txtMaHang.Text = "";
            txtTenHang.Text = "";
            cboMaSanPham.Text = "";
            txtSoLuong.Text = "";
            txtDonGiaNhap.Text = "";
            txtDonGiaBan.Text = "";
            txtAnh.Text = "";
            picAnh.Image = null;
            txtGhiChu.Text = "";
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            this.StyleManager = metroStyleManager1;
            metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Default;
            metroStyleManager1.Style = MetroFramework.MetroColorStyle.Green;
            string sql;
            sql = "SELECT * from TblLoaiSanPham";
            btnluu.Enabled = false;
            DBConnect.FillCombo(sql, cboMaSanPham, "Maloaisp", "Tenloaisp");
            cboMaSanPham.SelectedIndex = -1;
            DBConnect.thucthisql(sql);

            txtTenHang.Enabled = false;
            cboMaSanPham.Enabled = false;
            txtSoLuong.Enabled = false;
            txtDonGiaNhap.Enabled = false;
            txtDonGiaBan.Enabled = false;
       
            txtGhiChu.Enabled = false;
            btnluu.Enabled = false;
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            btnopen.Enabled = false;
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            Tangmasanpham();
            txtTenHang.Enabled = true;
            cboMaSanPham.Enabled = true;
            txtSoLuong.Enabled = true;
            txtDonGiaNhap.Enabled = true;
            txtDonGiaBan.Enabled = true;
            txtGhiChu.Enabled = true;

            txtTenHang.Focus();

            btnluu.Enabled = true;
            btnthem.Enabled = false;
            btnopen.Enabled = true;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (txtTenHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenHang.Focus();
                return;
            }
            if (cboMaSanPham.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập loại sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaSanPham.Focus();
                return;
            }
            if (txtSoLuong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuong.Focus();
                return;
            }
            if (txtDonGiaNhap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập đơn giá nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDonGiaNhap.Focus();
                return;
            }
            if (txtDonGiaBan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập đơn giá bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDonGiaBan.Focus();
                return;
            }
            if (txtAnh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn ảnh minh hoạ cho sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnopen.Focus();
                return;
            }
            if (txtGhiChu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ghi chú cho sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGhiChu.Focus();
                return;
            }
            string insert = "INSERT INTO TblSanPham(Masanpham,Tensanpham,Maloaisp,Soluong,Dongianhap,Dongiaban,Anh,Ghichu) VALUES(N'"
                + txtMaHang.Text.Trim() + "',N'" + txtTenHang.Text.Trim() +
                "',N'" + cboMaSanPham.SelectedValue.ToString() +
                "'," + txtSoLuong.Text.Trim() + "," + txtDonGiaNhap.Text +
                "," + txtDonGiaBan.Text + ",N'" + txtAnh.Text + "',N'" + txtGhiChu.Text.Trim() + "')";

            DBConnect.thucthisql(insert);
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
            if (txtMaHang.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE TblSanPham WHERE Masanpham=N'" + txtMaHang.Text + "'";
                DBConnect.thucthisql(sql);
                setnull();
                btnsua.Enabled = false;
                btnxoa.Enabled = false;
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql;
            if (dataGridViewX1.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenHang.Focus();
                return;
            }
            if (cboMaSanPham.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập loại sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaSanPham.Focus();
                return;
            }
            if (txtSoLuong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuong.Focus();
                return;
            }
            if (txtDonGiaNhap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập đơn giá nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDonGiaNhap.Focus();
                return;
            }
            if (txtDonGiaBan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập đơn giá bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDonGiaBan.Focus();
                return;
            }
            if (txtAnh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn ảnh minh hoạ cho sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnopen.Focus();
                return;
            }
            if (txtGhiChu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ghi chú cho sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGhiChu.Focus();
                return;
            }
            sql = "UPDATE TblSanPham SET Tensanpham=N'" + txtTenHang.Text.Trim().ToString() + "',Maloaisp=N'" + cboMaSanPham.SelectedValue.ToString() + "'" +
                ",Soluong=" + txtSoLuong.Text + "" +
                ",Dongianhap='" + txtDonGiaNhap.Text + "',Dongiaban='" + txtDonGiaBan.Text + "'" +
                ",Anh='" + txtAnh.Text + "',Ghichu=N'" + txtGhiChu.Text + "' WHERE Masanpham=N'" + txtMaHang.Text + "'";
            DBConnect.thucthisql(sql);
            setnull();
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            load_data();
            btnthem.Enabled = true;
            btnluu.Enabled = false;
            btnview.Enabled = true;
            btnxoa.Enabled = false;
            dataGridViewX1.Visible = true;
           
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            setnull();
            txtTenHang.Enabled = false;
            cboMaSanPham.Enabled = false;
            txtSoLuong.Enabled = false;
            txtDonGiaNhap.Enabled = false;
            txtDonGiaBan.Enabled = false;
            txtGhiChu.Enabled = false;

            btnthem.Enabled = true;
            btnluu.Enabled = false;
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            btnopen.Enabled = false;

            dataGridViewX1.Visible = false;
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn ảnh minh hoạ cho sản phẩm";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(dlgOpen.FileName);
                txtAnh.Text = dlgOpen.FileName;
            }
        }

        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string MaLoaiSanPham;
            string sql;
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHang.Focus();
                return;
            }
            if (dataGridViewX1.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaHang.Text = dataGridViewX1.CurrentRow.Cells["Masanpham"].Value.ToString();
            txtTenHang.Text = dataGridViewX1.CurrentRow.Cells["Tensanpham"].Value.ToString();
            MaLoaiSanPham = dataGridViewX1.CurrentRow.Cells["Maloaisp"].Value.ToString();
            sql = "SELECT Tenloaisp FROM TblLoaiSanPham WHERE Maloaisp=N'" + MaLoaiSanPham + "'";
            cboMaSanPham.Text = DBConnect.GetFieldValues1(sql);
            txtSoLuong.Text = dataGridViewX1.CurrentRow.Cells["Soluong"].Value.ToString();
            txtDonGiaNhap.Text = dataGridViewX1.CurrentRow.Cells["Dongianhap"].Value.ToString();
            txtDonGiaBan.Text = dataGridViewX1.CurrentRow.Cells["Dongiaban"].Value.ToString();
            sql = "SELECT Anh FROM TblSanPham WHERE Masanpham=N'" + txtMaHang.Text + "'";
            txtAnh.Text = DBConnect.GetFieldValues1(sql);
            picAnh.Image = Image.FromFile(txtAnh.Text);
            sql = "SELECT Ghichu FROM TblSanPham WHERE Masanpham = N'" + txtMaHang.Text + "'";
            txtGhiChu.Text = DBConnect.GetFieldValues1(sql);

            
            txtTenHang.Enabled = true;
            cboMaSanPham.Enabled = true;
            txtSoLuong.Enabled = true;
            txtDonGiaNhap.Enabled = true;
            txtDonGiaBan.Enabled = true;
            txtGhiChu.Enabled = true;
            
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnopen.Enabled = true;
            
        }

        private void txtDonGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDonGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
