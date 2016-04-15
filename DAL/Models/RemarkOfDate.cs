using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class RemarkOfDate
    {
        public int RemarkOfDateId { get; set; }
        public int ArtWorkId { get; set; }
        public int DateOfCreatedId { get; set; }
        public string RemarkOfDateCreate { get; set; }
    }
}
