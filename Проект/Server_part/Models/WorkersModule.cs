using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_part.Models
{
    class WorkersModule
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]

        public string IDDB { get; set; }
        public int ID_worker { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Position { get; set; }
    }
}
