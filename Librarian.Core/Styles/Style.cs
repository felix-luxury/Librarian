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
        [BsonId]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public FieldType[] Fields { get; set; }
        public StyleConfig Config { get; set; }
    }
}
