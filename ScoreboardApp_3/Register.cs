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
    public partial class Register : Form
    {
        private SqlConnection sc;
        private SqlCommand com;
        public Register()
        {
            InitializeComponent();
            TeamPicker.Items.Add("VVRooi");
            TeamPicker.Items.Add("Skunk");
            TeamPicker.Items.Add("PSV");
        }

        private void Register_btn_Click(object sender, EventArgs e)
        {
            sc = new SqlConnection();
            com = new SqlCommand();
            sc.ConnectionString = @"Server=mssql.fhict.local;Database=dbi466388;User Id=dbi466388;Password=tuintafel12;";
            sc.Open();

            //Create Command
            com.Connection = sc;
            com.CommandText = @"INSERT INTO tbl_Login VALUES(@Username, @Password, @Team, @Email)";
            // Add Parameters
            com.Parameters.AddWithValue("@Username", UsernameRegister.Text);
            com.Parameters.AddWithValue("@Password", PasswordRegister.Text);
            com.Parameters.AddWithValue("@Team", TeamPicker.SelectedItem);
            com.Parameters.AddWithValue("@Email", EmailRegister.Text);

            // Execute command & Close connection
            com.ExecuteNonQuery();
            if(TeamPicker.SelectedItem == "VVRooi")
            {
                com.CommandText = @"INSERT INTO TeamMembers VALUES(@VVRooi, @Skunk, @PSV)";
                com.Parameters.AddWithValue("@VVRooi", UsernameRegister.Text);
                com.Parameters.AddWithValue("@Skunk", "");
                com.Parameters.AddWithValue("@PSV", "");
            }
            else if (TeamPicker.SelectedItem == "Skunk")
            {
                com.CommandText = @"INSERT INTO TeamMembers VALUES(@VVRooi, @Skunk, @PSV)";
                com.Parameters.AddWithValue("@VVRooi", "");
                com.Parameters.AddWithValue("@Skunk", UsernameRegister.Text);
                com.Parameters.AddWithValue("@PSV", "");
            }
            else if (TeamPicker.SelectedItem == "PSV")
            {
                com.CommandText = @"INSERT INTO TeamMembers VALUES(@VVRooi, @Skunk, @PSV)";
                com.Parameters.AddWithValue("@VVRooi", "");
                com.Parameters.AddWithValue("@Skunk", "");
                com.Parameters.AddWithValue("@PSV", UsernameRegister.Text);
            }
            com.ExecuteNonQuery();
            sc.Close();
            SuccesRegister.Visible = true;
            UsernameRegister.Text = "Username";
            PasswordRegister.Text = "Password";
            EmailRegister.Text = "Email";
        }

        private void SuccesRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Login = new Login();
            Login.Closed += (s, args) => this.Close();
            Login.Show();
        }

        private void RegisterLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Login = new Login();
            Login.Closed += (s, args) => this.Close();
            Login.Show();
        }
    }
}
