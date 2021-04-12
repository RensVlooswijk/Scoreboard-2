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

namespace ScoreboardApp_3
{
    public partial class Login : Form
    {
        static public string MyTeam;

        public Login()
        {
            InitializeComponent();
            TeamPicker.Items.Add("VV Rooi");
            TeamPicker.Items.Add("Skunk");
            TeamPicker.Items.Add("PSV");
        }

        private void Register_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Register = new Register();
            Register.Closed += (s, args) => this.Close();
            Register.Show();
        }

        public void Login_btn_Click(object sender, EventArgs e)
        {
            if (TeamPicker.SelectedItem == null)
            {
                NoTeam.Visible = true;
            }
            if (TeamPicker.SelectedItem != null)
            {
                MyTeam = TeamPicker.SelectedItem.ToString();
                this.Hide();
                var HomePage = new CounterPage();
                HomePage.Closed += (s, args) => this.Close();
                HomePage.Show();
            }
        }

        private void NoTeamOk_Click(object sender, EventArgs e)
        {
            NoTeam.Visible = false;
        }
    }
}
