using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Santase
{
    public class Player
    {
        private string cardColor;
        private bool isOnTurn;
        private int points = 0;
        private string playerName;
        private List<string> playerHand  = new List<string>();

        public bool PlayerTurn
        {
            get
            {
                return this.isOnTurn;
            }
            set
            {
                this.isOnTurn = value;
            }
        }

        public int Points
        {
            get
            {
                return this.points;
            }
            set
            {
                this.points = value;
            }
        }

        public string Name
        {
            get
            {
                return this.playerName;
            }
            set
            {
                this.playerName = value;
            }
        }


        public List<string> Hand
        {
            get
            {
                return this.playerHand;
            }
            set
            {
                this.playerHand = value;
            }
        }
    }
}
