using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Physics_Simulation.welcomeScreen;

namespace Physics_Simulation
{
    public partial class wInteract : Form
    {
        public wInteract()
        {
            InitializeComponent();

            //Maximises the form and stops the user
            //from resizing it
            this.WindowState = FormWindowState.Maximized;

            // Disables annoying windows sounds
            this.AcceptButton = null;
        }

        private void wInteract_Load(object sender, EventArgs e)
        {

            // Sets the form text as the version num defined by the class
            // TitleVersion
            this.Text = systemWideVariables.titleVersion;

            // for fade in effect
            // Set the form's initial opacity to 0 (completely transparent)
            this.Opacity = 0;

            // Start the fade to animate the form
            fadeIn.Enabled = true;

            // For light mode
            if (systemWideVariables.lightTheme == true)
            {
                this.BackColor = Color.White;
                bArrow.BackgroundImage = Properties.Resources.lightBackArrow;
                bArrow.BackColor = Color.White;
                frequencyText.ForeColor = Color.Black;

            }

            // Puts the back arrow in the top left hand corner
            bArrow.Location = new Point(0, 0);

            // Sizes the back arrow
            bArrow.Size = new Size(ClientSize.Height / 10, ClientSize.Height / 10);

            // For sizing objects based on clients resoloution
            frequencyText.Font = new Font(frequencyText.Font.FontFamily,
            ClientSize.Width / 80);

            // Sets the same size for matching objects

            frequency.Size = frequencyText.Size;

            // Adds margins between objects to look nicer
            // Adds some margin gaps between controls to look better
            frequencyText.Margin = new System.Windows.Forms.Padding(
                ClientSize.Width / 150, 0, 0, 0);

        
            frequency.Margin = new System.Windows.Forms.Padding(
                ClientSize.Width / 150, ClientSize.Width / 50, 0, 0);

        }

        private void fadeIn_Tick(object sender, EventArgs e)
        {
            {

                // Fades in the form
                if (this.Opacity < 1)
                {
                    this.Opacity += 0.1;
                }

                // When fully solid stop the timer
                else
                {
                    fadeIn.Enabled = false;
                }
            }
        }

        private void fadeOut_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.1;
            }
            else
            {
                // When the opacity is 0, close the form
                this.Close();

            }
        }

        private void bArrow_Click(object sender, EventArgs e)
        {
            fadeOut.Enabled = true;
        }

        private void bArrow_MouseEnter(object sender, EventArgs e)
        {
            // Slighly increases the size of the bArrow
            bArrow.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void bArrow_MouseLeave(object sender, EventArgs e)
        {
            // Returns bArrow size back to normal
            bArrow.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            // If it is [0,2] then the bg of it will change to the right colour
            if (e.Column == 0 && e.Row == 2)
            {
                if (systemWideVariables.lightTheme == true)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.Black), e.CellBounds);
                }
                else { e.Graphics.FillRectangle(new SolidBrush(Color.White), e.CellBounds); }

            }
        }
    }
}
