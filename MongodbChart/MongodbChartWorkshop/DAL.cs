using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace MongodbChartWorkshop
{
    public class DAL
    {
        protected string connectionString;
        protected MongoClient dbClient;
        protected IMongoDatabase db;
        public DAL()
        {
            connectionString = ConfigurationManager.ConnectionStrings["Project"].ConnectionString;
            dbClient = new MongoClient(connectionString);
            db = dbClient.GetDatabase("Covid_Cases");
        }

        public List<BsonDocument> GetCollecction(string colName)
        {
            IMongoCollection<BsonDocument> collection = db.GetCollection<BsonDocument>(colName);
            return collection.Find(new BsonDocument()).ToList();
        }

        public List<BsonDocument> GetCollecctionFiltered(string colName, string filter)// filter must be like this: string filter = "\"id\", 1000"
        {
            IMongoCollection<BsonDocument> collection = db.GetCollection<BsonDocument>(colName);
            string[] filterArray = filter.Split(',');
            var f = Builders<BsonDocument>.Filter.Eq(filterArray[0], filterArray[1]);// mischien nog aan passen???
            return collection.Find(new BsonDocument()).ToList();
        }
    }
}
