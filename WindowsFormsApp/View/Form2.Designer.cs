namespace WindowsFormsApp.View
{
    partial class Form2
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
            this.txtsodt = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtdiachi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txttenkh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtmakh = new DevComponents.DotNetBar.Controls.TextBoxX();
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
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.txtsodt);
            this.groupBox1.Controls.Add(this.txtdiachi);
            this.groupBox1.Controls.Add(this.txttenkh);
            this.groupBox1.Controls.Add(this.txtmakh);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 221);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // txtsodt
            // 
            // 
            // 
            // 
            this.txtsodt.Border.Class = "TextBoxBorder";
            this.txtsodt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtsodt.Location = new System.Drawing.Point(119, 168);
            this.txtsodt.Name = "txtsodt";
            this.txtsodt.Size = new System.Drawing.Size(100, 23);
            this.txtsodt.TabIndex = 4;
            this.txtsodt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsodt_KeyPress);
            // 
            // txtdiachi
            // 
            // 
            // 
            // 
            this.txtdiachi.Border.Class = "TextBoxBorder";
            this.txtdiachi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtdiachi.Location = new System.Drawing.Point(119, 122);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(100, 23);
            this.txtdiachi.TabIndex = 3;
            // 
            // txttenkh
            // 
            // 
            // 
            // 
            this.txttenkh.Border.Class = "TextBoxBorder";
            this.txttenkh.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txttenkh.Location = new System.Drawing.Point(119, 75);
            this.txttenkh.Name = "txttenkh";
            this.txttenkh.Size = new System.Drawing.Size(100, 23);
            this.txttenkh.TabIndex = 2;
            // 
            // txtmakh
            // 
            // 
            // 
            // 
            this.txtmakh.Border.Class = "TextBoxBorder";
            this.txtmakh.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtmakh.Enabled = false;
            this.txtmakh.Location = new System.Drawing.Point(119, 29);
            this.txtmakh.Name = "txtmakh";
            this.txtmakh.Size = new System.Drawing.Size(100, 23);
            this.txtmakh.TabIndex = 1;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(14, 172);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(86, 19);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Số điện thoại";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(15, 122);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(48, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Địa chỉ";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(15, 79);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(98, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Tên khách hàng";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(15, 33);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(98, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Mã khách hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewX1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(270, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(507, 154);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách khách hàng";
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.dataGridViewX1.Size = new System.Drawing.Size(495, 126);
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
            this.groupBox5.Location = new System.Drawing.Point(270, 223);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(507, 61);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chức năng";
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(423, 22);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(75, 23);
            this.btnrefresh.TabIndex = 16;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseSelectable = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btnview
            // 
            this.btnview.Location = new System.Drawing.Point(342, 22);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(75, 23);
            this.btnview.TabIndex = 9;
            this.btnview.Text = "View data";
            this.btnview.UseSelectable = true;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(18, 22);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 5;
            this.btnthem.Text = "Add new";
            this.btnthem.UseSelectable = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(99, 22);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 6;
            this.btnluu.Text = "Save";
            this.btnluu.UseSelectable = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(180, 22);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 7;
            this.btnxoa.Text = "Delete";
            this.btnxoa.UseSelectable = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(261, 22);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 8;
            this.btnsua.Text = "Update";
            this.btnsua.UseSelectable = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 304);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Resizable = false;
            this.Text = "Quản Lý Khách Hàng";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtsodt;
        private DevComponents.DotNetBar.Controls.TextBoxX txtdiachi;
        private DevComponents.DotNetBar.Controls.TextBoxX txttenkh;
        private DevComponents.DotNetBar.Controls.TextBoxX txtmakh;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
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