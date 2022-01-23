using Librarian.Core.LiterarySources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarian.Core.Styles
{
    [Serializable]
    public class StyleFamily
    {
        public StyleFamily()
        {
            Style = new Dictionary<LiterarySourceType, Style>();
        }
        public Dictionary<LiterarySourceType, Style> Style { get; set; }
        public Style this[LiterarySourceType type]
        {
            get 
            { 
                if (Style.ContainsKey(type))
                    return Style[type];
                throw new InvalidOperationException("Стиль для такого литературного источника не существует");
            }
            set 
            {
                Style[type] = value; 
            }
        }
        public void Add(Style style, LiterarySourceType type)
        {
            Style.Add(type, style);
        }
    }
}
