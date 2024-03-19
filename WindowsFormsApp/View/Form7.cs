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
    public partial class Form7 : MetroFramework.Forms.MetroForm
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            this.StyleManager = metroStyleManager1;
            metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Default;
            metroStyleManager1.Style = MetroFramework.MetroColorStyle.Green;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
           // SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyVatTu;Integrated Security=True");
            try
            {
                DBConnect.Connect();
                string tk = textBoxX1.Text;
                string mk = textBoxX2.Text;
                string sql = "Select * From TblLogin Where TenDangNhap ='" + tk + "' and MatKhau ='" + mk + "'";
                string name = Convert.ToString(DBConnect.GetFieldValues1("Select TenDangNhap from TblLogin where MatKhau =N'" + mk + "' "));
                string Quyen = Convert.ToString(DBConnect.GetFieldValues1("Select Quyen from TblLogin where MatKhau =N'" + mk + "' "));
                
                SqlCommand cmd = new SqlCommand(sql, DBConnect.Con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if (Convert.ToString(tk) == name)
                    {
                        Form6.quyen = Quyen;
                        MessageBox.Show("Đăng nhập thành công", "Thông Báo");
                        Form6 f = new Form6();
                        f.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập không đúng");
                    }
                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công", "Thông Báo");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }
    }
}
