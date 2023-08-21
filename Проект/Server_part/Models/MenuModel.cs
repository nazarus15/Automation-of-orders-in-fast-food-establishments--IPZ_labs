using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_part.Models
{
    class MenuModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]

        public string IDDB { get; set; }
        public int Menu_ID { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public int Price { get; set; }
    }
}
