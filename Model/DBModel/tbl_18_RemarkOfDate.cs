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
    
    public partial class tbl_18_RemarkOfDate
    {
        public int RemarkOfDateId { get; set; }
        public int ArtWorkId { get; set; }
        public int DateOfCreatedId { get; set; }
        public string RemarkOfDateCreate { get; set; }
    
        public virtual tbl_14_ArtWork tbl_14_ArtWork { get; set; }
        public virtual tbl_19_DateOfCreated tbl_19_DateOfCreated { get; set; }
    }
}
