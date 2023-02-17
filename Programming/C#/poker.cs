string[] PokerCard = new String[5];

            PokerCard[0] = PokerCard1.ImageUrl = Path.Combine("~/GameStyles/VideoPoker/Images/BackCards/BackCard1.png");
            PokerCard[1] = PokerCard2.ImageUrl = Path.Combine("~/GameStyles/VideoPoker/Images/BackCards/BackCard2.png");
            PokerCard[2] = PokerCard3.ImageUrl = Path.Combine("~/GameStyles/VideoPoker/Images/BackCards/BackCard3.png");
            PokerCard[3] = PokerCard4.ImageUrl = Path.Combine("~/GameStyles/VideoPoker/Images/BackCards/BackCard4.png");
            PokerCard[4] = PokerCard5.ImageUrl = Path.Combine("~/GameStyles/VideoPoker/Images/BackCards/BackCard5.png");    

  public void Pair()
    {
        for (int i = 0; i < 4; i++)
        {
            for (int k = 0; k < 5; k++)
            {
                if (PokerCard[k] == two[i])
                {
                    PokerTwo++;
                }
                if (PokerTwo == 2)
                {
                    cash = cash + 10;
                    winnings = winnings + 10;
                    Cash.Text = Convert.ToString(cash);
                    Winnings.Text = Convert.ToString(winnings);
                    PairWin.BackColor = Color.Red;
                    Winner.Visible = true;
                    return;
                }
                if (PokerCard[k] == three[i])
                {
                    PokerThree++;
                }
                if (PokerThree == 2)
                {
                    cash = cash + 10;
                    winnings = winnings + 10;
                    Cash.Text = Convert.ToString(cash);
                    Winnings.Text = Convert.ToString(winnings);
                    PairWin.BackColor = Color.Red;
                    Winner.Visible = true;
                    return;
                }
                if (PokerCard[k] == four[i])
                {
                    PokerFour++;
                }
                if (PokerFour == 2)
                {
                    cash = cash + 10;
                    winnings = winnings + 10;
                    Cash.Text = Convert.ToString(cash);
                    Winnings.Text = Convert.ToString(winnings);
                    PairWin.BackColor = Color.Red;
                    Winner.Visible = true;
                    return;
                }
                if (PokerCard[k] == five[i])
                {
                    PokerFive++;
                }
                if (PokerFive == 2)
                {
                    cash = cash + 10;
                    winnings = winnings + 10;
                    Cash.Text = Convert.ToString(cash);
                    Winnings.Text = Convert.ToString(winnings);
                    PairWin.BackColor = Color.Red;
                    Winner.Visible = true;
                    return;
                }
                if (PokerCard[k] == six[i])
                {
                    PokerSix++;
                }
                if (PokerSix == 2)
                {
                    cash = cash + 10;
                    winnings = winnings + 10;
                    Cash.Text = Convert.ToString(cash);
                    Winnings.Text = Convert.ToString(winnings);
                    PairWin.BackColor = Color.Red;
                    Winner.Visible = true;
                    return;
                }
                if (PokerCard[k] == seven[i])
                {
                    PokerSeven++;
                }
                if (PokerSeven == 2)
                {
                    cash = cash + 10;
                    winnings = winnings + 10;
                    Cash.Text = Convert.ToString(cash);
                    Winnings.Text = Convert.ToString(winnings);
                    PairWin.BackColor = Color.Red;
                    Winner.Visible = true;
                    return;
                }
                if (PokerCard[k] == eight[i])
                {
                    PokerEight++;
                }
                if (PokerEight == 2)
                {
                    cash = cash + 10;
                    winnings = winnings + 10;
                    Cash.Text = Convert.ToString(cash);
                    Winnings.Text = Convert.ToString(winnings);
                    PairWin.BackColor = Color.Red;
                    Winner.Visible = true;
                    return;
                }
                if (PokerCard[k] == nine[i])
                {
                    PokerNine++;
                }
                if (PokerNine == 2)
                {
                    cash = cash + 10;
                    winnings = winnings + 10;
                    Cash.Text = Convert.ToString(cash);
                    Winnings.Text = Convert.ToString(winnings);
                    PairWin.BackColor = Color.Red;
                    Winner.Visible = true;
                    return;
                }
                if (PokerCard[k] == ten[i])
                {
                    PokerTen++;
                }
                if (PokerTen == 2)
                {
                    cash = cash + 10;
                    winnings = winnings + 10;
                    Cash.Text = Convert.ToString(cash);
                    Winnings.Text = Convert.ToString(winnings);
                    PairWin.BackColor = Color.Red;
                    Winner.Visible = true;
                    return;
                }
                if (PokerCard[k] == jack[i])
                {
                    PokerJack++;
                }
                if (PokerJack == 2)
                {
                    cash = cash + 10;
                    winnings = winnings + 10;
                    Cash.Text = Convert.ToString(cash);
                    Winnings.Text = Convert.ToString(winnings);
                    PairWin.BackColor = Color.Red;
                    Winner.Visible = true;
                    return;
                }
                if (PokerCard[k] == queen[i])
                {
                    PokerQueen++;
                }
                if (PokerQueen == 2)
                {
                    cash = cash + 10;
                    winnings = winnings + 10;
                    Cash.Text = Convert.ToString(cash);
                    Winnings.Text = Convert.ToString(winnings);
                    PairWin.BackColor = Color.Red;
                    Winner.Visible = true;
                    return;
                }
                if (PokerCard[k] == king[i])
                {
                    PokerKing++;
                }
                if (PokerKing == 2)
                {
                    cash = cash + 10;
                    winnings = winnings + 10;
                    Cash.Text = Convert.ToString(cash);
                    Winnings.Text = Convert.ToString(winnings);
                    PairWin.BackColor = Color.Red;
                    Winner.Visible = true;
                    return;
                }
                if (PokerCard[k] == ace[i])
                {
                    PokerAce++;
                }
                if (PokerAce == 2)
                {
                    cash = cash + 10;
                    winnings = winnings + 10;
                    Cash.Text = Convert.ToString(cash);
                    Winnings.Text = Convert.ToString(winnings);
                    PairWin.BackColor = Color.Red;
                    Winner.Visible = true;
                    return;
                }
            }
        }
    }