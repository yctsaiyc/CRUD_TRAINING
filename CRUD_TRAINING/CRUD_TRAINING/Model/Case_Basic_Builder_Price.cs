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
    
    public partial class Case_Basic_Builder_Price
    {
        public string Estimate_Num { get; set; }
        public string Evaluate_Method { get; set; }
        public Nullable<decimal> Land_Unit_Price_L { get; set; }
        public Nullable<decimal> Land_Unit_Price_H { get; set; }
        public Nullable<decimal> Builder_Unit_Price_L { get; set; }
        public Nullable<decimal> Builder_Unit_Price_H { get; set; }
        public Nullable<decimal> Total_Price_L { get; set; }
        public Nullable<decimal> Total_Price_H { get; set; }
        public Nullable<decimal> Net_Value_L { get; set; }
        public Nullable<decimal> Net_Value_H { get; set; }
        public string Other_Desc { get; set; }
        public string InputUser { get; set; }
        public Nullable<System.DateTime> InputDate { get; set; }
        public string ModifyUser { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public bool No_Car_Flag { get; set; }
        public string Appraiser_Find_Error { get; set; }
        public string Total_Reviewer_Find_Error { get; set; }
    }
}
