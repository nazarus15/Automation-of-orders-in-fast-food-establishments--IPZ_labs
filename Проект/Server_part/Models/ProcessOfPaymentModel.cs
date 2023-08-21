using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_part.Models
{
    class ProcessOfPaymentModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string IDDB { get; set; }
        public int Client_ID { get; set; }
        public int Price { get; set; }
    }
}
