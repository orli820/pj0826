//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp3.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class 電影Movies
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public 電影Movies()
        {
            this.電影代碼MovieCode = new HashSet<電影代碼MovieCode>();
            this.電影圖片MovieIImagesList = new HashSet<電影圖片MovieIImagesList>();
        }
    
        public int 電影編號Movie_ID { get; set; }
        public Nullable<int> 系列編號Series_ID { get; set; }
        public string 中文標題Title_Cht { get; set; }
        public string 英文標題Title_Eng { get; set; }
        public int 上映年份Release_Year { get; set; }
        public Nullable<System.DateTime> 上映日期Release_Date { get; set; }
        public int 片長Runtime { get; set; }
        public int 電影分級編號Rating_ID { get; set; }
        public Nullable<decimal> 評分Rate { get; set; }
        public Nullable<decimal> 期待度anticipation { get; set; }
        public string 票房BoxOffice { get; set; }
        public string 劇情大綱Plot { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<電影代碼MovieCode> 電影代碼MovieCode { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<電影圖片MovieIImagesList> 電影圖片MovieIImagesList { get; set; }
    }
}
