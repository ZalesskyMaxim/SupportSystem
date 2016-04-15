using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Peak
    {
        public int PeakId { get; set; }
        public int FocusSectionId { get; set; }
        public Nullable<int> WaveLenghtPeak { get; set; }
        public Nullable<int> IntensityPeak { get; set; }
    }
}
