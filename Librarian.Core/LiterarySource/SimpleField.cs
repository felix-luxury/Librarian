using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarian.Core.LiterarySource
{
    public class SimpleField : BaseField
    {
        // Свойства
        public object Value { get; set; }

        // Конструкторы
        public SimpleField(object value)
        {
            Value = value;
            Prefix = "";
            Postfix = "";
        }
        public SimpleField(object value, string prefix = "", string postfix = "") : this(value)
        {
            Prefix = prefix;
            Postfix = postfix;
        }

        // Методы
        public override string Build()
        {
            return Prefix + Value + Postfix;
        }

    }
}
