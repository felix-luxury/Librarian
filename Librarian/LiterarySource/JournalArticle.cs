using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarian.LiterarySource
{
    class JournalArticle : LiterarySource
    {
        public string Journal { get; set; }
        public int EditionNumber { get; set; }
        public int PageNumber { get; set; }
    }
}
