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
            TestCardWars();
            // TestNeighbourNodes();
            //TestStringSearch();
            //TestBinarySearch();



            Console.ReadKey();
        }


        static void TestCardWars()
        {
            Queue<string> player1 = new Queue<string>();
            //add cards for player 1 
            // standard  AD KC QC
            // Battle Mode 10D 9S 8D KH 7D 5H 6S
            player1.Enqueue("10D");
            player1.Enqueue("9S");
            player1.Enqueue("8D");
            player1.Enqueue("KH");
            player1.Enqueue("7D");
            player1.Enqueue("5H");
            player1.Enqueue("6S");
            Queue<string> player2 = new Queue<string>();
            // add ceard for player 2 KH QS JC
            // Battle Mode 10H 7H 5C QC 2C 4H 6D
            player2.Enqueue("10H");
            player2.Enqueue("7H");
            player2.Enqueue("5C");
            player2.Enqueue("QC");
            player2.Enqueue("2C");
            player2.Enqueue("4H");
            player2.Enqueue("6D");

            CardWar.CardWars cardWars = new CardWar.CardWars();
            Console.WriteLine(cardWars.GameResult(player1, player2));




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
