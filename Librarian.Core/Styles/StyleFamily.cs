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
            Styles = new Dictionary<string, Style>();
        }
        [BsonId]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Dictionary<string, Style> Styles { get; set; }
        public Style this[LiterarySourceType type]
        {
            get 
            { 
                if (Styles.ContainsKey(type.ToString()))
                    return Styles[type.ToString()];
                throw new InvalidOperationException("Стиль для такого литературного источника не существует");
            }
            set 
            {
                Styles[type.ToString()] = value; 
            }
        }
        public void Add(LiterarySourceType type, Style style)
        {
            Styles.Add(type.ToString(), style);
        }

        public void Remove(LiterarySourceType type)
        {
            Styles.Remove(type.ToString());
        }
        public bool Contains(LiterarySourceType type)
        {
            return Styles.ContainsKey(type.ToString());
        }
    }
}
