namespace StrategyDesignPattern.Strategies
{
    public class FastestStrategy : IRouteStrategy
    {
        public Route GetRoute()
        {
            return new Route
            {
                Path = new() { "Sumgait", "Train station", "Baku" },
                Duration = 60,
                Cost = 1.10,
                Transportation = Transportation.Train
            };
        }
    }
}
