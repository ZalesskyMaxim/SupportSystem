using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class FotoPictures
    {
        public int FotoPicturesId { get; set; }
        public int ArtWorkId { get; set; }
        public byte[] FotoPicturesObj { get; set; }
        public string FotoPicturesObjects { get; set; }
        public string FotoPicturesColors { get; set; }
    }
}
