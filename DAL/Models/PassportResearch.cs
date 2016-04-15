using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class PassportResearch
    {
        public int PassportResearchId { get; set; }
        public int ArtWorkId { get; set; }
        public int InstrumentalMethodsId { get; set; }
        public string Conclusion_the_method { get; set; }
    }
}
