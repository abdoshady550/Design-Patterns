using Menu_Order.Factory_Pattern.Factories;
using System.Collections;

namespace Menu_Order.Factory_Pattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Before();
            SimpleFactory();
            //FactoryMethod();
            //AbstractFactory();
        }
        static void Before()
        {
            (IAppetizer Appetizer, IMainCourse MainCourse, IDessert Dessert) meal = new();


            Console.WriteLine("Appetizers");
            Console.WriteLine($" - [01] Chicken Salad");
            Console.WriteLine($" - [02] Butter Cracker");
            Console.WriteLine($" - [03] Cheese Twist");
            Console.WriteLine($" - [04] Potato Bite");
            Console.WriteLine($" - Any other key to skip");


            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        meal.Appetizer = new ChickenSalad("Small", "350-450", 08.99m, new() { "Chicken", "Lettuce", "Tomatoes", "Cucumbers", "Salad dressing" });
                        break;
                    case 2:
                        meal.Appetizer = new ButterCracker("Small", "70-80", 09.99m, new() { "Flour", "Butter", "Salt" });
                        break;
                    case 3:
                        meal.Appetizer = new CheeseTwist("Small", "100-150", 07.99m, new() { "Puff pastry", "Cheese", "Egg", "Salt" });
                        break;
                    case 4:
                        meal.Appetizer = new PotatoBite("Small", "200-250", 05.99m, new() { "Potato", "Cheese", "Breadcrumbs", "Egg" });
                        break;
                    default:
                        break;
                }
            }

            Console.Clear();

            Console.WriteLine("Main Course");
            Console.WriteLine($" - [05] Lasagna");
            Console.WriteLine($" - [06] Steak");
            Console.WriteLine($" - [07] Molokhiya");
            Console.WriteLine($" - [08] Grilled Chicken");
            Console.WriteLine($" - Any other key to skip");

            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 5:
                        meal.MainCourse = new Lasagna("Large", "300-600", 14.99m, new() { "Pasta", "Cheese", "Tomato", "Beef" });
                        break;
                    case 6:
                        meal.MainCourse = new Steak("Medium", "500-700", 17.99m, new() { "Beef steak", "Salt", "Pepper" });
                        break;
                    case 7:
                        meal.MainCourse = new Molokhiya("Medium", "100-200", 16.99m, new() { "Molokhiya leaves", "Chicken broth", "Garlic", "Coriander" });
                        break;
                    case 8:
                        meal.MainCourse = new GrilledChicken("Large", "200-300", 15.99m, new() { "Chicken", "Salt", "Pepper", "Paprika" });
                        break;
                    default:
                        break;
                }
            }

            Console.Clear();

            Console.WriteLine("Desserts");
            Console.WriteLine($" - [09] Fruit Salad");
            Console.WriteLine($" - [10] Tiramisu");
            Console.WriteLine($" - [11] Browny");
            Console.WriteLine($" - [12] IceCream");
            Console.WriteLine($" - Any other key to skip");


            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 9:
                        meal.Dessert = new FruitSalad("Medium", "100-150", 07.99m, new() { "Apple", "Banana", "Orange", "Berries" });
                        break;
                    case 10:
                        meal.Dessert = new Tiramisu("Small", "400-600", 08.99m, new() { "Ladyfingers", "Coffee", "Egg yolks", "Mascarpone cheese", "Cocoa powder" });
                        break;
                    case 11:
                        meal.Dessert = new Browny("Medium", "150-250", 07.99m, new() { "Sugar", "Butter", "Cocoa powder", "Eggs", "Flour", "Vanilla extract" });
                        break;
                    case 12:
                        meal.Dessert = new IceCream("Small", "200-250", 06.99m, new() { "Milk", "Sugar", "Cream", "Egg yolks", "Vanilla extract" });
                        break;
                    default:
                        break;
                }
            }
            Console.Clear();

            meal.Appetizer?.Serve();
            meal.MainCourse?.Serve();
            meal.Dessert?.Serve();
        }
        static void SimpleFactory() 
        {
            (IAppetizer Appetizer, IMainCourse MainCourse, IDessert Dessert) meal = new();


            Console.WriteLine("Appetizers");
            Console.WriteLine($" - [01] Chicken Salad");
            Console.WriteLine($" - [02] Butter Cracker");
            Console.WriteLine($" - [03] Cheese Twist");
            Console.WriteLine($" - [04] Potato Bite");
            Console.WriteLine($" - Any other key to skip");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        meal.Appetizer = DishFactory.CreateAppetizer("ChickenSalad");
                        break;
                    case 2:
                        meal.Appetizer = DishFactory.CreateAppetizer("ButterCracker");
                        break;
                    case 3:
                        meal.Appetizer = DishFactory.CreateAppetizer("CheeseTwist");
                        break;
                    case 4:
                        meal.Appetizer = DishFactory.CreateAppetizer("PotatoBite");
                        break;
                    default:
                        break;
                }
            }

            Console.Clear();

            Console.WriteLine("Main Course");
            Console.WriteLine($" - [05] Lasagna");
            Console.WriteLine($" - [06] Steak");
            Console.WriteLine($" - [07] Molokhiya");
            Console.WriteLine($" - [08] Grilled Chicken");
            Console.WriteLine($" - Any other key to skip");

            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 5:
                        meal.MainCourse = DishFactory.CreateMainCourse("Lasagna");
                        break;
                    case 6:
                        meal.MainCourse = DishFactory.CreateMainCourse("Steak");
                        break;
                    case 7:
                        meal.MainCourse = DishFactory.CreateMainCourse("Molokhiya");
                        break;
                    case 8:
                        meal.MainCourse = DishFactory.CreateMainCourse("GrilledChicken");
                        break;
                    default:
                        break;
                }
            }

            Console.Clear();

            Console.WriteLine("Desserts");
            Console.WriteLine($" - [09] Fruit Salad");
            Console.WriteLine($" - [10] Tiramisu");
            Console.WriteLine($" - [11] Browny");
            Console.WriteLine($" - [12] IceCream");
            Console.WriteLine($" - Any other key to skip");

            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 9:
                        meal.Dessert = DishFactory.CreateDessert("FruitSalad");
                        break;
                    case 10:
                        meal.Dessert = DishFactory.CreateDessert("Tiramisu");
                        break;
                    case 11:
                        meal.Dessert = DishFactory.CreateDessert("Browny");
                        break;
                    case 12:
                        meal.Dessert = DishFactory.CreateDessert("IceCream");
                        break;
                    default:
                        break;
                }
            }
            Console.Clear();

            meal.Appetizer?.Serve();
            meal.MainCourse?.Serve();
            meal.Dessert?.Serve();
        }
        static void FactoryMethod()
        {

            (IAppetizer Appetizer, IMainCourse MainCourse, IDessert Dessert) meal = new();

            Console.WriteLine("Appetizers");
            Console.WriteLine($" - [01] Chicken Salad");
            Console.WriteLine($" - [02] Butter Cracker");
            Console.WriteLine($" - [03] Cheese Twist");
            Console.WriteLine($" - [04] Potato Bite");
            Console.WriteLine($" - Any other key to skip");


            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        meal.Appetizer = new ChickenSaladFactory().CreateDish();
                        break;
                    case 2:
                        meal.Appetizer = new ButterCrackerFactory().CreateDish();
                        break;
                    case 3:
                        meal.Appetizer = new CheeseTwistFactory().CreateDish();
                        break;
                    case 4:
                        meal.Appetizer = new PotatoBiteFactory().CreateDish();
                        break;
                    default:
                        break;
                }
            }

            Console.Clear();

            Console.WriteLine("Main Course");
            Console.WriteLine($" - [05] Lasagna");
            Console.WriteLine($" - [06] Steak");
            Console.WriteLine($" - [07] Molokhiya");
            Console.WriteLine($" - [08] Grilled Chicken");
            Console.WriteLine($" - Any other key to skip");

            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 5:
                        meal.MainCourse = new LasagnaFactory().CreateDish();
                        break;
                    case 6:
                        meal.MainCourse = new SteakFactory().CreateDish();
                        break;
                    case 7:
                        meal.MainCourse = new MolokhiyaFactory().CreateDish();
                        break;
                    case 8:
                        meal.MainCourse = new GrilledChickenFactory().CreateDish();
                        break;
                    default:
                        break;
                }
            }

            Console.Clear();

            Console.WriteLine("Desserts");
            Console.WriteLine($" - [09] Fruit Salad");
            Console.WriteLine($" - [10] Tiramisu");
            Console.WriteLine($" - [11] Browny");
            Console.WriteLine($" - [12] IceCream");
            Console.WriteLine($" - Any other key to skip");


            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 9:
                        meal.Dessert = new FruitSaladFactory().CreateDish();
                        break;
                    case 10:
                        meal.Dessert = new TiramisuFactory().CreateDish();
                        break;
                    case 11:
                        meal.Dessert = new BrownyFactory().CreateDish();
                        break;
                    case 12:
                        meal.Dessert = new IceCreamFactory().CreateDish();
                        break;
                    default:
                        break;
                }
            }
            Console.Clear();

            meal.Appetizer?.Serve();
            meal.MainCourse?.Serve();
            meal.Dessert?.Serve();
        }
        static void AbstractFactory()
        {
            (IAppetizer Appetizer, IMainCourse MainCourse, IDessert Dessert) meal = new();


            Console.WriteLine("Appetizers");
            Console.WriteLine($" - [01] Chicken Salad");
            Console.WriteLine($" - [02] Butter Cracker");
            Console.WriteLine($" - [03] Cheese Twist");
            Console.WriteLine($" - [04] Potato Bite");
            Console.WriteLine($" - Any other key to skip");


            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        meal.Appetizer = new ChickenSaladFactory().CreateDish();
                        break;
                    case 2:
                        meal.Appetizer = new ButterCrackerFactory().CreateDish();
                        break;
                    case 3:
                        meal.Appetizer = new CheeseTwistFactory().CreateDish();
                        break;
                    case 4:
                        meal.Appetizer = new PotatoBiteFactory().CreateDish();
                        break;
                    default:
                        break;
                }
            }

            Console.Clear();

            Console.WriteLine("Main Course");
            Console.WriteLine($" - [05] Lasagna");
            Console.WriteLine($" - [06] Steak");
            Console.WriteLine($" - [07] Molokhiya");
            Console.WriteLine($" - [08] Grilled Chicken");
            Console.WriteLine($" - Any other key to skip");

            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 5:
                        meal.MainCourse = new LasagnaFactory().CreateDish();
                        break;
                    case 6:
                        meal.MainCourse = new SteakFactory().CreateDish();
                        break;
                    case 7:
                        meal.MainCourse = new MolokhiyaFactory().CreateDish();
                        break;
                    case 8:
                        meal.MainCourse = new GrilledChickenFactory().CreateDish();
                        break;
                    default:
                        break;
                }
            }

            Console.Clear();

            Console.WriteLine("Desserts");
            Console.WriteLine($" - [09] Fruit Salad");
            Console.WriteLine($" - [10] Tiramisu");
            Console.WriteLine($" - [11] Browny");
            Console.WriteLine($" - [12] IceCream");
            Console.WriteLine($" - Any other key to skip");


            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 9:
                        meal.Dessert = new FruitSaladFactory().CreateDish();
                        break;
                    case 10:
                        meal.Dessert = new TiramisuFactory().CreateDish();
                        break;
                    case 11:
                        meal.Dessert = new BrownyFactory().CreateDish();
                        break;
                    case 12:
                        meal.Dessert = new IceCreamFactory().CreateDish();
                        break;
                    default:
                        break;
                }
            }
            Console.Clear();

            Console.WriteLine("Families (Combos)");
            Console.WriteLine($" - [13] Our Special");
            Console.WriteLine($" - [14] Diet Meal (Low in Carbs / Sugar");

            if (int.TryParse(Console.ReadLine(), out choice))
            {
                IMealFactory mealFactory = null;
                switch (choice)
                {
                    case 13:
                        mealFactory = new SpecialComboFactory();
                        break;
                    case 14:
                        mealFactory = new DietMealFactory();
                        break;
                    default:
                        break;
                }

                meal.Appetizer = mealFactory?.PrepareAppetizer();
                meal.MainCourse = mealFactory?.PrepareMainCourse();
                meal.Dessert = mealFactory?.PrepareDessert();
            }

            Console.Clear();

            meal.Appetizer?.Serve();
            meal.MainCourse?.Serve();
            meal.Dessert?.Serve();

        }

    }

}
