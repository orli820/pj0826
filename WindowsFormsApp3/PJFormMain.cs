using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3;

namespace Movie
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void BtnMovie_Click(object sender, EventArgs e)
        {
            Language viewLanguage =new Language();
            viewLanguage.MdiParent = this;
            viewLanguage.WindowState = FormWindowState.Maximized;
            viewLanguage.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Poster viewposter = new Poster();
            viewposter.MdiParent = this;
            viewposter.WindowState = FormWindowState.Maximized;
            viewposter.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Coupon viewBonus = new Coupon();
            viewBonus.MdiParent = this;
            viewBonus.WindowState = FormWindowState.Maximized;
            viewBonus.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            CouponList viewcplist = new CouponList();
            viewcplist.MdiParent = this;
            viewcplist.WindowState = FormWindowState.Maximized;
            viewcplist.Show();
        }
    }
 }

