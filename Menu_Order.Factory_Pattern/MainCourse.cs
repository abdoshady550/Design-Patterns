using System;
using System.Collections.Generic;
using System.Text;

namespace Menu_Order.Factory_Pattern
{
    public interface IMainCourse : IDish
    {
    }
    public class Lasagna : Dish, IMainCourse
    {
        public Lasagna(string size, string calories, decimal price, List<string> ingredients) : base(size, calories, price, ingredients) { }

        public void Serve()
        {
            Console.WriteLine($"Lasagna \n{ShowDetails()}");
        }
    }
    public class Steak : Dish, IMainCourse
    {
        public Steak(string size, string calories, decimal price, List<string> ingredients) : base(size, calories, price, ingredients) { }

        public void Serve()
        {
            Console.WriteLine($"Steak \n{ShowDetails()}");
        }
    }
    public class Molokhiya : Dish, IMainCourse
    {
        public Molokhiya(string size, string calories, decimal price, List<string> ingredients) : base(size, calories, price, ingredients) { }
        public void Serve()
        {
            Console.WriteLine($"Molokhiya \n{ShowDetails()}");
        }
    }
    public class GrilledChicken : Dish, IMainCourse
    {
        public GrilledChicken(string size, string calories, decimal price, List<string> ingredients) : base(size, calories, price, ingredients) { }
        public void Serve()
        {
            Console.WriteLine($"Grilled Chicken \n{ShowDetails()}");
        }
    }

}
