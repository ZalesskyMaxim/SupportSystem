using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class ArtWork
    {
        public int ArtWorkId { get; set; }
        public int AuthorPicturesId { get; set; }
        public int MaterialId { get; set; }
        public int TechnicsId { get; set; }
        public string ArtWorkName { get; set; }
        public string ArtWorkOriginalName { get; set; }
        public string ArtWorkLocation { get; set; }
        public string ArtWorkSize { get; set; }
        public Nullable<System.DateTime> ArtWorkDateResearch { get; set; }
        public string ArtWorkAimResearch { get; set; }
        public string ArtWorkAuthor { get; set; }
        public string ArtWorkAuthor_lang { get; set; }
        public string ArtWorkConclusionNumber { get; set; }
        public Nullable<System.DateTime> ArtWorkCreationDate { get; set; }
        public string ArtWorkStatus { get; set; }
        public string ArtWorkDescription { get; set; }
    }
}
