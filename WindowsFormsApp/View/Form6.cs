using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp.View
{
    public partial class Form6 : MetroFramework.Forms.MetroForm
    {
        public static string quyen;
        public Form6()
        {
            InitializeComponent();
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            DateTime tn = DateTime.Now;
            labelX3.Text = tn.ToString("dd / MM / yyyy");

            this.StyleManager = metroStyleManager1;
            metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Default;
            metroStyleManager1.Style = MetroFramework.MetroColorStyle.Green;

            quảnLýSảnPhẩmToolStripMenuItem.Enabled = false;
            quảnLýHóaĐơnToolStripMenuItem.Enabled = false;
            quảnLýNhânViênToolStripMenuItem.Enabled = false;
            quảnLýKháchHàngToolStripMenuItem.Enabled = false;
            quảnLýLoạiSảnPhẩmToolStripMenuItem.Enabled = false;
            quảnLýĐăngNhậpToolStripMenuItem.Enabled = false;
            if (quyen == "Admin")
            {
                MessageBox.Show("Bạn đang đăng nhập dưới quyền: " + quyen);
                quảnLýSảnPhẩmToolStripMenuItem.Enabled = true;
                quảnLýHóaĐơnToolStripMenuItem.Enabled = true;
                quảnLýNhânViênToolStripMenuItem.Enabled = true;
                quảnLýKháchHàngToolStripMenuItem.Enabled = true;
                quảnLýLoạiSảnPhẩmToolStripMenuItem.Enabled = true;
                quảnLýĐăngNhậpToolStripMenuItem.Enabled = true;
            }
            if (quyen == "Nhân Viên")
            {
               
                MessageBox.Show("Bạnđang đăng nhập dưới quyền: " + quyen);
                quảnLýLoạiSảnPhẩmToolStripMenuItem.Enabled = true;
                quảnLýSảnPhẩmToolStripMenuItem.Enabled = true;
                quảnLýHóaĐơnToolStripMenuItem.Enabled = true;
                quảnLýKháchHàngToolStripMenuItem.Enabled = true;
             


            }
        }
        private void quảnLýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.MdiParent = this;
            frm.Show();
        }

        private void quảnLýHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
            frm.MdiParent = this;
            frm.Show();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.MdiParent = this;
            frm.Show();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.MdiParent = this;
            frm.Show();
        }

        private void quảnLýLoạiSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.MdiParent = this;
            frm.Show();
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
           
        }

        private void quảnLýĐăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 frm = new Form8();
            frm.MdiParent = this;
            frm.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show(" Bạn có muốn thoát chương trình không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
