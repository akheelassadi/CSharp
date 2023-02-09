using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProject
{
    public class CRUD_MongoDB
    {

        public static void FindDocumentInDB()
        {
            var mongoClient = new MongoClient("mongodb://localhost:27017");
            var db = mongoClient.GetDatabase("kamor");
            var collection = db.GetCollection<BsonDocument>("SYSTEM_INFO");

            var filter = Builders<BsonDocument>.Filter.Eq("UniqueDeviceArticleNumber", "10449157");

            var document = collection.Find(filter).FirstOrDefault();

            Console.WriteLine(document);
        }

        public static void PopulateErrorsInDB()
        {
            var mongoClient = new MongoClient("mongodb://localhost:27017");
            var db = mongoClient.GetDatabase("kamor");
            var collection = db.GetCollection<BsonDocument>("ERRORS");            

            for (int i = 0; i < 2000; i++)
            {
                var dateTime = DateTime.Now.ToString("yyyyMMddhhmmss");
                var doc = new BsonDocument
                {
                    { "_id", new ObjectId()},
                    { "CreationTime", dateTime},
                    { "ErrorNumber", "7509"}
                };
                collection.InsertOne(doc);
            }           
        }

        public static int[] GenerateHundredAcronyms()
        {
            Random rnd = new Random();
            int[] intArr = new int[100];

            for (int i = 0; i < intArr.Length; i++)
            {
                int num = rnd.Next(100, 999);
                intArr[i] = num;
            }

            return intArr;
        }

        public static void PopulateSurgeonsInDB()
        {
            var mongoClient = new MongoClient("mongodb://localhost:27017");
            var db = mongoClient.GetDatabase("kamor");
            var collection = db.GetCollection<BsonDocument>("SURGEONS");

            for (int i = 0; i < 100; i++)
            {
                var surgeonFirstName = "Surg";
                int[] arr = GenerateHundredAcronyms(); 
                var doc = new BsonDocument
                {
                    { "_id", new ObjectId()},
                    { "FirstName", surgeonFirstName+(i+1)},
                    { "LastName", ""},
                    { "SurgeonID", arr[i].ToString()},
                    { "AccessPIN", ""},
                    { "IsActive", true}
                };
                collection.InsertOne(doc);
            }
        }
    }
}
