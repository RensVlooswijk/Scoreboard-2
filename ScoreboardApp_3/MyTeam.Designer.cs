
namespace ScoreboardApp_3
{
    partial class MyTeam
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
            this.HeaderCounter = new System.Windows.Forms.Panel();
            this.Logout = new System.Windows.Forms.Button();
            this.SportPicker = new System.Windows.Forms.ComboBox();
            this.MatchHistory = new System.Windows.Forms.Button();
            this.Leaderboard = new System.Windows.Forms.Button();
            this.Counter = new System.Windows.Forms.Button();
            this.CurrentSportlabel = new System.Windows.Forms.Label();
            this.txtCurrentuser = new System.Windows.Forms.TextBox();
            this.CurrentuserLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.MyTeamDatagrid = new System.Windows.Forms.DataGridView();
            this.teamMembersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamMemberList = new ScoreboardApp_3.TeamMemberList();
            this.teamMembersTableAdapter = new ScoreboardApp_3.TeamMemberListTableAdapters.TeamMembersTableAdapter();
            this.vVRooiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skunkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pSVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.HeaderCounter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyTeamDatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamMembersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamMemberList)).BeginInit();
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
            this.HeaderCounter.Controls.Add(this.Leaderboard);
            this.HeaderCounter.Controls.Add(this.Counter);
            this.HeaderCounter.Controls.Add(this.CurrentSportlabel);
            this.HeaderCounter.Controls.Add(this.txtCurrentuser);
            this.HeaderCounter.Controls.Add(this.CurrentuserLabel);
            this.HeaderCounter.Controls.Add(this.button1);
            this.HeaderCounter.ForeColor = System.Drawing.Color.White;
            this.HeaderCounter.Location = new System.Drawing.Point(2, 1);
            this.HeaderCounter.Name = "HeaderCounter";
            this.HeaderCounter.Size = new System.Drawing.Size(814, 103);
            this.HeaderCounter.TabIndex = 9;
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
            this.Logout.Click += new System.EventHandler(this.Logout_Click_1);
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
            // Leaderboard
            // 
            this.Leaderboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Leaderboard.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Leaderboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(101)))), ((int)(((byte)(194)))));
            this.Leaderboard.FlatAppearance.BorderSize = 4;
            this.Leaderboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Leaderboard.Location = new System.Drawing.Point(497, 36);
            this.Leaderboard.Name = "Leaderboard";
            this.Leaderboard.Size = new System.Drawing.Size(94, 35);
            this.Leaderboard.TabIndex = 6;
            this.Leaderboard.Text = "Leaderboard";
            this.Leaderboard.UseVisualStyleBackColor = false;
            this.Leaderboard.Click += new System.EventHandler(this.Leaderboard_Click);
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
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(101)))), ((int)(((byte)(194)))));
            this.button1.FlatAppearance.BorderSize = 4;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(397, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "My Team";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // MyTeamDatagrid
            // 
            this.MyTeamDatagrid.AutoGenerateColumns = false;
            this.MyTeamDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyTeamDatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vVRooiDataGridViewTextBoxColumn,
            this.skunkDataGridViewTextBoxColumn,
            this.pSVDataGridViewTextBoxColumn});
            this.MyTeamDatagrid.DataSource = this.teamMembersBindingSource;
            this.MyTeamDatagrid.Location = new System.Drawing.Point(2, 100);
            this.MyTeamDatagrid.Name = "MyTeamDatagrid";
            this.MyTeamDatagrid.Size = new System.Drawing.Size(545, 338);
            this.MyTeamDatagrid.TabIndex = 10;
            // 
            // teamMembersBindingSource
            // 
            this.teamMembersBindingSource.DataMember = "TeamMembers";
            this.teamMembersBindingSource.DataSource = this.teamMemberList;
            // 
            // teamMemberList
            // 
            this.teamMemberList.DataSetName = "TeamMemberList";
            this.teamMemberList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teamMembersTableAdapter
            // 
            this.teamMembersTableAdapter.ClearBeforeFill = true;
            // 
            // vVRooiDataGridViewTextBoxColumn
            // 
            this.vVRooiDataGridViewTextBoxColumn.DataPropertyName = "VVRooi";
            this.vVRooiDataGridViewTextBoxColumn.HeaderText = "VVRooi";
            this.vVRooiDataGridViewTextBoxColumn.Name = "vVRooiDataGridViewTextBoxColumn";
            // 
            // skunkDataGridViewTextBoxColumn
            // 
            this.skunkDataGridViewTextBoxColumn.DataPropertyName = "Skunk";
            this.skunkDataGridViewTextBoxColumn.HeaderText = "Skunk";
            this.skunkDataGridViewTextBoxColumn.Name = "skunkDataGridViewTextBoxColumn";
            // 
            // pSVDataGridViewTextBoxColumn
            // 
            this.pSVDataGridViewTextBoxColumn.DataPropertyName = "PSV";
            this.pSVDataGridViewTextBoxColumn.HeaderText = "PSV";
            this.pSVDataGridViewTextBoxColumn.Name = "pSVDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(557, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // MyTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MyTeamDatagrid);
            this.Controls.Add(this.HeaderCounter);
            this.Name = "MyTeam";
            this.Text = "MyTeam";
            this.Load += new System.EventHandler(this.MyTeam_Load);
            this.HeaderCounter.ResumeLayout(false);
            this.HeaderCounter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyTeamDatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamMembersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamMemberList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel HeaderCounter;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.ComboBox SportPicker;
        private System.Windows.Forms.Button MatchHistory;
        private System.Windows.Forms.Button Leaderboard;
        private System.Windows.Forms.Button Counter;
        private System.Windows.Forms.Label CurrentSportlabel;
        private System.Windows.Forms.TextBox txtCurrentuser;
        private System.Windows.Forms.Label CurrentuserLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView MyTeamDatagrid;
        private TeamMemberList teamMemberList;
        private System.Windows.Forms.BindingSource teamMembersBindingSource;
        private TeamMemberListTableAdapters.TeamMembersTableAdapter teamMembersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vVRooiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skunkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pSVDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}