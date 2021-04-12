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
    public partial class MyTeam : Form
    {
        public MyTeam()
        {
            InitializeComponent();  
        }

        private void Counter_Click(object sender, EventArgs e)
        {
            this.Hide();
            var CounterPage = new CounterPage();
            CounterPage.Closed += (s, args) => this.Close();
            CounterPage.Show();
        }

        private void MatchHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new MatchHistory();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void Leaderboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Leaderboard = new Leaderboard();
            Leaderboard.Closed += (s, args) => this.Close();
            Leaderboard.Show();
        }

        private void Logout_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var Login = new Login();
            Login.Closed += (s, args) => this.Close();
            Login.Show();
        }

        private void MyTeam_Load(object sender, EventArgs e)
        {
           if(Login.MyTeam == "VVRooi")
           {
                label1.Text = "Fiets"; 
           }

        }
    }
}
