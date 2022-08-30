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
    public partial class CouponList : Form
    {
        public CouponList()
        {
            InitializeComponent();
        }
        優惠總表Coupon 優惠總表Coupon = new 優惠總表Coupon();
        MDAEntities2 db = new MDAEntities2();
        優惠明細CouponList 優惠明細CouponList = new 優惠明細CouponList();
        會員Members 會員Members = new 會員Members();
        private void btnviewBonus_Click(object sender, EventArgs e)
        {
            var q = from a in db.優惠總表Coupon
                    select new { a.優惠編號Coupon_ID, a.優惠名稱Coupon_Name, a.優惠代碼Coupon_Code, a.優惠折扣Discount, a.優惠截止日期DueDate, a.優惠所需紅利BonusCost };
            dataGridViewCoupon.DataSource = q.ToList();
        }

        private void btnViewMember_Click(object sender, EventArgs e)
        {
            var q = from a in db.會員Members
                    select new { a.會員編號Members_ID, a.紅利點數Point };
            dataGridViewMember.DataSource = q.ToList();
        }

        private void btnviewcplist_Click(object sender, EventArgs e)
        {
            showviewcplist();
        }

        private void dataGridViewCoupon_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtCoupon_ID.Text = dataGridViewCoupon.CurrentRow.Cells["優惠編號Coupon_ID"].Value.ToString();
        }

        private void dataGridViewMember_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtmemberid.Text = dataGridViewMember.CurrentRow.Cells["會員編號Members_ID"].Value.ToString();
        }

        private void btnLanguageAdd_Click(object sender, EventArgs e)
        {
            if (txtCoupon_ID .Text== "")
                return;

            優惠明細CouponList.會員編號Members_ID = int.Parse(txtmemberid.Text);
            優惠明細CouponList.優惠編號Coupon_ID = int.Parse(txtCoupon_ID.Text);
            string result = comboBox1.Text;
            優惠明細CouponList.是否使用OX_CouponUsing =Convert.ToBoolean (result);
            this.db.優惠明細CouponList.Add(優惠明細CouponList);
            this.db.SaveChanges();
            labChage.Text = "新增成功";
            showviewcplist();
            clearall();

        }

        void showviewcplist()
        {
            var q = from a in db.優惠明細CouponList
                    select new { a.優惠明細編號CouponList_ID, a.會員編號Members_ID, a.優惠編號Coupon_ID, a.是否使用OX_CouponUsing };
            dataGridViewcplist.DataSource = q.ToList();
        }

        void clearall()
        {
            txtmemberid.Text = "";
            txtCoupon_ID.Text = "";
            comboBox1.Text = "";
        }

        private void btnLanguageUpDate_Click(object sender, EventArgs e)
        {
            var q = (from a in db.優惠明細CouponList.AsEnumerable()
                     where a.優惠明細編號CouponList_ID == int.Parse(dataGridViewcplist.CurrentRow.Cells["優惠明細編號CouponList_ID"].Value.ToString())
                     select a).FirstOrDefault();
            q.會員編號Members_ID = int.Parse(txtmemberid.Text);
            q.優惠編號Coupon_ID = int.Parse(txtCoupon_ID.Text);
            q.是否使用OX_CouponUsing = Convert.ToBoolean(comboBox1.Text.ToString());
            this.db.SaveChanges();
            labChage.Text = "修改成功";
            showviewcplist();
            clearall();

        }

        private void dataGridViewcplist_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtmemberid.Text = dataGridViewcplist.CurrentRow.Cells["會員編號Members_ID"].Value.ToString();
            txtCoupon_ID.Text = dataGridViewcplist.CurrentRow.Cells["優惠編號Coupon_ID"].Value.ToString();
            comboBox1.Text = dataGridViewcplist.CurrentRow.Cells["是否使用OX_CouponUsing"].Value.ToString();
        }
    }
}
