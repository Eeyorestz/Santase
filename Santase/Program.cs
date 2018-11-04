using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Santase
{
    class Program
    {


        enum CardColor
        {
            Spade,
            Diamonds,
            Hearts,
            Clubs
        }

        enum CardPool
        {
            NineOfClubs = 0,
            JokerOfClubs = 2,
            QueenOfClubs = 3,
            KingOfClubs = 4,
            TenOfClubs = 10,
            AceOfClubs = 11,
            NineOfDiamonds = 0,
            JokerOfDiamonds = 2,
            QueenOfDiamonds = 3,
            KingOfDiamonds = 4,
            TenOfDiamonds = 10,
            AceOfDiamonds = 11,
            NineOfHearts = 0,
            JokerOfHearts = 2,
            QueenOfHearts = 3,
            KingOfHearts = 4,
            TenOfHearts = 10,
            AceOfHearts = 11,
            NineOfSpades = 0,
            JokerOfSpades = 2,
            QueenOfSpades = 3,
            KingOfSpades = 4,
            TenOfSpades = 10,
            AceOfSpades = 11,
        }

        static void Main(string[] args)
        {
            string powerCard;
            string powerColor="";
            Utils util = new Utils();
            Player playerOne = new Player();
            Player playerTwo = new Player();

            playerOne.Name = "FirstPlayer";
            playerTwo.Name = "SecondPlayer";

            playerOne.Points = 0;
            playerTwo.Points = 0;


            bool isFirstPLayer = playerOne.PlayerTurn = false;
            CardPoolValues cards = new CardPoolValues();
            var allCards = cards.cardPool;
           
           // List<String> firstPlayerHand = new List<string>();
          
          // List <String> secondPlayerHand = new List<string>();

            Randomizer pool = new Randomizer();
            List<int> test = pool.GenerateRandom(allCards.Count);


            for (int i = 0; i < allCards.Count; i++)
            {
                playerOne.Hand.Add(allCards.ElementAt(test[i]).Key);
                test.RemoveAt(i);
                playerTwo.Hand.Add(allCards.ElementAt(test[i]).Key);
                test.RemoveAt(i);
                if (playerTwo.Hand.Count == 5)
                {
                    powerCard = allCards.ElementAt(test[i]).Key;
                    powerColor = powerCard.Substring(powerCard.IndexOf("Of") + 3);
                    test.RemoveAt(i);
                    break;
                }
            }
            for (int i = 0; i < playerOne.Hand.Count; i++)
            {
                util.cardCompare(playerOne.Hand[i], playerTwo.Hand[i], powerColor);
            }
            //   util.cardCompare(playerOne.Hand[0], playerTwo.Hand[0], powerColor);
            Console.ReadKey();
        }
    }
}
