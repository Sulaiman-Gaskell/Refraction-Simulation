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
    public partial class Waves : Form
    {
        public Waves()
        {
            InitializeComponent();
        }

        private void Waves_Load(object sender, EventArgs e)
        {
            // Maximises the form
            this.WindowState = FormWindowState.Maximized;

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

        private void bArrow_Click(object sender, EventArgs e)
        {
            // Calls the fadeOut timer
            fadeOut.Enabled = true;


            
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
    }
}
