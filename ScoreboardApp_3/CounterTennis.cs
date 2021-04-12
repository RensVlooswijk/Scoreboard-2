using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreboardApp_3
{
    public partial class CounterTennis : Form
    {
        int Player1ScoreCounter = 0;
        int Player2ScoreCounter = 0;
        int Player1GameCounter = 0;
        int Player2GameCounter = 0;
        public CounterTennis()
        {
            InitializeComponent();
            SportPicker.Items.Add("Volleyball");
        }

        private void SportSwitcher_Click(object sender, EventArgs e)
        {
            if (SportPicker.SelectedItem == "Volleyball")
            {
                this.Hide();
                var CounterPage = new CounterPage();
                CounterPage.Closed += (s, args) => this.Close();
                CounterPage.Show();
            }
        }

        private void PlayerGameWin_Click(object sender, EventArgs e)
        {
            AreYouSurePlayer2Panel.Visible = true;
        }

        private void Player2Yes_Click(object sender, EventArgs e)
        {
          //  Player2GamesWon = Player2GameCounter + 1;
            Player1ScoreCounter = 0;
            Player2ScoreCounter = 0;
            Player1Score.Text = Player1ScoreCounter.ToString();
            Player2Score.Text = Player2ScoreCounter.ToString();
            Player2GamesWon.Text = Player2GameCounter.ToString();
            AreYouSurePlayer2Panel.Visible = false;
        }
    }
}
