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
    public partial class qMenu : Form
    {
        public qMenu()
        {
            InitializeComponent();


            //Maximises the form and stops the user
            //from resizing it
            this.WindowState = FormWindowState.Maximized;

            // Disables annoying windows sounds
            this.AcceptButton = null;

            // sets the inital opacity of the form to 0
            this.Opacity = 0;

            // Starts the fadeIn timer
            fadeIn.Enabled = true;

        }

        private void qMenu_Load(object sender, EventArgs e)
        {

            this.Text = systemWideVariables.titleVersion;
            bArrow.Location = new Point(0,0);

            // Sizes the back arrow
            bArrow.Size = new Size(ClientSize.Height / 10, ClientSize.Height / 10);


            // For light mode
            if (systemWideVariables.lightTheme == true)
            {
                this.BackColor = Color.White;
                bArrow.BackgroundImage = Properties.Resources.lightBackArrow;
                bArrow.BackColor = Color.White;
                qPlay.BackColor = Color.Black;
                qPlay.ForeColor = Color.White;
                pQuestions.BackColor = Color.Black;
                pQuestions.ForeColor = Color.White;
                menuText.ForeColor = Color.Black;

            }


            // Sizes the button texts
            qPlay.Font = new Font(qPlay.Font.FontFamily,
            ClientSize.Width / 30);

            pQuestions.Font = new Font(pQuestions.Font.FontFamily,
            ClientSize.Width / 30);

            // Sets font size for text based on clients resolution
            menuText.Font = new Font(menuText.Font.FontFamily,
                ClientSize.Width / 30);


            animateObjects.Enabled = true;
        }

        private void bArrow_Click(object sender, EventArgs e)
        {
            // Starts the fadeOut timer
            fadeOut.Enabled = true;
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
                // Stops timer
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
                // When the opacity is 0, close the form
                this.Close();

            }
        }

        private void bArrow_MouseEnter(object sender, EventArgs e)
        {
            // Slighly increases the size of the bArrow
            bArrow.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void bArrow_MouseLeave(object sender, EventArgs e)
        {
            // Returns bArrow size back to normal
            bArrow.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void refractionMenu_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            // WIll remove later after written up
            //if ((e.Row == 2 | e.Row == 1) && e.Column == 1)
            //{
             //   if (systemWideVariables.lightTheme == true) 
               // {
                //    e.Graphics.FillRectangle(new SolidBrush(Color.Black), e.CellBounds);
              //  }
              //  else
              //  {
               //     e.Graphics.FillRectangle(new SolidBrush(Color.White), e.CellBounds);
               // }
                
            //}
        }

        private void refractionMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        // For fontsize initally of the buttons
        private int tickCount = 5;
        private void animateObjects_Tick(object sender, EventArgs e)
        {

        string label = "Choose a mode";

        if (tickCount <= label.Length)
            {

                qPlay.Font = new Font(qPlay.Font.FontFamily,
                ClientSize.Width / (tickCount + 16));
                pQuestions.Font = new Font(pQuestions.Font.FontFamily,
                ClientSize.Width / (tickCount + 16));

                tickCount++;
            }
            else
            {
                qPlay.Enabled = true;
                pQuestions.Enabled = true;
                animateObjects.Enabled = false;
            }
        }

        // Animates the interact text
        // Slowely increases the font size
        private int popOutSize = 29;

        private void popOutQPlay_Tick(object sender, EventArgs e)
        {
            if (popOutSize >= 25)
            {
                qPlay.Font = new Font(qPlay.Font.FontFamily,
                ClientSize.Width / popOutSize);
                popOutSize--;

            }
            else
            {
                popOutSize = 29;
                popOutQPlay.Enabled = false;
            }
        }

        private void qPlay_MouseEnter(object sender, EventArgs e)
        {
            qPlay.BackColor = Color.LightSkyBlue;
            // Starts the pop out timer
            popOutQPlay.Enabled = true;
        }


        private int popInSize = 25;
        private void popInQPlay_Tick(object sender, EventArgs e)
        {
            if (popInSize <= 30)
            {
                qPlay.Font = new Font(qPlay.Font.FontFamily,
                ClientSize.Width / popInSize);
                popInSize++;

            }
            else
            {
                popInSize = 25;
                // Disables the timer
                popInQPlay.Enabled = false;

            }
        }

        private void qPlay_MouseLeave(object sender, EventArgs e)
        {
            // Changes the colours the right one
            if (systemWideVariables.lightTheme == true)
            {
                qPlay.BackColor = Color.Black;
                menuText.ForeColor = Color.Black;
            }
            else
            {
                qPlay.BackColor = Color.White;
                menuText.ForeColor = Color.White;
            }
            
            // Makes the text grow smaller
            popInQPlay.Enabled = true;
        }

        private void qPlay_Click(object sender, EventArgs e)
        {

        }

        private void qPlay_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void qPlay_MouseDown(object sender, MouseEventArgs e)
        {
            menuText.ForeColor = Color.LightSkyBlue;
        }

        private void pQuestions_MouseEnter(object sender, EventArgs e)
        {
            pQuestions.BackColor = Color.Coral;
            popOutPQuestions.Enabled = true;
            
        }



        private void pQuestions_MouseLeave(object sender, EventArgs e)
        {

            popInPQuestions.Enabled = true;

            // Changes the colours the right one
            if (systemWideVariables.lightTheme == true)
            {
                pQuestions.BackColor = Color.Black;
                menuText.ForeColor = Color.Black;
            }
            else
            {
                pQuestions.BackColor = Color.White;
                menuText.ForeColor = Color.White;
            }
        }

        private void popOutPQuestions_Tick(object sender, EventArgs e)
        {
            if (popOutSize >= 25)
            {
                pQuestions.Font = new Font(pQuestions.Font.FontFamily,
                ClientSize.Width / popOutSize);
                popOutSize--;

            }
            else
            {
                popOutSize = 29;
                popOutPQuestions.Enabled = false;
            }
        }

        private void popInPQuestions_Tick(object sender, EventArgs e)
        {
            if (popInSize <= 30)
            {
                pQuestions.Font = new Font(pQuestions.Font.FontFamily,
                ClientSize.Width / popInSize);
                popInSize++;

            }
            else
            {
                popInSize = 25;
                // Disables the timer
                popInPQuestions.Enabled = false;

            }
        }
    }
    
}
