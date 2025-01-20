using Physics_Simulation.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
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
        public class systemWideVariables
        {
            public static string titleVersion = "V2.3.1";
            public static bool lightTheme = Settings.Default.lightTheme;
            public static string whichSim = "";
            public static bool isRandom = true;
        }

        private int initY;
        private void getInitY()
        {
            initY = this.DesktopLocation.Y;
        }
            
        private void leavingAnimation()
        {
            getInitY();
            int x = this.DesktopLocation.X;
            int y = this.DesktopLocation.Y;
            int count = 2;
            int flag = 0;
            while (y < (this.Height * 3))
            {

                this.Location = new Point(x, y);
                y = y + count;
                Thread.Sleep(1);
                if (flag == 1)
                {
                    count++;
                    flag = 0;
                }
                flag++;
            }
            this.Hide();

        }



        private void showingAnimation()
        {
            this.Show();
            int x = this.DesktopLocation.X;
            int y = this.DesktopLocation.Y;
            int count = 50;
            int flag = 0;
            while (y >= (initY))
            {
                Thread.Sleep(1);
                this.Location = new Point(x, y);
                y = y - count;
                if (flag == 1)
                {
                    count--;
                    flag = 0;
                }
                flag++;
            }
            

        }

         
        private void button1_Click(object sender, EventArgs e) // Refraction
        {
            refraction.BackColor = Color.White;

            // Sets the var to tell the program which forms need to be loaded
            systemWideVariables.whichSim = "refraction";


      
            leavingAnimation();

            // Creates an instance of the refraction form when
            // the button is pressed
            optionsMenu options = new optionsMenu();
            options.ShowDialog();
            showingAnimation();
            
            
        }
            
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void updateTheme()
        {

         
            // Sets colours acorrdingly
            if (systemWideVariables.lightTheme == true)
            {
                this.BackColor = Color.White;
                refraction.BackColor = Color.Black;
                refraction.ForeColor = Color.White;
                waves.BackColor = Color.Black;
                waves.ForeColor = Color.White;
                wTxt.BackColor = Color.White;
                wTxt.ForeColor = Color.Black;
                theme.Image = Properties.Resources.sun;
                theme.BackColor = Color.Transparent;
                theme.ForeColor = Color.Transparent;
            }
            else
            {
                this.BackColor = Color.Black;
                refraction.BackColor = Color.White;
                refraction.ForeColor = Color.Black;
                waves.BackColor = Color.White;
                waves.ForeColor = Color.Black;
                wTxt.BackColor = Color.Black;
                wTxt.ForeColor = Color.White;
                theme.Image = Properties.Resources.moon;
                theme.BackColor = Color.Black;
                theme.ForeColor = Color.Black; 
            }
        }

    private void welcomeScreen_Load(object sender, EventArgs e)
        {
           


            // Sets the form text as the version num defined by the class attribute
            // TitleVersion
            this.Text = systemWideVariables.titleVersion;

            // Sets the right theme
            updateTheme();

            // Triggers the fade in animation
            fadeIn.Enabled = true;

            // Chnages font to a nicer one for both buttons
            wTxt.Font = new Font ("Microsoft Sans Serif", 21);
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
            // Sets the var to tell the program which forms need to be loaded
            systemWideVariables.whichSim = "waves";

            // Creates an instance of optionMenu form when
            // the button is pressed
            leavingAnimation();
            optionsMenu options = new optionsMenu();
     
            options.ShowDialog();

            // When the optionMenu instance is closed by the user
            // the Welcome menu will open again
            showingAnimation();
            this.Location = new Point(this.Width, this.Height / 100 * 50);

        }

        private void refraction_MouseEnter(object sender, EventArgs e)
        {
            refraction.BackColor = Color.LightSkyBlue;
        }

        private void refraction_MouseLeave(object sender, EventArgs e)
        {
            if (systemWideVariables.lightTheme == true)
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
            waves.BackColor = Color.Coral;
        }

        private void waves_MouseLeave(object sender, EventArgs e)
        {
            if (systemWideVariables.lightTheme == true)
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
            wTxt.ForeColor = Color.LightSkyBlue;
        }

        private void waves_MouseDown(object sender, MouseEventArgs e)
        {
            wTxt.ForeColor = Color.Coral;
        }

        private void welcomeScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Not used anymore
            Settings.Default.lightTheme = systemWideVariables.lightTheme;
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
                wTxt.Text = "Physics Simulations!!";
            }
            else
            {
                wTxt.Text = defaultText;
            }
        }

        private void settings_Click(object sender, EventArgs e)
        {
            // Changes the theme
            if (systemWideVariables.lightTheme == true)
            {
                systemWideVariables.lightTheme = false;
            }
            else
            {
                systemWideVariables.lightTheme = true;
            }

            // Applies changes
            updateTheme();
            
            
        }

        private void settings_MouseEnter(object sender, EventArgs e)
        {
            // Shows a tooltip when hovering over the button
            if (systemWideVariables.lightTheme == true)
            {
                themeTip.SetToolTip(theme, "Click to switch to dark theme");
            }
            else 
            {
                themeTip.SetToolTip(theme, "Click to switch to light theme"); 
            }
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void theme_MouseDown(object sender, MouseEventArgs e)
        {

         
        }

        private void theme_MouseUp(object sender, MouseEventArgs e)
        {
        
        }

        private void cMove_Tick(object sender, EventArgs e)
        {
          
        }
    }
}
