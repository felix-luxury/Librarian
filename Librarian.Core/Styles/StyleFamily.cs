using Librarian.Core.LiterarySources;
using MongoDB.Bson.Serialization.Attributes;
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
            Styles = new Dictionary<LiterarySourceType, Style>();
        }
        [BsonId]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Dictionary<LiterarySourceType, Style> Styles { get; set; }
        public Style this[LiterarySourceType type]
        {
            get 
            { 
                if (Styles.ContainsKey(type))
                    return Styles[type];
                throw new InvalidOperationException("Стиль для такого литературного источника не существует");
            }
            set 
            {
                Styles[type] = value; 
            }
        }
        public void Add(LiterarySourceType type, Style style)
        {
            Styles.Add(type, style);
        }

        public void Remove(LiterarySourceType type)
        {
            Styles.Remove(type);
        }
    }
}
