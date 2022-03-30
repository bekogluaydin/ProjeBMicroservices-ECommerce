using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Course.Services.Catalog.Models
{
    public class Category
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]  /*mongoDB'de ID "Object" olarak tutulacak kod yazarken bu sayede otomatik olarak string çevirecek. Bizim kodla string 
                                         * yolladýðýmzý veri ise otomatik olarak mongoDB giderken Object olarak gidecek. */
        public string Id { get; set; }

        public string Name { get; set; }
    }
}