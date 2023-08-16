

namespace JwtOrnekProje.Models
{
    
        public class Product
        {
           
            public int ProductId { get; set; }
            public string ProductName { get; set; }
            public decimal ProductPrice { get; set; }
            public int ProductStock { get; set; }
            public string ProductDescripiton { get; set; }
            public string ProductImage { get; set; }
            public int CategoryId { get; set; }
        public Category Category { get; set; }
        }
    }