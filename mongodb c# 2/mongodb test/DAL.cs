using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace mongodb_test
{
     class DAL
    {
        public string connectionString;
        public MongoClient dbClient;
        public IMongoDatabase db;
        public DAL()
        {
            connectionString = ConfigurationManager.ConnectionStrings["Project"].ConnectionString;
            dbClient = new MongoClient(connectionString);
            db = dbClient.GetDatabase("HBO");
        }
        public List<Opleiding> GetCollecction(string colName)
        {
            IMongoCollection<BsonDocument> collection = db.GetCollection<BsonDocument>(colName);
            List <BsonDocument> l = collection.Find(new BsonDocument()).ToList();
            return ToOpleiding(l);
        }

        public List<Opleiding> GetCollecctionFiltered(string colName, string filter)// filter must be like this: string filter = "\"id\", 1000"
        {
            IMongoCollection<BsonDocument> collection = db.GetCollection<BsonDocument>(colName);
            string[] filterArray = filter.Split(',');
            var f = Builders<BsonDocument>.Filter.Eq(filterArray[0], filterArray[1]);// mischien nog aan passen???
            List<BsonDocument> l = collection.Find(f).ToList();
            return ToOpleiding(l);
        }

        private List<Opleiding> ToOpleiding(List<BsonDocument> T)// zet List<BsonDocument> lijst om naar  List<Incident_Ticket>
        {
            List<Opleiding> list = new List<Opleiding>();
            foreach (BsonDocument item in T)
            {
                Opleiding ticket = new Opleiding()
                {
                    _2014 = int.Parse((string)item["2014"]),
                    _2015 = int.Parse((string)item["2015"]),
                    _2016 = int.Parse((string)item["2016"]),
                    _2017 = int.Parse((string)item["2017"]),
                    _2018 = int.Parse((string)item["2018"]),
                    _id = (ObjectId)item["_id"],
                    PROVINCIE = (string)item["PROVINCIE"],
                    GEMEENTENUMMER = int.Parse((string)item["GEMEENTENUMMER"]),
                    GEMEENTENAAM = (string)item["GEMEENTENAAM"],
                    SOORTINSTELLING = (string)item["SOORT INSTELLING"],
                    BRINNUMMERACTUEEL = (string)item["BRIN NUMMER ACTUEEL"],
                    INSTELLINGSNAAMACTUEEL = (string)item["INSTELLINGSNAAM ACTUEEL"],
                    CROHOONDERDEEL = (string)item["CROHO ONDERDEEL"],
                    CROHOSUBONDERDEEL = (string)item["CROHO SUBONDERDEEL"],
                    OPLEIDINGSCODEACTUEEL = int.Parse((string)item["OPLEIDINGSCODE ACTUEEL"]),
                    OPLEIDINGSNAAMACTUEEL = (string)item["OPLEIDINGSNAAM ACTUEEL"],
                    OPLEIDINGSVORM = (string)item["OPLEIDINGSVORM"],
                    SOORTDIPLOMA = (string)item["SOORT DIPLOMA"],
                    GESLACHT = (string)item["GESLACHT"],
                };
                list.Add(ticket);
            }
            return list;
        }
    }
}
