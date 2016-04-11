//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class tbl_22_Spektr
    {
        public int SpektrId { get; set; }
        public int SpectrumLineId { get; set; }
        public int MaterialId { get; set; }
        public int ChemicalElementId { get; set; }
        public int FocusSectionId { get; set; }
        public Nullable<double> SpektrWaveLenght { get; set; }
        public string LineDescription { get; set; }
        public string SpektrsBase { get; set; }
        public Nullable<double> SpektrIntensity { get; set; }
        public Nullable<double> PeakArea { get; set; }
    
        public virtual tbl_10_ChemicalElement tbl_10_ChemicalElement { get; set; }
        public virtual tbl_21_SpectrumLine tbl_21_SpectrumLine { get; set; }
        public virtual tbl_37_Material tbl_37_Material { get; set; }
        public virtual tbl_32_FocusSection tbl_32_FocusSection { get; set; }
    }
}
