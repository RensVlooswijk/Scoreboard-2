
namespace ScoreboardApp_3
{
    partial class Register
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
            this.Register_lbl = new System.Windows.Forms.Label();
            this.UsernameRegister = new System.Windows.Forms.RichTextBox();
            this.PasswordRegister = new System.Windows.Forms.RichTextBox();
            this.EmailRegister = new System.Windows.Forms.RichTextBox();
            this.Register_btn = new System.Windows.Forms.Button();
            this.SuccesRegister = new System.Windows.Forms.Panel();
            this.SuccesRegisterOk = new System.Windows.Forms.Button();
            this.NewAccount = new System.Windows.Forms.Label();
            this.TeamPicker = new System.Windows.Forms.ComboBox();
            this.RegisterLogin = new System.Windows.Forms.Button();
            this.SuccesRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderCounter
            // 
            this.HeaderCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeaderCounter.BackColor = System.Drawing.Color.RoyalBlue;
            this.HeaderCounter.ForeColor = System.Drawing.Color.White;
            this.HeaderCounter.Location = new System.Drawing.Point(1, 1);
            this.HeaderCounter.Name = "HeaderCounter";
            this.HeaderCounter.Size = new System.Drawing.Size(814, 103);
            this.HeaderCounter.TabIndex = 11;
            // 
            // Register_lbl
            // 
            this.Register_lbl.AutoSize = true;
            this.Register_lbl.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Register_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_lbl.ForeColor = System.Drawing.Color.White;
            this.Register_lbl.Location = new System.Drawing.Point(308, 152);
            this.Register_lbl.Name = "Register_lbl";
            this.Register_lbl.Size = new System.Drawing.Size(157, 42);
            this.Register_lbl.TabIndex = 13;
            this.Register_lbl.Text = "Register";
            // 
            // UsernameRegister
            // 
            this.UsernameRegister.BackColor = System.Drawing.Color.CornflowerBlue;
            this.UsernameRegister.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameRegister.ForeColor = System.Drawing.Color.White;
            this.UsernameRegister.Location = new System.Drawing.Point(302, 212);
            this.UsernameRegister.Name = "UsernameRegister";
            this.UsernameRegister.Size = new System.Drawing.Size(196, 27);
            this.UsernameRegister.TabIndex = 14;
            this.UsernameRegister.Text = "Username";
            // 
            // PasswordRegister
            // 
            this.PasswordRegister.BackColor = System.Drawing.Color.CornflowerBlue;
            this.PasswordRegister.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordRegister.ForeColor = System.Drawing.Color.White;
            this.PasswordRegister.Location = new System.Drawing.Point(302, 245);
            this.PasswordRegister.Name = "PasswordRegister";
            this.PasswordRegister.Size = new System.Drawing.Size(196, 27);
            this.PasswordRegister.TabIndex = 15;
            this.PasswordRegister.Text = "Password";
            // 
            // EmailRegister
            // 
            this.EmailRegister.BackColor = System.Drawing.Color.CornflowerBlue;
            this.EmailRegister.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailRegister.ForeColor = System.Drawing.Color.White;
            this.EmailRegister.Location = new System.Drawing.Point(302, 278);
            this.EmailRegister.Name = "EmailRegister";
            this.EmailRegister.Size = new System.Drawing.Size(196, 27);
            this.EmailRegister.TabIndex = 18;
            this.EmailRegister.Text = "Email";
            // 
            // Register_btn
            // 
            this.Register_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Register_btn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Register_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(101)))), ((int)(((byte)(194)))));
            this.Register_btn.FlatAppearance.BorderSize = 4;
            this.Register_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Register_btn.Location = new System.Drawing.Point(341, 345);
            this.Register_btn.Name = "Register_btn";
            this.Register_btn.Size = new System.Drawing.Size(94, 35);
            this.Register_btn.TabIndex = 19;
            this.Register_btn.Text = "Register";
            this.Register_btn.UseVisualStyleBackColor = false;
            this.Register_btn.Click += new System.EventHandler(this.Register_btn_Click);
            // 
            // SuccesRegister
            // 
            this.SuccesRegister.BackColor = System.Drawing.Color.RoyalBlue;
            this.SuccesRegister.Controls.Add(this.SuccesRegisterOk);
            this.SuccesRegister.Controls.Add(this.NewAccount);
            this.SuccesRegister.Location = new System.Drawing.Point(260, 166);
            this.SuccesRegister.Name = "SuccesRegister";
            this.SuccesRegister.Size = new System.Drawing.Size(287, 119);
            this.SuccesRegister.TabIndex = 26;
            this.SuccesRegister.Visible = false;
            // 
            // SuccesRegisterOk
            // 
            this.SuccesRegisterOk.BackColor = System.Drawing.Color.CornflowerBlue;
            this.SuccesRegisterOk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(101)))), ((int)(((byte)(194)))));
            this.SuccesRegisterOk.FlatAppearance.BorderSize = 4;
            this.SuccesRegisterOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SuccesRegisterOk.ForeColor = System.Drawing.Color.White;
            this.SuccesRegisterOk.Location = new System.Drawing.Point(99, 65);
            this.SuccesRegisterOk.Name = "SuccesRegisterOk";
            this.SuccesRegisterOk.Size = new System.Drawing.Size(76, 32);
            this.SuccesRegisterOk.TabIndex = 17;
            this.SuccesRegisterOk.Text = "Ok";
            this.SuccesRegisterOk.UseVisualStyleBackColor = false;
            this.SuccesRegisterOk.Click += new System.EventHandler(this.SuccesRegister_Click);
            // 
            // NewAccount
            // 
            this.NewAccount.AutoSize = true;
            this.NewAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewAccount.ForeColor = System.Drawing.Color.White;
            this.NewAccount.Location = new System.Drawing.Point(15, 28);
            this.NewAccount.Name = "NewAccount";
            this.NewAccount.Size = new System.Drawing.Size(240, 13);
            this.NewAccount.TabIndex = 0;
            this.NewAccount.Text = "Your account has succesfully been made";
            // 
            // TeamPicker
            // 
            this.TeamPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TeamPicker.BackColor = System.Drawing.Color.CornflowerBlue;
            this.TeamPicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TeamPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamPicker.ForeColor = System.Drawing.Color.White;
            this.TeamPicker.FormattingEnabled = true;
            this.TeamPicker.Location = new System.Drawing.Point(331, 311);
            this.TeamPicker.Name = "TeamPicker";
            this.TeamPicker.Size = new System.Drawing.Size(115, 28);
            this.TeamPicker.TabIndex = 27;
            // 
            // RegisterLogin
            // 
            this.RegisterLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RegisterLogin.BackColor = System.Drawing.Color.CornflowerBlue;
            this.RegisterLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(101)))), ((int)(((byte)(194)))));
            this.RegisterLogin.FlatAppearance.BorderSize = 4;
            this.RegisterLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterLogin.Location = new System.Drawing.Point(341, 386);
            this.RegisterLogin.Name = "RegisterLogin";
            this.RegisterLogin.Size = new System.Drawing.Size(94, 35);
            this.RegisterLogin.TabIndex = 28;
            this.RegisterLogin.Text = "Login";
            this.RegisterLogin.UseVisualStyleBackColor = false;
            this.RegisterLogin.Click += new System.EventHandler(this.RegisterLogin_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RegisterLogin);
            this.Controls.Add(this.TeamPicker);
            this.Controls.Add(this.SuccesRegister);
            this.Controls.Add(this.Register_btn);
            this.Controls.Add(this.EmailRegister);
            this.Controls.Add(this.PasswordRegister);
            this.Controls.Add(this.UsernameRegister);
            this.Controls.Add(this.Register_lbl);
            this.Controls.Add(this.HeaderCounter);
            this.Name = "Register";
            this.Text = "Register";
            this.SuccesRegister.ResumeLayout(false);
            this.SuccesRegister.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel HeaderCounter;
        private System.Windows.Forms.Label Register_lbl;
        private System.Windows.Forms.RichTextBox UsernameRegister;
        private System.Windows.Forms.RichTextBox PasswordRegister;
        private System.Windows.Forms.RichTextBox EmailRegister;
        private System.Windows.Forms.Button Register_btn;
        private System.Windows.Forms.Panel SuccesRegister;
        private System.Windows.Forms.Button SuccesRegisterOk;
        private System.Windows.Forms.Label NewAccount;
        private System.Windows.Forms.ComboBox TeamPicker;
        private System.Windows.Forms.Button RegisterLogin;
    }
}