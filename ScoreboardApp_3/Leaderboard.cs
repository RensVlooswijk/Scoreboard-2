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
    public partial class Leaderboard : Form
    {
        public Leaderboard()
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

        private void MyTeam_Click(object sender, EventArgs e)
        {
            this.Hide();
            var MyTeam = new MyTeam();
            MyTeam.Closed += (s, args) => this.Close();
            MyTeam.Show();
        }

        private void MatchHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form1 = new MatchHistory();
            Form1.Closed += (s, args) => this.Close();
            Form1.Show();
        }
    }
}
