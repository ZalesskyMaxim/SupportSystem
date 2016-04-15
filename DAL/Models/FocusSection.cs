using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class FocusSection
    {
        public int FocusSectionId { get; set; }
        public int IDUser { get; set; }
        public int ArtWorkId { get; set; }
        public string FocusSectionName { get; set; }
        public Nullable<System.DateTime> FocusSectionDate { get; set; }
        public Nullable<System.DateTime> FocusSectionTime { get; set; }
        public string FocusSectionSpektrFile { get; set; }
        public string FocusSectionReportFile { get; set; }
        public Nullable<int> LabelFocus { get; set; }
    }
}
