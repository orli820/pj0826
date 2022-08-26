
namespace WindowsFormsApp3
{
    partial class Poster
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ptbshow = new System.Windows.Forms.PictureBox();
            this.btnADDMOVIE = new System.Windows.Forms.Button();
            this.btnMovieUpDate = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridViewMovieImage = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.labshowpicture = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMovieId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtImageId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewMovie = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lab = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridViewMovieImageList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ptbshow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovieImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovieImageList)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbshow
            // 
            this.ptbshow.BackColor = System.Drawing.Color.White;
            this.ptbshow.Location = new System.Drawing.Point(53, 191);
            this.ptbshow.Margin = new System.Windows.Forms.Padding(4);
            this.ptbshow.Name = "ptbshow";
            this.ptbshow.Size = new System.Drawing.Size(388, 306);
            this.ptbshow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbshow.TabIndex = 2;
            this.ptbshow.TabStop = false;
            this.ptbshow.Click += new System.EventHandler(this.pictureshow_Click);
            // 
            // btnADDMOVIE
            // 
            this.btnADDMOVIE.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnADDMOVIE.Location = new System.Drawing.Point(53, 88);
            this.btnADDMOVIE.Margin = new System.Windows.Forms.Padding(4);
            this.btnADDMOVIE.Name = "btnADDMOVIE";
            this.btnADDMOVIE.Size = new System.Drawing.Size(111, 57);
            this.btnADDMOVIE.TabIndex = 27;
            this.btnADDMOVIE.Text = "新增";
            this.btnADDMOVIE.UseVisualStyleBackColor = true;
            this.btnADDMOVIE.Click += new System.EventHandler(this.btnAddImage);
            // 
            // btnMovieUpDate
            // 
            this.btnMovieUpDate.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMovieUpDate.Location = new System.Drawing.Point(192, 88);
            this.btnMovieUpDate.Margin = new System.Windows.Forms.Padding(4);
            this.btnMovieUpDate.Name = "btnMovieUpDate";
            this.btnMovieUpDate.Size = new System.Drawing.Size(111, 57);
            this.btnMovieUpDate.TabIndex = 28;
            this.btnMovieUpDate.Text = "修改";
            this.btnMovieUpDate.UseVisualStyleBackColor = true;
            this.btnMovieUpDate.Click += new System.EventHandler(this.btnUpdateImage);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridViewMovieImage
            // 
            this.dataGridViewMovieImage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovieImage.Location = new System.Drawing.Point(492, 191);
            this.dataGridViewMovieImage.Name = "dataGridViewMovieImage";
            this.dataGridViewMovieImage.RowHeadersWidth = 51;
            this.dataGridViewMovieImage.RowTemplate.Height = 27;
            this.dataGridViewMovieImage.Size = new System.Drawing.Size(282, 306);
            this.dataGridViewMovieImage.TabIndex = 29;
            this.dataGridViewMovieImage.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseUp);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(492, 97);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 56);
            this.button1.TabIndex = 31;
            this.button1.Text = "檢視圖片庫";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnShowImageData);
            // 
            // labshowpicture
            // 
            this.labshowpicture.AutoSize = true;
            this.labshowpicture.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labshowpicture.Location = new System.Drawing.Point(64, 149);
            this.labshowpicture.Name = "labshowpicture";
            this.labshowpicture.Size = new System.Drawing.Size(102, 38);
            this.labshowpicture.TabIndex = 32;
            this.labshowpicture.Text = "label1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(53, 530);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(721, 339);
            this.flowLayoutPanel1.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(24, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 50);
            this.label2.TabIndex = 35;
            this.label2.Text = "圖片庫";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(1267, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 61);
            this.label1.TabIndex = 36;
            this.label1.Text = "電影海報";
            // 
            // txtMovieId
            // 
            this.txtMovieId.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMovieId.Location = new System.Drawing.Point(1516, 111);
            this.txtMovieId.Margin = new System.Windows.Forms.Padding(4);
            this.txtMovieId.Name = "txtMovieId";
            this.txtMovieId.Size = new System.Drawing.Size(162, 34);
            this.txtMovieId.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(1341, 180);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 25);
            this.label5.TabIndex = 45;
            this.label5.Text = "圖片編號Image";
            // 
            // txtImageId
            // 
            this.txtImageId.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtImageId.Location = new System.Drawing.Point(1516, 171);
            this.txtImageId.Margin = new System.Windows.Forms.Padding(4);
            this.txtImageId.Name = "txtImageId";
            this.txtImageId.Size = new System.Drawing.Size(162, 34);
            this.txtImageId.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(1332, 114);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 25);
            this.label6.TabIndex = 44;
            this.label6.Text = "電影編號Movie_ID";
            // 
            // dataGridViewMovie
            // 
            this.dataGridViewMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovie.Location = new System.Drawing.Point(807, 191);
            this.dataGridViewMovie.Name = "dataGridViewMovie";
            this.dataGridViewMovie.RowHeadersWidth = 51;
            this.dataGridViewMovie.RowTemplate.Height = 27;
            this.dataGridViewMovie.Size = new System.Drawing.Size(438, 678);
            this.dataGridViewMovie.TabIndex = 46;
            this.dataGridViewMovie.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseUp);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(807, 97);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 56);
            this.button2.TabIndex = 47;
            this.button2.Text = "檢視電影";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnShowMovieData);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(1731, 160);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 51);
            this.button3.TabIndex = 49;
            this.button3.Text = "修改";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnUpdateMovieId);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.Location = new System.Drawing.Point(1731, 91);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 51);
            this.button4.TabIndex = 48;
            this.button4.Text = "新增";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnAddMovieId);
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab.Location = new System.Drawing.Point(1391, 227);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(102, 38);
            this.lab.TabIndex = 50;
            this.lab.Text = "label1";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button5.Location = new System.Drawing.Point(1387, 291);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(244, 56);
            this.button5.TabIndex = 51;
            this.button5.Text = "檢視電影圖片";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btnShowImageListData);
            // 
            // dataGridViewMovieImageList
            // 
            this.dataGridViewMovieImageList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovieImageList.Location = new System.Drawing.Point(1387, 368);
            this.dataGridViewMovieImageList.Name = "dataGridViewMovieImageList";
            this.dataGridViewMovieImageList.RowHeadersWidth = 51;
            this.dataGridViewMovieImageList.RowTemplate.Height = 27;
            this.dataGridViewMovieImageList.Size = new System.Drawing.Size(438, 489);
            this.dataGridViewMovieImageList.TabIndex = 52;
            this.dataGridViewMovieImageList.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView3_CellMouseUp);
            // 
            // Poster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1026);
            this.Controls.Add(this.dataGridViewMovieImageList);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridViewMovie);
            this.Controls.Add(this.txtMovieId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtImageId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewMovieImage);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.labshowpicture);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMovieUpDate);
            this.Controls.Add(this.btnADDMOVIE);
            this.Controls.Add(this.ptbshow);
            this.Name = "Poster";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ptbshow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovieImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovieImageList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbshow;
        private System.Windows.Forms.Button btnADDMOVIE;
        private System.Windows.Forms.Button btnMovieUpDate;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridViewMovieImage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labshowpicture;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMovieId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtImageId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewMovie;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridViewMovieImageList;
    }
}

