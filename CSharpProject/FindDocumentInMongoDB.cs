using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProject
{
    public class FindDocumentInMongoDB
    {
    
        public static void FindDocumentInDB()
        {
            var client = new MongoClient("mongodb://localhost:27017");

            var db = client.GetDatabase("kamor");

            var collection = db.GetCollection<BsonDocument>("SYSTEM_INFO");

            var filter = Builders<BsonDocument>.Filter.Eq("UniqueDeviceArticleNumber", "10449157");

            var document = collection.Find(filter).FirstOrDefault();


            Console.WriteLine(document);

        }
    }
}
