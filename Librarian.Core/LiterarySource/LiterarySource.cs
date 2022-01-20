using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarian.Core.LiterarySources
{
    [Serializable]
    public class LiterarySource
    {
        public string[] Authors { get; set; }
        public PublishInfo PublishInfo { get; set; }
        public string Title { get; set; }
        public string JournalTitle { get; set; }
        public DateTime ReadDate { get; set; }
        public string Source { get; set; }
    }
}
