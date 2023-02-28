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
    public partial class loginForm : Form
    {
        User user;
        ButtonEffects bfx;
        String connectionString = "Data source=csharp2022_1.db;Version=3";
        SQLiteConnection connection;
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            
            bfx = new ButtonEffects();
            this.login_listBox.Items.Clear();

            //--------- Fill listbox with db usernames -------------
            connection = new SQLiteConnection(connectionString);
            connection.Open();
            String fillListBox = "SELECT * FROM User";
            SQLiteCommand command = new SQLiteCommand(fillListBox,connection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                this.login_listBox.Items.Add(reader["username"]);
            }
            connection.Close();

            //----------- Must select user to play --------
            if (this.login_listBox.SelectedIndex == -1)
            {
                this.playButton.Enabled = false;
            }

        }

        //----------- playButton Events ------------
        private void playButton_MouseEnter(object sender, EventArgs e)
        {
            bfx.reverseButtonColor(this.playButton);
        }

        private void playButton_MouseLeave(object sender, EventArgs e)
        {
            bfx.reverseButtonColor(this.playButton);
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            bfx.reverseButtonColor(this.playButton);

            //-------- Transfer User data to PlaygroundForm ---------------
            bool level; //convert level from int to bool
            connection.Open();
            String getUser = String.Format("SELECT * FROM User WHERE username = '{0}'", this.login_listBox.SelectedItem);
            SQLiteCommand command = new SQLiteCommand(getUser,connection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read()) 
            { 
                if(reader.GetInt16(2) == 0) { level = false; } else
                {
                    level = true;
                }
                user = new User(reader.GetString(1), level, reader.GetInt32(3)); 
            }
            connection.Close();

            //------ Debug -------
            Debug.WriteLine("User {0} logged in.", this.user.username);
            Debug.WriteLine("Advanced: {0}", this.user.advanced_level);
            Debug.WriteLine("Bestscore: {0}", this.user.bestscore);
            Debug.WriteLine("Transfering data to Playground Form..");


            this.Hide();
            playgroundForm playgroundForm = new playgroundForm(this.user);
            playgroundForm.StartPosition = this.StartPosition;
            playgroundForm.Location = this.Location;
            playgroundForm.ShowDialog();
            this.Close();
        }

        //------------- return Button Events -------------
        private void returnButton_loginForm_MouseEnter(object sender, EventArgs e)
        {
            bfx.reverseButtonColor(this.returnButton_loginForm);
        }

        private void returnButton_loginForm_MouseLeave(object sender, EventArgs e)
        {
            bfx.reverseButtonColor(this.returnButton_loginForm);
        }

        private void returnButton_loginForm_Click(object sender, EventArgs e)
        {
            bfx.reverseButtonColor(this.returnButton_loginForm);
            this.Hide();
            welcomeForm welcomeForm = new welcomeForm();
            welcomeForm.StartPosition = this.StartPosition;
            welcomeForm.Location = this.Location;
            welcomeForm.ShowDialog();
            this.Close();
        }

        private void login_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String str_level_value = "";
            connection.Open();

            //---------- Show Selected User's Username ------------
            String selectUser = String.Format("SELECT username,level,bestscore FROM User WHERE username = '{0}'; ",this.login_listBox.SelectedItem);
            SQLiteCommand command = new SQLiteCommand(selectUser,connection);
            SQLiteDataReader readerValue = command.ExecuteReader();
            while(readerValue.Read())
            {
                if(readerValue.GetInt16(1) == 1)
                {
                    str_level_value = "ADVANCED";
                }
                else
                {
                    str_level_value = "BEGINNER";
                }
                this.usernameValue.Text = readerValue.GetString(0);
                this.levelValue.Text = str_level_value;
                this.bestscoreValue.Text = readerValue.GetInt32(2).ToString();
            }
            connection.Close();
            this.playButton.Enabled = true;
        }
    }
}
