using Librarian.Core.LiterarySource;
using Librarian.Core.References;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarian.Core.Styles
{
    abstract class BaseStyle
    {
        public LiterarySourceType LiterarySourceType { get; set; }
        public BaseField[] MyProperty { get; set; }
    }
}
