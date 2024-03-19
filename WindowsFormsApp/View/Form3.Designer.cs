namespace WindowsFormsApp.View
{
    partial class Form3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtngaysinh = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtsodienthoai = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtdiachi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txttennhanvien = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtmanhanvien = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ckboxgioitinh = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnrefresh = new MetroFramework.Controls.MetroButton();
            this.btnview = new MetroFramework.Controls.MetroButton();
            this.btnthem = new MetroFramework.Controls.MetroButton();
            this.btnluu = new MetroFramework.Controls.MetroButton();
            this.btnxoa = new MetroFramework.Controls.MetroButton();
            this.btnsua = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtngaysinh)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtngaysinh);
            this.groupBox1.Controls.Add(this.txtsodienthoai);
            this.groupBox1.Controls.Add(this.txtdiachi);
            this.groupBox1.Controls.Add(this.txttennhanvien);
            this.groupBox1.Controls.Add(this.txtmanhanvien);
            this.groupBox1.Controls.Add(this.ckboxgioitinh);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 260);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // txtngaysinh
            // 
            // 
            // 
            // 
            this.txtngaysinh.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtngaysinh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtngaysinh.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.txtngaysinh.ButtonDropDown.Visible = true;
            this.txtngaysinh.IsPopupCalendarOpen = false;
            this.txtngaysinh.Location = new System.Drawing.Point(128, 222);
            // 
            // 
            // 
            this.txtngaysinh.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtngaysinh.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtngaysinh.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.txtngaysinh.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.txtngaysinh.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.txtngaysinh.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.txtngaysinh.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.txtngaysinh.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtngaysinh.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.txtngaysinh.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.txtngaysinh.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtngaysinh.MonthCalendar.DisplayMonth = new System.DateTime(2022, 5, 1, 0, 0, 0, 0);
            this.txtngaysinh.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.txtngaysinh.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtngaysinh.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.txtngaysinh.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.txtngaysinh.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.txtngaysinh.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtngaysinh.MonthCalendar.TodayButtonVisible = true;
            this.txtngaysinh.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.txtngaysinh.Name = "txtngaysinh";
            this.txtngaysinh.Size = new System.Drawing.Size(100, 23);
            this.txtngaysinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtngaysinh.TabIndex = 6;
            // 
            // txtsodienthoai
            // 
            // 
            // 
            // 
            this.txtsodienthoai.Border.Class = "TextBoxBorder";
            this.txtsodienthoai.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtsodienthoai.Location = new System.Drawing.Point(128, 183);
            this.txtsodienthoai.Name = "txtsodienthoai";
            this.txtsodienthoai.Size = new System.Drawing.Size(100, 23);
            this.txtsodienthoai.TabIndex = 5;
            this.txtsodienthoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsodienthoai_KeyPress);
            // 
            // txtdiachi
            // 
            // 
            // 
            // 
            this.txtdiachi.Border.Class = "TextBoxBorder";
            this.txtdiachi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtdiachi.Location = new System.Drawing.Point(128, 144);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(100, 23);
            this.txtdiachi.TabIndex = 4;
            // 
            // txttennhanvien
            // 
            // 
            // 
            // 
            this.txttennhanvien.Border.Class = "TextBoxBorder";
            this.txttennhanvien.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txttennhanvien.Location = new System.Drawing.Point(128, 69);
            this.txttennhanvien.Name = "txttennhanvien";
            this.txttennhanvien.Size = new System.Drawing.Size(100, 23);
            this.txttennhanvien.TabIndex = 2;
            // 
            // txtmanhanvien
            // 
            // 
            // 
            // 
            this.txtmanhanvien.Border.Class = "TextBoxBorder";
            this.txtmanhanvien.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtmanhanvien.Enabled = false;
            this.txtmanhanvien.Location = new System.Drawing.Point(128, 22);
            this.txtmanhanvien.Name = "txtmanhanvien";
            this.txtmanhanvien.Size = new System.Drawing.Size(100, 23);
            this.txtmanhanvien.TabIndex = 1;
            // 
            // ckboxgioitinh
            // 
            this.ckboxgioitinh.AutoSize = true;
            this.ckboxgioitinh.Location = new System.Drawing.Point(128, 112);
            this.ckboxgioitinh.Name = "ckboxgioitinh";
            this.ckboxgioitinh.Size = new System.Drawing.Size(49, 15);
            this.ckboxgioitinh.TabIndex = 3;
            this.ckboxgioitinh.Text = "Nam";
            this.ckboxgioitinh.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(11, 24);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(87, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Mã nhân viên";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(11, 183);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(86, 19);
            this.metroLabel7.TabIndex = 2;
            this.metroLabel7.Text = "Số điện thoại";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(11, 69);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(87, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Tên nhân viên";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(11, 222);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(66, 19);
            this.metroLabel6.TabIndex = 3;
            this.metroLabel6.Text = "Ngày sinh";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(11, 108);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(57, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Giới tính";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(11, 144);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(48, 19);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Địa chỉ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewX1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(272, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(676, 193);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách nhân viên";
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(6, 22);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.Size = new System.Drawing.Size(664, 165);
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
            this.groupBox5.Location = new System.Drawing.Point(272, 262);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(676, 61);
            this.groupBox5.TabIndex = 14;
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
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 341);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.Resizable = false;
            this.Text = "Quản Lý Nhân Viên";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtngaysinh)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput txtngaysinh;
        private DevComponents.DotNetBar.Controls.TextBoxX txtsodienthoai;
        private DevComponents.DotNetBar.Controls.TextBoxX txtdiachi;
        private DevComponents.DotNetBar.Controls.TextBoxX txttennhanvien;
        private DevComponents.DotNetBar.Controls.TextBoxX txtmanhanvien;
        private MetroFramework.Controls.MetroCheckBox ckboxgioitinh;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private System.Windows.Forms.GroupBox groupBox5;
        private MetroFramework.Controls.MetroButton btnrefresh;
        private MetroFramework.Controls.MetroButton btnview;
        private MetroFramework.Controls.MetroButton btnthem;
        private MetroFramework.Controls.MetroButton btnluu;
        private MetroFramework.Controls.MetroButton btnxoa;
        private MetroFramework.Controls.MetroButton btnsua;
    }
}