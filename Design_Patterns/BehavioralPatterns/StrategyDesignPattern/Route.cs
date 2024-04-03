namespace StrategyDesignPattern
{
    public class Route
    {
        public List<string> Path { get; set; } = new();
        public double Duration { get; set; }
        public double Cost { get; set; }
        public Transportation Transportation { get; set; }
    }
    public enum Transportation
    {
        Pedestrian,
        Bicycle,
        Car,
        Train,
        Ship
    }
}
