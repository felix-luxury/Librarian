using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarian.Core.LiterarySource
{
    public class JournalArticle : LiterarySource
    {
        public string JournalTitle { get; set; }
        public int EditionNumber { get; set; }
        public int PageNumber { get; set; }
    }
}
