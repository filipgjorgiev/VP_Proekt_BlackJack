using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Dealer
    {
        public List<Card> Hand { get; set; } = new List<Card>();



        public int Score { get; set; } = 0;

        public Dealer()
        {
            Hand = new List<Card>();
        }

        public void Draw(Graphics g)
        {
            foreach(Card card in Hand)
            {
                card.DrawDealerCard(g);
            }
        }

    }
}
