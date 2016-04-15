using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class ArtWorkGenre
    {
        public int ArtWorkGenreId { get; set; }
        public int ArtWorkId { get; set; }
        public string ArtWorkGenreName { get; set; }
        public string ArtWorkGenreDescription { get; set; }
    }
}
