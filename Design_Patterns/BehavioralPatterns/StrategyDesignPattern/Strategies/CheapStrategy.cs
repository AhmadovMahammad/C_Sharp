namespace StrategyDesignPattern.Strategies
{
    public class CheapestStrategy : IRouteStrategy
    {
        public Route GetRoute()
        {
            return new Route
            {
                Path = new() { "Path A", "Path B", "Path C", "Path D", },
                Duration = 120,
                Cost = 0.80,
                Transportation = Transportation.Car
            };
        }
    }
}
