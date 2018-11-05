using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Santase
{
    public class CardUtils : SingletonFactory
    {
        static Random random = new Random();
       
        public  void deckInitialize()
        {      
            cards.DeckCount = GenerateRandom();
            cards.DeckCards = cardPool;
            initialHand();
            getPowerColorCard();         
        }
        public void specialEventTwentyFourty()
        {
            hasMatchingKingAndQueen(playerOne);
            if (playerOne.PlayerTurn)
            {
                if (playerOne.Hand[playerOne.PlayedCard].Equals(""))
                {
                }


            }
            
        }
        private bool hasMatchingKingAndQueen(Player player)
        {
            bool areMatching=false;
            player.Hand[0]="King Of Clubs";
            player.Hand[1] = "Queen Of Clubs";
            player.Hand[2] = "Ten Of Diamonds";
            player.Hand[3] = "Ace Of Clubs";
            player.Hand[4] = "Queen Of Hearts";

            var  kingQueensList = kingQueens(player.Hand);
            List<int> matchingkingQueens = new List<int>();
            var duplicateKeys = kingQueensList.GroupBy(x => x.Value)
                        .Where(group => group.Count() > 1)
                        .Select(group => group.Key).ToList();


            for (int i = 0; i < kingQueensList.Count-1; i++)
            {
             //   if (player.Hand[kingQueensList[i]])
              
            }

            return areMatching;
        }
        private Dictionary<int, string> kingQueens (List<string> hand)
        {
            Dictionary<int, string > dictionary = new Dictionary<int, string>();
            for (int i = 0; i < hand.Count; i++)
            {
                if (hand[i].StartsWith("Queen") || hand[i].StartsWith("King"))
                {
                    dictionary.Add( i, getColor(hand[i]));
                }
            }
            return dictionary;
        }
        private List<string> kingQueenList(List<String> hand)
        {
            List<string> kingQueensList = new List<string>();
            for (int i = 0; i < hand.Count; i++)
            {
                if (hand[i].StartsWith("Queen") || hand[i].StartsWith("King"))
                {
                    
                    getColor(hand[i]); 
                    kingQueensList.Add(hand[i]);
                }
            }
            return kingQueensList;
        }
        private readonly Dictionary<string, int> cardPool = new Dictionary<string, int>
        {
            //Clubs
            { "Nine Of Clubs",0  },
            { "Joker Of Clubs",2},
            { "Queen Of Clubs",3 },
            {  "King Of Clubs",4 },
            {  "Ten Of Clubs",10 },
            {  "Ace Of Clubs",11 },
            //Diamonds
            { "Nine Of Diamonds",0 },
            {  "Joker Of Diamonds",2 },
            {  "Queen Of Diamonds",3 },
            {  "King Of Diamonds",4 },
            {  "Ten Of Diamonds",10 },
            {  "Ace Of Diamonds",11 },
            //Hearts
            {  "Nine Of Hearts",0 },
            {  "Joker Of Hearts",2 },
            {  "Queen Of Hearts",3 },
            {  "King Of Hearts",4 },
            {  "Ten Of Hearts",10 },
            {  "Ace Of Hearts",11 },
            //Spades
            {  "Nine Of Spades",0 },
            {  "Joker Of Spades",2 },
            {  "Queen Of Spades",3 },
            {  "King Of Spades",4 },
            {  "Ten Of Spades",10 },
            {  "Ace Of Spades",11 }
        };
        private void initialHand()
        {          
            for (int i = 0; i < cards.DeckCount.Count; i++)
            {
                playerOne.Hand.Add(cardPool.ElementAt(cards.DeckCount[i]).Key);
                cards.DeckCount.RemoveAt(i);
                playerTwo.Hand.Add(cardPool.ElementAt(cards.DeckCount[i]).Key);
                cards.DeckCount.RemoveAt(i);
                if (playerTwo.Hand.Count == 5)
                {
                    break;
                }
            }
        }
        private void getPowerColorCard()
        {
           cards.PowerCard = cardPool.ElementAt(cards.DeckCount[0]).Key;
            cards.PowerColor = getColor(cards.PowerCard);
            cards.DeckCount.RemoveAt(0);
        }
        
        private List<int> GenerateRandom()
        {
            // generate count random values.
            HashSet<int> candidates = new HashSet<int>();
            while (candidates.Count < cardPool.Count)
            {
                int randomNumber = random.Next(0, cardPool.Count);
                if (!candidates.Contains(randomNumber))
                {
                    candidates.Add(randomNumber);
                }
            }

            var descendingOrder = candidates.OrderByDescending(gi => gi);
            // load them in to a list.
            List<int> result = new List<int>();
            result.AddRange(candidates);

            // shuffle the results:
            int i = result.Count;
            while (i > 1)
            {
                i--;
                int k = random.Next(i + 1);
                int value = result[k];
                result[k] = result[i];
                result[i] = value;
            }
            return result;
        }
        private string getColor(string card)
        {
            card = card.Substring(card.IndexOf("Of") + 3);
            return card;
        }
    }

}
