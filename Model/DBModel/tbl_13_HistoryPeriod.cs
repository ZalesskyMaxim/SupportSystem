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
    
    public partial class tbl_13_HistoryPeriod
    {
        public tbl_13_HistoryPeriod()
        {
            this.tbl_11_AuthorPictures = new HashSet<tbl_11_AuthorPictures>();
        }
    
        public int HistoryPeriodId { get; set; }
        public string HistoryPeriodName { get; set; }
        public string HistoryPeriodIdDescription { get; set; }
        public Nullable<System.DateTime> HistoryPeriodIdDates { get; set; }
    
        public virtual ICollection<tbl_11_AuthorPictures> tbl_11_AuthorPictures { get; set; }
    }
}