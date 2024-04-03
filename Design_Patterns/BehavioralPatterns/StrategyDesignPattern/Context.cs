namespace StrategyDesignPattern
{
    public class RouteContext
    {
        private IRouteStrategy? _routeStrategy;
        public RouteContext()
        { }
        public RouteContext(IRouteStrategy routeStrategy)
        {
            _routeStrategy = routeStrategy;
        }
        public void SetStrategy(IRouteStrategy routeStrategy)
        {
            _routeStrategy = routeStrategy;
        }
        public void Travel()
        {
            var route = _routeStrategy?.GetRoute();
            if (route is not null)
                Console.WriteLine($"Path : {string.Join(" ---> ", route.Path)}\nDuration : {route.Duration}\nCost : ${route.Cost}\nTransportation : {route.Transportation}");
            else
                Console.WriteLine("you did not set a strategy to travel");
        }
    }
}
