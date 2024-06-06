using Physics_Simulation.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

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

        // Used for all winforms so made public
        public class TitleVersion
        {
            public static string titleVersion = "V1.5.2";
        }

        public class LightTheme
        {
            public static bool lightTheme = Settings.Default.lightTheme;
        }

        private void button1_Click(object sender, EventArgs e) // Refraction
        {
            refraction.BackColor = Color.White;

      
            this.Hide();
            // Creates an instance of the refraction form when
            // the button is pressed
            Refraction refractionWin = new Refraction();
            refractionWin.ShowDialog();
            this.Show();
            

            // When the refaction instance is closed by the user
            // the Welcome menu will open again

            // When the screen is next shown the opactiy is set to 0
            // and the fade in animation is triggered
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void welcomeScreen_Load(object sender, EventArgs e)
        {



            // Sets the form text as the version num defined by the class
            // TitleVersion
            this.Text = TitleVersion.titleVersion;

            // Sets colours acorrdingly
            if (LightTheme.lightTheme == true)
            {
                this.BackColor = Color.White;
                refraction.BackColor = Color.Black;
                refraction.ForeColor = Color.White;
                waves.BackColor = Color.Black;
                waves.ForeColor = Color.White;
                wTxt.BackColor = Color.White;
                wTxt.ForeColor = Color.Black;
                theme.Image = Properties.Resources.sun;
                theme.BackColor = Color.White;
                theme.ForeColor = Color.White;
            }



            // Triggers the fade in animation
            fadeIn.Enabled = true;

            // Chnages font to a nicer one for both buttons
            wTxt.Font = new Font ("Microsoft Sans Serif",21);
            refraction.Font = new Font("Microsoft Sans Serif", 20);
            waves.Font = new Font("Microsoft Sans Serif", 20);

            // Keeps sizing consistant
            refraction.Height = Convert.ToInt32(wTxt.Height / 1.5);
            refraction.Width = Convert.ToInt32(wTxt.Width / 1.5);
            waves.Size = refraction.Size;
            

        }

        // For fade in animation
        private void fadeIn_Tick(object sender, EventArgs e)
        {
            // Gradually increase the form's opacity
            if (this.Opacity < 1)
            {
                this.Opacity += 0.3;
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

        private void refraction_MouseEnter(object sender, EventArgs e)
        {
            refraction.BackColor = Color.Blue;
        }

        private void refraction_MouseLeave(object sender, EventArgs e)
        {
            if (LightTheme.lightTheme == true)
            {
                refraction.BackColor = Color.Black;
                wTxt.ForeColor = Color.Black;
            }
            else
            {
                refraction.BackColor = Color.White;
                wTxt.ForeColor = Color.White;
            }

        }

        private void waves_MouseEnter(object sender, EventArgs e)
        {
            waves.BackColor = Color.OrangeRed;
        }

        private void waves_MouseLeave(object sender, EventArgs e)
        {
            if (LightTheme.lightTheme == true)
            {
                waves.BackColor = Color.Black;
                wTxt.ForeColor = Color.Black;
            }
            else
            {
                waves.BackColor = Color.White;
                wTxt.ForeColor = Color.White;
            }
            
        }

        private void refraction_MouseDown(object sender, MouseEventArgs e)
        {
            wTxt.ForeColor = Color.Blue;
        }

        private void waves_MouseDown(object sender, MouseEventArgs e)
        {
            wTxt.ForeColor = Color.OrangeRed;
        }

        private void welcomeScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.lightTheme = LightTheme.lightTheme;
            Settings.Default.Save();
            Application.Exit();
        }

        private void wTxt_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void themePrompt_Tick(object sender, EventArgs e)
        {
            string defaultText = "Physics Simulations!";
            if (wTxt.Text == defaultText)
            {
                wTxt.Text = "By Sulaiman Gaskell";
            }
            else
            {
                wTxt.Text = defaultText;
            }
        }

        private void settings_Click(object sender, EventArgs e)
        {
            // Changes the theme
            if (LightTheme.lightTheme == true)
            {
                LightTheme.lightTheme = false;
            }
            else
            {
                LightTheme.lightTheme = true;
            }

            // Applies changes
            Application.Restart();
        }

        private void settings_MouseEnter(object sender, EventArgs e)
        {
            // Shows a tooltip when hovering over the button
            if (LightTheme.lightTheme == true)
            {
                themeTip.SetToolTip(theme, "Click to switch to dark theme");
            }
            else 
            {
                themeTip.SetToolTip(theme, "Click to switch to light theme"); 
            }
            
        }
    }
}
