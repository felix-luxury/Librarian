using MongoDB.Driver;
using Librarian.Core.Styles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using Librarian.Core.LiterarySources;

namespace Librarian.Core.MongoDb
{
    public class MongoConnection
    {
        private IMongoDatabase _db;
        public const string DbName = "Librarian";
        public const string StyleCollectionName = "Styles";
        public const string LitSourceCollectionName = "LiterarySources";
        public MongoConnection(string connectionString)
        {
            var client = new MongoClient(connectionString);
            _db = client.GetDatabase(DbName);
        }
        //// CRUD
        // Create
        public void InsertStyle(Style style)
        {
            var collection = _db.GetCollection<Style>(StyleCollectionName);
            collection.InsertOne(style);
        }
        public void InsertLitSource(LiterarySource source)
        {
            var collection = _db.GetCollection<LiterarySource>(LitSourceCollectionName);
            collection.InsertOne(source);
        }
        // Read
        public List<Style> GetStyles()
        {
            var collection = _db.GetCollection<Style>(StyleCollectionName);
            return collection.Find(new BsonDocument()).ToList();
        }
        public List<LiterarySource> GetLiterarySources()
        {
            var collection = _db.GetCollection<LiterarySource>(LitSourceCollectionName);
            return collection.Find(new BsonDocument()).ToList();
        }
        // Update
        public void UpsertStyle(Guid id, Style newStyle)
        {
            var collection = _db.GetCollection<Style>(StyleCollectionName);
            collection.ReplaceOne(new BsonDocument("_id", id), newStyle, new ReplaceOptions { IsUpsert = true });
        }
        public void UpsertLiterarySources(Guid id, LiterarySource newSource)
        {
            var collection = _db.GetCollection<LiterarySource>(LitSourceCollectionName);
            collection.ReplaceOne(new BsonDocument("_id", id), newSource, new UpdateOptions { IsUpsert = true });
        }
        // Delete
        public void DeleteStyle(Guid id)
        {
            var collection = _db.GetCollection<Style>(StyleCollectionName);
            var filter = Builders<Style>.Filter.Eq("Id", id);
            collection.DeleteOne(filter);
        }
        public void DeleteLitSource(Guid id)
        {
            var collection = _db.GetCollection<LiterarySource>(LitSourceCollectionName);
            var filter = Builders<LiterarySource>.Filter.Eq("Id", id);
            collection.DeleteOne(filter);
        }
    }
}
