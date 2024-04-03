namespace FlyweightDesignPattern
{
    public class GameArena
    {
        private readonly List<string> _faceColors = new() { "white", "black", "brown" };

        private Grid? _grid;
        private EnemyFactory? _enemyFactory;
        private readonly Random _random = new();
        public void StartGame(int gridRow, int gridColumn)
        {
            _grid ??= new Grid(gridRow, gridColumn);
            _enemyFactory ??= new EnemyFactory();

            for (int i = 0; i < _grid.GridRow; i++)
                for (int j = 0; j < _grid.GridColumn; j++)
                {
                    var faceColor = GetRandomFaceColor();
                    var clothesType = GetRandomClothesType();
                    var height = GetRandomHeight();

                    var enemy = _enemyFactory.GetEnemy(faceColor, clothesType, height);
                    _grid.Add(i, j, enemy);
                }
            Console.WriteLine($"Total Grid : {gridRow * gridColumn}\nInstances count : {_enemyFactory._instanceCount}");
        }
        private string GetRandomFaceColor()
        {
            var randomChoice = _random.Next(0, _faceColors.Count);
            return _faceColors[randomChoice];
        }
        private double GetRandomHeight()
        {
            return _random.Next(1, 5);
        }
        private ClothesType GetRandomClothesType()
        {
            var enumValues = Enum.GetValues(typeof(ClothesType));
            return (ClothesType)enumValues.GetValue(_random.Next(0, enumValues.Length))!;
        }
    }
    public class Grid
    {
        public Grid(int gridRow, int gridColumn)
        {
            GridRow = gridRow;
            GridColumn = gridColumn;
        }
        public int GridRow { get; }
        public int GridColumn { get; }
        public void Add(int positionX, int positionY, Enemy enemy)
        {
            Console.WriteLine($"[Enemy : face color : {enemy.FaceColor}, clothes type : {enemy.ClothesType}, height : {enemy.Height}] has been added into grid [ {positionX} * {positionY} ]");
        }
    }
}
