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
    
    public partial class tbl_15_Country
    {
        public tbl_15_Country()
        {
            this.tbl_12_GeografyPlace = new HashSet<tbl_12_GeografyPlace>();
        }
    
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string CountryDescription { get; set; }
    
        public virtual ICollection<tbl_12_GeografyPlace> tbl_12_GeografyPlace { get; set; }
    }
}
