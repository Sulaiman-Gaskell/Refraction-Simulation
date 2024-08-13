using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Physics_Simulation.welcomeScreen;

namespace Physics_Simulation
{
    public partial class optionsMenu : Form
    {
        public optionsMenu()
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
            // For light theme
            if (systemWideVariables.lightTheme == true)
            {
                this.BackColor = Color.White;
                interact.BackColor = Color.Black;
                interact.ForeColor = Color.White;
                questions.BackColor = Color.Black;
                questions.ForeColor = Color.White;
                menuText.ForeColor = Color.Black;
                bArrow.BackgroundImage = Properties.Resources.lightBackArrow;
                bArrow.BackColor = Color.White;
                
            }
            // Sets the form text as the version num defined by the class
            // TitleVersion
            this.Text = systemWideVariables.titleVersion;
            // Removes the x
            //this.ControlBox = false;
         
       
 

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


  

            animateObjects.Enabled = true;
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

            // Opens the right widnow and keeps this open
            // Without being seen in the taskbar

            if (systemWideVariables.whichSim == "refraction")
            {
                rInteract rInteract = new rInteract();
                rInteract.ShowDialog();

            }
            else
            {
                interact.Text = "Coming soon!";
            }
            
           
            if (systemWideVariables.lightTheme == true)
            {
                menuText.ForeColor = Color.Black;
            }
            else { menuText.ForeColor = Color.White; }
        }

        private void menuText_Click(object sender, EventArgs e)
        {
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

        
        // For menuText animation and fontsize initally growing
        private int tickCount = 0;
        private void menuTextGrow_Tick(object sender, EventArgs e)
        {
            string label = "Choose a mode:";
        
            if (tickCount <= label.Length)
            {
                menuText.Text = label.Substring(0,tickCount);

                interact.Font = new Font(interact.Font.FontFamily,
                ClientSize.Width / (tickCount + 16));
                questions.Font = new Font(questions.Font.FontFamily,
                ClientSize.Width / (tickCount + 16));

                tickCount++;
            }
            else
            {
                interact.Enabled = true;
                questions.Enabled = true;
                animateObjects.Enabled = false;
            }



        }

        // ALL BELOW FOR ANIMATIONS
        private void interact_MouseDown(object sender, MouseEventArgs e)
        {
            menuText.ForeColor = Color.LightSkyBlue;


            interact.Font = new Font(interact.Font.FontFamily,
                ClientSize.Width / 35);
        }

        private void interact_MouseLeave(object sender, EventArgs e)
        {
            if (systemWideVariables.lightTheme == true)
            {
                menuText.ForeColor = Color.Black;
                interact.BackColor = Color.Black;
            }
            else
            {
                menuText.ForeColor = Color.White;
                interact.BackColor = Color.White;
            }


            popInInteract.Enabled = true;
        }

        private void questions_MouseDown(object sender, MouseEventArgs e)
        {
            questions.Font = new Font(questions.Font.FontFamily,
                 ClientSize.Width / 35);

            menuText.ForeColor = Color.Coral;

        }

        private void questions_MouseLeave(object sender, EventArgs e)
        {
            if (systemWideVariables.lightTheme == true)
            {
                menuText.ForeColor = Color.Black;
                questions.BackColor = Color.Black;
            }
            else
            {
                menuText.ForeColor = Color.White;
                questions.BackColor = Color.White;
            }

            popInQuestions.Enabled = true;
        }

        // Useless
        private void interact_MouseHover(object sender, EventArgs e)
        {
        }

        // Useless
        private void questions_MouseHover(object sender, EventArgs e)
        {
        }



        private void interact_MouseEnter(object sender, EventArgs e)
        {
            interact.BackColor = Color.LightSkyBlue;
            popOutInteract.Enabled = true;
        }

        private void questions_MouseEnter(object sender, EventArgs e)
        {
            questions.BackColor = Color.Coral;
            popOutQuestions.Enabled = true;
        }




        // Animates the interact text
        // Slowely increases the font size
        private int popOutSize = 29;
        private void popOutInteract_Tick(object sender, EventArgs e)
        {
            if (popOutSize >= 25)
            {
                interact.Font = new Font(interact.Font.FontFamily,
                ClientSize.Width / popOutSize);
                popOutSize--;
                
            }
            else
            {
                popOutSize = 29;
                popOutInteract.Enabled = false;
            }
        
        }

        // Slowely decreases the font size when the mouse leaves the interact box
        private int popInSize = 25;
        private void popInInteract_Tick(object sender, EventArgs e)
        {
            if (popInSize <= 30)
            {
                interact.Font = new Font(interact.Font.FontFamily,
                ClientSize.Width / popInSize);
                popInSize++;

            }
            else
            {
                popInSize = 25;
                popInInteract.Enabled = false;
            }

        }

        // Slowely increases the font size of the questions mode when hovering over it
        // TEMP: CHANGES IT TO COMING SOON
        private void popOutQuestions_Tick(object sender, EventArgs e)
        {
            if (popOutSize >= 25)
            {
                questions.Text = "Coming Soon!";
                questions.Font = new Font(questions.Font.FontFamily,
                ClientSize.Width / popOutSize);
                popOutSize--;

            }
            else
            {
                popOutSize = 29;
                popOutQuestions.Enabled = false;
            }
        }

        // Slowely decreases the font size and changes the text back to questions
        private void popInQuestions_Tick(object sender, EventArgs e)
        {
            if (popInSize <= 30)
            {
                questions.Text = "Questions";
                questions.Font = new Font(questions.Font.FontFamily,
                ClientSize.Width / popInSize);
                popInSize++;

            }
            else
            {
                popInSize = 25;
                popInQuestions.Enabled = false;
            }
        }

        private void refractionMenu_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            // Not using as of now
            if ((e.Row == 2 | e.Row == 1) && e.Column == 1)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.Black), e.CellBounds);
            }
        }

        private void bArrow_Click_1(object sender, EventArgs e)
        {
            // Calls the fadeOut timer
            fadeOut.Enabled = true;

        }

        private void bArrow_MouseDown(object sender, MouseEventArgs e)
        {
            bArrow.Size = new Size(ClientSize.Height / 13, ClientSize.Height / 13);
        }

        private void bArrow_MouseLeave(object sender, EventArgs e)
        {
            // Returns bArrow size back to normal
            bArrow.BackgroundImageLayout = ImageLayout.Zoom;
            bArrow.Size = new Size(ClientSize.Height / 10, ClientSize.Height / 10);
        }

        private void bArrow_MouseEnter(object sender, EventArgs e)
        {
            // Slighly increases the size of the bArrow
            bArrow.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }


}
