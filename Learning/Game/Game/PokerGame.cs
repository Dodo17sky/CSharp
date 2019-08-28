using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class PokerGame
    {
        // array of players
        private List<Player> players;
        private int nextPlayerID;
        private Deck deck;
        private Form1 mainForm;

        public PokerGame(Form1 form)
        {
            mainForm = form;
            players = new List<Player>();
            deck = new Deck();
            deck.setAll();
            nextPlayerID = 1;
        }

        public void addPlayer(Player player)
        {
            player.ID = nextPlayerID;
            players.Add(player);
            nextPlayerID++;
        }

        public void startGame(int startMoney, int playersNumber)
        {
            for(int i=0; i < playersNumber; i++)
            {
                Player p = new Player();

                p.Money = startMoney;
                p.addCard(deck.extractRandom());
                p.addCard(deck.extractRandom());

                addPlayer(p);
            }
        }

        public void displayPlayersCards()
        {
            for( int i=0; i<players.Count; i++)
            {
                string path = String.Empty;
                List<Card> hand = players[i].Hand.Cards;

                path = "img/" + hand[0].ImageName;
                mainForm.setCardImage((i * 2) + 1, path);
                path = "img/" + hand[1].ImageName;
                mainForm.setCardImage((i * 2) + 2, path);
            }
        }
    }
}
