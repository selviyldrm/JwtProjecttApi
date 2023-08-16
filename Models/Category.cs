using MongoDB.Bson.Serialization.Attributes;

namespace JwtOrnekProje.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
