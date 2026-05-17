namespace Decorator.IceCreamShop
{
    public class StrawberryIceCream : IceCream
    {
        public override string Description => "Strawberry Ice Cream";
        public override decimal CalculateCost() => 5.5m;
    }
}
