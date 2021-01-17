using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmDemo2021.CardWar
{
    public class CardWars
    {

        private Queue<string> player1Deck;
        private Queue<string> player2Deck;
        Dictionary<string,int> deckMap = new Dictionary<string, int>();

        public CardWars()
        {
            InitializeDeckMap();
           // Console.WriteLine();
        }

        public string GameResult(Queue<string> deck1, Queue<string> deck2)
        {
            player1Deck = deck1;
            player2Deck = deck2;

            int deckSize = player1Deck.Count;
            string checkDeck;

            int x = 0;
            while(player1Deck.TryPeek(out checkDeck) && player2Deck.TryPeek(out checkDeck))
            {
                x++;                
                string player1Hand = player1Deck.Dequeue();
                string player2Hand = player2Deck.Dequeue();
             //   Console.WriteLine($"Round {x } P1 - {player1Hand } P2 -{ player2Hand}");
                // get card weight 
                int card1Weight = deckMap[player1Hand.Remove(player1Hand.Length- 1 , 1)];
                int card2Weight = deckMap[player2Hand.Remove(player2Hand.Length - 1, 1)];
                if(card1Weight > card2Weight)
                {
    //                Console.WriteLine($"Round {x } : Player 1 : wins  P1 - {card1Weight } P2 -{ card2Weight}");
                    player1Deck.Enqueue(player1Hand);
                    player1Deck.Enqueue(player2Hand);

                }
                else if (card1Weight < card2Weight)
                {
      //              Console.WriteLine($"Round {x } : Player 2 : wins P1 - {card1Weight } P2 -{ card2Weight}");
                    player2Deck.Enqueue(player2Hand);
                    player2Deck.Enqueue(player1Hand);
                }
                else
                {
                    Console.WriteLine($"Round { x } : Enter Battle mode P1 - {card1Weight } P2 -{ card2Weight}");
                }

            }

            //determine result
            var winner = player1Deck.TryPeek(out checkDeck) ? 1 : 2;
            var result = $"{ winner } { x }";


            return $"{result}";
        }



        public void InitializeDeckMap()
        {
            deckMap.Add("2", 1);
            deckMap.Add("3", 2);
            deckMap.Add("4", 3);
            deckMap.Add("5", 4);
            deckMap.Add("6", 5);
            deckMap.Add("7", 6);
            deckMap.Add("8", 7);
            deckMap.Add("9", 8);
            deckMap.Add("10", 9);
            deckMap.Add("J", 10);
            deckMap.Add("Q", 11);
            deckMap.Add("K", 12);
            deckMap.Add("A", 14);          
        }
    }
}
