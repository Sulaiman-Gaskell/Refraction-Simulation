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

            //
            flowLayoutPanel1.SetFlowBreak(angleOfIncidence, true);


            // Adds some margin gaps between controls to look better
            aOIText.Margin = new System.Windows.Forms.Padding(
                ClientSize.Width / 150, 0, 0, 0);

            angleOfIncidence.Margin = new System.Windows.Forms.Padding(
                ClientSize.Width / 150, ClientSize.Height / 50, 0, 0);

            rI1Text.Margin = new System.Windows.Forms.Padding(
                 ClientSize.Width / 50, 0, 0, 0);

            refractiveIndex1.Margin = new System.Windows.Forms.Padding(
                ClientSize.Width / 50, ClientSize.Height / 50, 0, 0);



            // For sizing objects based on clients resoloution
            aOIText.Font = new Font(aOIText.Font.FontFamily,
            ClientSize.Width / 80);

            angleOfIncidence.Font = new Font(angleOfIncidence.Font.
                FontFamily, ClientSize.Width / 80);
            
            angleOfIncidence.Size = aOIText.Size;

            rI1Text.Font = new Font(aOIText.Font.FontFamily,
                ClientSize.Width / 80);

            refractiveIndex1.Font = new Font(angleOfIncidence.Font.
                FontFamily, ClientSize.Width / 80);
            
            refractiveIndex1.Size = rI1Text.Size;


        }


  



        private void bArrow_Click_1(object sender, EventArgs e)
        {
            // triggers the fade out timer
            fadeOut.Enabled = true;

        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Creates a white pen
            Pen pen = new Pen(Color.White,5); 
            e.Graphics.DrawLine(pen, 20, 10, this.Width / 100 * 61,
                this.Height / 100 * 64);

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

        private void aOIText_Click(object sender, EventArgs e)
        {
        }

        private void angleOfIncidence_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void refractiveIndex1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rI1Text_Click(object sender, EventArgs e)
        {

        }
    }
}
