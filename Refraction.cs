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
    public partial class Refraction : Form
    {
        public Refraction()
        {
            InitializeComponent();

            // Maximises the window and removes the top bar
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;

            // Triggers Refracion_Resize when a resize event happens
            this.Resize += Refraction_Resize;

            // Sets font size for text based on clients resolution
            menuText.Font = new Font(menuText.Font.FontFamily,
                ClientSize.Width / 10);
            


            interact.Font = new Font(interact.Font.FontFamily, 
                ClientSize.Width / 15);
            questions.Font = new Font(questions.Font.FontFamily,
                ClientSize.Width / 15);
                

        }

        private void Refraction_Load(object sender, EventArgs e)
        {
            // Makes the form full screen
            this.WindowState = FormWindowState.Maximized;

            // for fade in effect
            // Set the form's initial opacity to 0 (completely transparent)
            this.Opacity = 0;

            // Start the fade to animate the form
            fadeIn.Enabled = true;
        }


        private void Refraction_Resize(object sender, EventArgs e)
        {
            // Calls the folliwng methods to:
            // Recenter the layout when full screened
            
            refractionMenu.Dock = DockStyle.Fill;
          

        }

        private void refractionMenu_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Opens the refraction widnow and keeps this open
            // Without being seen in the taskbar
            
            rInteract rInteract = new rInteract();
            rInteract.Show();

        }

        private void menuText_Click(object sender, EventArgs e)
        {
        }

        private void bArrow_Click(object sender, EventArgs e)
        {
            // Calls the fadeOut timer
            fadeOut.Enabled = true; 
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

        private void fadeOut_Tick(object sender, EventArgs e)
        {

        }

        private void fadeOut_Tick_1(object sender, EventArgs e)
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
