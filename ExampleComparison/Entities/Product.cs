using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleComparison.Entities
{
    class Product : IComparable<Product>
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double myProPriceperty)
        {
            Name = name;
            Price = myProPriceperty;
        }

        public int CompareTo(Product other)
        {
            return Name.ToUpper().CompareTo(other.Name.ToUpper());
        }

        public override string ToString()
        {
            return $"name: {Name}    \tPrice: {Price:C} ";
        }
    }
}
