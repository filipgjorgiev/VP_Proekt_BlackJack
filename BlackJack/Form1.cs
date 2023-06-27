using NHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class Form1 : Form
    {
        Scene scene;

   

        int timerTicks = 0;

     //   private bool isBid = false;


        //int randomIndex = random.Next(0, scene.Cards.Count);
        //Card randomCard = scene.Cards.ElementAt(randomIndex);

        Card firstRandomPlayerCard;
        Card secondRandomPlayerCard;
        Card firstRandomDealerCard;
        Card secondRandomDealerCard;

        private bool firstCardsMoving = true;
        private bool secondCardsMoving = false;

        private Image actualImage;

        Random random = new Random();

       

        public Image setCoveredImage()
        {
            Image image = Image.FromFile("C:/Users/Filip/source/repos/BlackJack/BlackJack/Resources/card back red11.png");

            Bitmap resizedImage = new Bitmap(105, 140);
            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                graphics.DrawImage(image, 0, 0, 105, 140);
            }

            return resizedImage;
        }
        public void generateFirstRandomCards()
        {
            

            int dealerRandomIndex1 = random.Next(0, scene.Cards.Count);

            firstRandomDealerCard = scene.Cards.ElementAt(dealerRandomIndex1);

            actualImage = firstRandomDealerCard.Image;

            firstRandomDealerCard.Image = setCoveredImage();


            scene.Dealer.Hand.Add(firstRandomDealerCard);

            scene.Cards.Remove(firstRandomDealerCard);


            int playerRandomIndex1 = random.Next(0, scene.Cards.Count);

           
            firstRandomPlayerCard = scene.Cards.ElementAt(playerRandomIndex1);

            //   firstRandomPlayerCard.Image = setAndResizeImage();

            scene.Player.Hand.Add(firstRandomPlayerCard);

            scene.Cards.Remove(firstRandomPlayerCard);




            int playerRandomIndex2 = random.Next(0, scene.Cards.Count);


            secondRandomPlayerCard = scene.Cards.ElementAt(playerRandomIndex2);

            scene.Player.Hand.Add(secondRandomPlayerCard);

            scene.Cards.Remove(secondRandomPlayerCard);


            int dealerRandomIndex2 = random.Next(0, scene.Cards.Count);

            secondRandomDealerCard = scene.Cards.ElementAt(dealerRandomIndex2);

            scene.Dealer.Hand.Add(secondRandomDealerCard);

            scene.Cards.Remove(secondRandomDealerCard);
        }
        public Form1()
        {
        
            InitializeComponent();

            scene = new Scene();
            this.DoubleBuffered = true;

          //  lblTotalPlayingCards.Text = "Total Cards: "+ scene.Cards.Count.ToString();

            generateFirstRandomCards();

            lblBid.Text = "Bid: $0";

      
        }

        //public void updateTotalCards()
        //{
        //    lblTotalPlayingCards.Text="Total Cards: " + scene.Cards.Count.ToString();
        //}

        private void rbFiveDollarsBid_Click(object sender, EventArgs e)
        {
          
                btnDeal.Visible = true;
        
          
                scene.Player.TotalMoney -= 5;
                lblPlayerMoney.Text = "Player total:" + "$" + scene.Player.TotalMoney.ToString();
                scene.Bid += 5;
                lblBid.Text = "Bid: $" + scene.Bid.ToString();
            
           
        }

        private void rbFiftyDollarBid_Click(object sender, EventArgs e)
        {

                btnDeal.Visible = true;
            
                scene.Player.TotalMoney -= 50;
                lblPlayerMoney.Text = "Player total:" + "$" + scene.Player.TotalMoney.ToString();
                scene.Bid += 50;
                lblBid.Text = "Bid: $" + scene.Bid.ToString();
           

        }

        private void rbTenDollarBid_Click_1(object sender, EventArgs e)
        {
                btnDeal.Visible = true;
                scene.Player.TotalMoney -= 10;
                lblPlayerMoney.Text = "Player total:" + "$" + scene.Player.TotalMoney.ToString();
                scene.Bid += 10;
                lblBid.Text = "Bid: $" + scene.Bid.ToString();
            
        }

        public void updateScore()
        {
            lblPlayerScore.Text = "Player: "+ scene.Player.Score.ToString();
            lblDealerScore.Text = "Dealer: " + scene.Dealer.Score.ToString();

        }

        //public void updateTotalMoneyOfPlayer()
        //{
        //    int bidMoney = int.Parse(lblBid.Text.Substring(1, lblBid.Text.Length));
        //    int totalWinMoney = bidMoney * 2;
        //    lblPlayerMoney.Text += totalWinMoney.ToString();
        //}

        public void checkIf21()
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            timerTicks++;
            if (firstCardsMoving)
            {
                scene.moveDealerCard(firstRandomDealerCard);

                scene.movePlayerCard(firstRandomPlayerCard);           
               
                if (timerTicks == 30)
                {

                    scene.Player.Score+= firstRandomPlayerCard.Value;
                   // scene.Dealer.Score+= firstRandomDealerCard.Value;
                    updateScore();
           
                    firstCardsMoving = false;
                    secondCardsMoving = true;
                    timerTicks = 0;
                }
            }

            if (secondCardsMoving)
            {
                scene.moveDealerCard(secondRandomDealerCard);

                scene.movePlayerCard(secondRandomPlayerCard);
                if (timerTicks == 27)
                {
                    scene.Player.Score+= secondRandomPlayerCard.Value;
                    scene.Dealer.Score += secondRandomDealerCard.Value;
                    updateScore();
                //    updateTotalCards();

                    secondCardsMoving = false;
                    timerTicks = 0;
                    timer1.Stop();
                    //if (scene.Player.Score == 21)
                    //{
                    //    updateTotalMoneyOfPlayer();
                    //    MessageBox.Show("You win !!", "Black Jack", MessageBoxButtons.OK);
                       
                    //}
                }
            }

           

            Invalidate();
        }
      
        

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scene.Player.Draw(e.Graphics);
            scene.Dealer.Draw(e.Graphics);

           

        }

        private void btnDeal_Click(object sender, EventArgs e)
        {
            lblPlayerScore.Visible = true;
            lblDealerScore.Visible = true;
            btnHit.Visible = true;
            btnStand.Visible = true;
            btnDeal.Visible = false;
            rbFiveDollarsBid.Visible = false;
            rbFiftyDollarBid.Visible = false;
            rbTenDollarBid.Visible = false;
            timer1.Start();
 
        }


    }
}
