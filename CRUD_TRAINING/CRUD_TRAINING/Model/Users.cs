//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRUD_TRAINING.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Users()
        {
            this.Users_Roles = new HashSet<Users_Roles>();
        }
    
        public System.Guid UserID { get; set; }
        public string User_Name { get; set; }
        public string AccountID { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string EmpoID { get; set; }
        public string InputUser { get; set; }
        public Nullable<System.DateTime> InputDate { get; set; }
        public string ModifyUser { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public bool Status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Users_Roles> Users_Roles { get; set; }
    }
}
