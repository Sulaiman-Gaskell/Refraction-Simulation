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

            // Prevents the user from resizing the window
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

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
            this.Hide();
            // when the 'Interactive' button is pressed then
            // the rInteract screen opens up
            rInteract rInteract = new rInteract();
            rInteract.ShowDialog();
            this.Show();


        }

        private void menuText_Click(object sender, EventArgs e)
        {
        }

        private void bArrow_Click(object sender, EventArgs e)
        {
            //closes the current form
            this.Close();
        }
    }


}
