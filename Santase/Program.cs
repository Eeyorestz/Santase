using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Santase
{
    class Program
    {
        enum CardValue
        {
            Nine = 0,
            Joker = 2,
            Queen = 3,
            King = 4,
            Ten = 10,
            Ace = 11
        }
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
            Utils util = new Utils();
            CardPoolValues cards = new CardPoolValues();
            var allCards =cards.cardPool;

            List<String> firstPlayerHand = new List<string>();
            List<String> secondPlayerHand = new List<string>();
        
            Randomizer pool = new Randomizer();
            List<int> test =  pool.GenerateRandom(allCards.Count);
                  
            for (int i = 0; i < allCards.Count; i++)
            {
                firstPlayerHand.Add(allCards.ElementAt(test[i]).Key);              
                test.RemoveAt(i);
                 secondPlayerHand.Add(allCards.ElementAt(test[i]).Key);
                test.RemoveAt(i);
                if (secondPlayerHand.Count == 5)
                {
                    break;
                }
            }
            util.cardCompared(firstPlayerHand[0],secondPlayerHand[0]);
        }
    }
}
