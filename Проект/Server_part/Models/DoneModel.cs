using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_part.Models
{
    class DoneModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string IDDB { get; set; }
        public int OrderDone_ID { get; set; }
        public bool Status { get; set; }
    }
}
