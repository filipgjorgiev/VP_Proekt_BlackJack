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



        int DealTimerTicks = 0;

        int HitTimerTicks = 0;

        int StandTimerTicks = 0;

        Card firstRandomPlayerCard;
        Card secondRandomPlayerCard;
        Card firstRandomDealerCard;
        Card secondRandomDealerCard;

        Card HitRandomPlayerCard;

        Card StandRandomDealerCard;

        private bool firstCardsMoving = true;
        private bool secondCardsMoving = false;

        private bool dealerCardMoving = false;

        private Image actualImage;

        Random random = new Random();

        int stopPosition;

        int HitCardStopPosition;

        int StandCardStopPosition;



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
            this.Width = 1020;
            this.Height = 710;

          
            scene = new Scene();
            this.DoubleBuffered = true;


            lblBid.Text = "Bid: $0";



        }


        public void updateFiveDollarsBid()
        {
            scene.Player.TotalMoney -= 5;
            scene.Bid += 5;
            lblPlayerMoney.Text = "Player total: " + "$" + scene.Player.TotalMoney.ToString();
            lblBid.Text = "Bid: $" + scene.Bid.ToString();
        }

        private void rbFiveDollarsBid_Click(object sender, EventArgs e)
        {
            if (scene.Player.TotalMoney - 5 < 50)
            {
                rbFiftyDollarBid.Visible = false;
                if (scene.Player.TotalMoney - 5 < 10)
                {
                    rbTenDollarBid.Visible = false;
                }
                if (scene.Player.TotalMoney - 5 == 0)
                {
                    rbFiveDollarsBid.Visible = false;
                    btnAllIn.Visible = false;
                    btnCashOut.Visible = false;

                }
            }
          
            updateFiveDollarsBid();
             
            btnDeal.Visible = true;

        }

        private void updateFiftyDollarsBid()
        {
            scene.Player.TotalMoney -= 50;
            lblPlayerMoney.Text = "Player total: " + "$" + scene.Player.TotalMoney.ToString();
            scene.Bid += 50;
            lblBid.Text = "Bid: $" + scene.Bid.ToString();
        }

        private void rbFiftyDollarBid_Click(object sender, EventArgs e)
        {
            if (scene.Player.TotalMoney - 50 < 50)
            {
                if (scene.Player.TotalMoney - 50 < 10)
                {
                    rbTenDollarBid.Visible = false;
                }
                if (scene.Player.TotalMoney - 50 == 0)
                {
                    rbFiveDollarsBid.Visible = false;
                    rbTenDollarBid.Visible = false;
                    btnAllIn.Visible = false;
                    btnCashOut.Visible = false;

                }
                rbFiftyDollarBid.Visible = false;
             
                btnDeal.Visible = true;

            }
           

            updateFiftyDollarsBid();
            btnDeal.Visible = true;

        }

        private void updateTenDollarsBid()
        {
            scene.Player.TotalMoney -= 10;
            lblPlayerMoney.Text = "Player total: " + "$" + scene.Player.TotalMoney.ToString();
            scene.Bid += 10;
            lblBid.Text = "Bid: $" + scene.Bid.ToString();
        }

        private void rbTenDollarBid_Click_1(object sender, EventArgs e)
        {

            if (scene.Player.TotalMoney - 10 < 50)
            {
                rbFiftyDollarBid.Visible = false;
                if (scene.Player.TotalMoney - 10 < 10)
                {
                    rbTenDollarBid.Visible = false;
                }

                if (scene.Player.TotalMoney - 10 == 0)
                {

                    rbFiveDollarsBid.Visible = false;
                    btnAllIn.Visible = false;
                    btnCashOut.Visible = false;


                }
            }
            


            updateTenDollarsBid();
            btnDeal.Visible = true;

        }


        public void updateScore()
        {
            // scene.Player.CalculateScore();
            lblPlayerScore.Text = "Player: " + scene.Player.Score.ToString();
            lblDealerScore.Text = "Dealer: " + scene.Dealer.Score.ToString();

        }

        public void updateTotalMoneyOfPlayer()
        {
            int bidMoney = scene.Bid;
            scene.Player.TotalMoney += bidMoney*2;
            
            lblPlayerMoney.Text = "Player total: $" + scene.Player.TotalMoney.ToString();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {


            DealTimerTicks++;
            if (firstCardsMoving)
            {
                scene.moveDealerCard(firstRandomDealerCard);

                scene.movePlayerCard(firstRandomPlayerCard);

                if (DealTimerTicks == 28)
                {
                    stopPosition = DealTimerTicks - 3; ;
                    scene.Player.Score += firstRandomPlayerCard.Value;
              
                    updateScore();
                  //  updateTotalCards();
                    firstCardsMoving = false;
                    secondCardsMoving = true;
                    DealTimerTicks = 0;
                }
            }

            if (secondCardsMoving)
            {
                scene.moveDealerCard(secondRandomDealerCard);

                scene.movePlayerCard(secondRandomPlayerCard);
                if (DealTimerTicks == stopPosition)
                {
                    stopPosition = DealTimerTicks -4;
                    if(firstRandomPlayerCard.Rank=="Ace" && secondRandomPlayerCard.Rank == "Ace")
                    {
                        secondRandomPlayerCard.Value = 1;
                    }

                    

                    scene.Player.Score += secondRandomPlayerCard.Value;
                    scene.Dealer.Score += secondRandomDealerCard.Value;
                    updateScore();
            

                    secondCardsMoving = false;
                    firstCardsMoving = true;
                    DealTimerTicks = 0;
                    HitCardStopPosition = stopPosition+3;
                    StandCardStopPosition = stopPosition+3;
                    btnHit.Visible = true;
                    btnStand.Visible = true;
                    timer1.Stop();
         
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
            generateFirstRandomCards();
            lblPlayerScore.Visible = true;
            lblDealerScore.Visible = true;
        
            btnDeal.Visible = false;
            btnAllIn.Visible = false;
            btnCashOut.Visible = false;
            rbFiveDollarsBid.Visible = false;
            rbFiftyDollarBid.Visible = false;
            rbTenDollarBid.Visible = false;
            timer1.Start();

        }



        private void btnHit_Click(object sender, EventArgs e)
        {
            btnHit.Visible = false;
            btnStand.Visible = false;
            int randomIndexOfPlayerCard = random.Next(0, scene.Cards.Count);
            HitRandomPlayerCard = scene.Cards.ElementAt(randomIndexOfPlayerCard);
            if (HitRandomPlayerCard.Rank == "Ace")
            {
                if (scene.Player.Score + HitRandomPlayerCard.Value > 21)
                {
                    HitRandomPlayerCard.Value = 1;
                }
            }
            scene.Cards.Remove(HitRandomPlayerCard);
            scene.Player.Hand.Add(HitRandomPlayerCard);

            scene.Player.Score += HitRandomPlayerCard.Value;
       
            timerHit.Start();
        }

        private void Reset()
        {
            firstCardsMoving = true;
            secondCardsMoving = false;

            dealerCardMoving = false;

            DealTimerTicks = 0;

            HitTimerTicks = 0;

            StandTimerTicks = 0;

            scene.Bid = 0;
            if (scene.Cards.Count < 15) // check if the total cards are less than 15
            {
                scene = new Scene(); // reset the scene and put back all cards

            }
      
            scene.Dealer.Reset();
            scene.Player.Reset();
            btnHit.Visible = false;
            btnStand.Visible = false;
            btnAllIn.Visible = true;
            lblDealerScore.Text = "";
            lblPlayerScore.Text = "";
            lblBid.Text = "Bid: $0";
            rbFiftyDollarBid.Visible = true;
            rbFiveDollarsBid.Visible = true;
            rbTenDollarBid.Visible = true;
            btnDeal.Visible = false;
            btnCashOut.Visible = true;

       
            resetChips();

        }

        private void resetChips()
        {
            if (scene.Player.TotalMoney == 0)
            {
                rbFiftyDollarBid.Visible = false;
                rbFiveDollarsBid.Visible = false;
                rbTenDollarBid.Visible = false;
            }
            if (scene.Player.TotalMoney < 50)
            {
                rbFiftyDollarBid.Visible = false;
            }

            if (scene.Player.TotalMoney < 10)
            {
                rbTenDollarBid.Visible = false;
            }
          
           
        }


        private void ResetGame()
        {
            if (scene.Player.TotalMoney == 0)
            {
                DialogResult result = MessageBox.Show("You lost all your money. Do you want to start a new game?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    Close();
                }
                else
                {
                    Reset();
                    scene.Player.TotalMoney = 200;
                    rbTenDollarBid.Visible = true;
                    rbFiveDollarsBid.Visible = true;
                    rbFiftyDollarBid.Visible = true;

                    lblPlayerMoney.Text = "Player money: $200";
                }

            }
            else
            {
                Reset();
            }
          
        }

        private void timerHit_Tick(object sender, EventArgs e)
        {
           
            scene.movePlayerCard(HitRandomPlayerCard);
            HitTimerTicks++;
            if (HitTimerTicks == HitCardStopPosition)
            {

                HitCardStopPosition = HitTimerTicks-2;
                updateScore();
                if (scene.Player.Score > 21)
                {
                    timerHit.Stop();

                    showMessageBoxForLost();


                    HitTimerTicks = 0;


                }
                else
                {
                    HitTimerTicks = 0;
                    btnHit.Visible = true;
                    btnStand.Visible = true;
                    timerHit.Stop();
                }

            }

            Invalidate();
        }

        private void showMessageBoxForNeutral()
        {
            DialogResult result = MessageBox.Show("No one won, the score of both is 21", "", MessageBoxButtons.OK);
            if (result == DialogResult.OK)
            {
                ResetGame();
            }
        }


        private void showMessageBoxForLost()
        {
            DialogResult result = MessageBox.Show("Dealer wins !!!", "Bust!", MessageBoxButtons.OK);
            if (result == DialogResult.OK)
            {
                ResetGame();
            }
        }

        private void showMessageBoxForWin()
        {
            DialogResult result = MessageBox.Show("You win !!!", "Congratulations!", MessageBoxButtons.OK);
            if (result == DialogResult.OK)
            {
                ResetGame();
            }
        }

        private void timerStand_Tick(object sender, EventArgs e)
        {
            StandTimerTicks++;
            if (!dealerCardMoving)
            {
                if (scene.Dealer.Score > scene.Player.Score)
                {
                    timerStand.Stop();
                    showMessageBoxForLost();
                  
                }
                else
                {
                    
                    dealerCardMoving = true;
                    StandTimerTicks = 0;
                    int randomDealerCardIndex = random.Next(0, scene.Cards.Count);
                    StandRandomDealerCard = scene.Cards.ElementAt(randomDealerCardIndex);
                    if (StandRandomDealerCard.Rank == "Ace")
                    {
                        if (scene.Dealer.Score + StandRandomDealerCard.Value > 21)
                        {
                            StandRandomDealerCard.Value = 1;
                        }
                    }
                    scene.Dealer.Hand.Add(StandRandomDealerCard);
                    scene.Cards.Remove(StandRandomDealerCard);

              
                }

            }

            else
            {

                if (StandTimerTicks!= StandCardStopPosition)
                {
                    scene.moveDealerCard(StandRandomDealerCard);
                }
                else 
                {

                    timerStand.Stop();
                    StandCardStopPosition-=2;
                    scene.Cards.Remove(StandRandomDealerCard);
                    scene.Dealer.Hand.Add(StandRandomDealerCard);
                    scene.Dealer.Score += StandRandomDealerCard.Value;

                    updateScore();
                    if (scene.Dealer.Score > 21)
                    {
                        timerStand.Stop();
                        updateTotalMoneyOfPlayer();

                        showMessageBoxForWin();

                    }
                    else if (scene.Dealer.Score > scene.Player.Score)
                    {
                        timerStand.Stop();
                        showMessageBoxForLost();
                    } 
                    else if(scene.Dealer.Score==21 && scene.Player.Score == 21)
                    {
                        timerStand.Stop();
                        scene.Player.TotalMoney += scene.Bid;
                        scene.Bid = 0;
                        showMessageBoxForNeutral();
                    }
                    else
                    {
                        dealerCardMoving = false;
                        StandTimerTicks = 0;

                        timerStand.Start();
                      

                    }


                }


            }
            Invalidate();


        }

    
            private void btnStand_Click(object sender, EventArgs e)
            {
                Card firstDealerCoveredCard = scene.Dealer.Hand.ElementAt(0);
                firstDealerCoveredCard.Image = actualImage;
                if (secondRandomDealerCard.Rank == "Ace" && firstDealerCoveredCard.Rank=="Ace")
                {
                    secondRandomDealerCard.Value = 1;
                }
          
                scene.Dealer.Score += firstDealerCoveredCard.Value;

                updateScore();
                
                if(scene.Dealer.Score==21 && scene.Player.Score == 21)
                {
                     scene.Player.TotalMoney += scene.Bid;
                     scene.Bid = 0;
                     showMessageBoxForNeutral();
            }
              
                btnHit.Visible = false;
                btnStand.Visible = false;

                timerStand.Start();

                Invalidate();
            }

        private void btnAllIn_Click(object sender, EventArgs e)
        {
            
            scene.Bid += scene.Player.TotalMoney;
            scene.Player.TotalMoney = 0;
            lblBid.Text = "Bid: $" + scene.Bid;
            lblPlayerMoney.Text = "Player total: $0";
            rbFiftyDollarBid.Visible = false;
            rbFiveDollarsBid.Visible = false;
            rbTenDollarBid.Visible = false;
            btnDeal.Visible = true;
            btnAllIn.Visible = false;
            btnCashOut.Visible = false;

        }

        private void btnCashOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("You won $" +scene.Player.TotalMoney+ ". Do you want to start a new game?","",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                Close();
            }
            else
            {
                Reset();
                scene.Player.TotalMoney = 200;
                rbTenDollarBid.Visible = true;
                rbFiveDollarsBid.Visible = true;
                rbFiftyDollarBid.Visible = true;
                lblPlayerMoney.Text = "Player money: $200";
            }
        }

       
    }
    }

