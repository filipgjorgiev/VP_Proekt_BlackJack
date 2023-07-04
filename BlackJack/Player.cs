using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Player
    {
        public int TotalMoney { get; set; } = 200;

        public List<Card> Hand { get; set; }

        public int Score { get; set; } = 0;

        public Player()
        {
            Hand = new List<Card>();
        }

        internal void Draw(Graphics graphics)
        {
            foreach (Card card in Hand)
            {
                card.DrawPlayerCard(graphics);
            }
        }

        public void Reset()
        {
            Hand = new List<Card>();
            Score = 0;
        }


    }
}
