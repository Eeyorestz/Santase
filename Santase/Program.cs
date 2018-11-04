using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Santase
{
    class Program : SingletonFactory
    {
      
        static void Main(string[] args) 
        {

            TurnUtils turnUtil = new TurnUtils();
            CardUtils cardUtils = new CardUtils();     

            cardUtils.deckInitialize();
          
            while (cards.DeckCount.Count > 0)
            {
                cardUtils.specialEventTwentyFourty();
                int playerOneCardIndex = int.Parse(Console.ReadLine());
                int playerTwoCardIndex = int.Parse(Console.ReadLine());
                turnUtil.cardCompare(playerOne.Hand[playerOneCardIndex], playerTwo.Hand[playerTwoCardIndex]);
                turnUtil.adjustedPlayersHand(playerOneCardIndex, playerTwoCardIndex);
            }
            Console.ReadKey();
        }
    }
}
