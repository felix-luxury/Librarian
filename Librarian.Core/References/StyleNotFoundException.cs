using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarian.Core.References
{
    public class StyleNotFoundException : Exception
    {
        public StyleNotFoundException() : base()
        { }
        public StyleNotFoundException(string? message) : base(message)
        { }
        public StyleNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        { }
    }
}
