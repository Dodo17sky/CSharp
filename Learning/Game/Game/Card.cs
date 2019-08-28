using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    enum CardsNumber { two, three, four, five, six, seven, eight, nine, ten, jack, queen, king, ace };
    enum CardsColor { club, diamond, heart, spade };
    class Card
    {
        private CardsNumber number;
        private CardsColor color;
        private string imageName;
        public Card()
        {
            imageName = String.Empty;
        }

        public Card(CardsNumber nmb, CardsColor clr)
        {
            number = nmb;
            color = clr;
            setName();
        }

        public void set(CardsNumber nmb, CardsColor clr)
        {
            number = nmb;
            color = clr;
            setName();
        }

        public CardsNumber Number
        {
            set { number = value; }
            get { return number; }
        }

        public CardsColor Color
        {
            set { color = value;  }
            get { return color;  }
        }

        public string ImageName
        {
            set { imageName = value; }
            get { return imageName;  }
        }

        public override string ToString()
        {
            int i = imageName.IndexOf('.');
            return String.Format("[{0}]", imageName.Substring(0,i));
        }

        private void setName()
        {
            string tmp = String.Empty;
            switch(number)
            {
                case CardsNumber.two:
                    tmp += "2";
                    break;
                case CardsNumber.three:
                    tmp += "3";
                    break;
                case CardsNumber.four:
                    tmp += "4";
                    break;
                case CardsNumber.five:
                    tmp += "5";
                    break;
                case CardsNumber.six:
                    tmp += "6";
                    break;
                case CardsNumber.seven:
                    tmp += "7";
                    break;
                case CardsNumber.eight:
                    tmp += "8";
                    break;
                case CardsNumber.nine:
                    tmp += "9";
                    break;
                case CardsNumber.ten:
                    tmp += "10";
                    break;
                case CardsNumber.jack:
                    tmp += "12";
                    break;
                case CardsNumber.queen:
                    tmp += "13";
                    break;
                case CardsNumber.king:
                    tmp += "14";
                    break;
                case CardsNumber.ace:
                    tmp += "15";
                    break;
            }

            switch(color)
            {
                case CardsColor.club:
                    tmp += "C";
                    break;
                case CardsColor.diamond:
                    tmp += "D";
                    break;
                case CardsColor.heart:
                    tmp += "H";
                    break;
                case CardsColor.spade:
                    tmp += "S";
                    break;
            }

            imageName = tmp + ".png";
        }
    }
}
