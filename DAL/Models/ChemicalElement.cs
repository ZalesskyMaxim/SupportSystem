using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class ChemicalElement
    {
        public int ChemicalElementId { get; set; }
        public int CrystalStructureId { get; set; }
        public string ChemicalElementName { get; set; }
        public string ChemicalElementDescription { get; set; }
        public Nullable<int> ChemicalElementAtomicNumber { get; set; }
        public Nullable<double> ChemicalElementAtomicWeight { get; set; }
        public Nullable<int> ChemicalElementCore { get; set; }
        public Nullable<int> ChemicalElementIons { get; set; }
    }
}
