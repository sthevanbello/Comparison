

namespace ExampleComparison.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double myProPriceperty)
        {
            Name = name;
            Price = myProPriceperty;
        }

        

        public override string ToString()
        {
            return $"name: {Name}    \tPrice: {Price:C} ";
        }
    }
}
