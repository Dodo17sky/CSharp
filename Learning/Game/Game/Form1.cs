using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        private PokerGame game;
        
        public Form1()
        {
            InitializeComponent();
        }

        public void setCardImage(int cardIndex, string imagePath)
        {
            switch(cardIndex)
            {
                case 1:
                    pictureBox1.ImageLocation = imagePath;
                    break;
                case 2:
                    pictureBox2.ImageLocation = imagePath;
                    break;
                case 3:
                    pictureBox3.ImageLocation = imagePath;
                    break;
                case 4:
                    pictureBox4.ImageLocation = imagePath;
                    break;
                case 5:
                    pictureBox5.ImageLocation = imagePath;
                    break;
                case 6:
                    pictureBox6.ImageLocation = imagePath;
                    break;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            game = new PokerGame(this);
            game.startGame(500, 3);
            game.displayPlayersCards();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

    }
}
