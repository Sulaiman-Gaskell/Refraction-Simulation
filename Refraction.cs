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
       

            // Triggers Refracion_Resize when a resize event happens
            this.Resize += Refraction_Resize;

            // Disables annoying windows sounds
            this.AcceptButton = null;


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

            // Puts the back arrow in the top left hand corner
            bArrow.Location = new Point(0, 0);

            // Sets font size for text based on clients resolution
            menuText.Font = new Font(menuText.Font.FontFamily,
                ClientSize.Width / 30);



            interact.Font = new Font(interact.Font.FontFamily,
                ClientSize.Width / 30);
            questions.Font = new Font(questions.Font.FontFamily,
                ClientSize.Width / 30);

            // Sizes the back arrow
            bArrow.Size = new Size(ClientSize.Height / 10, ClientSize.Height / 10);
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
            rInteract.ShowDialog();
           
    

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

        private void menuText_Click_1(object sender, EventArgs e)
        {

        }
    }


}
