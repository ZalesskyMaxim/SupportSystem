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
    
    public partial class tbl_20_InstrumentalMethods
    {
        public tbl_20_InstrumentalMethods()
        {
            this.tbl_17_PassportResearch = new HashSet<tbl_17_PassportResearch>();
        }
    
        public int InstrumentalMethodsId { get; set; }
        public string InstrumentalMethodsName { get; set; }
        public string InstrumentalMethodsDescription { get; set; }
    
        public virtual ICollection<tbl_17_PassportResearch> tbl_17_PassportResearch { get; set; }
    }
}
