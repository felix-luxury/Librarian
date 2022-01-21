using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarian.Core.LiterarySources
{
    [Serializable]
    public class LiterarySource
    {
        [BsonId]
        public Guid Id { get; set; }
        public string[] Authors { get; set; }
        public PublishInfo PublishInfo { get; set; }
        public string Title { get; set; }
        public string JournalTitle { get; set; }
        public DateTime ReadDate { get; set; }
        public string Source { get; set; }
        public int EditionNumber { get; set; }
        public int PageNumber { get; set; }
        public int PageCount { get; set; }
    }
}
