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
    
    public partial class tbl_25_Isotop_ChE
    {
        public int IsotopId { get; set; }
        public int ChemicalElementId { get; set; }
        public Nullable<int> IsotopMassValue { get; set; }
    
        public virtual tbl_10_ChemicalElement tbl_10_ChemicalElement { get; set; }
    }
}