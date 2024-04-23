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
    public partial class welcomeScreen : Form
    {
        public welcomeScreen()
        {
            InitializeComponent();

            // Sets the opactiy to 0 for the fade in animation
            this.Opacity = 0;

            // Disables annoying windows sounds
            this.AcceptButton = null;
        }

        private void button1_Click(object sender, EventArgs e) // Refraction
        {
        

            // Creates an instance of the refraction form when
            // the button is pressed
            Refraction refraction = new Refraction();
            refraction.Show();

            // When the refaction instance is closed by the user
            // the Welcome menu will open again
            this.Show();
            // When the screen is next shown the opactiy is set to 0
            // and the fade in animation is triggered
            this.Opacity = 0;
            fadeIn.Enabled  = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void welcomeScreen_Load(object sender, EventArgs e)
        {
            // Triggers the fade in animation
            fadeIn.Enabled = true;

            // Chnages font to a nicer one for both buttons
            wTxt.Font = new Font ("Microsoft Sans Serif",16);
            refraction.Font = new Font("Microsoft Sans Serif", 11);
            waves.Font = new Font("Microsoft Sans Serif",11);
        }

        // For fade in animation
        private void fadeIn_Tick(object sender, EventArgs e)
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

        private void waves_Click(object sender, EventArgs e)
        {
          

            // Creates an instance of the refraction form when
            // the button is pressed
            Waves waves = new Waves();
            waves.Show();

            // When the refaction instance is closed by the user
            // the Welcome menu will open again
            this.Show();
            // When the screen is next shown the opactiy is set to 0
            // and the fade in animation is triggered
            this.Opacity = 0;
            fadeIn.Enabled = true;
        }
    }
}
