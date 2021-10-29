using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PathEditor
{
    public partial class Form1 : Form
    {
        MouseData md = new MouseData();
        MemoryEditor mem = new MemoryEditor();
        CoordinateAdaptor cadaptor = new CoordinateAdaptor();
        bool isFirstTextBoxClicked = false, isSecondTextBoxClicked = false;

        const int mapScale = 7;

        public Form1()
        {
            InitializeComponent();
            ChangeLabels();
            PaintLabels();
            AddEventHandlersToLabels();
            AddEventHandlersToTextBoxes();
            mem.GetProcessID("gta3");
        }

        /// <summary>
        /// Sets parent and new text to every label on form
        /// </summary>
        public void ChangeLabels()
        {
            List<Control> list = new List<Control>();
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(Label))
                {
                    list.Add(c);
                }
            }
            for (int i = 0; i < list.Count(); i++)
            {
                list[i].Text = (i + 1).ToString();
                list[i].Parent = this.Map;
            }
        }

        /// <summary>
        /// Sets new backgound and foreground colors to every labal on form whose parent is Map picturebox
        /// Defines specified colors for first and last labels
        /// </summary>
        public void PaintLabels()
        {
            //Loop iterates every control whose parent is Map on this form
            foreach (Control c in this.Map.Controls)
            {
                if (c.GetType() == typeof(Label))
                {
                    c.BackColor = Color.Transparent;
                    c.ForeColor = Color.White;
                    if (c.Text == "1")
                    {
                        c.ForeColor = Color.Aqua;
                    }
                    if (c.Text == "44")
                    {
                        c.ForeColor = Color.Red;
                    }
                }
            }
        }

        /// <summary>
        /// Adds event handlers to all Labels on form whose parent is Map picturebox,
        /// these handlers handle MouseDown and MouseMove events
        /// </summary>
        public void AddEventHandlersToLabels()
        {
            foreach (Control c in this.Map.Controls)
            {
                if (c.GetType() == typeof(Label))
                {
                    c.MouseDown += new MouseEventHandler(this.Label_MouseDown);
                    c.MouseMove += new MouseEventHandler(this.Label_MouseMove);
                }
            }
        }

        /// <summary>
        /// Adds event handlers to all textboxes on form, these handlers handle Click event
        /// </summary>
        public void AddEventHandlersToTextBoxes()
        {
            foreach (Control c in this.SpecifiedHeightGroupBox.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    c.Click += new EventHandler(this.RemoveText);
                }
            }
        }

        /// <summary>
        /// Excutes when textbox is clicked, cleans text in each textbox once
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e">Represents the base class for classes that contain event data</param>
        public void RemoveText(object sender, EventArgs e)
        {
            var textbox = sender as TextBox; //Casts sender object to control on current form

            if (isFirstTextBoxClicked != true && textbox.Name == "PointNumber")
            {
                textbox.Text = "";
                isFirstTextBoxClicked = true;
            }
            if (isSecondTextBoxClicked != true && textbox.Name == "ZCoord")
            {
                textbox.Text = "";
                isSecondTextBoxClicked = true;
            }
        }

        /// <summary>
        /// Executes when left button of mouse is pressed by user and cursor is over the control
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e">Provides data for the MouseUp, MouseDown, and MouseMove events</param>
        public void Label_MouseDown(object sender, MouseEventArgs e)
        {
            md.StoreMouseLocation(e);
        }

        /// <summary>
        /// Executes when user moves mouse and cursos is over the control
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e">Provides data for the MouseUp, MouseDown, and MouseMove events</param>
        public void Label_MouseMove(object sender, MouseEventArgs e)
        {
            var label = sender as Label; //Casts sender object to control on current form
            md.MoveControl(e, label);
        }

        /// <summary>
        /// Executes when DetectPoints button is pressed. Reads all coordinates of each point in flight path from game process.
        /// Then moves each labels according to adapted coordinates
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e">Represents the base class for classes that contain event data</param>
        private void DetectPoints_Click(object sender, EventArgs e)
        {
            int baseAddress = 0x00400000 + 0x00485B3C;
            byte[] offsets = { 0x00 };
            mem.ReadCoordinates(baseAddress, offsets);
            mem.LogInfo("PATHS.txt");
            this.Text = "Path Editor - Points are detected";
            MoveLabels();
            this.SavePoints.Enabled = true;
            this.ApplyHeight.Enabled = true;
            this.SpecifiedHeightGroupBox.Enabled = true;
        }

        /// <summary>
        /// Adapts each coordinate in array according to map scale 
        /// then moves each label on form to adapted coordinates on Map picturebox
        /// </summary>
        public void MoveLabels()
        {
            //Zero coordinates according to Map picturebox
            int zx = this.Map.Width / 2;
            int zy = this.Map.Height / 2;

            int x = 0, y = 0;

            List<Control> list = new List<Control>();
            foreach (Control c in this.Map.Controls)
            {
                if (c.GetType() == typeof(Label))
                {
                    list.Add(c);
                }
            }
            for (int i = 0; i < list.Count(); i++)
            {
                x = Convert.ToInt32(mem.pointsOfPath[i, 0]);
                y = Convert.ToInt32(mem.pointsOfPath[i, 1]);
                cadaptor.AdaptCoordinates(ref x, ref y, mapScale);
                list[i].Location = new Point(zx + x, zy - y);
            }
        }

        /// <summary>
        /// Executes when SavePoints button is pressed. Gets new coordinates of each label on form, reverses it to real game coordinates 
        /// and saves it to array then writes array to game process
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e">Represents the base class for classes that contain event data</param>
        private void SavePoints_Click(object sender, EventArgs e)
        {
            //Zero coordinates according to Map picturebox
            int zx = this.Map.Width / 2;
            int zy = this.Map.Height / 2;

            int x = 0, y = 0;

            List<Control> list = new List<Control>();
            foreach (Control c in this.Map.Controls)
            {
                if (c.GetType() == typeof(Label))
                {
                    list.Add(c);
                }
            }

            for (int i = 0; i < list.Count(); i++)
            {
                x = list[i].Location.X;
                y = list[i].Location.Y;
                x = (zx - x) * (-1);
                y = zy - y;
                cadaptor.ReverseCoordinates(ref x, ref y, mapScale);

                mem.pointsOfPath[i, 0] = x;
                mem.pointsOfPath[i, 1] = y;
            }

            int baseAddress = 0x00400000 + 0x00485B3C;
            byte[] offsets = { 0x00 };
            mem.WriteCoordinates(baseAddress, offsets);


            mem.LogInfo("NEW_PATHS.txt");
        }

        /// <summary>
        /// Executes when TrackBar slider moves. Changes text of groupbox
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e">Represents the base class for classes that contain event data</param>
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.HeightGroupBox.Text = "Set whole height to " + this.trackBar1.Value * 30;
        }

        /// <summary>
        /// Executes when ApplyHeight button is pressed. Calcultes and writes new Z coordinates to array of path points (writes Z coordinates to each point of path)
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e">Represents the base class for classes that contain event data</param>
        private void ApplyHeight_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < mem.matrixRowCount; i++)
            {
                mem.pointsOfPath[i, 2] = Convert.ToSingle(this.trackBar1.Value * 30);
            }
        }

        /// <summary>
        /// Executes when ApplySpecHeight button is pressed. Gets number of point from first textbox
        /// then new Z coordinate from second textbox and writes it to array of points for specified point
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e">Represents the base class for classes that contain event data</param>
        private void ApplySpecHeight_Click(object sender, EventArgs e)
        {
            int row = Convert.ToInt32(this.PointNumber.Text) - 1;
            float coord = Convert.ToSingle(this.ZCoord.Text);
            for (int i = 0; i < mem.matrixRowCount; i++)
            {
                if (i == row)
                {
                    mem.pointsOfPath[i, 2] = coord;
                }
            }
        }
    }
}
