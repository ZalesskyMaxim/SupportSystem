using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class AuthorType
    {
        public int AuthorTypeId { get; set; }
        public string AuthorTypeName { get; set; }
        public string AuthorSubTypeName { get; set; }
        public string AuthorParentType { get; set; }
    }
}
