namespace Decorator.IceCreamShop
{
    class Program
    {
        static void Main(string[] args)
        {
            IceCream order = new StrawberryIceCream();
            order = new Sprinkles(order);
            order = new ChocolateChips(order);
            order = new FruiteMix(order);
            Console.WriteLine(order);

            Console.ReadKey();
        }
    }

}
