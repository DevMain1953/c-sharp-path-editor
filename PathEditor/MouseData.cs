using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace PathEditor
{
    /// <summary>
    /// This class enables users to work with mouse data
    /// </summary>
    public class MouseData
    {
        private Point MouseDownLocation; //Stores location where left mouse button was pressed by user

        /// <summary>
        /// Saves location where left mouse button was pressed by user to property
        /// </summary>
        /// <param name="e">Provides data for the MouseUp, MouseDown, and MouseMove events</param>
        public void StoreMouseLocation(MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        /// <summary>
        /// Moves control when left mouse button is pressed to location where mouse cursos is
        /// </summary>
        /// <param name="e">Provides data for the MouseUp, MouseDown, and MouseMove events</param>
        /// <param name="c">Control that will be moved</param>
        public void MoveControl(MouseEventArgs e, Control c)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                c.Left = e.X + c.Left - MouseDownLocation.X;
                c.Top = e.Y + c.Top - MouseDownLocation.Y;
            }
        }
    }
}
