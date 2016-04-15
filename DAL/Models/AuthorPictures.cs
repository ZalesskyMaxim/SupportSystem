using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class AuthorPictures
    {
        public int AuthorPicturesId { get; set; }
        public int GeografyPlaceId { get; set; }
        public int HistoryPeriodId { get; set; }
        public int AuthorTypeId { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
        public string AuthorMiddleName { get; set; }
        public Nullable<System.DateTime> AuthorDate_of_birth { get; set; }
        public Nullable<System.DateTime> AuthorOtherDates { get; set; }
        public string AuthorBiography { get; set; }
    }
}
