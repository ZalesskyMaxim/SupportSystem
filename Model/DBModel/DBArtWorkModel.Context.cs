﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model.DBModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBArtWorkContext : DbContext
    {
        public DBArtWorkContext()
            : base("name=DBArtWorkContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_1_User> tbl_1_User { get; set; }
        public virtual DbSet<tbl_10_ChemicalElement> tbl_10_ChemicalElement { get; set; }
        public virtual DbSet<tbl_11_AuthorPictures> tbl_11_AuthorPictures { get; set; }
        public virtual DbSet<tbl_12_GeografyPlace> tbl_12_GeografyPlace { get; set; }
        public virtual DbSet<tbl_13_HistoryPeriod> tbl_13_HistoryPeriod { get; set; }
        public virtual DbSet<tbl_14_ArtWork> tbl_14_ArtWork { get; set; }
        public virtual DbSet<tbl_15_Country> tbl_15_Country { get; set; }
        public virtual DbSet<tbl_16_FotoPictures> tbl_16_FotoPictures { get; set; }
        public virtual DbSet<tbl_17_PassportResearch> tbl_17_PassportResearch { get; set; }
        public virtual DbSet<tbl_18_RemarkOfDate> tbl_18_RemarkOfDate { get; set; }
        public virtual DbSet<tbl_19_DateOfCreated> tbl_19_DateOfCreated { get; set; }
        public virtual DbSet<tbl_2_Roles> tbl_2_Roles { get; set; }
        public virtual DbSet<tbl_20_InstrumentalMethods> tbl_20_InstrumentalMethods { get; set; }
        public virtual DbSet<tbl_21_SpectrumLine> tbl_21_SpectrumLine { get; set; }
        public virtual DbSet<tbl_22_Spektr> tbl_22_Spektr { get; set; }
        public virtual DbSet<tbl_23_StatesOfMatter_ChE> tbl_23_StatesOfMatter_ChE { get; set; }
        public virtual DbSet<tbl_24_CrystalStructuresChE> tbl_24_CrystalStructuresChE { get; set; }
        public virtual DbSet<tbl_25_Isotop_ChE> tbl_25_Isotop_ChE { get; set; }
        public virtual DbSet<tbl_26_Pigments> tbl_26_Pigments { get; set; }
        public virtual DbSet<tbl_27_Group> tbl_27_Group { get; set; }
        public virtual DbSet<tbl_3_Privileges> tbl_3_Privileges { get; set; }
        public virtual DbSet<tbl_30_AuthorType> tbl_30_AuthorType { get; set; }
        public virtual DbSet<tbl_32_FocusSection> tbl_32_FocusSection { get; set; }
        public virtual DbSet<tbl_33_ObjectsPhoto> tbl_33_ObjectsPhoto { get; set; }
        public virtual DbSet<tbl_34_LibrarySpectrumLines> tbl_34_LibrarySpectrumLines { get; set; }
        public virtual DbSet<tbl_34_Peak> tbl_34_Peak { get; set; }
        public virtual DbSet<tbl_35_ArtWorkGenre> tbl_35_ArtWorkGenre { get; set; }
        public virtual DbSet<tbl_36_Technics> tbl_36_Technics { get; set; }
        public virtual DbSet<tbl_37_Material> tbl_37_Material { get; set; }
        public virtual DbSet<tbl_38_OtherMaterials> tbl_38_OtherMaterials { get; set; }
        public virtual DbSet<tbl_39_Metals> tbl_39_Metals { get; set; }
        public virtual DbSet<tbl_40_Paints> tbl_40_Paints { get; set; }
        public virtual DbSet<tbl_5_Organization> tbl_5_Organization { get; set; }
        public virtual DbSet<tbl_6_City> tbl_6_City { get; set; }
        public virtual DbSet<tbl_9_SpektrumLinesChE> tbl_9_SpektrumLinesChE { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
    }
}