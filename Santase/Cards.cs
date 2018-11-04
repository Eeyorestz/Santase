using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Santase
{
    public class Cards
    {
        private string _powerCard;
        private string _powerColor;    
        private List<int> _deck = new List<int>();
        private Dictionary<string, int> _cards = new Dictionary<string, int>();



        public List<int> DeckCount
        {
            get
            {
                return this._deck;
            }
            set
            {
                this._deck = value;
            }
        }

        public Dictionary<string, int> DeckCards
        {
            get
            {
                return this._cards;
            }
            set
            {
                this._cards = value;
            }
        }

        public string PowerCard
        {
            get
            {
                return this._powerCard;
            }
            set
            {
                this._powerCard = value;
            }
        }

        public string PowerColor
        {
            get
            {
                return this._powerColor;
            }
            set
            {
                this._powerColor = value;
            }
        }

    }
}
