using AlgorithmDemo2021.BinarySearch;
using AlgorithmDemo2021.ListAlg;
using AlgorithmDemo2021.StringSearch;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmDemo2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TestNeighbourNodes();
            //TestStringSearch();
            //TestBinarySearch();



            Console.ReadKey();
        }

        static void TestStringSearch()
        {
            NaiveSearchAlg naiveSearch = new NaiveSearchAlg();
            BMYStringSearch bMYStringSearch = new BMYStringSearch();
            string toSearch = $"The following example has a yield return statement that's inside a for loop. Each iteration of the foreach statement body in the Main method creates a call to the Power iterator function. Each call to the iterator function proceeds to the next execution of the yield return statement, which occurs during the next iteration of the for loop.";
            string toFind = "the";


            var result = bMYStringSearch.FindStringMatches(toFind, toSearch);
            var result2 = naiveSearch.FindStringMatches(toFind, toSearch);


            Console.WriteLine($" match with BMY Search");
            foreach (var item in result)
            {
                Console.WriteLine($" match strt: {item.StartIndex }   match length: {item.MatchLength}");
            }

            Console.WriteLine($"");
            Console.WriteLine($" match with Naive Search");
            foreach (var item in result2)
            {
                Console.WriteLine($" match strt: {item.StartIndex }   match length: {item.MatchLength}");
            }

        }

        static void TestBinarySearch()
        {
            int[] searchItems = new int[] { 45, 12, 98, 67, 288, 7 };
            int[] sequenceArray = Enumerable.Range(1, 100).ToArray();

            int serchItemCount = searchItems.Length - 1;
            for (int x = 0; x <= serchItemCount; x++)
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

        }


        static void TestNeighbourNodes()
        {
            string[] inputLines = new string[] { "00", "0."};
            char[,] nodeGrid = new char[2, 2];
            for (int y = 0; y < inputLines.Length; y++)
            {
                int x = 0;
                foreach (char node in inputLines[y])
                {
                    nodeGrid[x, y] = node;
                    x++;
                }
            }

            var testitem = nodeGrid.Length;
            NeighbourTests nodeSearch = new NeighbourTests();
            List<string> res = nodeSearch.printNeighbourNodes(nodeGrid);
            res.ForEach(Console.WriteLine);

            Console.WriteLine("List of nodes");



        }
    }
}
