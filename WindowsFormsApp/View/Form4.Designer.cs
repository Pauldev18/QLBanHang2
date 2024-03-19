namespace WindowsFormsApp.View
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGhiChu = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.comboItem5 = new DevComponents.Editors.ComboItem();
            this.txtAnh = new System.Windows.Forms.TextBox();
            this.cboMaSanPham = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtDonGiaBan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDonGiaNhap = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtSoLuong = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTenHang = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMaHang = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnopen = new MetroFramework.Controls.MetroButton();
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnrefresh = new MetroFramework.Controls.MetroButton();
            this.btnview = new MetroFramework.Controls.MetroButton();
            this.btnthem = new MetroFramework.Controls.MetroButton();
            this.btnluu = new MetroFramework.Controls.MetroButton();
            this.btnxoa = new MetroFramework.Controls.MetroButton();
            this.btnsua = new MetroFramework.Controls.MetroButton();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.txtAnh);
            this.groupBox1.Controls.Add(this.cboMaSanPham);
            this.groupBox1.Controls.Add(this.txtDonGiaBan);
            this.groupBox1.Controls.Add(this.txtDonGiaNhap);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.txtTenHang);
            this.groupBox1.Controls.Add(this.txtMaHang);
            this.groupBox1.Controls.Add(this.btnopen);
            this.groupBox1.Controls.Add(this.picAnh);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.metroLabel9);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1222, 168);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.DisplayMember = "Text";
            this.txtGhiChu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtGhiChu.FormattingEnabled = true;
            this.txtGhiChu.ItemHeight = 17;
            this.txtGhiChu.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2,
            this.comboItem3,
            this.comboItem4,
            this.comboItem5});
            this.txtGhiChu.Location = new System.Drawing.Point(738, 90);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(113, 23);
            this.txtGhiChu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtGhiChu.TabIndex = 10;
            // 
            // comboItem1
            // 
            this.comboItem1.FontSize = 9F;
            this.comboItem1.FontStyle = System.Drawing.FontStyle.Italic;
            this.comboItem1.Text = "Hàng mới nhập";
            // 
            // comboItem2
            // 
            this.comboItem2.FontStyle = System.Drawing.FontStyle.Italic;
            this.comboItem2.Text = "Hàng tồn kho";
            // 
            // comboItem3
            // 
            this.comboItem3.FontStyle = System.Drawing.FontStyle.Italic;
            this.comboItem3.Text = "Hàng bị lỗi";
            // 
            // comboItem4
            // 
            this.comboItem4.FontStyle = System.Drawing.FontStyle.Italic;
            this.comboItem4.Text = "Hàng thanh lý";
            // 
            // comboItem5
            // 
            this.comboItem5.FontStyle = System.Drawing.FontStyle.Italic;
            this.comboItem5.Text = "Hàng đã nhập";
            // 
            // txtAnh
            // 
            this.txtAnh.Enabled = false;
            this.txtAnh.Location = new System.Drawing.Point(738, 31);
            this.txtAnh.Multiline = true;
            this.txtAnh.Name = "txtAnh";
            this.txtAnh.Size = new System.Drawing.Size(234, 43);
            this.txtAnh.TabIndex = 7;
            // 
            // cboMaSanPham
            // 
            this.cboMaSanPham.DisplayMember = "Text";
            this.cboMaSanPham.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMaSanPham.FormattingEnabled = true;
            this.cboMaSanPham.ItemHeight = 17;
            this.cboMaSanPham.Location = new System.Drawing.Point(163, 119);
            this.cboMaSanPham.Name = "cboMaSanPham";
            this.cboMaSanPham.Size = new System.Drawing.Size(100, 23);
            this.cboMaSanPham.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboMaSanPham.TabIndex = 3;
            // 
            // txtDonGiaBan
            // 
            // 
            // 
            // 
            this.txtDonGiaBan.Border.Class = "TextBoxBorder";
            this.txtDonGiaBan.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDonGiaBan.Location = new System.Drawing.Point(548, 122);
            this.txtDonGiaBan.Name = "txtDonGiaBan";
            this.txtDonGiaBan.Size = new System.Drawing.Size(100, 23);
            this.txtDonGiaBan.TabIndex = 6;
            this.txtDonGiaBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGiaBan_KeyPress);
            // 
            // txtDonGiaNhap
            // 
            // 
            // 
            // 
            this.txtDonGiaNhap.Border.Class = "TextBoxBorder";
            this.txtDonGiaNhap.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDonGiaNhap.Location = new System.Drawing.Point(548, 80);
            this.txtDonGiaNhap.Name = "txtDonGiaNhap";
            this.txtDonGiaNhap.Size = new System.Drawing.Size(100, 23);
            this.txtDonGiaNhap.TabIndex = 5;
            
            this.txtDonGiaNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGiaNhap_KeyPress);
            // 
            // txtSoLuong
            // 
            // 
            // 
            // 
            this.txtSoLuong.Border.Class = "TextBoxBorder";
            this.txtSoLuong.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSoLuong.Location = new System.Drawing.Point(548, 37);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(100, 23);
            this.txtSoLuong.TabIndex = 4;
        
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // txtTenHang
            // 
            // 
            // 
            // 
            this.txtTenHang.Border.Class = "TextBoxBorder";
            this.txtTenHang.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenHang.Location = new System.Drawing.Point(163, 77);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(257, 23);
            this.txtTenHang.TabIndex = 2;
            // 
            // txtMaHang
            // 
            // 
            // 
            // 
            this.txtMaHang.Border.Class = "TextBoxBorder";
            this.txtMaHang.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaHang.Enabled = false;
            this.txtMaHang.Location = new System.Drawing.Point(163, 32);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(100, 23);
            this.txtMaHang.TabIndex = 1;
            // 
            // btnopen
            // 
            this.btnopen.Location = new System.Drawing.Point(916, 126);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(75, 23);
            this.btnopen.TabIndex = 9;
            this.btnopen.Text = "Open";
            this.btnopen.UseSelectable = true;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // picAnh
            // 
            this.picAnh.Location = new System.Drawing.Point(1006, 32);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(210, 110);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnh.TabIndex = 4;
            this.picAnh.TabStop = false;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(662, 90);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(52, 19);
            this.metroLabel8.TabIndex = 2;
            this.metroLabel8.Text = "Ghi chú";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(710, 126);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(181, 19);
            this.metroLabel9.TabIndex = 1;
            this.metroLabel9.Text = "Thêm hình ảnh cho sản phẩm";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(662, 32);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(60, 19);
            this.metroLabel7.TabIndex = 1;
            this.metroLabel7.Text = "Hình ảnh";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(426, 126);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(81, 19);
            this.metroLabel6.TabIndex = 0;
            this.metroLabel6.Text = "Đơn giá bán";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(426, 80);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(88, 19);
            this.metroLabel5.TabIndex = 0;
            this.metroLabel5.Text = "Đơn giá nhập";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(426, 37);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(62, 19);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Số lượng";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(41, 122);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(114, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Mã loại sản phẩm";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(41, 77);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(89, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Tên sản phẩm";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(41, 32);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(89, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Mã sản phẩm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewX1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(23, 237);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1222, 225);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sản phẩm";
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewX1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(6, 17);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.Size = new System.Drawing.Size(1210, 202);
            this.dataGridViewX1.TabIndex = 0;
            this.dataGridViewX1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewX1_CellClick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnrefresh);
            this.groupBox5.Controls.Add(this.btnview);
            this.groupBox5.Controls.Add(this.btnthem);
            this.groupBox5.Controls.Add(this.btnluu);
            this.groupBox5.Controls.Add(this.btnxoa);
            this.groupBox5.Controls.Add(this.btnsua);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(308, 468);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(676, 61);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chức năng";
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(574, 23);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(75, 23);
            this.btnrefresh.TabIndex = 16;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseSelectable = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btnview
            // 
            this.btnview.Location = new System.Drawing.Point(471, 23);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(75, 23);
            this.btnview.TabIndex = 9;
            this.btnview.Text = "View data";
            this.btnview.UseSelectable = true;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(43, 22);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 5;
            this.btnthem.Text = "Add new";
            this.btnthem.UseSelectable = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(150, 22);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 6;
            this.btnluu.Text = "Save";
            this.btnluu.UseSelectable = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(255, 22);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 7;
            this.btnxoa.Text = "Delete";
            this.btnxoa.UseSelectable = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(360, 22);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 8;
            this.btnsua.Text = "Update";
            this.btnsua.UseSelectable = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 554);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.Resizable = false;
            this.Text = "Quản Lý Sản Phẩm";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton btnopen;
        private System.Windows.Forms.PictureBox picAnh;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TextBox txtAnh;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboMaSanPham;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDonGiaBan;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDonGiaNhap;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSoLuong;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenHang;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaHang;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private System.Windows.Forms.GroupBox groupBox5;
        private MetroFramework.Controls.MetroButton btnrefresh;
        private MetroFramework.Controls.MetroButton btnview;
        private MetroFramework.Controls.MetroButton btnthem;
        private MetroFramework.Controls.MetroButton btnluu;
        private MetroFramework.Controls.MetroButton btnxoa;
        private MetroFramework.Controls.MetroButton btnsua;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private DevComponents.DotNetBar.Controls.ComboBoxEx txtGhiChu;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.Editors.ComboItem comboItem5;
    }
}