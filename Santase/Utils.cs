using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Santase
{
    public class Utils
    {
        CardPoolValues cards = new CardPoolValues();
        public int cardCompared(string playerOneCard, string playerTwoCard)
        {
            int player = 0;
            int sum = cards.cardPool[playerOneCard] + cards.cardPool[playerTwoCard];
            var areMatching = colorComparer(playerOneCard, playerTwoCard);
            if (areMatching)
            {
                var one = cards.cardPool[playerOneCard];
                var two = cards.cardPool[playerTwoCard];

            }
            else
            {
                var one = cards.cardPool[playerOneCard];
                var two = cards.cardPool[playerTwoCard];
            }
            return player;
        }
        private bool colorComparer(string playerOneCard, string playerTwoCard)
        {
            bool areEqual = false;
            playerOneCard = playerOneCard.Substring(playerOneCard.IndexOf("Of")+3);
            playerTwoCard = playerTwoCard.Substring(playerTwoCard.IndexOf("Of")+3);
            if (playerOneCard.Equals(playerTwoCard)) {
                areEqual = true;
            }
            return areEqual;
        }
        private bool isPowerColor(string playerCard, string powerColor)
        {
            playerCard = playerCard.Substring(playerCard.IndexOf("Of") + 3);
            bool isPowerColor = false;
            if (playerCard.Equals(powerColor)) {
                isPowerColor = true;
            }
            return isPowerColor;
        }
    }
}
