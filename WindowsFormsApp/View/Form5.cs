using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMExcel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp.View
{
    public partial class Form5 : MetroFramework.Forms.MetroForm
    {
        DBConnect DBConnect = new DBConnect();
        DataTable tblCTHDB;
        public Form5()
        {
            InitializeComponent();
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT a.Masanpham, b.Tensanpham, a.Soluong, b.Dongiaban, a.Giamgia,a.Thanhtien FROM TblChiTietHDBan AS a,TblSanPham AS b WHERE a.MaHDBan = N'" + txtMaHDBan.Text + "' AND a.Masanpham=b.Masanpham";
            tblCTHDB = DBConnect.GetDataToTable(sql);
            dataGridViewX1.DataSource = tblCTHDB;
            dataGridViewX1.Columns[0].HeaderText = "Mã hàng";
            dataGridViewX1.Columns[1].HeaderText = "Tên hàng";
            dataGridViewX1.Columns[2].HeaderText = "Số lượng";
            dataGridViewX1.Columns[3].HeaderText = "Đơn giá";
            dataGridViewX1.Columns[4].HeaderText = "Giảm giá %";
            dataGridViewX1.Columns[5].HeaderText = "Thành tiền";
            dataGridViewX1.Columns[0].Width = 100;
            dataGridViewX1.Columns[1].Width = 276;
            dataGridViewX1.Columns[2].Width = 100;
            dataGridViewX1.Columns[3].Width = 100;
            dataGridViewX1.Columns[4].Width = 100;
            dataGridViewX1.Columns[5].Width = 100;
            dataGridViewX1.AllowUserToAddRows = false;
            dataGridViewX1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        public void LoadInfoHoaDon()
        {
            string str;
            str = "SELECT Ngayban FROM TblHoaDonBan WHERE Mahdban = N'" + txtMaHDBan.Text + "'";
            txtngayban.Text = DBConnect.ConvertDateTime(DBConnect.GetFieldValues1(str));
            str = "SELECT Manhanvien FROM TblHoaDonBan WHERE Mahdban = N'" + txtMaHDBan.Text + "'";
            cboMaNhanVien.Text = DBConnect.GetFieldValues1(str);
            str = "SELECT Makhachhang FROM TblHoaDonBan WHERE Mahdban = N'" + txtMaHDBan.Text + "'";
            cboMaKhach.Text = DBConnect.GetFieldValues1(str);
            str = "SELECT Tongtien FROM TblHoaDonBan WHERE Mahdban = N'" + txtMaHDBan.Text + "'";
            txtTongTien.Text = DBConnect.GetFieldValues1(str);

        }
        
        private void Form5_Load(object sender, EventArgs e)
        {
            this.StyleManager = metroStyleManager1;
            metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Default;
            metroStyleManager1.Style = MetroFramework.MetroColorStyle.Green;
            DBConnect.FillCombo("SELECT Makhachhang, Tenkhachhang FROM TblKhachHang", cboMaKhach, "Makhachhang", "Makhachhang");
            cboMaKhach.SelectedIndex = -1;
            DBConnect.FillCombo("SELECT Manhanvien, Tennhanvien FROM TblNhanVien", cboMaNhanVien, "Manhanvien", "Manhanvien");
            cboMaNhanVien.SelectedIndex = -1;
            DBConnect.FillCombo("SELECT Masanpham, Tensanpham FROM TblSanPham", cboMaHang, "Masanpham", "Masanpham");
            cboMaHang.SelectedIndex = -1;
            if (txtMaHDBan.Text != "")
            {
                LoadInfoHoaDon();
            }
            
            btnluu.Enabled = false;
            btnxoa.Enabled = false;
            btninhoadon.Enabled = false;
            txtngayban.Enabled = false;
            cboMaNhanVien.Enabled = false;
            cboMaKhach.Enabled = false;
            txtSoLuong.Enabled = false;
            txtGiamGia.Enabled = false;
            cboMaHang.Enabled = false;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
            txtMaHDBan.Text = DBConnect.CreateKey("HDB");
            txtngayban.Enabled = true;
            cboMaNhanVien.Enabled = true;
            cboMaKhach.Enabled = true;
            txtSoLuong.Enabled = true;
            txtGiamGia.Enabled = true;
            cboMaHang.Enabled = true;
            btnluu.Enabled = true;
            btnthem.Enabled = false;
            dataGridViewX1.Visible = true;

        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql;
            double sl, SLcon, tong=0;
            sql = "SELECT Mahdban FROM TblHoaDonBan WHERE Mahdban=N'" + txtMaHDBan.Text + "'";
            if (!DBConnect.CheckKey(sql))
            {
                // Mã hóa đơn chưa có, tiến hành lưu các thông tin chung
                // Mã HDBan được sinh tự động do đó không có trường hợp trùng khóa
                if (txtngayban.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập ngày bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtngayban.Focus();
                    return;
                }
                if (cboMaNhanVien.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboMaNhanVien.Focus();
                    return;
                }
                if (cboMaKhach.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboMaKhach.Focus();
                    return;
                }
                if (cboMaHang.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboMaHang.Focus();
                    return;
                }
                if ((txtSoLuong.Text.Trim().Length == 0) || (txtSoLuong.Text == "0"))
                {
                    MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSoLuong.Text = "";
                    txtSoLuong.Focus();
                    return;
                }
                if (txtGiamGia.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập giảm giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtGiamGia.Focus();
                    return;
                }
                sql = "INSERT INTO TblHoaDonBan(Mahdban, Manhanvien, Ngayban, Makhachhang, Tongtien) VALUES (N'" + txtMaHDBan.Text.Trim() + "','" +
                        cboMaNhanVien.SelectedValue + "',N'" + txtngayban.Value + "',N'" +
                        cboMaKhach.SelectedValue + "'," + txtTongTien.Text + ")";
                DBConnect.thucthisql(sql);
            }
            //// Lưu thông tin của các mặt hàng
           
            sql = "SELECT Masanpham FROM TblChiTietHDBan WHERE Masanpham=N'" + cboMaHang.SelectedValue + "' AND Mahdban = N'" + txtMaHDBan.Text.Trim() + "'";
            if (DBConnect.CheckKey(sql))
            {
                MessageBox.Show("Mã hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                cboMaHang.Focus();
                return;
            }
            // Kiểm tra xem số lượng hàng trong kho còn đủ để cung cấp không?
            sl = Convert.ToDouble(DBConnect.GetFieldValues1("SELECT Soluong FROM TblSanPham WHERE Masanpham = N'" + cboMaHang.SelectedValue + "'"));
            if (Convert.ToDouble(txtSoLuong.Text) > sl)
            {
                MessageBox.Show("Số lượng mặt hàng này chỉ còn " + sl, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuong.Text = "";
                txtSoLuong.Focus();
                return;
            }
            sql = "INSERT INTO TblChiTietHDBan(Mahdban,Masanpham,Soluong,Dongia, Giamgia,Thanhtien) VALUES(N'" + txtMaHDBan.Text.Trim() + "',N'" + cboMaHang.SelectedValue + "'," + txtSoLuong.Text + "," + txtDonGiaBan.Text + "," + txtGiamGia.Text + "," + txtTongTien.Text + ")";
            DBConnect.RunSQL(sql);
            LoadDataGridView();
            //// Cập nhật lại số lượng của mặt hàng vào bảng tblHang
            SLcon = sl - Convert.ToDouble(txtSoLuong.Text);
            sql = "UPDATE TblSanPham SET Soluong =" + SLcon + " WHERE Masanpham= N'" + cboMaHang.SelectedValue + "'";
            DBConnect.RunSQL(sql);
            //// Cập nhật lại tổng tiền cho hóa đơn bán
            tong = Convert.ToDouble(DBConnect.GetFieldValues1("SELECT sum(Thanhtien) FROM TblChiTietHDBan WHERE Mahdban = N'" + txtMaHDBan.Text + "'"));
            txtTongTien1.Text = tong.ToString();
            sql = "UPDATE TblHoaDonBan SET Tongtien =" + txtTongTien1.Text + " WHERE Mahdban = N'" + txtMaHDBan.Text + "'";
            DBConnect.thucthisql(sql);
            btnluu.Enabled = true;
            btnthem.Enabled = true;
           
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            double sl, slcon, slxoa;
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "SELECT Masanpham,Soluong FROM TblChiTietHDBan WHERE Mahdban = N'" + txtMaHDBan.Text + "'";
                DataTable tblHang = DBConnect.GetDataToTable(sql);
                for (int hang = 0; hang <= tblHang.Rows.Count - 1; hang++)
                {
                    // Cập nhật lại số lượng cho các mặt hàng
                    sl = Convert.ToDouble(DBConnect.GetFieldValues1("SELECT Soluong FROM TblSanPham WHERE Masanpham = N'" + tblHang.Rows[hang][0].ToString() + "'"));
                    slxoa = Convert.ToDouble(tblHang.Rows[hang][1].ToString());
                    slcon = sl + slxoa;
                    sql = "UPDATE TblSanPham SET Soluong =" + slcon + " WHERE Masanpham= N'" + tblHang.Rows[hang][0].ToString() + "'";
                    DBConnect.RunSQL(sql);
                }

                //Xóa chi tiết hóa đơn
                sql = "DELETE TblChiTietHDBan WHERE Mahdban=N'" + txtMaHDBan.Text + "'";
                DBConnect.RunSQL(sql);

                //Xóa hóa đơn
                sql = "DELETE TblHoaDonBan WHERE Mahdban=N'" + txtMaHDBan.Text + "'";
                DBConnect.RunSQL(sql);
               
                LoadDataGridView();
               
            }
        }
        private void btnrefresh_Click(object sender, EventArgs e)
        {
            txtMaHDBan.Text = "";
            txtngayban.Text = "";
            cboMaNhanVien.Text = "";
            txttennv.Text = "";
            cboMaKhach.Text = "";
            txttenkh.Text = "";
            txtdiachikh.Text = "";
            txtsdtkh.Text = "";
            cboMaHang.Text = "";
            txttensp.Text = "";
            txtSoLuong.Text="";
            txtDonGiaBan.Text="";
            textBoxX1.Text = "";
            txtGiamGia.Text = "";
            txtTongTien.Text = "";
            dataGridViewX1.Visible = false;
            btnluu.Enabled = false;
            btninhoadon.Enabled = false;
            btnxoa.Enabled = false;

        }

        private void btninhoadon_Click(object sender, EventArgs e)
        {
            // Khởi động chương trình Excel
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblThongtinHD, tblThongtinHang;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:Z300"].Font.Name = "Times new roman"; //Font chữ
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "Shop Quản Lý Bán Hàng ABC";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Quận 12 - Sài Gòn";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: 0976972771";
            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "HÓA ĐƠN BÁN HÀNG";
            // Biểu diễn thông tin chung của hóa đơn bán
            sql = "SELECT a.Mahdban, a.Ngayban, a.Tongtien, b.Tenkhachhang, b.Diachi, b.Dienthoai, c.Tennhanvien FROM TblHoaDonBan AS a, TblKhachHang AS b, TblNhanVien AS c WHERE a.Mahdban = N'" + txtMaHDBan.Text + "' AND a.Makhachhang = b.Makhachhang AND a.Manhanvien = c.Manhanvien";
            tblThongtinHD = DBConnect.GetDataToTable(sql);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:B6"].Value = "Mã hóa đơn:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Khách hàng:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0][3].ToString();
            exRange.Range["B8:B8"].Value = "Địa chỉ:";
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = tblThongtinHD.Rows[0][4].ToString();
            exRange.Range["B9:B9"].Value = "Điện thoại:";
            exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:E9"].Value = tblThongtinHD.Rows[0][5].ToString();
            //Lấy thông tin các mặt hàng
            sql = "SELECT b.Tensanpham, a.Soluong, b.Dongiaban, a.Giamgia, a.Thanhtien " +
                  "FROM TblChiTietHDBan AS a , TblSanPham AS b WHERE a.Mahdban = N'" +
                  txtMaHDBan.Text + "' AND a.Masanpham = b.Masanpham";
            tblThongtinHang = DBConnect.GetDataToTable(sql);
            //Tạo dòng tiêu đề bảng
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Tên hàng";
            exRange.Range["C11:C11"].Value = "Số lượng";
            exRange.Range["D11:D11"].Value = "Đơn giá";
            exRange.Range["E11:E11"].Value = "Giảm giá";
            exRange.Range["F11:F11"].Value = "Thành tiền";
            exRange.Range["B11:B11"].ColumnWidth = 45;
            for (hang = 0; hang < tblThongtinHang.Rows.Count; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot < tblThongtinHang.Columns.Count; cot++)
                //Điền thông tin hàng từ cột thứ 2, dòng 12
                {
                    exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString();
                    if (cot == 3) exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString() + "%";
                }
            }
            exRange = exSheet.Cells[cot][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng tiền:";
            exRange = exSheet.Cells[cot + 1][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = tblThongtinHD.Rows[0][2].ToString();
            exRange = exSheet.Cells[1][hang + 15]; //Ô A1 
            exRange.Range["A1:F1"].MergeCells = true;
            exRange.Range["A1:F1"].Font.Bold = true;
            exRange.Range["A1:F1"].Font.Italic = true;
            exRange.Range["A1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
            exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = Convert.ToDateTime(tblThongtinHD.Rows[0][1]);
            exRange.Range["A1:C1"].Value = "Hà Nội, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Nhân viên bán hàng";
            exRange.Range["A6:C6"].MergeCells = true;
            exRange.Range["A6:C6"].Font.Italic = true;
            exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A6:C6"].Value = tblThongtinHD.Rows[0][6];
            exSheet.Name = "Hóa đơn nhập";
            exApp.Visible = true;
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            if (cboMaHDBan.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một mã hóa đơn để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaHDBan.Focus();
                return;
            }
            txtMaHDBan.Text = cboMaHDBan.Text;
            LoadInfoHoaDon();
            LoadDataGridView();
            cboMaHDBan.SelectedIndex = -1;
            btninhoadon.Enabled = true;
            btnxoa.Enabled = true;
            dataGridViewX1.Visible = true;
        }
        private void cboKhangHang_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMaKhach.Text == "")
            {
                txttenkh.Text = "";
                txtdiachikh.Text = "";
                txtsdtkh.Text = "";
            }
            //Khi chọn Mã khách hàng thì các thông tin của khách hàng sẽ hiện ra
            str = "Select Tenkhachhang from TblKhachHang where Makhachhang = N'" + cboMaKhach.SelectedValue + "'";
            txttenkh.Text = DBConnect.GetFieldValues1(str);
            str = "Select Diachi from TblKhachHang where Makhachhang = N'" + cboMaKhach.SelectedValue + "'";
            txtdiachikh.Text = DBConnect.GetFieldValues1(str);
            str = "Select Dienthoai from TblKhachHang where Makhachhang= N'" + cboMaKhach.SelectedValue + "'";
            txtsdtkh.Text = DBConnect.GetFieldValues1(str);
        }

        private void cboNhanvien_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMaNhanVien.Text == "")
                txttennv.Text = "";
            // Khi chọn Mã nhân viên thì tên nhân viên tự động hiện ra
            str = "Select Tennhanvien from TblNhanVien where Manhanvien =N'" + cboMaNhanVien.SelectedValue + "'";
            txttennv.Text = DBConnect.GetFieldValues1(str);
        }

        private void cboMasanpham_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMaHang.Text == "")
            {
                txttensp.Text = "";
                txtDonGiaBan.Text = "";
                textBoxX1.Text = "";
            }
            // Khi chọn mã hàng thì các thông tin về hàng hiện ra
            str = "SELECT Tensanpham FROM TblSanPham WHERE Masanpham =N'" + cboMaHang.SelectedValue + "'";
            txttensp.Text = DBConnect.GetFieldValues1(str);
            str = "SELECT Dongiaban FROM TblSanPham WHERE Masanpham =N'" + cboMaHang.SelectedValue + "'";
            txtDonGiaBan.Text = DBConnect.GetFieldValues1(str);
            str = "SELECT Ghichu FROM TblSanPham WHERE Masanpham =N'" + cboMaHang.SelectedValue + "'";
            textBoxX1.Text = DBConnect.GetFieldValues1(str);

        }

        private void txtsoluong_TextChanged(object sender, EventArgs e)
        {
            //Khi thay đổi số lượng thì thực hiện tính lại thành tiền
            double tt, sl, dg, gg;
            if (txtSoLuong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoLuong.Text);
            if (txtGiamGia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtGiamGia.Text);
            if (txtDonGiaBan.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDonGiaBan.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtTongTien.Text = tt.ToString();
        }

        private void txtgiamgia_TextChanged(object sender, EventArgs e)
        {
            //Khi thay đổi giảm giá thì tính lại thành tiền
            double tt, sl, dg, gg;
            if (txtSoLuong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoLuong.Text);
            if (txtGiamGia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtGiamGia.Text);
            if (txtDonGiaBan.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDonGiaBan.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtTongTien.Text = tt.ToString();
        }

        private void comboBoxEx1_DropDown(object sender, EventArgs e)
        {
            DBConnect.FillCombo("SELECT Mahdban FROM TblHoaDonBan", cboMaHDBan, "Mahdban", "Mahdban");
            cboMaHDBan.SelectedIndex = -1;
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGiamGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dataGridViewX1_DoubleClick(object sender, EventArgs e)
        {
            string MaHangxoa, sql;
            Double ThanhTienxoa, SoLuongxoa, sl, slcon, tong, tongmoi;
            if (tblCTHDB.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                //Xóa hàng và cập nhật lại số lượng hàng 
                MaHangxoa = dataGridViewX1.CurrentRow.Cells["Masanpham"].Value.ToString();
                SoLuongxoa = Convert.ToDouble(dataGridViewX1.CurrentRow.Cells["SoLuong"].Value.ToString());
                ThanhTienxoa = Convert.ToDouble(dataGridViewX1.CurrentRow.Cells["ThanhTien"].Value.ToString());
                sql = "DELETE TblChiTietHDBan WHERE Mahdban=N'" + txtMaHDBan.Text + "' AND Masanpham = N'" + MaHangxoa + "'";
                DBConnect.RunSQL(sql);
                // Cập nhật lại số lượng cho các mặt hàng
                sl = Convert.ToDouble(DBConnect.GetFieldValues1("SELECT Soluong FROM TblSanPham WHERE Masanpham = N'" + MaHangxoa + "'"));
                slcon = sl + SoLuongxoa;
                sql = "UPDATE TblSanPham SET Soluong =" + slcon + " WHERE Masanpham= N'" + MaHangxoa + "'";
                DBConnect.RunSQL(sql);
                // Cập nhật lại tổng tiền cho hóa đơn bán
                tong = Convert.ToDouble(DBConnect.GetFieldValues1("SELECT Tongtien FROM TblHoaDonBan WHERE Mahdban = N'" + txtMaHDBan.Text + "'"));
                tongmoi = tong - ThanhTienxoa;
                sql = "UPDATE TblHoaDonBan SET Tongtien =" + tongmoi + " WHERE Mahdban = N'" + txtMaHDBan.Text + "'";
                DBConnect.RunSQL(sql);
                txtTongTien.Text = tongmoi.ToString();
                LoadDataGridView();
               
            }
        }
    }
}
