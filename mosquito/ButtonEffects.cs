/* University of Piraeus - Computer Science */
/* Course : Object Oriented Software Development */
/* Grigoris Karaoglanian - p16044 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace mosquito
{
    internal class ButtonEffects:Button
    {
        SoundPlayer s;

        public void reverseButtonColor(Button btn)
        {
            Color reverseclr = btn.BackColor;     //BACKGROUND COLOR
            btn.BackColor = btn.ForeColor;
            btn.ForeColor = reverseclr;
        }

        public void reverseCheckBoxColor(CheckBox checkBox)
        {
            Color reverseclr = checkBox.BackColor;
            checkBox.BackColor = checkBox.ForeColor;
            checkBox.ForeColor = reverseclr;
        }
    }
}
