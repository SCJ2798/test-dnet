namespace mytestapi.Models.Entities{
    public class Product
    {
        public Guid Id {get; set;}
        public required string Name {get; set;}
        public required double Cost {get; set;}
         public double? Tax {get; set;}
    }

}


