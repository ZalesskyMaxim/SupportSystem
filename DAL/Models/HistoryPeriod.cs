using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class HistoryPeriod
    {
        public int HistoryPeriodId { get; set; }
        public string HistoryPeriodName { get; set; }
        public string HistoryPeriodIdDescription { get; set; }
        public Nullable<System.DateTime> HistoryPeriodIdDates { get; set; }
    }
}
