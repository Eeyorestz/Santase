using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Santase
{
   public class SingletonFactory
    {
        private static readonly Cards _cards = new Cards();
        private static readonly Player _playerOne = new Player();
        private static readonly Player _playerTwo = new Player();

        public static Cards cards
        {
            get { return _cards; }
        }
        public static Player playerOne
        {
            get { return _playerOne; }
        }
        public static Player playerTwo
        {
            get { return _playerTwo; }
        }
    }
}
