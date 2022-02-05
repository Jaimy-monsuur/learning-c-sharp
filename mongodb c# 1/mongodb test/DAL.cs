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
            db = dbClient.GetDatabase("sample_training");
        }


        public void AddTestVersion()//dal
        {
            int test = 55555;
            var document = new BsonDocument { { "student_id", test }, {
                "scores",
                new BsonArray {
                new BsonDocument { { "type", "exam" }, { "score", 88.12334193287023 } },
                new BsonDocument { { "type", "quiz" }, { "score", 74.92381029342834 } },
                new BsonDocument { { "type", "homework" }, { "score", 89.97929384290324 } },
                new BsonDocument { { "type", "homework" }, { "score", 82.12931030513218 } }
                }
                }, { "class_id", 480 }
            };
            IMongoCollection<BsonDocument> collection = db.GetCollection<BsonDocument>("grades");
            collection.InsertOne(document);
        }

        public List<Student> GET_NBR_Grades(int nbr)//DAL
        {
            //ophalen uit db
            IMongoCollection<BsonDocument> collection = db.GetCollection<BsonDocument>("grades");
            List<BsonDocument> documents = collection.Find(new BsonDocument()).Limit(nbr).ToList();// haalt hoeveelheid:nbr grades op
  
            List<Student> grades = BsonToStudentgrades(documents);
            return grades;
        }

        public List<Student> BsonToStudentgrades(List<BsonDocument> documents)//DAL
        {

            List<Student> grades = new List<Student>();
            foreach (BsonDocument doc in documents)
            {
                Student g = new Student();
                g.id = doc[0].ToString();
                g.Student_ID = doc[1].ToString();
                g.classID = doc[3].ToString();
                //zucht
                BsonArray array = doc[2].AsBsonArray;
                foreach (var item in array)
                {
                    Scores s = new Scores();
                    //Console.WriteLine(item); //tercontrole
                    string[] a = item.ToString().Split(",");
                    string[] b = a[0].Split(":");
                    s.Type = b[1].Replace('"', ' ');
                    string[] c = a[1].Split(":");
                    s.Score = c[1].Replace('}', ' ');
                    g.Scores.Add(s);
                }
                grades.Add(g);
            }
            return grades;
        }
    }
}
