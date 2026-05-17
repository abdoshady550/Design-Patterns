using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Menu_Order.Factory_Pattern
{
    public interface IAppetizer : IDish
    {
    }

    public class ChickenSalad : Dish, IAppetizer
    {
        public ChickenSalad(string size, string calories, decimal price, List<string> ingredients): base(size, calories, price, ingredients) { }
        public void Serve()
        {
            Console.WriteLine($"Chicken Salad \n{ShowDetails()}");
        }
    }
    public class ButterCracker : Dish, IAppetizer
    {
        public ButterCracker(string size, string calories, decimal price, List<string> ingredients) : base(size, calories, price, ingredients) { }
        public void Serve()
        {
            Console.WriteLine($"Butter Cracker \n{ShowDetails()}");
        }
    }
    public class CheeseTwist : Dish, IAppetizer
    {
        public CheeseTwist(string size, string calories, decimal price, List<string> ingredients) : base(size, calories, price, ingredients) { }
        public void Serve()
        {
            Console.WriteLine($"Cheese Twist n{ShowDetails()}");
        }
    }
    public class PotatoBite : Dish, IAppetizer
    {
        public PotatoBite(string size, string calories, decimal price, List<string> ingredients) : base(size, calories, price, ingredients) { }
        public void Serve()
        {
            Console.WriteLine($"Potato Bite \n{ShowDetails()}");
        }
    }

}
