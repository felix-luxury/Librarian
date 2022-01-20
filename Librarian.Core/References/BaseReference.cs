using Librarian.Core.LiterarySources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarian.Core.References
{
    public abstract class BaseReference
    {
        public string[] Author { get; set; }
        public string Title { get; set; }
        public PublishInfo PublishInfo { get; set; }
        public int PageCount { get; set; }
    }
}
