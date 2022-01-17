using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarian.Core.References
{
    class ReferenceConfigBuilder
    {
        public ReferenceConfigBuilder(ReferenceConfig config)
        {
            Fields = new List<BaseField>();
            Config = config;
        }
        public List<BaseField> Fields { get; set; }
        public ReferenceConfig Config { get; set; }
        public ReferenceConfig AddAuthorField(string[] authors, string prefix = "", string postfix = "", string delimiter = ", ", string lastDelimiter = " и ")
        {
            Fields.Add(new AuthorsField(authors, delimiter, lastDelimiter));
            return this;
        }
        public ReferenceConfig AddYear(int year, string prefix = "", string postfix = "")
        {
            Fields.Add(new SimpleField(year, prefix, postfix));
            return this;
        }
        public ReferenceConfig AddArticleName(string name, string prefix = "", string postfix = "")
        {
            Fields.Add(new SimpleField(year, name, postfix));
            return this;
        }
        public ReferenceConfig AddJournalName(string name, string prefix = "", string postfix = "")
        {
            Fields.Add(new SimpleField(name, prefix, postfix));
            return this;
        }
        public ReferenceConfig AddDate(DateTime date, string format, string prefix = "", string postfix = "")
        {
            Fields.Add(new DateField(date, format, prefix, postfix));
            return this;
        }
        public ReferenceConfig AddSource(string url, string prefix = "", string postfix = "")
        {
            Fields.Add(new SimpleField(url, prefix, postfix));
            return this;
        }
    }
}
