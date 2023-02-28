namespace mosquito
{
    partial class playgroundForm
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
            this.gameplay_panel = new System.Windows.Forms.Panel();
            this.movingMosquito = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.bestscoreLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.gamescoreValue = new System.Windows.Forms.Label();
            this.bestscoreValue = new System.Windows.Forms.Label();
            this.userlevelLabel = new System.Windows.Forms.Label();
            this.mosquito_position = new System.Windows.Forms.Timer(this.components);
            this.countdown = new System.Windows.Forms.Timer(this.components);
            this.mosquito_position_advanced = new System.Windows.Forms.Timer(this.components);
            this.gameplay_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movingMosquito)).BeginInit();
            this.SuspendLayout();
            // 
            // gameplay_panel
            // 
            this.gameplay_panel.BackColor = System.Drawing.SystemColors.Control;
            this.gameplay_panel.Controls.Add(this.movingMosquito);
            this.gameplay_panel.Location = new System.Drawing.Point(12, 122);
            this.gameplay_panel.Name = "gameplay_panel";
            this.gameplay_panel.Size = new System.Drawing.Size(1160, 527);
            this.gameplay_panel.TabIndex = 0;
            // 
            // movingMosquito
            // 
            this.movingMosquito.Image = global::mosquito.Properties.Resources.P8KN;
            this.movingMosquito.Location = new System.Drawing.Point(462, 142);
            this.movingMosquito.Name = "movingMosquito";
            this.movingMosquito.Size = new System.Drawing.Size(79, 51);
            this.movingMosquito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.movingMosquito.TabIndex = 0;
            this.movingMosquito.TabStop = false;
            this.movingMosquito.Click += new System.EventHandler(this.movingMosquito_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.DarkBlue;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startButton.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startButton.ForeColor = System.Drawing.Color.LawnGreen;
            this.startButton.Location = new System.Drawing.Point(12, 12);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(105, 42);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "START!";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            this.startButton.MouseEnter += new System.EventHandler(this.startButton_MouseEnter);
            this.startButton.MouseLeave += new System.EventHandler(this.startButton_MouseLeave);
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.DarkBlue;
            this.returnButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.returnButton.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.returnButton.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.returnButton.Location = new System.Drawing.Point(1067, 12);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(105, 42);
            this.returnButton.TabIndex = 2;
            this.returnButton.Text = "RETURN";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            this.returnButton.MouseEnter += new System.EventHandler(this.returnButton_MouseEnter);
            this.returnButton.MouseLeave += new System.EventHandler(this.returnButton_MouseLeave);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timeLabel.ForeColor = System.Drawing.Color.Red;
            this.timeLabel.Location = new System.Drawing.Point(548, 25);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(73, 79);
            this.timeLabel.TabIndex = 3;
            this.timeLabel.Text = "0";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bestscoreLabel
            // 
            this.bestscoreLabel.AutoSize = true;
            this.bestscoreLabel.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bestscoreLabel.ForeColor = System.Drawing.Color.Gold;
            this.bestscoreLabel.Location = new System.Drawing.Point(763, 9);
            this.bestscoreLabel.Name = "bestscoreLabel";
            this.bestscoreLabel.Size = new System.Drawing.Size(130, 23);
            this.bestscoreLabel.TabIndex = 4;
            this.bestscoreLabel.Text = "BEST SCORE";
            this.bestscoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scoreLabel.ForeColor = System.Drawing.Color.LightCoral;
            this.scoreLabel.Location = new System.Drawing.Point(289, 9);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(74, 23);
            this.scoreLabel.TabIndex = 5;
            this.scoreLabel.Text = "SCORE";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gamescoreValue
            // 
            this.gamescoreValue.AutoSize = true;
            this.gamescoreValue.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gamescoreValue.ForeColor = System.Drawing.Color.LightCoral;
            this.gamescoreValue.Location = new System.Drawing.Point(300, 44);
            this.gamescoreValue.Name = "gamescoreValue";
            this.gamescoreValue.Size = new System.Drawing.Size(54, 60);
            this.gamescoreValue.TabIndex = 6;
            this.gamescoreValue.Text = "0";
            this.gamescoreValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bestscoreValue
            // 
            this.bestscoreValue.AutoSize = true;
            this.bestscoreValue.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bestscoreValue.ForeColor = System.Drawing.Color.Gold;
            this.bestscoreValue.Location = new System.Drawing.Point(808, 44);
            this.bestscoreValue.Name = "bestscoreValue";
            this.bestscoreValue.Size = new System.Drawing.Size(54, 60);
            this.bestscoreValue.TabIndex = 7;
            this.bestscoreValue.Text = "0";
            this.bestscoreValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userlevelLabel
            // 
            this.userlevelLabel.AutoSize = true;
            this.userlevelLabel.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.userlevelLabel.ForeColor = System.Drawing.Color.Aquamarine;
            this.userlevelLabel.Location = new System.Drawing.Point(1081, 101);
            this.userlevelLabel.Name = "userlevelLabel";
            this.userlevelLabel.Size = new System.Drawing.Size(52, 18);
            this.userlevelLabel.TabIndex = 8;
            this.userlevelLabel.Text = "level";
            this.userlevelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mosquito_position
            // 
            this.mosquito_position.Interval = 1000;
            this.mosquito_position.Tick += new System.EventHandler(this.mosquito_position_Tick);
            // 
            // countdown
            // 
            this.countdown.Interval = 1000;
            this.countdown.Tick += new System.EventHandler(this.countdown_Tick);
            // 
            // mosquito_position_advanced
            // 
            this.mosquito_position_advanced.Interval = 500;
            this.mosquito_position_advanced.Tick += new System.EventHandler(this.mosquito_position_advanced_Tick);
            // 
            // playgroundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.userlevelLabel);
            this.Controls.Add(this.bestscoreValue);
            this.Controls.Add(this.gamescoreValue);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.bestscoreLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.gameplay_panel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "playgroundForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "playgroundForm";
            this.Load += new System.EventHandler(this.playgroundForm_Load);
            this.gameplay_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.movingMosquito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel gameplay_panel;
        private PictureBox movingMosquito;
        private Button startButton;
        private Button returnButton;
        private Label timeLabel;
        private Label bestscoreLabel;
        private Label scoreLabel;
        private Label gamescoreValue;
        private Label bestscoreValue;
        private Label userlevelLabel;
        private System.Windows.Forms.Timer mosquito_position;
        private System.Windows.Forms.Timer countdown;
        private System.Windows.Forms.Timer mosquito_position_advanced;
    }
}