using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Pigments
    {
        public int PigmentsId { get; set; }
        public int PaintId { get; set; }
        public int GroupId { get; set; }
        public string PigmentColor { get; set; }
        public string PigmentChemicalFormula { get; set; }
        public Nullable<System.DateTime> PigmentYearUsed { get; set; }
        public string PigmentWhereUsed { get; set; }
        public string PigmentLiterature { get; set; }
    }
}
