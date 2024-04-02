namespace DecoratorDesignPattern
{
    public interface IBeverage
    {
        string Description { get; }
        double Cost { get; }
    }
    public class Tea : IBeverage
    {
        public string Description => "Black Tea";
        public double Cost => 1.50;
    }
    public class Espresso : IBeverage
    {
        public string Description => "Espresso";
        public double Cost => 1.99;
    }
    public class HouseBlend : IBeverage
    {
        public string Description => "House Blend Coffee";
        public double Cost => 0.99;
    }
}
