using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using ScoreboardApp_3;


namespace ScoreboardApp_3
{
    public partial class CounterPage : Form
    {
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
        SpeechSynthesizer Synth = new SpeechSynthesizer();
        private SqlConnection sc;
        private SqlCommand com;
        public int HomeScoreCounter = 0;
        public int AwayScoreCounter = 0;
        public int HomeSetCounter = 0;
        public int AwaySetCounter = 0;
        public int HomeGameCounter = 0;
        public int AwayGameCounter = 0;
        public int AddValue = 0;
        public string HomeTeamName;
        public string CurrentSport;


        public CounterPage()
        {
            InitializeComponent();
            //get the date so I can send that to the database once you end the game
            string date = DateTime.UtcNow.ToString("MM-dd-yyyy");
            date_txt.Text = date;
            //add sports so you can switch with Volleyball as default
            SportPicker.Items.Add("Tennis");
            SportPicker.Items.Add("Volleyball");
            CurrentSport = "Volleyball";
            HomeTeamName = HomeTeam.Text;
        }


        public void CounterPage_Load(object sender, EventArgs e)
        {
            //VoiceControl VC = new VoiceControl();
            //VC.Voice();
            //add all the available voice commands plus the voice recognition engine
            Choices commands = new Choices();
            commands.Add(new string[] {"Home", "Guest", "Player one", "Player two", "End Game", "yes I am sure", "no dont end the game", "remove point left", "remove point right", "voice help", "okey", "home set", "guest set", "yes", "no", "player one set", "player two set", "player one game", "player two game", "score", "sets", "games" });
            GrammarBuilder gBuilder = new GrammarBuilder();
            gBuilder.Append(commands);
            Grammar grammar = new Grammar(gBuilder);

            recEngine.LoadGrammarAsync(grammar);
            recEngine.SetInputToDefaultAudioDevice();
            Synth.SetOutputToDefaultAudioDevice();
            recEngine.SpeechRecognized += RecEngine_SpeechRecognized;
        }

        void RecEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            //assign all the voice commands to specific button clicks
            switch (e.Result.Text)
            {
                case "Home":
                    HomeScore.PerformClick();
                    break;
                case "Guest":
                    AwayScore.PerformClick();
                    break;
                case "Player one":
                    HomeScore.PerformClick();
                    break;
                case "Player two":
                    AwayScore.PerformClick();
                    break;
                case "End Game":
                    EndGameSecurityPanel.Visible = true;
                    break;
                case "yes I am sure":
                    EndGameYes.PerformClick();
                    break;
                case "no dont end the game":
                    EndGameSecurityPanel.Visible = false;
                    break;
                case "remove point left":
                    RemoveHomeScore.PerformClick();
                    break;
                case "remove point right":
                    RemoveAwayScore.PerformClick();
                    break;
                case "voice help":
                    VoiceHelpPanel.Visible = true;
                    break;
                case "okey":
                    VoiceHelpOk.PerformClick();
                    break;
                case "home set":
                    HomeSetWin.PerformClick();
                    break;
                case "guest set":
                    AwaySetWin.PerformClick();
                    break;
                case "yes":
                    HomeYes.PerformClick();
                    AwayYes.PerformClick();
                    HomeGameWonYes.PerformClick();
                    AwayGameWonYes.PerformClick();
                    break;
                case "no":
                    HomeNo.PerformClick();
                    AwayNo.PerformClick();
                    HomeGameWonNo.PerformClick();
                    AwayGameWonNo.PerformClick();
                    break;
                case "player one set":
                    HomeSetWin.PerformClick();
                    break;
                case "player two set":
                    AwaySetWin.PerformClick();
                    break;
                case "player one game":
                    HomeGameWin.PerformClick();
                    break;
                case "player two game":
                    AwayGameWin.PerformClick();
                    break;
                case "score":
                    Synth.Speak(HomeTeam.Text);
                    Synth.Speak(HomeScore.Text);
                    Synth.Speak(AwayTeam.Text);
                    Synth.Speak(AwayScore.Text);
                    break;
                case "sets":
                    Synth.Speak(HomeTeam.Text);
                    Synth.Speak(HomeSetCounter.ToString());
                    Synth.Speak(AwayTeam.Text);
                    Synth.Speak(AwaySetCounter.ToString());
                    break;
                case "games":
                    Synth.Speak(HomeTeam.Text);
                    Synth.Speak(AwayGameCounter.ToString());
                    Synth.Speak(AwayTeam.Text);
                    Synth.Speak(HomeGameCounter.ToString());
                    break;
            }
        }

