using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarian.Core.LiterarySource
{
    public class AuthorsField : BaseField
    {
        public string Delimiter { get; set; }
        public string LastDelimiter { get; set; }
        public string[] Authors { get; set; }

        public AuthorsField()
        {
            Delimiter = ", ";
            LastDelimiter = " и ";
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
