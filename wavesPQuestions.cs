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
    public partial class wavesPQuestions : Form
    {
        public wavesPQuestions()
        {
            InitializeComponent();
        }

        private void wavesPQuestions_Load(object sender, EventArgs e)
        {
            this.Text = systemWideVariables.titleVersion;

            this.Opacity = 0;

            fadeIn.Enabled = true;
        }

        private void fadeIn_Tick(object sender, EventArgs e)
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
    }
}
