namespace FlyweightDesignPattern
{
    public class EnemyFactory
    {
        //below property is considered for only test purposes
        public int _instanceCount = 0;
        private readonly Dictionary<string, Enemy> _enemyDict = new();
        public Enemy GetEnemy(string faceColor, ClothesType clothesType, double height)
        {
            string key = $"{faceColor}_{(int)clothesType}_{height}";
            if (!_enemyDict.ContainsKey(key))
            {
                _enemyDict[key] = new Enemy(faceColor, clothesType, height);
                _instanceCount++;
            }
            return _enemyDict[key];
        }
    }
}
