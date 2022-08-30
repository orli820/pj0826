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
    public partial class Language : Form
    {
        電影語言MovieLanguage 電影語言MovieLanguage = new 電影語言MovieLanguage();
        電影代碼MovieCode 電影代碼MovieCode = new 電影代碼MovieCode();
        MDAEntities2 db = new MDAEntities2();

        public Language()
        {
            InitializeComponent();
        }

        private void btnLanguageAdd_Click(object sender, EventArgs e)
        {

            if (txtLanguage.Text == "")
                return;
            var q = (from p in this.db.電影語言MovieLanguage
                     where p.語言名稱Language_Name == txtLanguage.Text
                     select p).Any();
            if (q)
            {
                MessageBox.Show("語言重複");
                return;
            }

            電影語言MovieLanguage.語言名稱Language_Name = txtLanguage.Text;
            this.db.電影語言MovieLanguage.Add(電影語言MovieLanguage);
            this.db.SaveChanges();
            labChage.Text = "新增成功";
            dataLanguage();
        }
        void dataLanguage()
        {
            var p = from r in db.電影語言MovieLanguage
                    select new { r.語言編號Language_ID, r.語言名稱Language_Name };
            var list = p.ToList();
            this.dataGridViewMovieLanguage.DataSource = list;
        }

        private void btnLanguageUpDate_Click(object sender, EventArgs e)
        {
            var q = (from p in this.db.電影語言MovieLanguage.AsEnumerable()
                     where p.語言編號Language_ID == int.Parse(dataGridViewMovieLanguage.CurrentRow.Cells["語言編號Language_ID"].Value.ToString())
                     select p).FirstOrDefault();
            q.語言名稱Language_Name = txtLanguage.Text;
            this.db.SaveChanges();
            dataLanguage();
            labChage.Text = "修改成功";
        }

        private void btnviewLanguage_Click(object sender, EventArgs e)
        {
            dataLanguage();
        }

        private void btnViewMovie_Click(object sender, EventArgs e)
        {
            var p = from r in db.電影Movies
                    select new { r.電影編號Movie_ID, r.中文標題Title_Cht, r.英文標題Title_Eng };
            var list2 = p.ToList();
            this.dataGridmMovie.DataSource = list2;
        }

        private void btnMovieCode_Click(object sender, EventArgs e)
        {
            showMovieCodeData();
        }
        void showMovieCodeData()
        {
            var p = from r in db.電影代碼MovieCode
                    select new { r.電影代碼Movie_Code, r.電影編號Movie_ID, r.語言編號Language_ID };
            var list3 = p.ToList();
            this.dataGridmMovieCode.DataSource = list3;

        }
        private void btnAddId_Click(object sender, EventArgs e)
        {
            if (txtMovieId.Text == "" || txtLanguageId.Text == "")
                return;
            電影代碼MovieCode.電影編號Movie_ID = int.Parse(txtMovieId.Text);
            電影代碼MovieCode.語言編號Language_ID = int.Parse(txtLanguageId.Text);
            this.db.電影代碼MovieCode.Add(電影代碼MovieCode);
            this.db.SaveChanges();
            labMovieCode.Text = "新增成功";
            showMovieCodeData();
        }

        private void btnUpdateId_Click(object sender, EventArgs e)
        {
            var q = (from p in this.db.電影代碼MovieCode.AsEnumerable()
                     where p.電影代碼Movie_Code == int.Parse(dataGridmMovieCode.CurrentRow.Cells["電影代碼Movie_Code"].Value.ToString())
                     select p).FirstOrDefault();
            q.電影編號Movie_ID = int.Parse(txtMovieId.Text);
            q.語言編號Language_ID = int.Parse(txtLanguageId.Text);
            this.db.SaveChanges();
            showMovieCodeData();
            labMovieCode.Text = "修改成功";
        }

        private void dataGridViewMovieImage_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtLanguageId.Text = dataGridViewMovieLanguage.CurrentRow.Cells["語言編號Language_ID"].Value.ToString();
        }

        private void dataGridmMovie_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtMovieId.Text = dataGridmMovie.CurrentRow.Cells["電影編號Movie_ID"].Value.ToString();
        }

        private void dataGridmMovieCode_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtMovieId.Text = dataGridmMovieCode.CurrentRow.Cells["電影編號Movie_ID"].Value.ToString();
            txtLanguageId.Text = dataGridmMovieCode.CurrentRow.Cells["語言編號Language_ID"].Value.ToString();
        }

    }   
}
