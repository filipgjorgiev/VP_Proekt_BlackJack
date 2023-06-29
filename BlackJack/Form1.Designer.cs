
namespace BlackJack
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblBid = new System.Windows.Forms.Label();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStand = new System.Windows.Forms.Button();
            this.lblPlayerMoney = new System.Windows.Forms.Label();
            this.pbCard1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnDeal = new System.Windows.Forms.Button();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.lblDealerScore = new System.Windows.Forms.Label();
            this.lblTotalCards = new System.Windows.Forms.Label();
            this.timerHit = new System.Windows.Forms.Timer(this.components);
            this.timerStand = new System.Windows.Forms.Timer(this.components);
            this.btnAllIn = new System.Windows.Forms.Button();
            this.rbTenDollarBid = new BlackJack.RoundButton();
            this.rbFiftyDollarBid = new BlackJack.RoundButton();
            this.rbFiveDollarsBid = new BlackJack.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBid
            // 
            this.lblBid.AutoSize = true;
            this.lblBid.BackColor = System.Drawing.Color.Transparent;
            this.lblBid.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.8F);
            this.lblBid.ForeColor = System.Drawing.Color.White;
            this.lblBid.Location = new System.Drawing.Point(445, 366);
            this.lblBid.Name = "lblBid";
            this.lblBid.Size = new System.Drawing.Size(0, 48);
            this.lblBid.TabIndex = 0;
            // 
            // btnHit
            // 
            this.btnHit.BackColor = System.Drawing.Color.White;
            this.btnHit.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.8F);
            this.btnHit.ForeColor = System.Drawing.Color.White;
            this.btnHit.Image = global::BlackJack.Properties.Resources.Green_Table11;
            this.btnHit.Location = new System.Drawing.Point(711, 322);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(207, 127);
            this.btnHit.TabIndex = 1;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = false;
            this.btnHit.Visible = false;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnStand
            // 
            this.btnStand.BackColor = System.Drawing.Color.White;
            this.btnStand.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.8F);
            this.btnStand.ForeColor = System.Drawing.Color.White;
            this.btnStand.Image = global::BlackJack.Properties.Resources.Green_Table11;
            this.btnStand.Location = new System.Drawing.Point(136, 322);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(199, 136);
            this.btnStand.TabIndex = 3;
            this.btnStand.Text = "Stand";
            this.btnStand.UseVisualStyleBackColor = false;
            this.btnStand.Visible = false;
            this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // lblPlayerMoney
            // 
            this.lblPlayerMoney.AutoSize = true;
            this.lblPlayerMoney.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.8F);
            this.lblPlayerMoney.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lblPlayerMoney.Location = new System.Drawing.Point(12, 719);
            this.lblPlayerMoney.Name = "lblPlayerMoney";
            this.lblPlayerMoney.Size = new System.Drawing.Size(316, 44);
            this.lblPlayerMoney.TabIndex = 5;
            this.lblPlayerMoney.Text = "Player total: $200";
            // 
            // pbCard1
            // 
            this.pbCard1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbCard1.BackgroundImage")));
            this.pbCard1.Image = global::BlackJack.Properties.Resources.card_back_red11;
            this.pbCard1.Location = new System.Drawing.Point(1090, 490);
            this.pbCard1.Margin = new System.Windows.Forms.Padding(0);
            this.pbCard1.Name = "pbCard1";
            this.pbCard1.Size = new System.Drawing.Size(133, 181);
            this.pbCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCard1.TabIndex = 6;
            this.pbCard1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::BlackJack.Properties.Resources.Green_Table11;
            this.pictureBox2.Image = global::BlackJack.Properties.Resources.card_back_red11;
            this.pictureBox2.Location = new System.Drawing.Point(1090, 91);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(133, 181);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnDeal
            // 
            this.btnDeal.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDeal.CausesValidation = false;
            this.btnDeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.8F);
            this.btnDeal.Image = global::BlackJack.Properties.Resources.Green_Table11;
            this.btnDeal.Location = new System.Drawing.Point(1038, 322);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(199, 127);
            this.btnDeal.TabIndex = 8;
            this.btnDeal.Text = "DEAL";
            this.btnDeal.UseVisualStyleBackColor = false;
            this.btnDeal.Visible = false;
            this.btnDeal.Click += new System.EventHandler(this.btnDeal_Click);
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F);
            this.lblPlayerScore.Location = new System.Drawing.Point(464, 714);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(145, 51);
            this.lblPlayerScore.TabIndex = 9;
            this.lblPlayerScore.Text = "Player";
            this.lblPlayerScore.Visible = false;
            // 
            // lblDealerScore
            // 
            this.lblDealerScore.AutoSize = true;
            this.lblDealerScore.BackColor = System.Drawing.Color.Transparent;
            this.lblDealerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F);
            this.lblDealerScore.Location = new System.Drawing.Point(464, 18);
            this.lblDealerScore.Name = "lblDealerScore";
            this.lblDealerScore.Size = new System.Drawing.Size(149, 51);
            this.lblDealerScore.TabIndex = 10;
            this.lblDealerScore.Text = "Dealer";
            this.lblDealerScore.Visible = false;
            // 
            // lblTotalCards
            // 
            this.lblTotalCards.AutoSize = true;
            this.lblTotalCards.Location = new System.Drawing.Point(77, 52);
            this.lblTotalCards.Name = "lblTotalCards";
            this.lblTotalCards.Size = new System.Drawing.Size(0, 17);
            this.lblTotalCards.TabIndex = 13;
            // 
            // timerHit
            // 
            this.timerHit.Interval = 30;
            this.timerHit.Tick += new System.EventHandler(this.timerHit_Tick);
            // 
            // timerStand
            // 
            this.timerStand.Interval = 30;
            this.timerStand.Tick += new System.EventHandler(this.timerStand_Tick);
            // 
            // btnAllIn
            // 
            this.btnAllIn.BackColor = System.Drawing.Color.DarkBlue;
            this.btnAllIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.btnAllIn.ForeColor = System.Drawing.Color.White;
            this.btnAllIn.Location = new System.Drawing.Point(20, 480);
            this.btnAllIn.Name = "btnAllIn";
            this.btnAllIn.Size = new System.Drawing.Size(130, 52);
            this.btnAllIn.TabIndex = 14;
            this.btnAllIn.Text = "All-in";
            this.btnAllIn.UseVisualStyleBackColor = false;
            this.btnAllIn.Click += new System.EventHandler(this.btnAllIn_Click);
            // 
            // rbTenDollarBid
            // 
            this.rbTenDollarBid.BackColor = System.Drawing.Color.Transparent;
            this.rbTenDollarBid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.rbTenDollarBid.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rbTenDollarBid.Image = global::BlackJack.Properties.Resources.black_poker_chip;
            this.rbTenDollarBid.Location = new System.Drawing.Point(147, 550);
            this.rbTenDollarBid.Name = "rbTenDollarBid";
            this.rbTenDollarBid.Size = new System.Drawing.Size(119, 105);
            this.rbTenDollarBid.TabIndex = 12;
            this.rbTenDollarBid.Text = "$10";
            this.rbTenDollarBid.UseVisualStyleBackColor = false;
            this.rbTenDollarBid.Click += new System.EventHandler(this.rbTenDollarBid_Click_1);
            // 
            // rbFiftyDollarBid
            // 
            this.rbFiftyDollarBid.BackColor = System.Drawing.Color.Transparent;
            this.rbFiftyDollarBid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.rbFiftyDollarBid.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rbFiftyDollarBid.Image = global::BlackJack.Properties.Resources.red_poker_chip;
            this.rbFiftyDollarBid.Location = new System.Drawing.Point(293, 550);
            this.rbFiftyDollarBid.Name = "rbFiftyDollarBid";
            this.rbFiftyDollarBid.Size = new System.Drawing.Size(123, 105);
            this.rbFiftyDollarBid.TabIndex = 11;
            this.rbFiftyDollarBid.Text = "$50";
            this.rbFiftyDollarBid.UseVisualStyleBackColor = false;
            this.rbFiftyDollarBid.Click += new System.EventHandler(this.rbFiftyDollarBid_Click);
            // 
            // rbFiveDollarsBid
            // 
            this.rbFiveDollarsBid.BackColor = System.Drawing.Color.Transparent;
            this.rbFiveDollarsBid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbFiveDollarsBid.BackgroundImage")));
            this.rbFiveDollarsBid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.rbFiveDollarsBid.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rbFiveDollarsBid.Image = global::BlackJack.Properties.Resources.poker_chip2;
            this.rbFiveDollarsBid.Location = new System.Drawing.Point(12, 555);
            this.rbFiveDollarsBid.Name = "rbFiveDollarsBid";
            this.rbFiveDollarsBid.Size = new System.Drawing.Size(110, 100);
            this.rbFiveDollarsBid.TabIndex = 4;
            this.rbFiveDollarsBid.Text = "$5";
            this.rbFiveDollarsBid.UseVisualStyleBackColor = false;
            this.rbFiveDollarsBid.Click += new System.EventHandler(this.rbFiveDollarsBid_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::BlackJack.Properties.Resources.Green_Table11;
            this.ClientSize = new System.Drawing.Size(1306, 840);
            this.Controls.Add(this.btnAllIn);
            this.Controls.Add(this.lblTotalCards);
            this.Controls.Add(this.rbTenDollarBid);
            this.Controls.Add(this.rbFiftyDollarBid);
            this.Controls.Add(this.lblDealerScore);
            this.Controls.Add(this.lblPlayerScore);
            this.Controls.Add(this.btnDeal);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pbCard1);
            this.Controls.Add(this.lblPlayerMoney);
            this.Controls.Add(this.rbFiveDollarsBid);
            this.Controls.Add(this.btnStand);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.lblBid);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pbCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBid;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStand;
        private RoundButton rbFiveDollarsBid;
        private System.Windows.Forms.Label lblPlayerMoney;
        private System.Windows.Forms.PictureBox pbCard1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnDeal;
        private System.Windows.Forms.Label lblPlayerScore;
        private System.Windows.Forms.Label lblDealerScore;
        private RoundButton rbFiftyDollarBid;
        private RoundButton rbTenDollarBid;
        private System.Windows.Forms.Label lblTotalCards;
        private System.Windows.Forms.Timer timerHit;
        private System.Windows.Forms.Timer timerStand;
        private System.Windows.Forms.Button btnAllIn;
    }
}

