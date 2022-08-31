
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
            this.dataGridViewMember = new System.Windows.Forms.DataGridView();
            this.txtCoupon_ID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labChage = new System.Windows.Forms.Label();
            this.btnLanguageUpDate = new System.Windows.Forms.Button();
            this.btnLanguageAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmemberid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewcplist = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnviewBonus = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoupon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcplist)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCoupon
            // 
            this.dataGridViewCoupon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCoupon.Location = new System.Drawing.Point(960, 143);
            this.dataGridViewCoupon.Name = "dataGridViewCoupon";
            this.dataGridViewCoupon.RowHeadersWidth = 51;
            this.dataGridViewCoupon.RowTemplate.Height = 27;
            this.dataGridViewCoupon.Size = new System.Drawing.Size(613, 616);
            this.dataGridViewCoupon.TabIndex = 64;
            this.dataGridViewCoupon.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewCoupon_CellMouseUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(37, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 50);
            this.label4.TabIndex = 65;
            this.label4.Text = "優惠明細";
            // 
            // dataGridViewMember
            // 
            this.dataGridViewMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMember.Location = new System.Drawing.Point(1613, 148);
            this.dataGridViewMember.Name = "dataGridViewMember";
            this.dataGridViewMember.RowHeadersWidth = 51;
            this.dataGridViewMember.RowTemplate.Height = 27;
            this.dataGridViewMember.Size = new System.Drawing.Size(299, 611);
            this.dataGridViewMember.TabIndex = 67;
            this.dataGridViewMember.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewMember_CellMouseUp);
            // 
            // txtCoupon_ID
            // 
            this.txtCoupon_ID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCoupon_ID.Location = new System.Drawing.Point(619, 129);
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
            this.label5.Location = new System.Drawing.Point(339, 132);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 25);
            this.label5.TabIndex = 82;
            this.label5.Text = "優惠編號Coupon_ID";
            // 
            // labChage
            // 
            this.labChage.AutoSize = true;
            this.labChage.BackColor = System.Drawing.Color.Red;
            this.labChage.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labChage.ForeColor = System.Drawing.Color.Yellow;
            this.labChage.Location = new System.Drawing.Point(347, 241);
            this.labChage.Name = "labChage";
            this.labChage.Size = new System.Drawing.Size(77, 38);
            this.labChage.TabIndex = 80;
            this.labChage.Text = "狀態";
            // 
            // btnLanguageUpDate
            // 
            this.btnLanguageUpDate.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLanguageUpDate.Location = new System.Drawing.Point(93, 198);
            this.btnLanguageUpDate.Margin = new System.Windows.Forms.Padding(4);
            this.btnLanguageUpDate.Name = "btnLanguageUpDate";
            this.btnLanguageUpDate.Size = new System.Drawing.Size(114, 54);
            this.btnLanguageUpDate.TabIndex = 79;
            this.btnLanguageUpDate.Text = "修改";
            this.btnLanguageUpDate.UseVisualStyleBackColor = true;
            this.btnLanguageUpDate.Click += new System.EventHandler(this.btnLanguageUpDate_Click);
            // 
            // btnLanguageAdd
            // 
            this.btnLanguageAdd.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLanguageAdd.Location = new System.Drawing.Point(93, 114);
            this.btnLanguageAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnLanguageAdd.Name = "btnLanguageAdd";
            this.btnLanguageAdd.Size = new System.Drawing.Size(114, 56);
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
            this.label2.Location = new System.Drawing.Point(339, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 25);
            this.label2.TabIndex = 75;
            this.label2.Text = "是否使用OX_CouponUsing";
            // 
            // txtmemberid
            // 
            this.txtmemberid.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtmemberid.Location = new System.Drawing.Point(619, 73);
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
            this.dataGridViewcplist.Location = new System.Drawing.Point(341, 343);
            this.dataGridViewcplist.Name = "dataGridViewcplist";
            this.dataGridViewcplist.RowHeadersWidth = 51;
            this.dataGridViewcplist.RowTemplate.Height = 27;
            this.dataGridViewcplist.Size = new System.Drawing.Size(588, 416);
            this.dataGridViewcplist.TabIndex = 83;
            this.dataGridViewcplist.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewcplist_CellMouseUp);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(336, 82);
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
            this.comboBox1.Location = new System.Drawing.Point(626, 186);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 35);
            this.comboBox1.TabIndex = 86;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnviewBonus);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnLanguageAdd);
            this.panel1.Controls.Add(this.btnLanguageUpDate);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 774);
            this.panel1.TabIndex = 87;
            // 
            // btnviewBonus
            // 
            this.btnviewBonus.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnviewBonus.Location = new System.Drawing.Point(93, 291);
            this.btnviewBonus.Margin = new System.Windows.Forms.Padding(4);
            this.btnviewBonus.Name = "btnviewBonus";
            this.btnviewBonus.Size = new System.Drawing.Size(114, 59);
            this.btnviewBonus.TabIndex = 88;
            this.btnviewBonus.Text = "檢視";
            this.btnviewBonus.UseVisualStyleBackColor = true;
            this.btnviewBonus.Click += new System.EventHandler(this.btnviewBonus_Click_1);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(1608, 115);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 25);
            this.label6.TabIndex = 88;
            this.label6.Text = "會員Members";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(955, 115);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 25);
            this.label7.TabIndex = 89;
            this.label7.Text = "優惠總表Coupon";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(336, 315);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(212, 25);
            this.label8.TabIndex = 90;
            this.label8.Text = "優惠明細CouponLists";
            // 
            // CouponList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 784);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewcplist);
            this.Controls.Add(this.txtCoupon_ID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labChage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmemberid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewMember);
            this.Controls.Add(this.dataGridViewCoupon);
            this.Name = "CouponList";
            this.Text = "CouponList";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoupon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcplist)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCoupon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewMember;
        private System.Windows.Forms.TextBox txtCoupon_ID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labChage;
        private System.Windows.Forms.Button btnLanguageUpDate;
        private System.Windows.Forms.Button btnLanguageAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmemberid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewcplist;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnviewBonus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}