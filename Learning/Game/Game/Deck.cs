using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Deck : CardsRange
    {
        private Random random;
        public Deck()
        {
            random = new Random();
        }
        public void setAll()
        {
            List<Card> tmpList = new List<Card>();

            var colors = Enum.GetValues(typeof(CardsColor));
            var numbers = Enum.GetValues(typeof(CardsNumber));

            // generate an ordered list of cards
            foreach (CardsColor clr in colors)
            {
                foreach (CardsNumber nmb in numbers)
                {
                    Card newCard = new Card(nmb, clr);
                    tmpList.Add(newCard);
                }
            }

            // mix the cards generated before
            int idx;
            while( tmpList.Count > 0 )
            {
                idx = random.Next(tmpList.Count);
                cards.Add(tmpList[idx]);
                tmpList.RemoveAt(idx);
            }
        }
    }
}
