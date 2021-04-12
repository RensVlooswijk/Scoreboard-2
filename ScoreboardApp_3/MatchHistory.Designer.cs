
namespace ScoreboardApp_3
{
    partial class MatchHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.homeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.awayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homeScoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.awayScoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refereeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matchHistoryDatatableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.matchHistoryDatatable = new ScoreboardApp_3.MatchHistoryDatatable();
            this.HeaderCounter = new System.Windows.Forms.Panel();
            this.Logout = new System.Windows.Forms.Button();
            this.MatchHistoryHeaderButton = new System.Windows.Forms.Button();
            this.Leaderboard = new System.Windows.Forms.Button();
            this.Counter = new System.Windows.Forms.Button();
            this.txtCurrentuser = new System.Windows.Forms.TextBox();
            this.CurrentuserLabel = new System.Windows.Forms.Label();
            this.MyTeam = new System.Windows.Forms.Button();
            this.matchHistoryDatatableTableAdapter = new ScoreboardApp_3.dbi466388MatchHistoryDatatableTableAdapters.MatchHistoryDatatableTableAdapter();
            this.matchHistoryDatatableTableAdapter1 = new ScoreboardApp_3.MatchHistoryDatatableTableAdapters.MatchHistoryDatatableTableAdapter();
            this.TennisMatchHistory = new ScoreboardApp_3.TennisMatchHistory();
            this.tennisMatchHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tennisMatchHistoryTableAdapter = new ScoreboardApp_3.TennisMatchHistoryTableAdapters.TennisMatchHistoryTableAdapter();
            this.MatchHistoryLbl = new System.Windows.Forms.Label();
            this.SportSwitcher = new System.Windows.Forms.Button();
            this.SportPickerMatchHistory = new System.Windows.Forms.ComboBox();
            this.CurrentSportlabel = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.playerOneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerTwoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p1GamesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p2GamesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refereeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchHistoryDatatableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchHistoryDatatable)).BeginInit();
            this.HeaderCounter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TennisMatchHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tennisMatchHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.homeDataGridViewTextBoxColumn,
            this.awayDataGridViewTextBoxColumn,
            this.homeScoreDataGridViewTextBoxColumn,
            this.awayScoreDataGridViewTextBoxColumn,
            this.refereeDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.matchHistoryDatatableBindingSource;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(101)))), ((int)(((byte)(194)))));
            this.dataGridView1.Location = new System.Drawing.Point(1, 143);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Size = new System.Drawing.Size(779, 308);
            this.dataGridView1.TabIndex = 0;
            // 
            // homeDataGridViewTextBoxColumn
            // 
            this.homeDataGridViewTextBoxColumn.DataPropertyName = "Home";
            this.homeDataGridViewTextBoxColumn.HeaderText = "Home";
            this.homeDataGridViewTextBoxColumn.Name = "homeDataGridViewTextBoxColumn";
            // 
            // awayDataGridViewTextBoxColumn
            // 
            this.awayDataGridViewTextBoxColumn.DataPropertyName = "Away";
            this.awayDataGridViewTextBoxColumn.HeaderText = "Away";
            this.awayDataGridViewTextBoxColumn.Name = "awayDataGridViewTextBoxColumn";
            // 
            // homeScoreDataGridViewTextBoxColumn
            // 
            this.homeScoreDataGridViewTextBoxColumn.DataPropertyName = "Home_Score";
            this.homeScoreDataGridViewTextBoxColumn.HeaderText = "Home_Score";
            this.homeScoreDataGridViewTextBoxColumn.Name = "homeScoreDataGridViewTextBoxColumn";
            // 
            // awayScoreDataGridViewTextBoxColumn
            // 
            this.awayScoreDataGridViewTextBoxColumn.DataPropertyName = "Away_Score";
            this.awayScoreDataGridViewTextBoxColumn.HeaderText = "Away_Score";
            this.awayScoreDataGridViewTextBoxColumn.Name = "awayScoreDataGridViewTextBoxColumn";
            // 
            // refereeDataGridViewTextBoxColumn
            // 
            this.refereeDataGridViewTextBoxColumn.DataPropertyName = "Referee";
            this.refereeDataGridViewTextBoxColumn.HeaderText = "Referee";
            this.refereeDataGridViewTextBoxColumn.Name = "refereeDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // matchHistoryDatatableBindingSource
            // 
            this.matchHistoryDatatableBindingSource.DataMember = "MatchHistoryDatatable";
            this.matchHistoryDatatableBindingSource.DataSource = this.matchHistoryDatatable;
            // 
            // matchHistoryDatatable
            // 
            this.matchHistoryDatatable.DataSetName = "MatchHistoryDatatable";
            this.matchHistoryDatatable.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // HeaderCounter
            // 
            this.HeaderCounter.BackColor = System.Drawing.Color.RoyalBlue;
            this.HeaderCounter.Controls.Add(this.SportSwitcher);
            this.HeaderCounter.Controls.Add(this.SportPickerMatchHistory);
            this.HeaderCounter.Controls.Add(this.CurrentSportlabel);
            this.HeaderCounter.Controls.Add(this.Logout);
            this.HeaderCounter.Controls.Add(this.MatchHistoryHeaderButton);
            this.HeaderCounter.Controls.Add(this.Leaderboard);
            this.HeaderCounter.Controls.Add(this.Counter);
            this.HeaderCounter.Controls.Add(this.txtCurrentuser);
            this.HeaderCounter.Controls.Add(this.CurrentuserLabel);
            this.HeaderCounter.Controls.Add(this.MyTeam);
            this.HeaderCounter.ForeColor = System.Drawing.Color.White;
            this.HeaderCounter.Location = new System.Drawing.Point(1, 0);
            this.HeaderCounter.Name = "HeaderCounter";
            this.HeaderCounter.Size = new System.Drawing.Size(960, 100);
            this.HeaderCounter.TabIndex = 7;
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Logout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(101)))), ((int)(((byte)(194)))));
            this.Logout.FlatAppearance.BorderSize = 4;
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout.Location = new System.Drawing.Point(677, 36);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(93, 35);
            this.Logout.TabIndex = 9;
            this.Logout.Text = "Log out";
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // MatchHistoryHeaderButton
            // 
            this.MatchHistoryHeaderButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.MatchHistoryHeaderButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(101)))), ((int)(((byte)(194)))));
            this.MatchHistoryHeaderButton.FlatAppearance.BorderSize = 4;
            this.MatchHistoryHeaderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MatchHistoryHeaderButton.Location = new System.Drawing.Point(577, 36);
            this.MatchHistoryHeaderButton.Name = "MatchHistoryHeaderButton";
            this.MatchHistoryHeaderButton.Size = new System.Drawing.Size(94, 35);
            this.MatchHistoryHeaderButton.TabIndex = 7;
            this.MatchHistoryHeaderButton.Text = "Match History";
            this.MatchHistoryHeaderButton.UseVisualStyleBackColor = false;
            // 
            // Leaderboard
            // 
            this.Leaderboard.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Leaderboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(101)))), ((int)(((byte)(194)))));
            this.Leaderboard.FlatAppearance.BorderSize = 4;
            this.Leaderboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Leaderboard.Location = new System.Drawing.Point(479, 36);
            this.Leaderboard.Name = "Leaderboard";
            this.Leaderboard.Size = new System.Drawing.Size(92, 35);
            this.Leaderboard.TabIndex = 6;
            this.Leaderboard.Text = "Leaderboard";
            this.Leaderboard.UseVisualStyleBackColor = false;
            this.Leaderboard.Click += new System.EventHandler(this.Leaderboard_Click);
            // 
            // Counter
            // 
            this.Counter.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Counter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(101)))), ((int)(((byte)(194)))));
            this.Counter.FlatAppearance.BorderSize = 4;
            this.Counter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Counter.Location = new System.Drawing.Point(291, 36);
            this.Counter.Name = "Counter";
            this.Counter.Size = new System.Drawing.Size(93, 35);
            this.Counter.TabIndex = 5;
            this.Counter.Text = "Counter";
            this.Counter.UseVisualStyleBackColor = false;
            this.Counter.Click += new System.EventHandler(this.Counter_Click);
            // 
            // txtCurrentuser
            // 
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
            this.CurrentuserLabel.AutoSize = true;
            this.CurrentuserLabel.Location = new System.Drawing.Point(20, 23);
            this.CurrentuserLabel.Name = "CurrentuserLabel";
            this.CurrentuserLabel.Size = new System.Drawing.Size(71, 13);
            this.CurrentuserLabel.TabIndex = 2;
            this.CurrentuserLabel.Text = "Logged in as:";
            // 
            // MyTeam
            // 
            this.MyTeam.BackColor = System.Drawing.Color.CornflowerBlue;
            this.MyTeam.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(101)))), ((int)(((byte)(194)))));
            this.MyTeam.FlatAppearance.BorderSize = 4;
            this.MyTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MyTeam.Location = new System.Drawing.Point(390, 36);
            this.MyTeam.Name = "MyTeam";
            this.MyTeam.Size = new System.Drawing.Size(83, 35);
            this.MyTeam.TabIndex = 0;
            this.MyTeam.Text = "My Team";
            this.MyTeam.UseVisualStyleBackColor = false;
            this.MyTeam.Click += new System.EventHandler(this.MyTeam_Click);
            // 
            // matchHistoryDatatableTableAdapter
            // 
            this.matchHistoryDatatableTableAdapter.ClearBeforeFill = true;
            // 
            // matchHistoryDatatableTableAdapter1
            // 
            this.matchHistoryDatatableTableAdapter1.ClearBeforeFill = true;
            // 
            // TennisMatchHistory
            // 
            this.TennisMatchHistory.DataSetName = "TennisMatchHistory";
            this.TennisMatchHistory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tennisMatchHistoryBindingSource
            // 
            this.tennisMatchHistoryBindingSource.DataMember = "TennisMatchHistory";
            this.tennisMatchHistoryBindingSource.DataSource = this.TennisMatchHistory;
            // 
            // tennisMatchHistoryTableAdapter
            // 
            this.tennisMatchHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // MatchHistoryLbl
            // 
            this.MatchHistoryLbl.AutoSize = true;
            this.MatchHistoryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatchHistoryLbl.Location = new System.Drawing.Point(329, 115);
            this.MatchHistoryLbl.Name = "MatchHistoryLbl";
            this.MatchHistoryLbl.Size = new System.Drawing.Size(115, 25);
            this.MatchHistoryLbl.TabIndex = 9;
            this.MatchHistoryLbl.Text = "Volleyball";
            // 
            // SportSwitcher
            // 
            this.SportSwitcher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SportSwitcher.BackColor = System.Drawing.Color.CornflowerBlue;
            this.SportSwitcher.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(101)))), ((int)(((byte)(194)))));
            this.SportSwitcher.FlatAppearance.BorderSize = 4;
            this.SportSwitcher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SportSwitcher.Location = new System.Drawing.Point(169, 69);
            this.SportSwitcher.MaximumSize = new System.Drawing.Size(116, 28);
            this.SportSwitcher.MinimumSize = new System.Drawing.Size(116, 28);
            this.SportSwitcher.Name = "SportSwitcher";
            this.SportSwitcher.Size = new System.Drawing.Size(116, 28);
            this.SportSwitcher.TabIndex = 37;
            this.SportSwitcher.Text = "Switch Sport";
            this.SportSwitcher.UseVisualStyleBackColor = false;
            this.SportSwitcher.Click += new System.EventHandler(this.SportSwitcher_Click);
            // 
            // SportPickerMatchHistory
            // 
            this.SportPickerMatchHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SportPickerMatchHistory.BackColor = System.Drawing.Color.CornflowerBlue;
            this.SportPickerMatchHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SportPickerMatchHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SportPickerMatchHistory.ForeColor = System.Drawing.Color.White;
            this.SportPickerMatchHistory.FormattingEnabled = true;
            this.SportPickerMatchHistory.Location = new System.Drawing.Point(170, 42);
            this.SportPickerMatchHistory.MaximumSize = new System.Drawing.Size(115, 0);
            this.SportPickerMatchHistory.MinimumSize = new System.Drawing.Size(115, 0);
            this.SportPickerMatchHistory.Name = "SportPickerMatchHistory";
            this.SportPickerMatchHistory.Size = new System.Drawing.Size(115, 23);
            this.SportPickerMatchHistory.TabIndex = 36;
            this.SportPickerMatchHistory.Text = "Volleyball";
            // 
            // CurrentSportlabel
            // 
            this.CurrentSportlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentSportlabel.AutoSize = true;
            this.CurrentSportlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentSportlabel.Location = new System.Drawing.Point(182, 21);
            this.CurrentSportlabel.Name = "CurrentSportlabel";
            this.CurrentSportlabel.Size = new System.Drawing.Size(84, 15);
            this.CurrentSportlabel.TabIndex = 35;
            this.CurrentSportlabel.Text = "Sport switcher";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playerOneDataGridViewTextBoxColumn,
            this.playerTwoDataGridViewTextBoxColumn,
            this.p1GamesDataGridViewTextBoxColumn,
            this.p2GamesDataGridViewTextBoxColumn,
            this.refereeDataGridViewTextBoxColumn1,
            this.dateDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.tennisMatchHistoryBindingSource;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(101)))), ((int)(((byte)(194)))));
            this.dataGridView2.Location = new System.Drawing.Point(1, 143);
            this.dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.Size = new System.Drawing.Size(779, 308);
            this.dataGridView2.TabIndex = 10;
            this.dataGridView2.Visible = false;
            // 
            // playerOneDataGridViewTextBoxColumn
            // 
            this.playerOneDataGridViewTextBoxColumn.DataPropertyName = "Player_One";
            this.playerOneDataGridViewTextBoxColumn.HeaderText = "Player_One";
            this.playerOneDataGridViewTextBoxColumn.Name = "playerOneDataGridViewTextBoxColumn";
            // 
            // playerTwoDataGridViewTextBoxColumn
            // 
            this.playerTwoDataGridViewTextBoxColumn.DataPropertyName = "Player_Two";
            this.playerTwoDataGridViewTextBoxColumn.HeaderText = "Player_Two";
            this.playerTwoDataGridViewTextBoxColumn.Name = "playerTwoDataGridViewTextBoxColumn";
            // 
            // p1GamesDataGridViewTextBoxColumn
            // 
            this.p1GamesDataGridViewTextBoxColumn.DataPropertyName = "P1_Games";
            this.p1GamesDataGridViewTextBoxColumn.HeaderText = "P1_Games";
            this.p1GamesDataGridViewTextBoxColumn.Name = "p1GamesDataGridViewTextBoxColumn";
            // 
            // p2GamesDataGridViewTextBoxColumn
            // 
            this.p2GamesDataGridViewTextBoxColumn.DataPropertyName = "p2_Games";
            this.p2GamesDataGridViewTextBoxColumn.HeaderText = "p2_Games";
            this.p2GamesDataGridViewTextBoxColumn.Name = "p2GamesDataGridViewTextBoxColumn";
            // 
            // refereeDataGridViewTextBoxColumn1
            // 
            this.refereeDataGridViewTextBoxColumn1.DataPropertyName = "Referee";
            this.refereeDataGridViewTextBoxColumn1.HeaderText = "Referee";
            this.refereeDataGridViewTextBoxColumn1.Name = "refereeDataGridViewTextBoxColumn1";
            // 
            // dateDataGridViewTextBoxColumn1
            // 
            this.dateDataGridViewTextBoxColumn1.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn1.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn1.Name = "dateDataGridViewTextBoxColumn1";
            // 
            // MatchHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(776, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.MatchHistoryLbl);
            this.Controls.Add(this.HeaderCounter);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MatchHistory";
            this.Text = "Match History";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchHistoryDatatableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchHistoryDatatable)).EndInit();
            this.HeaderCounter.ResumeLayout(false);
            this.HeaderCounter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TennisMatchHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tennisMatchHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel HeaderCounter;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button MatchHistoryHeaderButton;
        private System.Windows.Forms.Button Leaderboard;
        private System.Windows.Forms.Button Counter;
        private System.Windows.Forms.TextBox txtCurrentuser;
        private System.Windows.Forms.Label CurrentuserLabel;
        private System.Windows.Forms.Button MyTeam;
        private dbi466388MatchHistoryDatatableTableAdapters.MatchHistoryDatatableTableAdapter matchHistoryDatatableTableAdapter;
        private MatchHistoryDatatable matchHistoryDatatable;
        private System.Windows.Forms.BindingSource matchHistoryDatatableBindingSource;
        private MatchHistoryDatatableTableAdapters.MatchHistoryDatatableTableAdapter matchHistoryDatatableTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn awayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeScoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn awayScoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn refereeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private TennisMatchHistory TennisMatchHistory;
        private System.Windows.Forms.BindingSource tennisMatchHistoryBindingSource;
        private TennisMatchHistoryTableAdapters.TennisMatchHistoryTableAdapter tennisMatchHistoryTableAdapter;
        private System.Windows.Forms.Label MatchHistoryLbl;
        private System.Windows.Forms.Button SportSwitcher;
        private System.Windows.Forms.ComboBox SportPickerMatchHistory;
        private System.Windows.Forms.Label CurrentSportlabel;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerOneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerTwoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn p1GamesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn p2GamesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn refereeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn1;
    }
}

