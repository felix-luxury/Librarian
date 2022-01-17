using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarian.Core.References
{
    public abstract class BaseField
    {
        public string Prefix { get; set; }
        public string Postfix { get; set; }

        public abstract string Build();
    }
}
