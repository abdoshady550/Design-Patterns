namespace Decorator.IceCreamShop
{
    public class FruiteMix(IceCream iceCream) : IceCreamDecorator(iceCream)
    {
        public override string Description => $"{base.Description} + Fruite Mix";
        public override decimal CalculateCost() => base.CalculateCost() + .75m;
    }
}

