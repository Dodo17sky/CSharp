using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class CardsRange
    {
        protected List<Card> cards;
        private Random random;

        public CardsRange()
        {
            cards = new List<Card>();
            random = new Random();
        }

        public List<Card> Cards
        {
            set { cards = value; }
            get { return cards; }
        }

        public void add(Card card)
        {
            cards.Add(card);
        }

        public void extract(Card card)
        {
            cards.Remove(card);
        }

        public Card extractRandom()
        {
            int randCard = random.Next(0, cards.Count);
            Card tmp = cards.ElementAt(randCard);
            cards.Remove(tmp);
            return tmp;
        }

        public bool isEmpty()
        {
            return (cards.Count == 0);
        }

        public override string ToString()
        {
            string output = String.Empty;
            foreach(Card c in cards)
            {
                output += c.ToString();
            }
            return output;
        }
    }
}
