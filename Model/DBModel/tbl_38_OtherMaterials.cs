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
    
    public partial class tbl_38_OtherMaterials
    {
        public int OtherMaterialId { get; set; }
        public int MaterialId { get; set; }
        public string OtherMaterialName { get; set; }
        public string OtherMateriaRemark { get; set; }
    
        public virtual tbl_37_Material tbl_37_Material { get; set; }
    }
}