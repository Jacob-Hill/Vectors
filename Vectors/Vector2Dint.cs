using System;

namespace Vectors
{
    public class Vector2Dint
    {
        public int x { get; set; }
        public int y { get; set; }
        public Vector2Dint(int X, int Y)
        {
            x = X;
            y = Y;
        }
        public void PrintToConsole()
        {
            Console.WriteLine("(" + x.ToString() + ", " + y.ToString() + ")");
        }
        public Vector2Dint AddTo(Vector2Dint v)
        {
            return new Vector2Dint(x + v.x, y + v.y);
        }
        public Vector2Dint ScalarMultiply(int i)
        {
            return new Vector2Dint(i*x, i*y);
        }
        public int DotProduct(Vector2Dint v)
        {
            return x * v.x + y * v.y;
        }

    }
}
