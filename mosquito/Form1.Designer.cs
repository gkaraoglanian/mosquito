namespace mosquito
{
    partial class welcomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginButton = new System.Windows.Forms.Button();
            this.newUserButton = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.welcome_pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.welcome_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Cyan;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginButton.ForeColor = System.Drawing.Color.Red;
            this.loginButton.Location = new System.Drawing.Point(500, 440);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(170, 50);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "LOG IN";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            this.loginButton.MouseEnter += new System.EventHandler(this.loginButton_MouseEnter);
            this.loginButton.MouseLeave += new System.EventHandler(this.loginButton_MouseLeave);
            // 
            // newUserButton
            // 
            this.newUserButton.BackColor = System.Drawing.Color.Cyan;
            this.newUserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newUserButton.FlatAppearance.BorderSize = 0;
            this.newUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newUserButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newUserButton.ForeColor = System.Drawing.Color.Maroon;
            this.newUserButton.Location = new System.Drawing.Point(519, 496);
            this.newUserButton.Name = "newUserButton";
            this.newUserButton.Size = new System.Drawing.Size(140, 30);
            this.newUserButton.TabIndex = 1;
            this.newUserButton.Text = "NEW USER";
            this.newUserButton.UseVisualStyleBackColor = false;
            this.newUserButton.Click += new System.EventHandler(this.newUserButton_Click);
            this.newUserButton.MouseEnter += new System.EventHandler(this.newUserButton_MouseEnter);
            this.newUserButton.MouseLeave += new System.EventHandler(this.newUserButton_MouseLeave);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.welcomeLabel.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.welcomeLabel.ForeColor = System.Drawing.Color.Lime;
            this.welcomeLabel.Location = new System.Drawing.Point(428, 106);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(336, 46);
            this.welcomeLabel.TabIndex = 2;
            this.welcomeLabel.Text = "CAN\'T CATCH ME!";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // welcome_pictureBox
            // 
            this.welcome_pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.welcome_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.welcome_pictureBox.Image = global::mosquito.Properties.Resources.angrymosquitooriginal;
            this.welcome_pictureBox.Location = new System.Drawing.Point(347, 159);
            this.welcome_pictureBox.Name = "welcome_pictureBox";
            this.welcome_pictureBox.Size = new System.Drawing.Size(491, 262);
            this.welcome_pictureBox.TabIndex = 3;
            this.welcome_pictureBox.TabStop = false;
            // 
            // welcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.welcome_pictureBox);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.newUserButton);
            this.Controls.Add(this.loginButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "welcomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mosquito";
            this.Load += new System.EventHandler(this.welcomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.welcome_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button loginButton;
        private Button newUserButton;
        private Label welcomeLabel;
        private PictureBox welcome_pictureBox;
    }
}