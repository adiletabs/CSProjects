namespace Snake
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override bool Equals(object obj)
        {
            Point b = obj as Point;
            if (b.X == X && b.Y == Y) return true;
            else return false;
        }
    }
}
