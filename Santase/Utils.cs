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
        
        public int handSum;
        Player playerOne = new Player();
        Player playerTwo = new Player();
        private bool isFirstPlayerTurn = true;



        public bool isTakingTheHand(bool isFirstPlayer)
        {
            return isFirstPlayer;
        }

        private void takingPoints()
        {
            if (isFirstPlayerTurn)
            {
                playerOne.Points = playerOne.Points + handSum;
                Console.WriteLine("Player one points : {0} ",playerOne.Points);
            }
            else
            {
                playerTwo.Points = playerTwo.Points + handSum;
                Console.WriteLine("Player two points : {0}",playerTwo.Points);
            }
        }

        public bool isOnTurn(string playerOneCard, string playerTwoCard, bool isFirstPlayer)
        {
            return isFirstPlayer;
        }
        public void cardCompare(string playerOneCard, string playerTwoCard, string powerColor)
        {
            handSum= sum(playerOneCard, playerTwoCard);
            var areMatching = colorComparer(playerOneCard, playerTwoCard);
            if (areMatching)
            {
                if (cards.cardPool[playerOneCard] > cards.cardPool[playerTwoCard])
                {
                    takingPoints();
                }
                else
                {
                    isFirstPlayerTurn = false;
                    takingPoints();
                }
            }
            else
            {
                if (isPowerColor(playerOneCard, powerColor))
                {
                    isFirstPlayerTurn = true;
                    takingPoints();
                }
                else if (isPowerColor(playerTwoCard, powerColor))
                {
                    isFirstPlayerTurn = false;
                    takingPoints();                   
                }
                else
                {
                    if (isFirstPlayerTurn)
                    {
                        takingPoints();
                    }
                    else
                    {
                        isFirstPlayerTurn = false;
                        takingPoints();
                    }
                }
            }          
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
        private int sum(string playerOneCard, string playerTwoCard)
        {
            return  cards.cardPool[playerOneCard] + cards.cardPool[playerTwoCard];
        }
    }
}
