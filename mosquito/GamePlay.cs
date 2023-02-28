/* University of Piraeus - Computer Science */
/* Course : Object Oriented Software Development */
/* Grigoris Karaoglanian - p16044 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Diagnostics;

namespace mosquito
{
    public class GamePlay
    {
        public int game_time { get; set; }
        public int game_score { get; set; }
        public bool defeated { get; set; }
        public String returnMessage { get; set; }

        public GamePlay()
        {
            game_time = 60;
            game_score = 0;
            defeated = false;
            
        }

        public bool isBestScore(User user, int game_score)
        {
            if (user.bestscore >= game_score)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void logUserGame(User user, GamePlay game, SQLiteConnection connection)
        {
            if (isBestScore(user,game.game_score)) 
            {
                connection.Open();
                String updateUser = String.Format("UPDATE User SET bestscore={0} WHERE username='{1}'", game.game_score, user.username);
                SQLiteCommand command = new SQLiteCommand(updateUser,connection);
                command.ExecuteNonQuery();
                connection.Close();
                //----- Debugging -------
                Debug.WriteLine("Updating {0}'s bestscore from {1} to {2}.",user.username,user.bestscore,game.game_score);
            }
            else
            {
                Debug.WriteLine("{0}'s bestscore {1} is higher of this game's score {2}.", user.username, user.bestscore, game.game_score);
            }
            
        }
        
    }
}
