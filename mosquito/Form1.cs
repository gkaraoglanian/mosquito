/* University of Piraeus - Computer Science */
/* Course : Object Oriented Software Development */
/* Grigoris Karaoglanian - p16044 */

using System.Data.SQLite;
using System.Diagnostics;

namespace mosquito
{
    public partial class welcomeForm : Form
    {
        ButtonEffects bfx;

        String connectionString = "Data source=csharp2022_1.db;Version=3";
        SQLiteConnection connection;
        public welcomeForm()
        {
            InitializeComponent();
        }

        private void welcomeForm_Load(object sender, EventArgs e)
        {
            bfx = new ButtonEffects();

            //---------- create DB if not exists---------
            connection = new SQLiteConnection(connectionString);
            connection.Open();
            //SQLiteCommand rem_com = new SQLiteCommand("DROP TABLE User ", connection);
            //rem_com.ExecuteNonQuery();
            String createDB = "CREATE TABLE IF NOT EXISTS User(user_id integer auto increment primary key,username Text,level integer,bestscore integer)";
            SQLiteCommand command = new SQLiteCommand(createDB,connection);
            command.ExecuteNonQuery();
            SQLiteCommand command2 = new SQLiteCommand("SELECT * FROM User",connection);
            SQLiteDataReader reader = command2.ExecuteReader();
            while(reader.Read()) 
            {
                //Debug.WriteLine(reader.GetString(0).ToString());
                Debug.WriteLine(reader.GetString(1));
                Debug.WriteLine(reader.GetInt16(2).ToString());
                Debug.WriteLine(reader.GetInt32(3).ToString());
            }
            
            connection.Close();

        }

        //------------ Login Button ------------
        private void loginButton_MouseEnter(object sender, EventArgs e)
        {
            bfx.reverseButtonColor(this.loginButton);
        }

        private void loginButton_MouseLeave(object sender, EventArgs e)
        {
            bfx.reverseButtonColor(this.loginButton);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm loginForm = new loginForm();
            loginForm.StartPosition = this.StartPosition;
            loginForm.Location = this.Location;
            loginForm.ShowDialog();
            this.Close();
        }

        //-------------- New User Button ------------
        private void newUserButton_MouseEnter(object sender, EventArgs e)
        {
            bfx.reverseButtonColor(this.newUserButton);
        }

        private void newUserButton_MouseLeave(object sender, EventArgs e)
        {
            bfx.reverseButtonColor(this.newUserButton);
        }

        private void newUserButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            newUserForm newUserForm = new newUserForm();
            newUserForm.StartPosition = this.StartPosition;
            newUserForm.Location = this.Location;
            newUserForm.ShowDialog();
            this.Close();
        }

        

    }
}