﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MDAEntities2 : DbContext
    {
        public MDAEntities2()
            : base("name=MDAEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<會員Members> 會員Members { get; set; }
        public virtual DbSet<電影Movies> 電影Movies { get; set; }
        public virtual DbSet<電影代碼MovieCode> 電影代碼MovieCode { get; set; }
        public virtual DbSet<電影圖片MovieIImagesList> 電影圖片MovieIImagesList { get; set; }
        public virtual DbSet<電影圖片總表MovieImages> 電影圖片總表MovieImages { get; set; }
        public virtual DbSet<電影語言MovieLanguage> 電影語言MovieLanguage { get; set; }
        public virtual DbSet<優惠明細CouponLists> 優惠明細CouponLists { get; set; }
        public virtual DbSet<優惠總表Coupon> 優惠總表Coupon { get; set; }
    }
}
