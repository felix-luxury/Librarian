using Librarian.Core.References;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarian.Core.Styles
{
    [Serializable]
    public class Style
    {
        public Style()
        {

        }
        public Style(FieldType[] fields, StyleConfig config)
        {
            Fields = fields;
            Config = config;
        }

        public FieldType[] Fields { get; set; }
        public StyleConfig Config { get; set; }
    }
}
