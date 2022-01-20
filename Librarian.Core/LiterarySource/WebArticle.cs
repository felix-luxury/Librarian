using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarian.Core.LiterarySources
{
    public class WebArticle : JournalArticle
    {
        public DateTime ReadDate { get; set; }
        public string UrlAddress { get; set; }
    }
}
