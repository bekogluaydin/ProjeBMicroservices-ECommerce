using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Course.Services.Catalog.Models
{
    public class Feature
    {
        public int Duration { get; set; }
    }
}