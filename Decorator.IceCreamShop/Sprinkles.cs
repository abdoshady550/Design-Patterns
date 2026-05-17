namespace Decorator.IceCreamShop
{
    // Concrete Decorator

    public class Sprinkles(IceCream iceCream) : IceCreamDecorator(iceCream)
    {
        public override string Description => $"{base.Description} + Sprinkles";
        public override decimal CalculateCost() => base.CalculateCost() + .25m;
    }
}

