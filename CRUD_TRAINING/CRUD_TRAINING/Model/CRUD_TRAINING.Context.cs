﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CRUD_TRAININGEntities : DbContext
    {
        public CRUD_TRAININGEntities()
            : base("name=CRUD_TRAININGEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Bank_Casetype_Relation> Bank_Casetype_Relation { get; set; }
        public virtual DbSet<Bank_Report_Relation> Bank_Report_Relation { get; set; }
        public virtual DbSet<Case_Basic> Case_Basic { get; set; }
        public virtual DbSet<Case_Basic_Builder_Cars> Case_Basic_Builder_Cars { get; set; }
        public virtual DbSet<Case_Basic_Builder_Price> Case_Basic_Builder_Price { get; set; }
        public virtual DbSet<Case_Basic_Builder_Price_Detail> Case_Basic_Builder_Price_Detail { get; set; }
        public virtual DbSet<Case_Basic_Builder_Products> Case_Basic_Builder_Products { get; set; }
        public virtual DbSet<Case_Basic_Land_House> Case_Basic_Land_House { get; set; }
        public virtual DbSet<Case_Basic_Land_Price> Case_Basic_Land_Price { get; set; }
        public virtual DbSet<Case_Basic_Land_Price_Detail> Case_Basic_Land_Price_Detail { get; set; }
        public virtual DbSet<Case_Basic_Land_Products> Case_Basic_Land_Products { get; set; }
        public virtual DbSet<Case_Process> Case_Process { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Class> Class { get; set; }
        public virtual DbSet<Code_Table> Code_Table { get; set; }
        public virtual DbSet<Customer_Appraise_Price> Customer_Appraise_Price { get; set; }
        public virtual DbSet<Dept> Dept { get; set; }
        public virtual DbSet<Empo> Empo { get; set; }
        public virtual DbSet<Holidays> Holidays { get; set; }
        public virtual DbSet<Menus> Menus { get; set; }
        public virtual DbSet<Process_JumpReturn_History> Process_JumpReturn_History { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<Report> Report { get; set; }
        public virtual DbSet<Road> Road { get; set; }
        public virtual DbSet<Road_Sec> Road_Sec { get; set; }
        public virtual DbSet<Road_Sub_Sec> Road_Sub_Sec { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Roles_Menus> Roles_Menus { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Users_Roles> Users_Roles { get; set; }
        public virtual DbSet<Road_TEST> Road_TEST { get; set; }
        public virtual DbSet<Bank> Bank { get; set; }
    }
}