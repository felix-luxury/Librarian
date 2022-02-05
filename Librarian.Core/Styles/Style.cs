using Librarian.Core.LiterarySources;
using Librarian.Core.References;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Librarian.Core.Styles
{
    [Serializable]
    public class Style : Object
    {
        public Style()
        {

        }
        public Style(string name, FieldType[] fields, StyleConfig config, LiterarySourceType type)
        {
            Name = name;
            Fields = fields;
            Config = config;
            Type = type;
        }
        [BsonId]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public LiterarySourceType Type { get; set; }
        public FieldType[] Fields { get; set; }
        public StyleConfig Config { get; set; }

        public override string ToString()
        {
            return Name + ": " + Type.ToString();
        }
    }
}
