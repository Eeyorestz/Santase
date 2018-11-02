using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Santase
{
    public class Card
    {
        private string cardColor;
        private int cardValue;
        private string cardName;

        public string Color
        {
            get
            {
                return this.cardColor;
            }
            set
            {
                this.cardColor = value;
            }
        }
        public int Value
        {
            get
            {
                return this.cardValue;
            }
            set
            {
                this.cardValue = value;
            }
        }
        public string Name
        {
            get
            {
                return this.cardName;
            }
            set
            {
                this.cardName = value;
            }
        }
    }
}
