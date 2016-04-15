using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class SpektrumLinesChE
    {
        public int SpektrumLineChEId { get; set; }
        public int ChemicalElementId { get; set; }
        public int FocusSectionId { get; set; }
        public Nullable<double> SpektrumLineChEWavelength { get; set; }
        public Nullable<double> SpektrumLineChEIntensity { get; set; }
    }
}
