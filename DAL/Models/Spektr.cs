using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Spektr
    {
        public int SpektrId { get; set; }
        public int SpectrumLineId { get; set; }
        public int MaterialId { get; set; }
        public int ChemicalElementId { get; set; }
        public int FocusSectionId { get; set; }
        public Nullable<double> SpektrWaveLenght { get; set; }
        public string LineDescription { get; set; }
        public string SpektrsBase { get; set; }
        public Nullable<double> SpektrIntensity { get; set; }
        public Nullable<double> PeakArea { get; set; }
    }
}
