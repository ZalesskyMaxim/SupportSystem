using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class SpectrumLine
    {
        public int SpectrumLineId { get; set; }
        public int LibraryId { get; set; }
        public Nullable<System.DateTime> SpectrumLineDate { get; set; }
        public string SpectrumLinePersonName { get; set; }
        public Nullable<double> SpectrumLineWavelLength { get; set; }
        public string OtherOptions { get; set; }
    }
}
