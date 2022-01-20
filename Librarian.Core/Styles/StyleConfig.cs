using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarian.Core.Styles

{
    public class StyleConfig
    {
        public string AuthorPrefix { get; set; }
        public string AuthorPostfix { get; set; }
        public string AuthorDelimiter { get; set; }
        public string AuthorLastDelimiter { get; set; }
        public string YearPrefix { get; set; }
        public string YearPostfix { get; set; }
        public string TitlePrefix { get; set; }
        public string TitlePostfix { get; set; }
        public string JournalTitlePrefix { get; set; }
        public string JournalTitlePostfix { get; set; }
        public string DatePrefix { get; set; }
        public string DatePostfix { get; set; }
        public string DateFormat { get; set; }
        public string SourcePrefix { get; set; }
        public string SourcePostfix { get; set; }
    }
}
