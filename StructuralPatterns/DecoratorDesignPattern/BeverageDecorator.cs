using System.ComponentModel.DataAnnotations;

namespace DecoratorDesignPattern
{
    public abstract class BeverageDecorator : IBeverage
    {
        protected readonly IBeverage _beverage;
        protected BeverageDecorator(IBeverage beverage)
        {
            _beverage = beverage;
        }
        public virtual string Description => $"{_beverage.Description},";
        public abstract double Cost { get; }
    }
    public class Milk : BeverageDecorator
    {
        public Milk(IBeverage beverage) : base(beverage) { }
        public override string Description => $"{base.Description} Extra Milk";
        public override double Cost => _beverage.Cost + 0.50;
    }
    public class Caramel : BeverageDecorator
    {
        public Caramel(IBeverage beverage) : base(beverage) { }
        public override string Description => $"{base.Description} Extra Caramel";
        public override double Cost => _beverage.Cost + 0.75;
    }
}
