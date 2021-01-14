using AlgorithmDemo2021.BinarySearch;
using AlgorithmDemo2021.StringSearch;
using System;
using System.Linq;

namespace AlgorithmDemo2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            NaiveSearchAlg naiveSearch = new NaiveSearchAlg();
            string toSearch = $"The following example has a yield return statement that's inside a for loop. Each iteration of the foreach statement body in the Main method creates a call to the Power iterator function. Each call to the iterator function proceeds to the next execution of the yield return statement, which occurs during the next iteration of the for loop.";
            string toFind = "the";

            var result = naiveSearch.FindStringMatches(toFind,toSearch);

            foreach(var item in result)
            {
                Console.WriteLine($" match strt: {item.StartIndex }   match length: {item.MatchLength}");
            }





            //int[] searchItems = new int[] { 45,12,98,67,288, 7 };

            //int[] sequenceArray = Enumerable.Range(1,100).ToArray();

            //int serchItemCount = searchItems.Length - 1;
            //for(int x =0; x <= serchItemCount; x++)
            //{
            //    BinarySearchAlg search = new BinarySearchAlg(sequenceArray);
            //    bool isFound = search.geSearchResult(searchItems[x]).Equals(1);
            //    if (isFound)
            //    {
            //        Console.WriteLine($"found item - {searchItems[x]}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"did not find item - {searchItems[x]}");
            //    }

            //}

            
            
            Console.ReadKey();
        }
    }
}
