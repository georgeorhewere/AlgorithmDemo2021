using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmDemo2021.CardWar
{
    public class CardWars
    {

        private Queue<string> player1Deck;
        private Queue<string> player2Deck;
        private List<string> player1BattleList = new List<string>();
        private List<string> player2BattleList = new List<string>();
        Dictionary<string, int> deckMap = new Dictionary<string, int>();

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
            while (player1Deck.TryPeek(out checkDeck) && player2Deck.TryPeek(out checkDeck))
            {
                x++;
                string player1Hand = player1Deck.Dequeue();
                string player2Hand = player2Deck.Dequeue();
                //   Console.WriteLine($"Round {x } P1 - {player1Hand } P2 -{ player2Hand}");
                // get card weight 
                int card1Weight = deckMap[player1Hand.Remove(player1Hand.Length - 1, 1)];
                int card2Weight = deckMap[player2Hand.Remove(player2Hand.Length - 1, 1)];
                if (card1Weight > card2Weight)
                {
                    //                Console.WriteLine($"Round {x } : Player 1 : wins  P1 - {card1Weight } P2 -{ card2Weight}");
                    player1Deck.Enqueue(player1Hand);
                    player1Deck.Enqueue(player2Hand);

                }
                else if (card1Weight < card2Weight)
                {
                    //              Console.WriteLine($"Round {x } : Player 2 : wins P1 - {card1Weight } P2 -{ card2Weight}");
                    player2Deck.Enqueue(player1Hand);
                    player2Deck.Enqueue(player2Hand);
                }
                else
                {
                    Console.WriteLine($"Round { x } : Enter Battle mode P1 - {card1Weight } P2 -{ card2Weight}");
                    player1BattleList.Add(player1Hand);
                    player2BattleList.Add(player2Hand);
                    bool isValidBattle = true;
                    for (int y = 0; y < 4; y++)
                    {
                        if (player1Deck.TryPeek(out checkDeck) && player2Deck.TryPeek(out checkDeck))
                        {
                            player1BattleList.Add(player1Deck.Dequeue());
                            player2BattleList.Add(player2Deck.Dequeue());
                        }
                        else
                        {
                            isValidBattle = false;
                            break;
                        }
                    }
                    if (isValidBattle)
                        BattleMode();
                    else
                        return "PAT";
                }

            }
            //determine result
            var winner = player1Deck.TryPeek(out checkDeck) ? 1 : 2;
            var result = $"{ winner } { x }";

            return $"{result}";
        }



        public void BattleMode()
        {

            //Queue<string> player1BattleDeck = new Queue<string>();
            //Queue<string> player2BattleDeck = new Queue<string>();

            //for(int c = 1; c < 3; c++)
            //{
            //    player1BattleDeck.Enqueue(player1BattleList[c]);
            //    player2BattleDeck.Enqueue(player2BattleList[c]);
            //}



            int x = 0;
            string checkBattleDeck;

            //while (player1BattleDeck.TryPeek(out checkBattleDeck) && player2BattleDeck.TryPeek(out checkBattleDeck))
            //{
            //    x++;
            string player1Hand = player1BattleList[player1BattleList.Count - 1];
            string player2Hand = player2BattleList[player2BattleList.Count - 1];

            //    Console.WriteLine($"Round {x } P1 - {player1Hand } P2 -{ player2Hand}");
            //    // get card weight 
            int card1Weight = deckMap[player1Hand.Remove(player1Hand.Length - 1, 1)];
            int card2Weight = deckMap[player2Hand.Remove(player2Hand.Length - 1, 1)];
            if (card1Weight > card2Weight)
            {
                player1BattleList.ForEach(ca => { player1Deck.Enqueue(ca); });
                player2BattleList.ForEach(ca => { player1Deck.Enqueue(ca); });

            }
            else if (card1Weight < card2Weight)
            {
                //              Console.WriteLine($"Round {x } : Player 2 : wins P1 - {card1Weight } P2 -{ card2Weight}");
                player1BattleList.ForEach(ca => { player2Deck.Enqueue(ca); });
                player2BattleList.ForEach(ca => { player2Deck.Enqueue(ca); });
            }
            else
            {
                // Console.WriteLine($"Round { x } : Enter Chained Battle mode P1 - {card1Weight } P2 -{ card2Weight}");



            }
va


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
