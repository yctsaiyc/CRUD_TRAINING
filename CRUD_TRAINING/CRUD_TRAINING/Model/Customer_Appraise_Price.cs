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
    
    public partial class Customer_Appraise_Price
    {
        public string Estimate_Num { get; set; }
        public int Land_HouseID { get; set; }
        public int Customer_Appraise_PriceID { get; set; }
        public Nullable<decimal> Land_Unit_Price { get; set; }
        public Nullable<decimal> Builder_Unit_Price { get; set; }
        public Nullable<decimal> Car_Unit_Price { get; set; }
        public string Desc { get; set; }
        public Nullable<decimal> Other_Unit_Price { get; set; }
        public string InputUser { get; set; }
        public Nullable<System.DateTime> InputDate { get; set; }
        public string ModifyUser { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
    }
}