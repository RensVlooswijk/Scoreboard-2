
namespace ScoreboardApp_3
{
    partial class Leaderboard
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
            this.HeaderCounter = new System.Windows.Forms.Panel();
            this.Logout = new System.Windows.Forms.Button();
            this.SportPicker = new System.Windows.Forms.ComboBox();
            this.MatchHistory = new System.Windows.Forms.Button();
            this.Leaderboard_btn = new System.Windows.Forms.Button();
            this.Counter = new System.Windows.Forms.Button();
            this.CurrentSportlabel = new System.Windows.Forms.Label();
            this.txtCurrentuser = new System.Windows.Forms.TextBox();
            this.CurrentuserLabel = new System.Windows.Forms.Label();
            this.MyTeam = new System.Windows.Forms.Button();
            this.scoresTableAdapter1 = new ScoreboardApp_3.ScoresTableAdapters.scoresTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.HeaderCounter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderCounter
            // 
            this.HeaderCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeaderCounter.BackColor = System.Drawing.Color.RoyalBlue;
            this.HeaderCounter.Controls.Add(this.Logout);
            this.HeaderCounter.Controls.Add(this.SportPicker);
            this.HeaderCounter.Controls.Add(this.MatchHistory);
            this.HeaderCounter.Controls.Add(this.Leaderboard_btn);
            this.HeaderCounter.Controls.Add(this.Counter);
            this.HeaderCounter.Controls.Add(this.CurrentSportlabel);
            this.HeaderCounter.Controls.Add(this.txtCurrentuser);
            this.HeaderCounter.Controls.Add(this.CurrentuserLabel);
            this.HeaderCounter.Controls.Add(this.MyTeam);
            this.HeaderCounter.ForeColor = System.Drawing.Color.White;
            this.HeaderCounter.Location = new System.Drawing.Point(0, 0);
            this.HeaderCounter.Name = "HeaderCounter";
            this.HeaderCounter.Size = new System.Drawing.Size(814, 103);
            this.HeaderCounter.TabIndex = 10;
            // 
            // Logout
            // 
            this.Logout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Logout.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Logout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(101)))), ((int)(((byte)(194)))));
            this.Logout.FlatAppearance.BorderSize = 4;
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout.Location = new System.Drawing.Point(697, 36);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(94, 35);
            this.Logout.TabIndex = 9;
            this.Logout.Text = "Log out";
            this.Logout.UseVisualStyleBackColor = false;
            // 
            // SportPicker
            // 
            this.SportPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SportPicker.BackColor = System.Drawing.Color.CornflowerBlue;
            this.SportPicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SportPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SportPicker.ForeColor = System.Drawing.Color.White;
            this.SportPicker.FormattingEnabled = true;
            this.SportPicker.Location = new System.Drawing.Point(156, 39);
            this.SportPicker.Name = "SportPicker";
            this.SportPicker.Size = new System.Drawing.Size(115, 28);
            this.SportPicker.TabIndex = 8;
            // 
            // MatchHistory
            // 
            this.MatchHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MatchHistory.BackColor = System.Drawing.Color.CornflowerBlue;
            this.MatchHistory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(101)))), ((int)(((byte)(194)))));
            this.MatchHistory.FlatAppearance.BorderSize = 4;
            this.MatchHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MatchHistory.Location = new System.Drawing.Point(597, 36);
            this.MatchHistory.Name = "MatchHistory";
            this.MatchHistory.Size = new System.Drawing.Size(94, 35);
            this.MatchHistory.TabIndex = 7;
            this.MatchHistory.Text = "Match History";
            this.MatchHistory.UseVisualStyleBackColor = false;
            this.MatchHistory.Click += new System.EventHandler(this.MatchHistory_Click);
            // 
            // Leaderboard_btn
            // 
            this.Leaderboard_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Leaderboard_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.Leaderboard_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(101)))), ((int)(((byte)(194)))));
            this.Leaderboard_btn.FlatAppearance.BorderSize = 4;
            this.Leaderboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Leaderboard_btn.Location = new System.Drawing.Point(497, 36);
            this.Leaderboard_btn.Name = "Leaderboard_btn";
            this.Leaderboard_btn.Size = new System.Drawing.Size(94, 35);
            this.Leaderboard_btn.TabIndex = 6;
            this.Leaderboard_btn.Text = "Leaderboard";
            this.Leaderboard_btn.UseVisualStyleBackColor = false;
            // 
            // Counter
            // 
            this.Counter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Counter.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Counter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(101)))), ((int)(((byte)(194)))));
            this.Counter.FlatAppearance.BorderSize = 4;
            this.Counter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Counter.Location = new System.Drawing.Point(297, 36);
            this.Counter.Name = "Counter";
            this.Counter.Size = new System.Drawing.Size(94, 35);
            this.Counter.TabIndex = 5;
            this.Counter.Text = "Counter";
            this.Counter.UseVisualStyleBackColor = false;
            this.Counter.Click += new System.EventHandler(this.Counter_Click);
            // 
            // CurrentSportlabel
            // 
            this.CurrentSportlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentSportlabel.AutoSize = true;
            this.CurrentSportlabel.Location = new System.Drawing.Point(153, 23);
            this.CurrentSportlabel.Name = "CurrentSportlabel";
            this.CurrentSportlabel.Size = new System.Drawing.Size(72, 13);
            this.CurrentSportlabel.TabIndex = 3;
            this.CurrentSportlabel.Text = "Current Sport:";
            // 
            // txtCurrentuser
            // 
            this.txtCurrentuser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCurrentuser.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtCurrentuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCurrentuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentuser.ForeColor = System.Drawing.Color.White;
            this.txtCurrentuser.Location = new System.Drawing.Point(23, 44);
            this.txtCurrentuser.Name = "txtCurrentuser";
            this.txtCurrentuser.Size = new System.Drawing.Size(115, 19);
            this.txtCurrentuser.TabIndex = 0;
            // 
            // CurrentuserLabel
            // 
            this.CurrentuserLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentuserLabel.AutoSize = true;
            this.CurrentuserLabel.Location = new System.Drawing.Point(20, 23);
            this.CurrentuserLabel.Name = "CurrentuserLabel";
            this.CurrentuserLabel.Size = new System.Drawing.Size(71, 13);
            this.CurrentuserLabel.TabIndex = 2;
            this.CurrentuserLabel.Text = "Logged in as:";
            // 
            // MyTeam
            // 
            this.MyTeam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MyTeam.BackColor = System.Drawing.Color.CornflowerBlue;
            this.MyTeam.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(101)))), ((int)(((byte)(194)))));
            this.MyTeam.FlatAppearance.BorderSize = 4;
            this.MyTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MyTeam.Location = new System.Drawing.Point(397, 36);
            this.MyTeam.Name = "MyTeam";
            this.MyTeam.Size = new System.Drawing.Size(94, 35);
            this.MyTeam.TabIndex = 0;
            this.MyTeam.Text = "My Team";
            this.MyTeam.UseVisualStyleBackColor = false;
            this.MyTeam.Click += new System.EventHandler(this.MyTeam_Click);
            // 
            // scoresTableAdapter1
            // 
            this.scoresTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(801, 350);
            this.dataGridView1.TabIndex = 11;
            // 
            // Leaderboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.HeaderCounter);
            this.Name = "Leaderboard";
            this.Text = "Leaderboard";
            this.HeaderCounter.ResumeLayout(false);
            this.HeaderCounter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderCounter;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.ComboBox SportPicker;
        private System.Windows.Forms.Button MatchHistory;
        private System.Windows.Forms.Button Leaderboard_btn;
        private System.Windows.Forms.Button Counter;
        private System.Windows.Forms.Label CurrentSportlabel;
        private System.Windows.Forms.TextBox txtCurrentuser;
        private System.Windows.Forms.Label CurrentuserLabel;
        private System.Windows.Forms.Button MyTeam;
        private ScoresTableAdapters.scoresTableAdapter scoresTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}