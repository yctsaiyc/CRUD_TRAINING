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
    
    public partial class Case_Basic_Land_House
    {
        public string Estimate_Num { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public Nullable<bool> Special_House_Status { get; set; }
        public Nullable<bool> Recent_Estimate_Review_Neighborhood { get; set; }
        public string InputUser { get; set; }
        public Nullable<System.DateTime> InputDate { get; set; }
        public string ModifyUser { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public int Land_HouseID { get; set; }
        public string Land_Road_Sec { get; set; }
        public string Land_Road_Sub_Sec { get; set; }
        public string Land_Desc { get; set; }
        public string Land_Data_Length { get; set; }
        public string Builder_Road { get; set; }
        public string Builder_Desc { get; set; }
        public string Builder_Data_Length { get; set; }
        public Nullable<bool> Old_Case { get; set; }
        public Nullable<bool> About_Sinyi_Flag { get; set; }
        public string ZipCode { get; set; }
        public string Community_Name { get; set; }
        public Nullable<int> Floor_Up { get; set; }
        public Nullable<int> Floor_Down { get; set; }
        public Nullable<decimal> House_Age { get; set; }
        public string sFloor_Up { get; set; }
        public string sFloor_Down { get; set; }
        public Nullable<decimal> Total_Price { get; set; }
    }
}
