namespace Decorator.IceCreamShop
{
    public class ChocolateChips(IceCream iceCream) : IceCreamDecorator(iceCream)
    {
        public override string Description => $"{base.Description} + Chocolate Chips";
        public override decimal CalculateCost() => base.CalculateCost() + .45m;
    }
}

