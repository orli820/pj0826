using Movie.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Poster : Form
    {
        圖片庫MovieImages 圖片庫MovieImage = new 圖片庫MovieImages();
        電影圖片 電影圖片MovieImageList = new 電影圖片();
        ImageToBinary picTool = new ImageToBinary();
        MDAEntities2 db = new MDAEntities2();
        public Poster()
        {
            InitializeComponent();

            if (圖片庫MovieImage.圖片Image != null)
                ptbshow.Image = picTool.ConvertToImage(圖片庫MovieImage.圖片Image);

        }

        private void pictureshow_Click(object sender, EventArgs e)
        {
            labshowpicture.Text = "";
            PictureBox pic = sender as PictureBox;
            pic.Image = null;
            openFileDialog1.FileName = "*.png;*.jpg;*.gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pic.Image = Image.FromFile(openFileDialog1.FileName);
            }

        }


        private void btnAddImage(object sender, EventArgs e)
        {
            圖片庫MovieImage.圖片Image = picTool.ConvertToByte(this.ptbshow.Image);
            this.db.圖片庫MovieImages.Add(圖片庫MovieImage);
            this.db.SaveChanges();
            ptbshow.Image = null;
            labshowpicture.Text = "新增成功";
            showdataMovieImage();
            //this.Close();
        }

        private void btnUpdateImage(object sender, EventArgs e)
        {
            var q = (from p in this.db.圖片庫MovieImages.AsEnumerable()
                     where p.圖片編號Image_ID== int.Parse(dataGridViewMovieImage.CurrentRow.Cells["圖片編號Image_ID"].Value.ToString())
            select p).FirstOrDefault();
            q.圖片Image = picTool.ConvertToByte(this.ptbshow.Image);
            this.db.SaveChanges();
            showdataMovieImage();
            labshowpicture.Text = "修改成功";
            //this.Close();
        }

        private void btnShowImageData(object sender, EventArgs e)
        {
            showdataMovieImage();


        }

        void showdataMovieImage()
        {
            var q = from p in db.圖片庫MovieImages
                    select new { p.圖片編號Image_ID, p.圖片Image };

            var list = q.ToList();
            this.dataGridViewMovieImage.DataSource = list;
            this.flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                UserControl1 us = new UserControl1();

                us.Desc = "編號：" + list[i].圖片編號Image_ID.ToString();
                us.Bytes = list[i].圖片Image;

                this.flowLayoutPanel1.Controls.Add(us);
                Application.DoEvents();
            }
        }

        void showdataMovie()
        {
            var m = from p in db.電影Movies                    
                    select new { p.電影編號Movie_ID, p.中文標題Title_Cht, p.英文標題Title_Eng };
            var list1 = m.ToList();
            this.dataGridViewMovie.DataSource = list1;
         }
        void showdataMovieImageList()
        {
            var p = from r in db.電影圖片
                    select new { r.電影圖片編號MI_ID,r.電影編號Movie_ID,r.圖片編號Pictue_ID};
            var list2 = p.ToList();
            this.dataGridViewMovieImageList.DataSource = list2;
            
        }


        private void btnShowMovieData(object sender, EventArgs e)
        {
            showdataMovie();
        }


        private void btnAddMovieId(object sender, EventArgs e)
        {
            if (txtImageId.Text == "" || txtMovieId.Text == "")
                return;
            電影圖片MovieImageList.電影編號Movie_ID = int.Parse(txtMovieId.Text);
            電影圖片MovieImageList.圖片編號Pictue_ID = int.Parse(txtImageId.Text);            
            this.db.電影圖片.Add(電影圖片MovieImageList);            
            this.db.SaveChanges();            
            lab.Text = "新增成功";
            showdataMovieImageList();
        }

        private void btnShowImageListData(object sender, EventArgs e)
        {
            showdataMovieImageList();
        }

        private void btnUpdateMovieId(object sender, EventArgs e)
        {
            var q = (from p in this.db.電影圖片.AsEnumerable()
                     where p.電影圖片編號MI_ID == int.Parse(dataGridViewMovieImageList.CurrentRow.Cells["電影圖片編號MI_ID"].Value.ToString())
                     select p).FirstOrDefault();

            
            q.電影編號Movie_ID = int.Parse(txtMovieId.Text);
            q.圖片編號Pictue_ID = int.Parse(txtImageId.Text); 
            
            this.db.SaveChanges();
            showdataMovieImageList();
            lab.Text = "修改成功";
        }


        private void dataGridView3_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
           
            txtMovieId.Text = dataGridViewMovieImageList.CurrentRow.Cells["電影編號Movie_ID"].Value.ToString();
            txtImageId.Text = dataGridViewMovieImageList.CurrentRow.Cells["圖片編號Pictue_ID"].Value.ToString();
        }

        private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            labshowpicture.Text = "編號：" + dataGridViewMovieImage.CurrentRow.Cells["圖片編號Image_ID"].Value.ToString();
            byte[] ByteData = (byte[])dataGridViewMovieImage.CurrentRow.Cells["圖片Image"].Value;
            MemoryStream ms = new MemoryStream(ByteData);
            ptbshow.Image = Image.FromStream(ms);
            ms.Close();
            txtImageId.Text = dataGridViewMovieImage.CurrentRow.Cells["圖片編號Image_ID"].Value.ToString();
        }

        private void dataGridView2_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtMovieId.Text = dataGridViewMovie.CurrentRow.Cells["電影編號Movie_ID"].Value.ToString();
        }
    }
}
