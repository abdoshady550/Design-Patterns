namespace Decorator.IceCreamShop
{
    // Decorator
    public abstract class IceCreamDecorator : IceCream
    {
        protected IceCream _iceCream;

        public IceCreamDecorator(IceCream iceCream)
        {
            _iceCream = iceCream;
        }

        public override string Description => _iceCream.Description;
        public override decimal CalculateCost() => _iceCream.CalculateCost();
    }
}

