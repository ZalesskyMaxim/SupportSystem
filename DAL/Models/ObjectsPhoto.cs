using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class ObjectsPhoto
    {
        public int ObjectsPhotoId { get; set; }
        public int FocusSectionId { get; set; }
        public byte[] ObjectsPhotoFile { get; set; }
        public Nullable<System.DateTime> ObjectsPhotoDate { get; set; }
    }
}
