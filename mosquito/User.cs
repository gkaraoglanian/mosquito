/* University of Piraeus - Computer Science */
/* Course : Object Oriented Software Development */
/* Grigoris Karaoglanian - p16044 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosquito
{
    public class User
    {
        public string username { get; set; }
        public bool advanced_level { get; set; }
        public int bestscore { get; set; }

        public User(String username) { 
            this.username = username;
            this.advanced_level = false;
            this.bestscore = 0;
        } 
        
        public User(String username, bool advanced_level)
        {
            this.username = username;
            this.advanced_level = advanced_level;
            this.bestscore = 0;
        }

        public User(String username, bool advanced_level, int bestscore) 
        {
            this.username = username;
            this.advanced_level = advanced_level;
            this.bestscore= bestscore;
        }
    }
}
