using System;
using System.Collections.Generic;
using System.Text;

namespace Menu_Order.Factory_Pattern
{
    public abstract class Dish
    {
        public string Size { get; set; }
        public string Calories { get; set; }
        public decimal Price { get; set; }
        public List<string> Ingredients { get; set; }

        public Dish(string size, string calories, decimal price, List<string> ingredients)
        {
            Size = size;
            Calories = calories;
            Price = price;
            Ingredients = ingredients;
        }
        protected string ShowDetails()
        {
            return $"  ── Size: {Size} ({Calories}) cal. ({Price:C})\n  ── Ingredients: {string.Join(", ", Ingredients)}\n";
        }
    }




}
