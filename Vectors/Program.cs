using System;
using System.Collections.Generic;

namespace Vectors
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintListToConsole(AddVectors(new List<int> { 4, 8, 12 }, new List<int> { 14, 16, 19 }));
            PrintListToConsole(ScalarMultiply(new List<int> { 1, 3, 5, 9 }, 3));
            Console.WriteLine(DotProduct(new List<float> { 3.0f, 5.0f, -1.0f }, new List<float> { 2.0f, 6.0f, 7.0f }));
            PrintListToConsole(ConvexCombination(new List<int> { 4, 8 }, new List<int> { 14, 16 }, 0.2f, 0.8f));
            Console.Read();
        }
        static void PrintListToConsole(List<int> l)
        {
            Console.Write("(");
            for(int i = 0; i<l.Count; i++)
            {
                if(i != l.Count - 1)
                {
                    Console.Write(l[i].ToString() + ",");
                }
                else
                {
                    Console.WriteLine(l[i].ToString() + ")");
                }
            }
        }
        static void PrintListToConsole(List<float> l)
        {
            Console.Write("(");
            for (int i = 0; i < l.Count; i++)
            {
                if (i != l.Count - 1)
                {
                    Console.Write(l[i].ToString() + ",");
                }
                else
                {
                    Console.WriteLine(l[i].ToString() + ")");
                }
            }
        }
        static List<int> AddVectors(List<int> l1, List<int> l2)
        {
            List<int> result = new List<int>();
            if(l1.Count != l2.Count)
            {
                throw new Exception("Vectors are of different lengths");
            }
            for (int i = 0; i < l1.Count; i++)
            {
                result.Add(l1[i] + l2[i]);
            }
            return result;
        }
        static List<float> AddVectors(List<float> l1, List<float> l2)
        {
            List<float> result = new List<float>();
            if (l1.Count != l2.Count)
            {
                throw new Exception("Vectors are of different lengths");
            }
            for (int i = 0; i < l1.Count; i++)
            {
                result.Add(l1[i] + l2[i]);
            }
            return result;
        }
        static List<int> ScalarMultiply(List<int> l, int s)
        {
            List<int> result = new List<int>();
            for(int i = 0; i<l.Count; i++)
            {
                result.Add(l[i] * s);
            }
            return result;
        }
        static List<float> ScalarMultiply(List<int> l, float s)
        {
            List<float> result = new List<float>();
            for (int i = 0; i < l.Count; i++)
            {
                result.Add(l[i] * s);
            }
            return result;
        }
        static float DotProduct(List<float> l1, List<float> l2)
        {
            float result = 0;
            if (l1.Count != l2.Count)
            {
                throw new Exception("Vectors are of different lengths");
            }
            for(int i = 0; i<l1.Count; i++)
            {
                result += l1[i] * l2[i];
            }
            return result;
        }
        static List<float> ConvexCombination(List<int> l1, List<int> l2, float a, float b)
        {
            if (a + b != 1)
            {
                throw new Exception("invalid weights");
            }
            return (AddVectors(ScalarMultiply(l1, a), ScalarMultiply(l2, b)));
        }
    }
}
