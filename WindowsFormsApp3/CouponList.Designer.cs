
namespace WindowsFormsApp3
{
    partial class CouponList
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
            this.dataGridViewCoupon = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnviewBonus = new System.Windows.Forms.Button();
            this.dataGridViewMember = new System.Windows.Forms.DataGridView();
            this.btnViewMember = new System.Windows.Forms.Button();
            this.txtCoupon_ID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labChage = new System.Windows.Forms.Label();
            this.btnLanguageUpDate = new System.Windows.Forms.Button();
            this.btnLanguageAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmemberid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewcplist = new System.Windows.Forms.DataGridView();
            this.btnviewcplist = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoupon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcplist)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCoupon
            // 
            this.dataGridViewCoupon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCoupon.Location = new System.Drawing.Point(39, 212);
            this.dataGridViewCoupon.Name = "dataGridViewCoupon";
            this.dataGridViewCoupon.RowHeadersWidth = 51;
            this.dataGridViewCoupon.RowTemplate.Height = 27;
            this.dataGridViewCoupon.Size = new System.Drawing.Size(847, 392);
            this.dataGridViewCoupon.TabIndex = 64;
            this.dataGridViewCoupon.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewCoupon_CellMouseUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(42, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 50);
            this.label4.TabIndex = 65;
            this.label4.Text = "優惠明細";
            // 
            // btnviewBonus
            // 
            this.btnviewBonus.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnviewBonus.Location = new System.Drawing.Point(39, 144);
            this.btnviewBonus.Margin = new System.Windows.Forms.Padding(4);
            this.btnviewBonus.Name = "btnviewBonus";
            this.btnviewBonus.Size = new System.Drawing.Size(166, 43);
            this.btnviewBonus.TabIndex = 66;
            this.btnviewBonus.Text = "檢視優惠券";
            this.btnviewBonus.UseVisualStyleBackColor = true;
            this.btnviewBonus.Click += new System.EventHandler(this.btnviewBonus_Click);
            // 
            // dataGridViewMember
            // 
            this.dataGridViewMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMember.Location = new System.Drawing.Point(1582, 229);
            this.dataGridViewMember.Name = "dataGridViewMember";
            this.dataGridViewMember.RowHeadersWidth = 51;
            this.dataGridViewMember.RowTemplate.Height = 27;
            this.dataGridViewMember.Size = new System.Drawing.Size(299, 323);
            this.dataGridViewMember.TabIndex = 67;
            this.dataGridViewMember.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewMember_CellMouseUp);
            // 
            // btnViewMember
            // 
            this.btnViewMember.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnViewMember.Location = new System.Drawing.Point(1582, 160);
            this.btnViewMember.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewMember.Name = "btnViewMember";
            this.btnViewMember.Size = new System.Drawing.Size(127, 43);
            this.btnViewMember.TabIndex = 68;
            this.btnViewMember.Text = "檢視會員";
            this.btnViewMember.UseVisualStyleBackColor = true;
            this.btnViewMember.Click += new System.EventHandler(this.btnViewMember_Click);
            // 
            // txtCoupon_ID
            // 
            this.txtCoupon_ID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCoupon_ID.Location = new System.Drawing.Point(1270, 117);
            this.txtCoupon_ID.Margin = new System.Windows.Forms.Padding(4);
            this.txtCoupon_ID.Name = "txtCoupon_ID";
            this.txtCoupon_ID.Size = new System.Drawing.Size(162, 34);
            this.txtCoupon_ID.TabIndex = 81;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(990, 120);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 25);
            this.label5.TabIndex = 82;
            this.label5.Text = "優惠編號Coupon_ID";
            // 
            // labChage
            // 
            this.labChage.AutoSize = true;
            this.labChage.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labChage.Location = new System.Drawing.Point(1297, 246);
            this.labChage.Name = "labChage";
            this.labChage.Size = new System.Drawing.Size(102, 38);
            this.labChage.TabIndex = 80;
            this.labChage.Text = "label1";
            // 
            // btnLanguageUpDate
            // 
            this.btnLanguageUpDate.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLanguageUpDate.Location = new System.Drawing.Point(1123, 234);
            this.btnLanguageUpDate.Margin = new System.Windows.Forms.Padding(4);
            this.btnLanguageUpDate.Name = "btnLanguageUpDate";
            this.btnLanguageUpDate.Size = new System.Drawing.Size(100, 50);
            this.btnLanguageUpDate.TabIndex = 79;
            this.btnLanguageUpDate.Text = "修改";
            this.btnLanguageUpDate.UseVisualStyleBackColor = true;
            this.btnLanguageUpDate.Click += new System.EventHandler(this.btnLanguageUpDate_Click);
            // 
            // btnLanguageAdd
            // 
            this.btnLanguageAdd.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLanguageAdd.Location = new System.Drawing.Point(996, 234);
            this.btnLanguageAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnLanguageAdd.Name = "btnLanguageAdd";
            this.btnLanguageAdd.Size = new System.Drawing.Size(100, 50);
            this.btnLanguageAdd.TabIndex = 78;
            this.btnLanguageAdd.Text = "新增";
            this.btnLanguageAdd.UseVisualStyleBackColor = true;
            this.btnLanguageAdd.Click += new System.EventHandler(this.btnLanguageAdd_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(990, 174);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 25);
            this.label2.TabIndex = 75;
            this.label2.Text = "是否使用OX_CouponUsing";
            // 
            // txtmemberid
            // 
            this.txtmemberid.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtmemberid.Location = new System.Drawing.Point(1270, 61);
            this.txtmemberid.Margin = new System.Windows.Forms.Padding(4);
            this.txtmemberid.Name = "txtmemberid";
            this.txtmemberid.Size = new System.Drawing.Size(162, 34);
            this.txtmemberid.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(987, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 73;
            // 
            // dataGridViewcplist
            // 
            this.dataGridViewcplist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewcplist.Location = new System.Drawing.Point(952, 405);
            this.dataGridViewcplist.Name = "dataGridViewcplist";
            this.dataGridViewcplist.RowHeadersWidth = 51;
            this.dataGridViewcplist.RowTemplate.Height = 27;
            this.dataGridViewcplist.Size = new System.Drawing.Size(588, 274);
            this.dataGridViewcplist.TabIndex = 83;
            this.dataGridViewcplist.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewcplist_CellMouseUp);
            // 
            // btnviewcplist
            // 
            this.btnviewcplist.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnviewcplist.Location = new System.Drawing.Point(952, 325);
            this.btnviewcplist.Margin = new System.Windows.Forms.Padding(4);
            this.btnviewcplist.Name = "btnviewcplist";
            this.btnviewcplist.Size = new System.Drawing.Size(218, 43);
            this.btnviewcplist.TabIndex = 84;
            this.btnviewcplist.Text = "檢視優惠券明細";
            this.btnviewcplist.UseVisualStyleBackColor = true;
            this.btnviewcplist.Click += new System.EventHandler(this.btnviewcplist_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(987, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 25);
            this.label3.TabIndex = 85;
            this.label3.Text = "會員編號Member_ID";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "true",
            "false"});
            this.comboBox1.Location = new System.Drawing.Point(1277, 174);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 35);
            this.comboBox1.TabIndex = 86;
            // 
            // CouponList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 793);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnviewcplist);
            this.Controls.Add(this.dataGridViewcplist);
            this.Controls.Add(this.txtCoupon_ID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labChage);
            this.Controls.Add(this.btnLanguageUpDate);
            this.Controls.Add(this.btnLanguageAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmemberid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnViewMember);
            this.Controls.Add(this.dataGridViewMember);
            this.Controls.Add(this.btnviewBonus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewCoupon);
            this.Name = "CouponList";
            this.Text = "CouponList";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoupon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcplist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCoupon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnviewBonus;
        private System.Windows.Forms.DataGridView dataGridViewMember;
        private System.Windows.Forms.Button btnViewMember;
        private System.Windows.Forms.TextBox txtCoupon_ID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labChage;
        private System.Windows.Forms.Button btnLanguageUpDate;
        private System.Windows.Forms.Button btnLanguageAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmemberid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewcplist;
        private System.Windows.Forms.Button btnviewcplist;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}