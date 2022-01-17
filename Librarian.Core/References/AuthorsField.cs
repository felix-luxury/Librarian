using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarian.Core.References
{
    public class AuthorsField : SimpleField
    {
        public string Delimiter { get; set; }
        public string LastDelimiter { get; set; }
        public string[] Authors
        {
            get
            {
                return (string[])Value;
            }
        }

        public AuthorsField(string[] authors, string prefix, string postfix, string delimiter = ", ", string lastDelimiter = " и ") : base(authors,prefix,postfix)
        {
            Delimiter = delimiter;
            LastDelimiter = lastDelimiter;
        }

        public override string Build()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Authors.Length; i++)
            {
                if (i < Authors.Length - 2)
                    sb.Append(Authors[i] + Delimiter);
                else if (i == Authors.Length - 2)
                    sb.Append(Authors[i] + LastDelimiter);
                else
                    sb.Append(Authors[i]);
            }
            return Prefix + sb.ToString() + Postfix;
        }
    }
}
