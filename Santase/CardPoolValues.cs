using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Santase
{
   public class CardPoolValues
    {
       
       public readonly Dictionary<string,int > cardPool = new Dictionary<string, int>
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
}
    
}
