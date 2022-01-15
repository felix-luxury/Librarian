using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarian.Core.References
{
    public class WebReference : BaseReference
    {
        public DateTime AccessDate { get; set; }
        public string UrlAddress { get; set; }
    }
}
