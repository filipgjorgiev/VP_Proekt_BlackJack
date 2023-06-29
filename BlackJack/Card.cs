using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Card
    {
        public Image Image { get; set; }

        public String Rank { get; set; }

        public String Suit { get; set; } // sign of card

       // public Point CurrentPosition { get; set; }
        public Point Position_Of_Dealer_Card { get; set; }= new Point(815, 75);

        public Point Position_Of_Player_Card { get; set; } = new Point(815, 400);

   
        public int Value { get; set; }

        public Card(Image image, String numberOfCard, string signOfCard,int value)
        {
            Image = image;
            Rank = numberOfCard;
            Suit = signOfCard;
            Value = value;
        }

        public void movePlayerCard()
        {
            Position_Of_Player_Card = new Point(Position_Of_Player_Card.X - 15, Position_Of_Player_Card.Y);
             
        }

        public void moveDealerCard()
        {
            Position_Of_Dealer_Card = new Point(Position_Of_Dealer_Card.X - 15, Position_Of_Dealer_Card.Y);

        }

        internal void DrawPlayerCard(Graphics g)
        {
            g.DrawImage(Image, Position_Of_Player_Card);
        }

        internal void DrawDealerCard(Graphics g)
        {
            g.DrawImage(Image, Position_Of_Dealer_Card);
        }


      
    }
}
