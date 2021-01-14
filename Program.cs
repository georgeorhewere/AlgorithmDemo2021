using AlgorithmDemo2021.BinarySearch;
using System;
using System.Linq;

namespace AlgorithmDemo2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] searchItems = new int[] { 45,12,98,67,288, 7 };

            int[] sequenceArray = Enumerable.Range(1,100).ToArray();

            int serchItemCount = searchItems.Length - 1;
            for(int x =0; x <= serchItemCount; x++)
            {
                BinarySearchAlg search = new BinarySearchAlg(sequenceArray);
                bool isFound = search.geSearchResult(searchItems[x]).Equals(1);
                if (isFound)
                {
                    Console.WriteLine($"found item - {searchItems[x]}");
                }
                else
                {
                    Console.WriteLine($"did not find item - {searchItems[x]}");
                }

            }
            
            
            Console.ReadKey();
        }
    }
}
