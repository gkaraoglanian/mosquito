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
    public partial class newUserForm : Form
    {
        ButtonEffects bfx;
        User user;
        String connectionString = "Data source=csharp2022_1.db;Version=3";
        SQLiteConnection connection;
        bool advanced;

        public newUserForm()
        {
            InitializeComponent();
        }

        private void newUserForm_Load(object sender, EventArgs e)
        {
            bfx = new ButtonEffects();
            connection = new SQLiteConnection(connectionString);
            
            this.playButton.Enabled= false;
        }

        //-------------- playButton Events ---------------
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
            user = new User(this.username_textBox.Text,this.advanced);

            int level;  //convert advanced_level to int
            if (this.user.advanced_level == true)
            {
                level = 1;
            }
            else
            {
                level = 0;
            }

            connection.Open();
            String insertUser = String.Format("INSERT INTO User(username,level,bestscore) VALUES('{0}','{1}','{2}')", this.user.username.ToString(), level.ToString(), this.user.bestscore.ToString());
            SQLiteCommand command = new SQLiteCommand(insertUser,connection);
            command.ExecuteNonQuery();

            //----- Debugging ----------
            Debug.WriteLine("Logging new user.");
            Debug.WriteLine("User info:");
            SQLiteCommand dbg_command = new SQLiteCommand(String.Format("SELECT * FROM user WHERE username='{0}'", this.user.username.ToString()), connection);
            SQLiteDataReader reader = dbg_command.ExecuteReader();
            while (reader.Read())
            {
                Debug.WriteLine(reader.GetString(1));
                Debug.WriteLine(reader.GetInt16(2).ToString());
                Debug.WriteLine(reader.GetInt32(3).ToString());
            }
            connection.Close(); 

            this.Hide();
            playgroundForm playgroundForm = new playgroundForm(this.user);
            playgroundForm.StartPosition = this.StartPosition;
            playgroundForm.Location = this.Location;
            playgroundForm.ShowDialog();
            this.Close();
        }

        //-------------- returnButton Events ---------------
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
            this.Hide();
            welcomeForm welcomeForm = new welcomeForm();
            welcomeForm.StartPosition = this.StartPosition;
            welcomeForm.Location = this.Location;
            welcomeForm.ShowDialog();
            this.Close();
        }

        //---------------- checkBox Events -------------------
        private void advanced_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            this.advanced = this.advanced_checkBox.Checked;
            bfx.reverseCheckBoxColor(this.advanced_checkBox);
        }

        private void username_textBox_TextChanged(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(username_textBox.Text))
            {
                playButton.Enabled = true;
            }
            else
            {
                playButton.Enabled = false;
            }
        }
    }
}
