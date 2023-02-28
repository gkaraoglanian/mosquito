namespace mosquito
{
    partial class loginForm
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
            this.playButton = new System.Windows.Forms.Button();
            this.returnButton_loginForm = new System.Windows.Forms.Button();
            this.welcomeLabel_loginForm = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.login_listBox = new System.Windows.Forms.ListBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.bestscoreLabel = new System.Windows.Forms.Label();
            this.usernameValue = new System.Windows.Forms.Label();
            this.levelValue = new System.Windows.Forms.Label();
            this.bestscoreValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Blue;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.playButton.ForeColor = System.Drawing.Color.Lime;
            this.playButton.Location = new System.Drawing.Point(290, 589);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(840, 60);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "LET\'S PLAY";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            this.playButton.MouseEnter += new System.EventHandler(this.playButton_MouseEnter);
            this.playButton.MouseLeave += new System.EventHandler(this.playButton_MouseLeave);
            // 
            // returnButton_loginForm
            // 
            this.returnButton_loginForm.BackColor = System.Drawing.Color.Blue;
            this.returnButton_loginForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnButton_loginForm.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.returnButton_loginForm.ForeColor = System.Drawing.Color.Lime;
            this.returnButton_loginForm.Location = new System.Drawing.Point(54, 589);
            this.returnButton_loginForm.Name = "returnButton_loginForm";
            this.returnButton_loginForm.Size = new System.Drawing.Size(230, 60);
            this.returnButton_loginForm.TabIndex = 1;
            this.returnButton_loginForm.Text = "RETURN";
            this.returnButton_loginForm.UseVisualStyleBackColor = false;
            this.returnButton_loginForm.Click += new System.EventHandler(this.returnButton_loginForm_Click);
            this.returnButton_loginForm.MouseEnter += new System.EventHandler(this.returnButton_loginForm_MouseEnter);
            this.returnButton_loginForm.MouseLeave += new System.EventHandler(this.returnButton_loginForm_MouseLeave);
            // 
            // welcomeLabel_loginForm
            // 
            this.welcomeLabel_loginForm.AutoSize = true;
            this.welcomeLabel_loginForm.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.welcomeLabel_loginForm.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.welcomeLabel_loginForm.Location = new System.Drawing.Point(496, 9);
            this.welcomeLabel_loginForm.Name = "welcomeLabel_loginForm";
            this.welcomeLabel_loginForm.Size = new System.Drawing.Size(193, 44);
            this.welcomeLabel_loginForm.TabIndex = 2;
            this.welcomeLabel_loginForm.Text = "WELCOME";
            this.welcomeLabel_loginForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "SELECT YOUR USERNAME AND LET\'S PLAY!";
            // 
            // login_listBox
            // 
            this.login_listBox.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login_listBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.login_listBox.FormattingEnabled = true;
            this.login_listBox.ItemHeight = 20;
            this.login_listBox.Location = new System.Drawing.Point(23, 124);
            this.login_listBox.Name = "login_listBox";
            this.login_listBox.Size = new System.Drawing.Size(261, 344);
            this.login_listBox.TabIndex = 4;
            this.login_listBox.SelectedIndexChanged += new System.EventHandler(this.login_listBox_SelectedIndexChanged);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.usernameLabel.Location = new System.Drawing.Point(496, 165);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(122, 23);
            this.usernameLabel.TabIndex = 5;
            this.usernameLabel.Text = "USERNAME:";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.levelLabel.Location = new System.Drawing.Point(542, 222);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(76, 23);
            this.levelLabel.TabIndex = 6;
            this.levelLabel.Text = "LEVEL:";
            this.levelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bestscoreLabel
            // 
            this.bestscoreLabel.AutoSize = true;
            this.bestscoreLabel.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bestscoreLabel.Location = new System.Drawing.Point(481, 279);
            this.bestscoreLabel.Name = "bestscoreLabel";
            this.bestscoreLabel.Size = new System.Drawing.Size(137, 23);
            this.bestscoreLabel.TabIndex = 7;
            this.bestscoreLabel.Text = "BEST SCORE:";
            this.bestscoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernameValue
            // 
            this.usernameValue.AutoSize = true;
            this.usernameValue.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.usernameValue.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.usernameValue.Location = new System.Drawing.Point(684, 165);
            this.usernameValue.Name = "usernameValue";
            this.usernameValue.Size = new System.Drawing.Size(19, 23);
            this.usernameValue.TabIndex = 8;
            this.usernameValue.Text = "-";
            // 
            // levelValue
            // 
            this.levelValue.AutoSize = true;
            this.levelValue.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.levelValue.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.levelValue.Location = new System.Drawing.Point(684, 222);
            this.levelValue.Name = "levelValue";
            this.levelValue.Size = new System.Drawing.Size(19, 23);
            this.levelValue.TabIndex = 9;
            this.levelValue.Text = "-";
            // 
            // bestscoreValue
            // 
            this.bestscoreValue.AutoSize = true;
            this.bestscoreValue.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bestscoreValue.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bestscoreValue.Location = new System.Drawing.Point(684, 279);
            this.bestscoreValue.Name = "bestscoreValue";
            this.bestscoreValue.Size = new System.Drawing.Size(19, 23);
            this.bestscoreValue.TabIndex = 10;
            this.bestscoreValue.Text = "-";
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.bestscoreValue);
            this.Controls.Add(this.levelValue);
            this.Controls.Add(this.usernameValue);
            this.Controls.Add(this.bestscoreLabel);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.login_listBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.welcomeLabel_loginForm);
            this.Controls.Add(this.returnButton_loginForm);
            this.Controls.Add(this.playButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.loginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button playButton;
        private Button returnButton_loginForm;
        private Label welcomeLabel_loginForm;
        private Label label1;
        private ListBox login_listBox;
        private Label usernameLabel;
        private Label levelLabel;
        private Label bestscoreLabel;
        private Label usernameValue;
        private Label levelValue;
        private Label bestscoreValue;
    }
}