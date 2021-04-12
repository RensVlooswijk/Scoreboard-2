using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreboardApp_3
{
    public partial class MatchHistory : Form
    {
        string CurrentSport;
        public MatchHistory()
        {
            InitializeComponent();
            SportPickerMatchHistory.Items.Add("Tennis");
            SportPickerMatchHistory.Items.Add("Volleyball");
            CurrentSport = "Volleyball";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tennisMatchHistory._TennisMatchHistory' table. You can move, or remove it, as needed.
            this.tennisMatchHistoryTableAdapter.Fill(this.TennisMatchHistory._TennisMatchHistory);
            // TODO: This line of code loads data into the 'matchHistoryDatatable._MatchHistoryDatatable' table. You can move, or remove it, as needed.
            this.matchHistoryDatatableTableAdapter1.Fill(this.matchHistoryDatatable._MatchHistoryDatatable);
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

        private void SportSwitcher_Click(object sender, EventArgs e)
        {
            if(SportPickerMatchHistory.SelectedItem == "Tennis")
            {
                CurrentSport = "Tennis";
                dataGridView2.Visible = true;
                dataGridView1.Visible = false;
                MatchHistoryLbl.Text = "Tennis";
            }
            if(SportPickerMatchHistory.SelectedItem == "Volleyball")
            {
                CurrentSport = "Volleyball";
                dataGridView1.Visible = true;
                dataGridView2.Visible = false;
                MatchHistoryLbl.Text = "Volleyball";
            }
        }
    }
}
