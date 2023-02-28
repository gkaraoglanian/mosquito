namespace mosquito
{
    partial class newUserForm
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
            this.mainLabel = new System.Windows.Forms.Label();
            this.username_textBox = new System.Windows.Forms.TextBox();
            this.playButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.advanced_checkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mainLabel.Location = new System.Drawing.Point(280, 9);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(605, 30);
            this.mainLabel.TabIndex = 0;
            this.mainLabel.Text = "ENTER YOUR USERNAME AND SELECT DIFFICULTY";
            this.mainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // username_textBox
            // 
            this.username_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username_textBox.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.username_textBox.ForeColor = System.Drawing.Color.Crimson;
            this.username_textBox.Location = new System.Drawing.Point(280, 223);
            this.username_textBox.MaxLength = 38;
            this.username_textBox.Name = "username_textBox";
            this.username_textBox.Size = new System.Drawing.Size(593, 43);
            this.username_textBox.TabIndex = 2;
            this.username_textBox.Text = "USERNAME";
            this.username_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.username_textBox.TextChanged += new System.EventHandler(this.username_textBox_TextChanged);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.playButton.ForeColor = System.Drawing.Color.Aquamarine;
            this.playButton.Location = new System.Drawing.Point(514, 318);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(242, 40);
            this.playButton.TabIndex = 3;
            this.playButton.Text = "LET\'S PLAY!";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            this.playButton.MouseEnter += new System.EventHandler(this.playButton_MouseEnter);
            this.playButton.MouseLeave += new System.EventHandler(this.playButton_MouseLeave);
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.returnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnButton.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.returnButton.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.returnButton.Location = new System.Drawing.Point(410, 318);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(98, 40);
            this.returnButton.TabIndex = 4;
            this.returnButton.Text = "RETURN";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            this.returnButton.MouseEnter += new System.EventHandler(this.returnButton_MouseEnter);
            this.returnButton.MouseLeave += new System.EventHandler(this.returnButton_MouseLeave);
            // 
            // advanced_checkBox
            // 
            this.advanced_checkBox.AutoSize = true;
            this.advanced_checkBox.BackColor = System.Drawing.Color.Black;
            this.advanced_checkBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.advanced_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.advanced_checkBox.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.advanced_checkBox.ForeColor = System.Drawing.Color.Red;
            this.advanced_checkBox.Location = new System.Drawing.Point(503, 272);
            this.advanced_checkBox.Name = "advanced_checkBox";
            this.advanced_checkBox.Size = new System.Drawing.Size(121, 24);
            this.advanced_checkBox.TabIndex = 5;
            this.advanced_checkBox.Text = "ADVANCED";
            this.advanced_checkBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.advanced_checkBox.UseVisualStyleBackColor = false;
            this.advanced_checkBox.CheckedChanged += new System.EventHandler(this.advanced_checkBox_CheckedChanged);
            // 
            // newUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.advanced_checkBox);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.username_textBox);
            this.Controls.Add(this.mainLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "newUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "newUserForm";
            this.Load += new System.EventHandler(this.newUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label mainLabel;
        private TextBox username_textBox;
        private Button playButton;
        private Button returnButton;
        private CheckBox advanced_checkBox;
    }
}