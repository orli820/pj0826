
namespace WindowsFormsApp3
{
    partial class Language
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
            this.btnLanguageAdd = new System.Windows.Forms.Button();
            this.btnLanguageUpDate = new System.Windows.Forms.Button();
            this.dataGridViewMovieLanguage = new System.Windows.Forms.DataGridView();
            this.labChage = new System.Windows.Forms.Label();
            this.txtLanguage = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnviewLanguage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridmMovie = new System.Windows.Forms.DataGridView();
            this.btnViewMovie = new System.Windows.Forms.Button();
            this.dataGridmMovieCode = new System.Windows.Forms.DataGridView();
            this.btnMovieCode = new System.Windows.Forms.Button();
            this.labMovieCode = new System.Windows.Forms.Label();
            this.btnUpdateId = new System.Windows.Forms.Button();
            this.btnAddId = new System.Windows.Forms.Button();
            this.txtMovieId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLanguageId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovieLanguage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridmMovie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridmMovieCode)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLanguageAdd
            // 
            this.btnLanguageAdd.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLanguageAdd.Location = new System.Drawing.Point(65, 162);
            this.btnLanguageAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnLanguageAdd.Name = "btnLanguageAdd";
            this.btnLanguageAdd.Size = new System.Drawing.Size(100, 50);
            this.btnLanguageAdd.TabIndex = 28;
            this.btnLanguageAdd.Text = "新增";
            this.btnLanguageAdd.UseVisualStyleBackColor = true;
            this.btnLanguageAdd.Click += new System.EventHandler(this.btnLanguageAdd_Click);
            // 
            // btnLanguageUpDate
            // 
            this.btnLanguageUpDate.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLanguageUpDate.Location = new System.Drawing.Point(192, 162);
            this.btnLanguageUpDate.Margin = new System.Windows.Forms.Padding(4);
            this.btnLanguageUpDate.Name = "btnLanguageUpDate";
            this.btnLanguageUpDate.Size = new System.Drawing.Size(100, 50);
            this.btnLanguageUpDate.TabIndex = 29;
            this.btnLanguageUpDate.Text = "修改";
            this.btnLanguageUpDate.UseVisualStyleBackColor = true;
            this.btnLanguageUpDate.Click += new System.EventHandler(this.btnLanguageUpDate_Click);
            // 
            // dataGridViewMovieLanguage
            // 
            this.dataGridViewMovieLanguage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovieLanguage.Location = new System.Drawing.Point(58, 290);
            this.dataGridViewMovieLanguage.Name = "dataGridViewMovieLanguage";
            this.dataGridViewMovieLanguage.RowHeadersWidth = 51;
            this.dataGridViewMovieLanguage.RowTemplate.Height = 27;
            this.dataGridViewMovieLanguage.Size = new System.Drawing.Size(401, 392);
            this.dataGridViewMovieLanguage.TabIndex = 30;
            this.dataGridViewMovieLanguage.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewMovieImage_CellMouseUp);
            // 
            // labChage
            // 
            this.labChage.AutoSize = true;
            this.labChage.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labChage.Location = new System.Drawing.Point(344, 174);
            this.labChage.Name = "labChage";
            this.labChage.Size = new System.Drawing.Size(102, 38);
            this.labChage.TabIndex = 55;
            this.labChage.Text = "label1";
           
            // 
            // txtLanguage
            // 
            this.txtLanguage.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLanguage.Location = new System.Drawing.Point(314, 108);
            this.txtLanguage.Margin = new System.Windows.Forms.Padding(4);
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.Size = new System.Drawing.Size(162, 34);
            this.txtLanguage.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(53, 111);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(253, 25);
            this.label6.TabIndex = 53;
            this.label6.Text = "語言名稱Language_Name";
            // 
            // btnviewLanguage
            // 
            this.btnviewLanguage.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnviewLanguage.Location = new System.Drawing.Point(232, 240);
            this.btnviewLanguage.Margin = new System.Windows.Forms.Padding(4);
            this.btnviewLanguage.Name = "btnviewLanguage";
            this.btnviewLanguage.Size = new System.Drawing.Size(74, 43);
            this.btnviewLanguage.TabIndex = 56;
            this.btnviewLanguage.Text = "檢視";
            this.btnviewLanguage.UseVisualStyleBackColor = true;
            this.btnviewLanguage.Click += new System.EventHandler(this.btnviewLanguage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(27, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 50);
            this.label2.TabIndex = 57;
            this.label2.Text = "電影語言";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(555, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 50);
            this.label1.TabIndex = 58;
            this.label1.Text = "電影代碼";
            // 
            // dataGridmMovie
            // 
            this.dataGridmMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridmMovie.Location = new System.Drawing.Point(537, 201);
            this.dataGridmMovie.Name = "dataGridmMovie";
            this.dataGridmMovie.RowHeadersWidth = 51;
            this.dataGridmMovie.RowTemplate.Height = 27;
            this.dataGridmMovie.Size = new System.Drawing.Size(401, 490);
            this.dataGridmMovie.TabIndex = 59;
            this.dataGridmMovie.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridmMovie_CellMouseUp);
            // 
            // btnViewMovie
            // 
            this.btnViewMovie.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnViewMovie.Location = new System.Drawing.Point(537, 121);
            this.btnViewMovie.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewMovie.Name = "btnViewMovie";
            this.btnViewMovie.Size = new System.Drawing.Size(74, 43);
            this.btnViewMovie.TabIndex = 60;
            this.btnViewMovie.Text = "檢視";
            this.btnViewMovie.UseVisualStyleBackColor = true;
            this.btnViewMovie.Click += new System.EventHandler(this.btnViewMovie_Click);
            // 
            // dataGridmMovieCode
            // 
            this.dataGridmMovieCode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridmMovieCode.Location = new System.Drawing.Point(1100, 290);
            this.dataGridmMovieCode.Name = "dataGridmMovieCode";
            this.dataGridmMovieCode.RowHeadersWidth = 51;
            this.dataGridmMovieCode.RowTemplate.Height = 27;
            this.dataGridmMovieCode.Size = new System.Drawing.Size(401, 401);
            this.dataGridmMovieCode.TabIndex = 61;
            this.dataGridmMovieCode.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridmMovieCode_CellMouseUp);
            // 
            // btnMovieCode
            // 
            this.btnMovieCode.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMovieCode.Location = new System.Drawing.Point(1100, 221);
            this.btnMovieCode.Margin = new System.Windows.Forms.Padding(4);
            this.btnMovieCode.Name = "btnMovieCode";
            this.btnMovieCode.Size = new System.Drawing.Size(74, 43);
            this.btnMovieCode.TabIndex = 62;
            this.btnMovieCode.Text = "檢視";
            this.btnMovieCode.UseVisualStyleBackColor = true;
            this.btnMovieCode.Click += new System.EventHandler(this.btnMovieCode_Click);
            // 
            // labMovieCode
            // 
            this.labMovieCode.AutoSize = true;
            this.labMovieCode.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMovieCode.Location = new System.Drawing.Point(1342, 201);
            this.labMovieCode.Name = "labMovieCode";
            this.labMovieCode.Size = new System.Drawing.Size(102, 38);
            this.labMovieCode.TabIndex = 69;
            this.labMovieCode.Text = "label1";
            // 
            // btnUpdateId
            // 
            this.btnUpdateId.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUpdateId.Location = new System.Drawing.Point(1374, 132);
            this.btnUpdateId.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateId.Name = "btnUpdateId";
            this.btnUpdateId.Size = new System.Drawing.Size(95, 51);
            this.btnUpdateId.TabIndex = 68;
            this.btnUpdateId.Text = "修改";
            this.btnUpdateId.UseVisualStyleBackColor = true;
            this.btnUpdateId.Click += new System.EventHandler(this.btnUpdateId_Click);
            // 
            // btnAddId
            // 
            this.btnAddId.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddId.Location = new System.Drawing.Point(1374, 63);
            this.btnAddId.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddId.Name = "btnAddId";
            this.btnAddId.Size = new System.Drawing.Size(95, 51);
            this.btnAddId.TabIndex = 67;
            this.btnAddId.Text = "新增";
            this.btnAddId.UseVisualStyleBackColor = true;
            this.btnAddId.Click += new System.EventHandler(this.btnAddId_Click);
            // 
            // txtMovieId
            // 
            this.txtMovieId.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMovieId.Location = new System.Drawing.Point(1175, 77);
            this.txtMovieId.Margin = new System.Windows.Forms.Padding(4);
            this.txtMovieId.Name = "txtMovieId";
            this.txtMovieId.Size = new System.Drawing.Size(162, 34);
            this.txtMovieId.TabIndex = 63;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(938, 146);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 25);
            this.label5.TabIndex = 66;
            this.label5.Text = "語言編號Language_ID";
            // 
            // txtLanguageId
            // 
            this.txtLanguageId.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLanguageId.Location = new System.Drawing.Point(1175, 142);
            this.txtLanguageId.Margin = new System.Windows.Forms.Padding(4);
            this.txtLanguageId.Name = "txtLanguageId";
            this.txtLanguageId.Size = new System.Drawing.Size(162, 34);
            this.txtLanguageId.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(972, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 25);
            this.label3.TabIndex = 65;
            this.label3.Text = "電影編號Movie_ID";
            // 
            // Language
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1568, 717);
            this.Controls.Add(this.labMovieCode);
            this.Controls.Add(this.btnUpdateId);
            this.Controls.Add(this.btnAddId);
            this.Controls.Add(this.txtMovieId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLanguageId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMovieCode);
            this.Controls.Add(this.dataGridmMovieCode);
            this.Controls.Add(this.btnViewMovie);
            this.Controls.Add(this.dataGridmMovie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnviewLanguage);
            this.Controls.Add(this.labChage);
            this.Controls.Add(this.txtLanguage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewMovieLanguage);
            this.Controls.Add(this.btnLanguageUpDate);
            this.Controls.Add(this.btnLanguageAdd);
            this.Name = "Language";
            this.Text = "Language";
          
            ((System.ComponentModel.ISupportInitialize)(this.dataGridmMovie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridmMovieCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLanguageAdd;
        private System.Windows.Forms.Button btnLanguageUpDate;
        private System.Windows.Forms.DataGridView dataGridViewMovieLanguage;
        private System.Windows.Forms.Label labChage;
        private System.Windows.Forms.TextBox txtLanguage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnviewLanguage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridmMovie;
        private System.Windows.Forms.Button btnViewMovie;
        private System.Windows.Forms.DataGridView dataGridmMovieCode;
        private System.Windows.Forms.Button btnMovieCode;
        private System.Windows.Forms.Label labMovieCode;
        private System.Windows.Forms.Button btnUpdateId;
        private System.Windows.Forms.Button btnAddId;
        private System.Windows.Forms.TextBox txtMovieId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLanguageId;
        private System.Windows.Forms.Label label3;
    }
}