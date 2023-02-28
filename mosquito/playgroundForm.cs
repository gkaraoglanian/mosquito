/* University of Piraeus - Computer Science */
/* Course : Object Oriented Software Development */
/* Grigoris Karaoglanian - p16044 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mosquito
{
    
    public partial class playgroundForm : Form
    {
        User user;
        GamePlay gameplay;
        ButtonEffects bfx;
        Random random;
        bool gamestarted = false;

        String connectionString = "Data source=csharp2022_1.db;Version=3";
        SQLiteConnection connection;

        public playgroundForm()
        {
            InitializeComponent();
        }

        public playgroundForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void playgroundForm_Load(object sender, EventArgs e)
        {
            bfx = new ButtonEffects();
            gameplay = new GamePlay();
            random = new Random();
            connection = new SQLiteConnection(connectionString);

            this.bestscoreValue.Text = this.user.bestscore.ToString();
            this.timeLabel.Text = this.gameplay.game_time.ToString();

            if(this.user.advanced_level == false)
            {
                this.userlevelLabel.Text = "BEGINNER";
            }
            else
            {
                this.userlevelLabel.Text = "ADVANCED";
            }
            
        }

        //------------ startButton Events -----------
        private void startButton_MouseEnter(object sender, EventArgs e)
        {
            bfx.reverseButtonColor(this.startButton);
        }

        private void startButton_MouseLeave(object sender, EventArgs e)
        {
            bfx.reverseButtonColor(this.startButton);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            this.startButton.Enabled = false;
            this.gamestarted = true;
            if(this.user.advanced_level == false)
            {
                this.mosquito_position.Start();
            }
            else
            {
                this.mosquito_position_advanced.Start();
            }
            
            this.countdown.Start();
        }

        //-------------- returnButton Events --------------
        private void returnButton_MouseEnter(object sender, EventArgs e)
        {
            bfx.reverseButtonColor(this.returnButton);
        }

        private void returnButton_MouseLeave(object sender, EventArgs e)
        {
            bfx.reverseButtonColor(this.returnButton);
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.gameplay.defeated = true;
            this.mosquito_position.Stop();
            this.mosquito_position_advanced.Stop();
            this.countdown.Stop();
            this.gameplay.logUserGame(this.user, this.gameplay, this.connection);
            MessageBox.Show("GAMEOVER");

            //---------- switch forms ------------
            this.Hide();
            loginForm loginForm = new loginForm();
            loginForm.StartPosition = this.StartPosition;
            loginForm.Location = this.Location;
            loginForm.ShowDialog();
            this.Close();
        }

        private void mosquito_position_Tick(object sender, EventArgs e)
        {
            if(!gameplay.defeated)
            {
                this.movingMosquito.Location = new Point(random.Next(this.gameplay_panel.Width - this.movingMosquito.Width), random.Next(this.gameplay_panel.Height - this.movingMosquito.Height));
            }
            else
            {
                this.mosquito_position.Stop();
                MessageBox.Show("GAMEOVER");
                
            }
            
        }

        private void movingMosquito_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Mosquito clicked!");

            if (this.startButton.Enabled == false)
            {
                if (!gameplay.defeated)
                {
                    gameplay.game_score += 1;
                    this.gamescoreValue.Text = gameplay.game_score.ToString();
                }
            }
            
           
        }

        private void countdown_Tick(object sender, EventArgs e)
        {
            if (!gameplay.defeated) 
            { 
                if(gameplay.game_time >= 1)
                {
                    gameplay.game_time -= 1;
                    this.timeLabel.Text = this.gameplay.game_time.ToString();

                }
                else { gameplay.defeated = true; }
            }
            else
            {
                this.countdown.Stop();
                this.gameplay.logUserGame(this.user, this.gameplay, this.connection);
                //MessageBox.Show("LOGED USER GAME");
            }
        }

        private void mosquito_position_advanced_Tick(object sender, EventArgs e)
        {
            if (!gameplay.defeated)
            {
                this.movingMosquito.Location = new Point(random.Next(this.gameplay_panel.Width - this.movingMosquito.Width), random.Next(this.gameplay_panel.Height - this.movingMosquito.Height));
            }
            else
            {
                this.mosquito_position_advanced.Stop();
                MessageBox.Show("GAMEOVER");
            }
        }
    }
}
