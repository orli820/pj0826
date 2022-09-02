using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.DataBase;

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
        優惠明細CouponLists 優惠明細CouponLists = new 優惠明細CouponLists();
        會員Members 會員Members = new 會員Members();
       
        void viewcoupon()
        {
            var q = from a in db.優惠總表Coupon
                    select new { a.優惠編號Coupon_ID, a.優惠名稱Coupon_Name, a.優惠代碼Coupon_Code, a.優惠折扣CouponDiscount, a.優惠截止日期CouponDueDate, a.優惠所需紅利BonusCost };
            dataGridViewCoupon.DataSource = q.ToList();
        }
        void viewmember()
        {
            var q = from a in db.會員Members
                    select new { a.會員編號Member_ID,a.會員電話Cellphone,a.電子信箱Email,a.紅利點數Bonus };
            dataGridViewMember.DataSource = q.ToList();
        }
       

        private void dataGridViewCoupon_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtCoupon_ID.Text = dataGridViewCoupon.CurrentRow.Cells["優惠編號Coupon_ID"].Value.ToString();
            txtcpName.Text = dataGridViewCoupon.CurrentRow.Cells["優惠名稱Coupon_Name"].Value.ToString();            
            comboBox1.Text = "false";
        }

        private void dataGridViewMember_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtmemberid.Text = dataGridViewMember.CurrentRow.Cells["會員編號Member_ID"].Value.ToString();
            txtCoupon_ID.Text = "";
            txtcpName.Text = "";
        }

        private void btnLanguageAdd_Click(object sender, EventArgs e)
        {
            if (txtCoupon_ID .Text== "")
                return;

            優惠明細CouponLists.會員編號Member_ID = int.Parse(txtmemberid.Text);
            優惠明細CouponLists.優惠編號Coupon_ID = int.Parse(txtCoupon_ID.Text);
            string result = comboBox1.Text;
            優惠明細CouponLists.是否使用優惠OX_CouponUsing =Convert.ToBoolean (result);
            this.db.優惠明細CouponLists.Add(優惠明細CouponLists);
            this.db.SaveChanges();
            labChage.Text = "新增成功";
            showviewcplist();
            clearall();

        }

        void showviewcplist()
        {
            var q = from a in db.優惠明細CouponLists
                    select new { a.優惠明細編號CouponList_ID, a.會員編號Member_ID, a.優惠編號Coupon_ID, a.是否使用優惠OX_CouponUsing };
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
            var q = (from a in db.優惠明細CouponLists.AsEnumerable()
                     where a.優惠明細編號CouponList_ID == int.Parse(dataGridViewcplist.CurrentRow.Cells["優惠明細編號CouponList_ID"].Value.ToString())
                     select a).FirstOrDefault();
            q.會員編號Member_ID = int.Parse(txtmemberid.Text);
            q.優惠編號Coupon_ID = int.Parse(txtCoupon_ID.Text);
            q.是否使用優惠OX_CouponUsing = Convert.ToBoolean(comboBox1.Text.ToString());
            this.db.SaveChanges();
            labChage.Text = "修改成功";
            showviewcplist();
            clearall();

        }

        private void dataGridViewcplist_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtmemberid.Text = dataGridViewcplist.CurrentRow.Cells["會員編號Member_ID"].Value.ToString();
            txtCoupon_ID.Text = dataGridViewcplist.CurrentRow.Cells["優惠編號Coupon_ID"].Value.ToString();
            comboBox1.Text = dataGridViewcplist.CurrentRow.Cells["是否使用優惠OX_CouponUsing"].Value.ToString();
            txtcpName.Text = dataGridViewCoupon.Rows[int.Parse(txtCoupon_ID.Text) - 1].Cells["優惠名稱Coupon_Name"].Value.ToString();
        }

        private void btnviewBonus_Click_1(object sender, EventArgs e)
        {
            showviewcplist();
            viewcoupon();
            viewmember();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (txtsearchmember.Text != "")
            {
                var q = from a in db.會員Members.AsEnumerable()
                        where ((a.會員編號Member_ID.ToString()).Contains(txtsearchmember.Text))
                        || (a.會員電話Cellphone.Contains(txtsearchmember.Text))
                        || ((a.電子信箱Email).Contains(txtsearchmember.Text))
                        || ((a.紅利點數Bonus.ToString()).Contains(txtsearchmember.Text))
                        select new { a.會員編號Member_ID, a.會員電話Cellphone, a.電子信箱Email, a.紅利點數Bonus };
                dataGridViewMember.DataSource = q.ToList();
            }
            if (txtsearchcoupon.Text != "")
            {
                var q = from a in db.優惠總表Coupon.AsEnumerable()
                        where a.優惠編號Coupon_ID.ToString().Contains(txtsearchcoupon.Text)
                        ||a.優惠名稱Coupon_Name.Contains(txtsearchcoupon.Text)
                        ||a.優惠代碼Coupon_Code.Contains(txtsearchcoupon.Text)
                        ||a.優惠折扣CouponDiscount.ToString().Contains(txtsearchcoupon.Text)         
                        ||a.優惠所需紅利BonusCost.ToString().Contains(txtsearchcoupon.Text)
                        || a.優惠截止日期CouponDueDate.ToString().Contains(txtsearchcoupon.Text)
                        select new { a.優惠編號Coupon_ID, a.優惠名稱Coupon_Name, a.優惠代碼Coupon_Code, a.優惠折扣CouponDiscount, a.優惠截止日期CouponDueDate, a.優惠所需紅利BonusCost };
                dataGridViewCoupon.DataSource = q.ToList();
            }
            if (txtseachcouponlist.Text != "")
            {
                var q = from a in db.優惠明細CouponLists
                        where a.會員編號Member_ID.ToString().Contains(txtseachcouponlist.Text)
                        || a.優惠編號Coupon_ID.ToString().Contains(txtseachcouponlist.Text)
                        ||a.優惠明細編號CouponList_ID.ToString().Contains(txtseachcouponlist.Text)
                        select new { a.優惠明細編號CouponList_ID, a.會員編號Member_ID, a.優惠編號Coupon_ID, a.是否使用優惠OX_CouponUsing };
                dataGridViewcplist.DataSource = q.ToList();
            }
            if(comboBox2.Text != "")
            {
                var q = from a in db.優惠總表Coupon.AsEnumerable()
                        where a.優惠截止日期CouponDueDate == Convert.ToDateTime(comboBox2.Text)
                        select new { a.優惠編號Coupon_ID, a.優惠名稱Coupon_Name, a.優惠代碼Coupon_Code, a.優惠折扣CouponDiscount, a.優惠截止日期CouponDueDate, a.優惠所需紅利BonusCost };
                dataGridViewCoupon.DataSource = q.ToList();
            }
            if (comboBox3.Text != "")
            {
                var q =from a in db.優惠明細CouponLists
                       where a.是否使用優惠OX_CouponUsing.ToString()==comboBox3.Text
                       select new { a.優惠明細編號CouponList_ID, a.會員編號Member_ID, a.優惠編號Coupon_ID, a.是否使用優惠OX_CouponUsing };
                dataGridViewcplist.DataSource = q.ToList();
            }

        }

        private void comboBox2_MouseDown(object sender, MouseEventArgs e)
        {
            var q = (from a in db.優惠總表Coupon
                     orderby a.優惠截止日期CouponDueDate ascending
                     select a.優惠截止日期CouponDueDate).Distinct();
            comboBox2.DataSource = q.ToList();
        }

        private void comboBox3_MouseDown(object sender, MouseEventArgs e)
        {
            var q = from a in db.優惠明細CouponLists
                    select a.是否使用優惠OX_CouponUsing;
            comboBox3.DataSource = q.ToList();
        }
    }
}
