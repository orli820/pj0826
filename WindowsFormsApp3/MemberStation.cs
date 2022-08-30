using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class MemberStation : Form
    {
        public MemberStation()
        {
            InitializeComponent();
            this.splitContainer1.BackColor = Color.Black;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //到首頁
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            //到會員中心
        }
    }
}
