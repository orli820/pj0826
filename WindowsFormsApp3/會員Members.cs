//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp3
{
    using System;
    using System.Collections.Generic;
    
    public partial class 會員Members
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public 會員Members()
        {
            this.優惠明細CouponLists = new HashSet<優惠明細CouponLists>();
        }
    
        public int 會員編號Member_ID { get; set; }
        public string 會員電話Cellphone { get; set; }
        public string 密碼Password { get; set; }
        public string 姓氏F_Name { get; set; }
        public string 名字L_Name { get; set; }
        public string 暱稱NickName { get; set; }
        public Nullable<System.DateTime> 生日BirthDate { get; set; }
        public Nullable<int> 性別Gender { get; set; }
        public string 電子信箱Email { get; set; }
        public string 地址Address { get; set; }
        public Nullable<int> 紅利點數Bonus { get; set; }
        public Nullable<bool> 正式會員Formal { get; set; }
        public Nullable<bool> 會員權限Permission { get; set; }
        public byte[] 會員照片Image { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<優惠明細CouponLists> 優惠明細CouponLists { get; set; }
    }
}
