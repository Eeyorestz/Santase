using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Santase
{
    public class TurnUtils : SingletonFactory
    {
        CardUtils cardUtils = new CardUtils();
        private int handSum;

        public void cardCompare(string playerOneCard, string playerTwoCard)
        {
            handSum = cards.DeckCards[playerOneCard] + cards.DeckCards[playerTwoCard];
            Console.WriteLine("Player One card is : {0} , Player two card is {1}; Power color is :{2}", playerOneCard, playerTwoCard,cards.PowerColor);
            var areMatching = colorComparer(playerOneCard, playerTwoCard);
            if (areMatching)
            {
                if (cards.DeckCards[playerOneCard] > cards.DeckCards[playerTwoCard])
                {
                    takingPoints();
                }
                else
                {
                    playerOne.PlayerTurn = false;
                    takingPoints();
                }
            }
            else
            {
                if (isPowerColor(playerOneCard))
                {
                    playerOne.PlayerTurn = true;
                    takingPoints();
                }
                else if (isPowerColor(playerTwoCard))
                {
                    playerOne.PlayerTurn = false;
                    takingPoints();
                }
                else
                {
                    if (playerOne.PlayerTurn)
                    {
                        takingPoints();
                    }
                    else
                    {
                        playerOne.PlayerTurn = false;
                        takingPoints();
                    }
                }
            }
        }
        public void adjustedPlayersHand(int playerOneCardIndex, int playerTwoCardIndex)
        {
            if (playerOne.PlayerTurn)
            {
                addRemoveCards(playerOneCardIndex, playerOne);
                addRemoveCards(playerTwoCardIndex, playerTwo);
            }
            else
            {
                addRemoveCards(playerTwoCardIndex, playerTwo);
                addRemoveCards(playerOneCardIndex, playerOne);
            }
        }
        private void addRemoveCards(int playerCardIndex, Player player)
        {

            player.Hand.RemoveAt(playerCardIndex);
            player.Hand.Add(cards.DeckCards.ElementAt(cards.DeckCount[0]).Key);
            cards.DeckCount.RemoveAt(0);

        }
        private void takingPoints()
        {
            if (playerOne.PlayerTurn)
            {
                playerOne.Points = playerOne.Points + handSum;
                Console.WriteLine("Player one points : {0} ", playerOne.Points);
            }
            else
            {
                playerTwo.Points = playerTwo.Points + handSum;
                Console.WriteLine("Player two points : {0}", playerTwo.Points);
            }
        }
        private bool colorComparer(string playerOneCard, string playerTwoCard)
        {
            bool areEqual = false;
            playerOneCard = playerOneCard.Substring(playerOneCard.IndexOf("Of") + 3);
            playerTwoCard = playerTwoCard.Substring(playerTwoCard.IndexOf("Of") + 3);
            if (playerOneCard.Equals(playerTwoCard))
            {
                areEqual = true;
            }
            return areEqual;
        }
        private bool isPowerColor(string playerCard)
        {
            playerCard = playerCard.Substring(playerCard.IndexOf("Of") + 3);
            bool isPowerColor = false;
            if (playerCard.Equals(cards.PowerColor))
            {
                isPowerColor = true;
            }
            return isPowerColor;
        }
    }
}
