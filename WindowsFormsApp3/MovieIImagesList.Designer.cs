﻿
namespace WindowsFormsApp3
{
    partial class MovieIImagesList
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
            this.dataGridViewMovieImageList = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.lab = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtMovieId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtImageId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewMovie = new System.Windows.Forms.DataGridView();
            this.dataGridViewMovieImage = new System.Windows.Forms.DataGridView();
            this.ptbshow = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovieImageList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovieImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbshow)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewMovieImageList
            // 
            this.dataGridViewMovieImageList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovieImageList.Location = new System.Drawing.Point(803, 125);
            this.dataGridViewMovieImageList.Name = "dataGridViewMovieImageList";
            this.dataGridViewMovieImageList.RowHeadersWidth = 51;
            this.dataGridViewMovieImageList.RowTemplate.Height = 27;
            this.dataGridViewMovieImageList.Size = new System.Drawing.Size(438, 798);
            this.dataGridViewMovieImageList.TabIndex = 62;
            this.dataGridViewMovieImageList.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewMovieImageList_CellMouseUp);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button5.Location = new System.Drawing.Point(64, 349);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 56);
            this.button5.TabIndex = 61;
            this.button5.Text = "檢視";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.BackColor = System.Drawing.Color.Red;
            this.lab.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab.ForeColor = System.Drawing.Color.Yellow;
            this.lab.Location = new System.Drawing.Point(405, 41);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(77, 38);
            this.lab.TabIndex = 60;
            this.lab.Text = "狀態";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(64, 178);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 54);
            this.button3.TabIndex = 59;
            this.button3.Text = "修改";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.Location = new System.Drawing.Point(64, 94);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 56);
            this.button4.TabIndex = 58;
            this.button4.Text = "新增";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtMovieId
            // 
            this.txtMovieId.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMovieId.Location = new System.Drawing.Point(530, 116);
            this.txtMovieId.Margin = new System.Windows.Forms.Padding(4);
            this.txtMovieId.Name = "txtMovieId";
            this.txtMovieId.Size = new System.Drawing.Size(162, 34);
            this.txtMovieId.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(355, 185);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 25);
            this.label5.TabIndex = 57;
            this.label5.Text = "圖片編號Image";
            // 
            // txtImageId
            // 
            this.txtImageId.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtImageId.Location = new System.Drawing.Point(530, 176);
            this.txtImageId.Margin = new System.Windows.Forms.Padding(4);
            this.txtImageId.Name = "txtImageId";
            this.txtImageId.Size = new System.Drawing.Size(162, 34);
            this.txtImageId.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(324, 125);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 25);
            this.label6.TabIndex = 56;
            this.label6.Text = "電影編號Movie_ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 61);
            this.label1.TabIndex = 53;
            this.label1.Text = "電影圖片";
            // 
            // dataGridViewMovie
            // 
            this.dataGridViewMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovie.Location = new System.Drawing.Point(360, 301);
            this.dataGridViewMovie.Name = "dataGridViewMovie";
            this.dataGridViewMovie.RowHeadersWidth = 51;
            this.dataGridViewMovie.RowTemplate.Height = 27;
            this.dataGridViewMovie.Size = new System.Drawing.Size(375, 622);
            this.dataGridViewMovie.TabIndex = 69;
            this.dataGridViewMovie.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewMovie_CellMouseUp);
            // 
            // dataGridViewMovieImage
            // 
            this.dataGridViewMovieImage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovieImage.Location = new System.Drawing.Point(1369, 125);
            this.dataGridViewMovieImage.Name = "dataGridViewMovieImage";
            this.dataGridViewMovieImage.RowHeadersWidth = 51;
            this.dataGridViewMovieImage.RowTemplate.Height = 27;
            this.dataGridViewMovieImage.Size = new System.Drawing.Size(349, 334);
            this.dataGridViewMovieImage.TabIndex = 66;
            this.dataGridViewMovieImage.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewMovieImage_CellMouseUp);
            // 
            // ptbshow
            // 
            this.ptbshow.BackColor = System.Drawing.Color.White;
            this.ptbshow.Location = new System.Drawing.Point(1369, 492);
            this.ptbshow.Margin = new System.Windows.Forms.Padding(4);
            this.ptbshow.Name = "ptbshow";
            this.ptbshow.Size = new System.Drawing.Size(484, 420);
            this.ptbshow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbshow.TabIndex = 63;
            this.ptbshow.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 946);
            this.panel1.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(355, 273);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 25);
            this.label2.TabIndex = 71;
            this.label2.Text = "電影圖片MovieIImagesList";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(798, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 72;
            this.label3.Text = "電影Movies";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(1364, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 25);
            this.label4.TabIndex = 73;
            this.label4.Text = "電影圖片總表MovieImages";
            // 
            // MovieIImagesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 946);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewMovie);
            this.Controls.Add(this.dataGridViewMovieImage);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.ptbshow);
            this.Controls.Add(this.dataGridViewMovieImageList);
            this.Controls.Add(this.txtMovieId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtImageId);
            this.Controls.Add(this.label6);
            this.Name = "MovieIImagesList";
            this.Text = "MovieIImagesList";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovieImageList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovieImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbshow)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMovieImageList;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtMovieId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtImageId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewMovie;
        private System.Windows.Forms.DataGridView dataGridViewMovieImage;
        private System.Windows.Forms.PictureBox ptbshow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}