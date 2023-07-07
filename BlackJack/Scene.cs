using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Scene
    {
        public List<Card> Cards { get; set; }

        

        public Player Player { get; set; }

        public Dealer Dealer { get; set; }

        public int Bid { get; set; }

        string[] ranks = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

        string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };

        public Scene()
        {
            Cards = new List<Card>();
            Bid = 0;
            Player = new Player();
            Dealer = new Dealer();
            setCards();

        }

        public void setCards()
        {

            foreach (string rank in ranks)
            {
                int rankValue;
                if (rank.Equals("Jack") || rank.Equals("Queen") || rank.Equals("King"))
                {

                    rankValue = 10;

                }
                else if (rank.Equals("Ace"))
                {

                    rankValue = 11;
                }
                else
                {
                    int powerOfCard = int.Parse(rank);
                    rankValue = powerOfCard;
                }


                foreach (string suit in suits)
                {
                    Card card = new Card(null, rank, null, 0);
                    string imageSrc = $"C:/Users/Filip/source/repos/BlackJack/BlackJack/Resources/ImagesOfCards/{rank}_of_{suit}.png";
                    Image image = Image.FromFile(imageSrc);

                    Bitmap resizedImage = new Bitmap(105, 140);
                    using (Graphics graphics = Graphics.FromImage(resizedImage))
                    {
                        graphics.DrawImage(image, 0, 0, 105, 140);
                    }

                    card.Image = resizedImage;
                    card.Rank = rank;
                    card.Value = rankValue;
                    card.Suit = suit;

                    Cards.Add(card);

                }
            }
        }



        internal void movePlayerCard(Card randomCard)
        {
            randomCard.movePlayerCard();
        }


        internal void moveDealerCard(Card randomCard)
        {
            randomCard.moveDealerCard();
        }

    }
}
