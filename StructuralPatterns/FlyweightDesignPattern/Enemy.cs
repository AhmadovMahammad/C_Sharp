using System.Xml;

namespace FlyweightDesignPattern
{
    public enum ClothesType
    {
        Army,
        Civil
    }
    //For example : We have a war game and we should spawn a millions of enemy

    //Face Colour && Clothes Type && Height are the intrinsic (shared) property that
    //an enemy can be of certain enemies.

    //Conversely : positions (x & y) are extrinsic (unique) property that is unique to a “Enemy” instance.

    //If we also store x & y positions in Enemy class, then for each 1_000_000 enemy, we need to create a new instance
    public class Enemy
    {
        public string FaceColor { get; private set; }
        public ClothesType ClothesType { get; private set; }
        public double Height { get; private set; }
        public Enemy(string faceColor, ClothesType clothesType, double height)
        {
            FaceColor = faceColor;
            ClothesType = clothesType;
            Height = height;
        }
    }
}
