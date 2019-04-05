using System;
namespace OdontologyClinic
{
    public class Procedure
    {
        public string Name { get; set;}
        public double Price { get; set; }

        public Procedure(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public Procedure()
        {
        }
    }
}
