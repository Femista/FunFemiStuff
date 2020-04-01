using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Receiver
{
    public class Product
    {
        private readonly string _name;
        private int _price;
        public Product(string name, int price)
        {
            _name = name;
            _price = price;
        }
 
        public void IncreasePrice(int amount)
        {
            _price += amount;
            Console.WriteLine($"The price for the {_name} has been increased by {amount}$.");
        }
 
        public bool DecreasePrice(int amount)
        {
            if(amount < _price)
            {
                _price -= amount;
                Console.WriteLine($"The price for the {_name} has been decreased by {amount}$.");
                return true;
            }
            return false;
        } 

        public override string ToString()
        {
            return $"Current price for the {_name} product is {_price}$.";
        } 
    }
}