        public void btnEnable_Click(object sender, EventArgs e)
        {
            VoiceControl BtnEnable = new VoiceControl();
            BtnEnable.ButtonClickTestOn();
            //turn on the voice recognition
            recEngine.RecognizeAsync(RecognizeMode.Multiple);
            btnDisable.Enabled = true;
            btnEnable.Enabled = false;
        }

        public void btnDisable_Click(object sender, EventArgs e)
        {
            VoiceControl BtnDisable = new VoiceControl();
            BtnDisable.ButtonClickTestOff();
            //turn off the voice recognition
            recEngine.RecognizeAsyncStop();
            btnDisable.Enabled = false;
            btnEnable.Enabled = true;
        }

        public void MatchHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new MatchHistory();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void MyTeam_Click(object sender, EventArgs e)
        {
            this.Hide();
            var MyTeam = new MyTeam();
            MyTeam.Closed += (s, args) => this.Close();
            MyTeam.Show();
        }

        private void Leaderboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Leaderboard = new Leaderboard();
            Leaderboard.Closed += (s, args) => this.Close();
            Leaderboard.Show();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Login = new Login();
            Login.Closed += (s, args) => this.Close();
            Login.Show();
        }

        public void HomeScore_Click(object sender, EventArgs e)
        {
            CounterAlgorithms CA = new CounterAlgorithms();
            CA.CounterAlgorithm();
            //For volleyball every click just adds one point but for tennis the added points depend on its current score
            if (CurrentSport == "Volleyball")
                {
                    AddValue = 1;
                }
            if (CurrentSport == "Tennis")
            {
                if (HomeScoreCounter == 0 || HomeScoreCounter == 15)
                {
                    AddValue = 15;
                }
                if (HomeScoreCounter == 30)
                {
                    AddValue = 10;
                }
                if (HomeScoreCounter > 39)
                {
                    AddValue = 5;
                }
            }
            HomeScoreCounter = HomeScoreCounter + AddValue;
            HomeScore.Text = HomeScoreCounter.ToString();
        }

        public void AwayScore_Click(object sender, EventArgs e)
        {
            //and you need this for both the home team and the guest team
            if (CurrentSport == "Volleyball")
            {
                AddValue = 1;
            }
            if (CurrentSport == "Tennis")
            {
                if(AwayScoreCounter == 0 || AwayScoreCounter == 15)
                {
                    AddValue = 15;
                }
                if(AwayScoreCounter == 30)
                {
                    AddValue = 10;
                }
                if(AwayScoreCounter > 39)
                {
                    AddValue = 5;
                }
            }
            AwayScoreCounter = AwayScoreCounter + AddValue;
            AwayScore.Text = AwayScoreCounter.ToString();
        }

        private void HomeSetWin_Click(object sender, EventArgs e)
        {
            AreYouSureHomePanel.Visible = true;
        }

        private void AwaySetWin_Click(object sender, EventArgs e)
        {
            AreYouSureAwayPanel.Visible = true;
        }

        public async void RemoveAwayScore_Click(object sender, EventArgs e)
        {
            //if you want to remove a point its the same as adding but - the points
            AddValue = 0;
            if (CurrentSport == "Volleyball" && AwayScoreCounter > 0)
            {
                AddValue = -1;
            }
            if (CurrentSport == "Tennis")
            {
                if (AwayScoreCounter == 15 || AwayScoreCounter == 30)
                {
                    AddValue = -15;
                }
                if(AwayScoreCounter == 40)
                {
                    AddValue = -10;
                }
                if (AwayScoreCounter > 40)
                {
                    AddValue = -5;
                }
            }
            AwayScoreCounter = AwayScoreCounter + AddValue;
            AwayScore.Text = AwayScoreCounter.ToString();

            RemoveAwayScore.BackColor = Color.Red;
            await Task.Delay(TimeSpan.FromSeconds(0.5));
            RemoveAwayScore.BackColor = Color.CornflowerBlue;
        }

        public async void RemoveHomeScore_Click(object sender, EventArgs e)
        {
            AddValue = 0;
            if (CurrentSport == "Volleyball" && HomeScoreCounter > 0)
            {
                AddValue = -1;
            }
            if (CurrentSport == "Tennis")
            {
                if (HomeScoreCounter == 15 || HomeScoreCounter == 30)
                {
                    AddValue = -15;
                }
                if (HomeScoreCounter == 40)
                {
                    AddValue = -10;
                }
                if (HomeScoreCounter > 40)
                {
                    AddValue = -5;
                }
                
            }
            HomeScoreCounter = HomeScoreCounter + AddValue;
            HomeScore.Text = HomeScoreCounter.ToString();

            RemoveHomeScore.BackColor = Color.Red;
            await Task.Delay(TimeSpan.FromSeconds(0.5));
            RemoveHomeScore.BackColor = Color.CornflowerBlue;
        }

        private void Yes_Click(object sender, EventArgs e)
        {
            //I made a safety panel so you dont accidentally assign a set
            //this will add 1 point to the set score and clear the other fields
            HomeSetCounter = HomeSetCounter + 1;
            HomeScoreCounter = 0;
            AwayScoreCounter = 0;
            HomeScore.Text = HomeScoreCounter.ToString();
            AwayScore.Text = AwayScoreCounter.ToString();
            HomeSetsWon.Text = HomeSetCounter.ToString();
            AreYouSureHomePanel.Visible = false;
        }

        private void No_Click(object sender, EventArgs e)
        {
            AreYouSureHomePanel.Visible = false;
        }

        private void AwayYes_Click(object sender, EventArgs e)
        {
            //same as the yes_click but for the other team
            AwaySetCounter = AwaySetCounter + 1;
            HomeScoreCounter = 0;
            AwayScoreCounter = 0;
            AwayScore.Text = AwayScoreCounter.ToString();
            HomeScore.Text = HomeScoreCounter.ToString();
            AwaySetsWon.Text = AwaySetCounter.ToString();
            AreYouSureAwayPanel.Visible = false;
        }

        private void AwayNo_Click(object sender, EventArgs e)
        {
            AreYouSureAwayPanel.Visible = false;
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            RemovePointsPanel.Visible = false;
        }

        public void EndGame_Click(object sender, EventArgs e)
        {
            if (HomeTeam.Text != "" && AwayTeam.Text != "")
            {
                EndGameSecurityPanel.Visible = true;
            }
            else
                EndGamePanel.Visible = true;
        }

        private void EndGamePanelOk_Click(object sender, EventArgs e)
        {
            EndGamePanel.Visible = false;
        }

        private void EndGameYes_Click(object sender, EventArgs e)
        {
            // Make connection
            sc = new SqlConnection();
            com = new SqlCommand();
            sc.ConnectionString = @"Server=mssql.fhict.local;Database=dbi466388;User Id=dbi466388;Password=tuintafel12;";
            sc.Open();

            //Create Command
            if (CurrentSport == "Volleyball")
            {
                com.Connection = sc;
                com.CommandText = @"INSERT INTO MatchHistoryDatatable VALUES(@Home, @Away, @Home_Score, @Away_Score, @Referee, @date)";

                // Add Parameters
                com.Parameters.AddWithValue("@Away", AwayTeam.Text);
                com.Parameters.AddWithValue("@Home", HomeTeam.Text);
                com.Parameters.AddWithValue("@Away_Score", AwayGamesWon.Text);
                com.Parameters.AddWithValue("@Home_Score", HomeGamesWon.Text);
                com.Parameters.AddWithValue("@Referee", Referee.Text);
                com.Parameters.AddWithValue("@date", date_txt.Text);

                // Execute command & Close connection
                com.ExecuteNonQuery();
                sc.Close();
            }
            if (CurrentSport == "Tennis")
            {
                com.Connection = sc;
                com.CommandText = @"INSERT INTO TennisMatchHistory VALUES(@Player_One, @Player_Two, @p1_Games, @p2_Games, @Referee, @Date)";

                // Add Parameters
                com.Parameters.AddWithValue("@Player_One", HomeTeam.Text);
                com.Parameters.AddWithValue("@Player_Two", AwayTeam.Text);
                com.Parameters.AddWithValue("@p1_Games", HomeGamesWon.Text);
                com.Parameters.AddWithValue("@p2_Games", AwayGamesWon.Text);
                com.Parameters.AddWithValue("@Referee", Referee.Text);
                com.Parameters.AddWithValue("@date", date_txt.Text);

                // Execute command & Close connection
                com.ExecuteNonQuery();
                sc.Close();
            }
            //reset everything to 0 and remove all text
            HomeScoreCounter = 0;
            AwayScoreCounter = 0;
            AwayScore.Text = AwayScoreCounter.ToString();
            HomeScore.Text = HomeScoreCounter.ToString();
            HomeSetCounter = 0;
            AwaySetCounter = 0;
            HomeSetsWon.Text = "0";
            AwaySetsWon.Text = "0";
            HomeTeam.Text = "";
            AwayTeam.Text = "";
            Referee.Text = "";
            EndGameSecurityPanel.Visible = false;
        }

        private void EndGameNo_Click(object sender, EventArgs e)
        {
            EndGameSecurityPanel.Visible = false;
        }

        private void SportSwitcher_Click(object sender, EventArgs e)
        {
            if (SportPicker.SelectedItem == "Tennis")
            {
                SwitchTennisPanel.Visible = true;
            }
            if (SportPicker.SelectedItem == "Volleyball")
            {
                SwitchSportsPanel2.Visible = true;
            }
        }

        private void SwitchYes_Click(object sender, EventArgs e)
        {
            //changes to volleyball 
            //sets all the texts to the correct names
            CurrentSport = "Volleyball";
            label2.Text = "Home Team";
            label3.Text = "Guest Team";
            HomeScoreCounter = 0;
            AwayScoreCounter = 0;
            AwayScore.Text = AwayScoreCounter.ToString();
            HomeScore.Text = HomeScoreCounter.ToString();
            HomeSetCounter = 0;
            AwaySetCounter = 0;
            HomeSetsWon.Text = "0";
            AwaySetsWon.Text = "0";
            HomeTeam.Text = "";
            AwayTeam.Text = "";
            panel3.Visible = false;
            panel4.Visible = false;
            HomeGameWin.Visible = false;
            AwayGameWin.Visible = false;
            AwayGamesWonCounter.Visible = false;
            GamesWonCounter_txt.Visible = false;
            HomeGamesWon.Visible = false;
            AwayGamesWon.Visible = false;
            SwitchSportsPanel2.Visible = false;
        }

        private void SwitchTennisYes_Click(object sender, EventArgs e)
        {
            //switches to tennis
            //adds extra buttons and texts for the games system
            CurrentSport = "Tennis";
            label2.Text = "Player 1";
            label3.Text = "Player 2";
            HomeScoreCounter = 0;
            AwayScoreCounter = 0;
            AwayScore.Text = AwayScoreCounter.ToString();
            HomeScore.Text = HomeScoreCounter.ToString();
            HomeSetCounter = 0;
            AwaySetCounter = 0;
            HomeSetsWon.Text = "0";
            AwaySetsWon.Text = "0";
            HomeTeam.Text = "";
            AwayTeam.Text = "";
            panel3.Visible = true;
            panel4.Visible = true;
            HomeGameWin.Visible = true;
            AwayGameWin.Visible = true;
            AwayGamesWonCounter.Visible = true;
            GamesWonCounter_txt.Visible = true;
            HomeGamesWon.Visible = true;
            AwayGamesWon.Visible = true;
            SwitchTennisPanel.Visible = false;
        }

        private void SwitchTennisNo_Click(object sender, EventArgs e)
        {
            SwitchTennisPanel.Visible = false;
        }

        private void SwitchNo_Click(object sender, EventArgs e)
        {
            SwitchSportsPanel2.Visible = false;
        }

        private void HomeGameWin_Click(object sender, EventArgs e)
        {
            HomeGameWonPanel.Visible = true;
        }

        private void AwayGameWin_Click(object sender, EventArgs e)
        {
            AwayGameWonPanel.Visible = true;
        }

        private void HomeGameWonYes_Click(object sender, EventArgs e)
        {
            //same as sets wins but for tennis games
            HomeGameCounter = HomeGameCounter + 1;
            HomeScoreCounter = 0;
            AwayScoreCounter = 0;
            HomeScore.Text = HomeScoreCounter.ToString();
            AwayScore.Text = AwayScoreCounter.ToString();
            HomeGamesWon.Text = HomeGameCounter.ToString();
            HomeGameWonPanel.Visible = false;
        }

        private void AwayGameWonYes_Click(object sender, EventArgs e)
        {
            //same as sets wins but for tennis games
            AwayGameCounter = AwayGameCounter + 1;
            HomeScoreCounter = 0;
            AwayScoreCounter = 0;
            AwayScore.Text = AwayScoreCounter.ToString();
            HomeScore.Text = HomeScoreCounter.ToString();
            AwayGamesWon.Text = AwayGameCounter.ToString();
            AwayGameWonPanel.Visible = false;
        }

        private void VoiceHelpBtn_Click(object sender, EventArgs e)
        {
            VoiceHelpPanel.Visible = true;
        }

        private void VoiceHelpOk_Click(object sender, EventArgs e)
        {
            VoiceHelpPanel.Visible = false;
        }

        private void HomeGameWonNo_Click(object sender, EventArgs e)
        {
            HomeGameWonPanel.Visible = false;
        }

        private void AwayGameWonNo_Click(object sender, EventArgs e)
        {
            AwayGameWonPanel.Visible = false;
        }     
    }

}
