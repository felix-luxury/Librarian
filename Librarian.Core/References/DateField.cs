using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarian.Core.References
{
    public class DateField : SimpleField
    {
        public string Format { get; set; }
        public DateTime Date
        {
            get { return (DateTime)Value; }
        }
        public DateField(DateTime date, string format, string prefix = "", string postfix = "") : base(date,prefix,postfix)
        {
            Format = format;
        }
        public override string Build()
        {
            return Prefix + Date.ToString(Format) + Postfix;
        }
    }
}
