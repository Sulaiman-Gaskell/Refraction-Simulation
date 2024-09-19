using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

            }
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
    }
}
