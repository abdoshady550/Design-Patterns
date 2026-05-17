namespace Decorator.IceCreamShop
{
    // Concrete Componenet
    public class BasicIceCream : IceCream
    {
        public override string Description => "Ice Cream";
        public override decimal CalculateCost() => 3.5m;
    }
}

