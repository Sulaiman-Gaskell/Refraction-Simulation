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
    public partial class refractionQQuestions : Form
    {
        public refractionQQuestions()
        {
            InitializeComponent();
        }

        private void refractionQQuestions_Load(object sender, EventArgs e)
        {
            // Gives a full screen window
            this.WindowState = FormWindowState.Maximized;

            // Sets the form text as the version num defined by the class
            // TitleVersion
            this.Text = systemWideVariables.titleVersion;

            if (systemWideVariables.lightTheme == true)
            {
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;   
                bArrow.BackgroundImage = Properties.Resources.lightBackArrow;
                bArrow.BackColor = Color.White;
            }

            // Puts the back arrow in the top left hand corner
            bArrow.Location = new Point(0, 0);


            // sets up the fade in animatino
            this.Opacity = 0;
            fadeIn.Enabled = true;

            // Sizes the back arrow
            bArrow.Size = new Size(ClientSize.Height / 10, ClientSize.Height / 10);
        }

        private void bArrow_Click(object sender, EventArgs e)
        {
            fadeOut.Enabled = true;
        }

        // For fade in animaiton
        private void fadeIn_Tick(object sender, EventArgs e)
        {

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

        // For the fade out animation
        private void fadeOut_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.1;
            }
            else
            {
                this.Close();
            }
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
    }
}
