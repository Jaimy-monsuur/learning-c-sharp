using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;

namespace mongodb_test
{
    class Opleiding
    {
        public int _2014 { get; set; }
        public int _2015 { get; set; }
        public int _2016 { get; set; }
        public int _2017 { get; set; }
        public int _2018 { get; set; }
        public ObjectId _id { get; set; }
        public string PROVINCIE { get; set; }
        public int GEMEENTENUMMER { get; set; }
        public string GEMEENTENAAM { get; set; }
        public string SOORTINSTELLING { get; set; }
        public string BRINNUMMERACTUEEL { get; set; }
        public string INSTELLINGSNAAMACTUEEL { get; set; }
        public string CROHOONDERDEEL { get; set; }
        public string CROHOSUBONDERDEEL { get; set; }
        public int OPLEIDINGSCODEACTUEEL { get; set; }
        public string OPLEIDINGSNAAMACTUEEL { get; set; }
        public string OPLEIDINGSVORM { get; set; }
        public string SOORTDIPLOMA { get; set; }
        public string GESLACHT { get; set; }
    }
}
