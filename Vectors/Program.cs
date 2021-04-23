using System;

namespace Vectors
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector2Dint v1 = new Vector2Dint(1, 2);
            Vector2Dint v2 = new Vector2Dint(3, 5);
            v1.AddTo(v2).PrintToConsole();
            v1.ScalarMultiply(5).PrintToConsole();
            Console.WriteLine(v1.DotProduct(v2));
            Console.Read();
        }
    }
}
