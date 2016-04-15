using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Paints
    {
        public int PaintId { get; set; }
        public int MaterialId { get; set; }
        public string PaintName { get; set; }
        public string PaintRemark { get; set; }
    }
}
