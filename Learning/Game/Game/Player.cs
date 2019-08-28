using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Player
    {
        private int pID;        // player ID
        private int pMoney;     // player money
        private CardsRange hand; // player cards

        public Player()
        {
            pID = 0; // 0 - a player without a game
            pMoney = 0;
            hand = new CardsRange();
        }

        public int ID
        {
            set { pID = value; }
            get { return pID; }
        }

        public int Money
        {
            set { pMoney = value; }
            get { return pMoney; }
        }

        public CardsRange Hand
        {
            set { hand = value; }
            get { return hand; }
        }

        public void addCard(Card card)
        {
            hand.add(card);
        }

        public override string ToString()
        {
            string output = String.Empty;

            output = String.Format("P{0}: {1} money; cards: {2}", pID, pMoney, hand.ToString());

            return output;
        }
    }
}
