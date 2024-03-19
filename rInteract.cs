using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Physics_Simulation
{
    public partial class rInteract : Form
    {
        public rInteract()
        {
            InitializeComponent();
            //Maximises the form and stops the user
            //from resizing it
            //and removes the topbar
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;



        }

        private void rInteract_Load(object sender, EventArgs e)
        {
            // for fade in effect
            // Set the form's initial opacity to 0 (completely transparent)
            this.Opacity = 0;

            // Start the fade to animate the form
            fadeIn.Enabled = true;

        }

  



        private void bArrow_Click_1(object sender, EventArgs e)
        {
            // triggers the fade out timer
            fadeOut.Enabled = true;

        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // For the fade in animation
        private void fade_Tick(object sender, EventArgs e)
        {
            // Gradually increase the form's opacity
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
    }
}
