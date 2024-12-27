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
    public partial class refractionBuilder : Form
    {
        public refractionBuilder()
        {
            InitializeComponent();
        }

        private void refractionBuilder_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            // Sets the form text as the version num defined by the class
            // TitleVersion
            this.Text = systemWideVariables.titleVersion;

            // Sizes the back arrow
            bArrow.Size = new Size(this.Height / 10, this.Height / 10);
            bArrow.Location = new Point(0, 0);

            this.Opacity = 0;

            fadeIn.Enabled = true;


            qNameLabel.Location = new Point(this.Width / 2, this.Height / 100 * 20);

        }

        private void bArrow_Click(object sender, EventArgs e)
        {
            fadeOut.Enabled = true;
        }

        private void fadeIn_Tick(object sender, EventArgs e)
        {
            // Fixes wierd scaling animation bug when maximising the window
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
                this.Close();
            }
        }

        private void bArrow_MouseLeave(object sender, EventArgs e)
        {
            // Returns bArrow size back to normal
            bArrow.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void bArrow_MouseEnter(object sender, EventArgs e)
        {
            // Slighly increases the size of the bArrow
            bArrow.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void qNameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
