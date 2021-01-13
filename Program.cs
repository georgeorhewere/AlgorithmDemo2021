using System;

namespace AlgorithmDemo2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] testArray = new int[] { 0,1,2,3,4,5,6,7,8,9 };
            ArrayBinarySearch search = new ArrayBinarySearch();
            int arrayMidPoint = search.getArrayMidPoint(testArray);
            Console.WriteLine($"midpoint - { arrayMidPoint}");
            Console.ReadKey();
        }
    }
}
