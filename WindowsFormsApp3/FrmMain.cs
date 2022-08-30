using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjAdoDotNetDemo
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //FRMCustomerEditor f = new FRMCustomerEditor();
            //f.MdiParent = this;    //告訴他他爸是誰
            //f.WindowState = FormWindowState.Maximized;
            //f.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //FrmProduct p = new FrmProduct();
            //p.MdiParent = this;
            //p.WindowState = FormWindowState.Maximized;
            //p.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.ActiveMdiChild.Close();
        }

        private void 水平排列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void 垂直排列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void 階梯式排列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void 關閉目前視窗ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.ActiveMdiChild!=null)  //如果不是null關閉視窗
                this.ActiveMdiChild.Close();
        }

        private void 關閉所有視窗ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            while (this.ActiveMdiChild != null)    //只要是null關閉視窗
                this.ActiveMdiChild.Close();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //(new login()).ShowDialog();
            
            
        }

        
    }
}
