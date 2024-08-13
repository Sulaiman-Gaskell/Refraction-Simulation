using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Physics_Simulation.welcomeScreen;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace Physics_Simulation
{
    public partial class rInteract : Form
    {
        public rInteract()
        {
            InitializeComponent();
            //Maximises the form and stops the user
            //from resizing it
            this.WindowState = FormWindowState.Maximized;

            // Disables annoying windows sounds
            this.AcceptButton = null;
            
          
            



        }

        private void rInteract_Load(object sender, EventArgs e)
        {

            // Changes colours based on the them selected
            if (systemWideVariables.lightTheme == true)
            {
                this.BackColor = Color.White;
                refractiveIndex1.BackColor = Color.Black;
                refractiveIndex1.ForeColor = Color.White;
                refractiveIndex2.BackColor = Color.Black;
                refractiveIndex2.ForeColor = Color.White;
                angleOfIncidence.BackColor = Color.Black;
                angleOfIncidence.ForeColor = Color.White;
                aoR.ForeColor = Color.Black;
                aOIText.ForeColor = Color.Black;
                rI1Text.ForeColor = Color.Black;
                rI2Text.ForeColor = Color.Black;
                bArrow.BackgroundImage = Properties.Resources.lightBackArrow;
                bArrow.BackColor = Color.White;
                glossary.LinkColor = Color.Black;

            }

            // Sets up the glossary loaction
            glossary.Font = new Font(
                glossary.Font.FontFamily, ClientSize.Width / 80);

            glossary.Location = new Point(Left, 
                Convert.ToInt32(ClientSize.Height / 1.75));

            glossary.Padding = new System.Windows.Forms.Padding(
                ClientSize.Width / 40, 0, 0, 0);


            // Sets the form text as the version num defined by the class
            // TitleVersion
            this.Text = systemWideVariables.titleVersion;

            // for fade in effect
            // Set the form's initial opacity to 0 (completely transparent)
            this.Opacity = 0;

            // Start the fade to animate the form
            fadeIn.Enabled = true;

           


            // Adds some margin gaps between controls to look better
            aOIText.Margin = new System.Windows.Forms.Padding(
                ClientSize.Width / 150, 0, 0, 0);

            angleOfIncidence.Margin = new System.Windows.Forms.Padding(
                ClientSize.Width / 150, ClientSize.Height / 50, 0, 0);

            rI1Text.Margin = new System.Windows.Forms.Padding(
                ClientSize.Width / 150, ClientSize.Height / 50, 0, 0);

            rI2Text.Margin = new System.Windows.Forms.Padding(
                 ClientSize.Width / 150, ClientSize.Height / 50, 0, 0);

            refractiveIndex1.Margin = new System.Windows.Forms.Padding(
                ClientSize.Width / 150, ClientSize.Height / 50, 0, 0);

            refractiveIndex2.Margin = new System.Windows.Forms.Padding(
                ClientSize.Width / 150, ClientSize.Height / 50,
                0, ClientSize.Height / 100);




            // For sizing objects based on clients resoloution
            aOIText.Font = new Font(aOIText.Font.FontFamily,
            ClientSize.Width / 80);

            aoR.Font = new Font(aoR.Font.FontFamily,
                ClientSize.Width / 80);

            angleOfIncidence.Font = new Font(angleOfIncidence.Font.
                FontFamily, ClientSize.Width / 80);
            
            // Sets the same size for matching objects
            angleOfIncidence.Size = aOIText.Size;

            rI1Text.Font = new Font(rI1Text.Font.FontFamily,
                ClientSize.Width / 80);

            rI2Text.Font = new Font(aOIText.Font.FontFamily,
                ClientSize.Width / 80);

            refractiveIndex1.Font = new Font(refractiveIndex1.Font.
                FontFamily, ClientSize.Width / 80);

            refractiveIndex2.Font = new Font(angleOfIncidence.Font.
                FontFamily, ClientSize.Width / 80);


            // Keeps sizing consistent
            refractiveIndex1.Size = aOIText.Size;
            refractiveIndex2.Size = aOIText.Size;

           
           

            // Calls the text_changed  method when text changes
            angleOfIncidence.TextChanged += angleOfIncidence_TextChanged;

            // Puts the back arrow in the top left hand corner
            bArrow.Size = new Size(ClientSize.Height / 10, ClientSize.Height / 10);


          
        }


        private void bArrow_Click_1(object sender, EventArgs e)
        {
            fadeOut.Enabled = true;
          

        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Calls the initDraw method to draw some lines
            initDraw();


        }

        // For drawing the static lines
        private void initDraw()
        {

            // Changes line col based on the theme
            Color lineCol = Color.White;

            if (systemWideVariables.lightTheme == true)
            {
                this.BackColor = Color.White;
                lineCol = Color.Black;
            }


            // Creates a white pen
            Pen pen = new Pen(lineCol, 3);

       
            // Creates a new graphic object
            Graphics g = tableLayoutPanel1.CreateGraphics();


            // Draws a vertical line
            g.DrawLine(pen,this.Width / 100 * 70, 0,
                this.Width / 100 * 70, this.Height);


            // Draws a dotted horizontal line for the normal
            pen.DashStyle = DashStyle.Dot;

            g.DrawLine(pen, this.Width / 100 * 50, this.Height / 100 * 50,
                this.Width / 100 * 90, this.Height / 100 * 50);
        }

        private void fade_Tick(object sender, EventArgs e)
        {
            
            // Fades in the form
            if (this.Opacity < 1)
            {
                this.Opacity += 0.1;
            }
                
            // When fully solid stop the timer
            else
            {
                // Draws the inital diagram
                // Called twice to fix wierd bug
                DrawRays();
                DrawRays();
                fadeIn.Enabled = false;
            }
        }


        // For the fade out animation  (now obselete)
        private void fadeOut_Tick(object sender, EventArgs e)
        {
        }

        private void aOIText_Click(object sender, EventArgs e)
        {
        }

        private void angleOfIncidence_TextChanged(object sender, EventArgs e)
        {
            // Calls the DrawRays method whenever text is changed in the textbox
            DrawRays();
        }

    

        private void DrawRays()
        {
            // Creates a pen object to draw the incident ray
            Pen aOIPen = new Pen(Color.Blue,6);
    

            // Creates another pen but for the refracted ray
            Pen aORPen = new Pen(Color.OrangeRed, 6);

            // Creates another pen but for the reflected ray
            Pen aORePen = new Pen(Color.Blue, 6);

            // Creates a graphic 'canvas' to draw on the tableLayoutPanel
            Graphics rays = tableLayoutPanel1.CreateGraphics();

            // Increases the quality of the line 
            rays.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            rays.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            

            // Used as an arrow cap
            AdjustableArrowCap bigArrow = new AdjustableArrowCap
                (ClientSize.Height / 100, 
                ClientSize.Width / 200);

            // Refreshes the tableLayout panel to redraw everthing
            tableLayoutPanel1.Refresh();

            // Validation
            if (double.TryParse(angleOfIncidence.Text, out double _)
                && double.TryParse(refractiveIndex1.Text, out double _)
                && double.TryParse(refractiveIndex2.Text, out double _)
                && Convert.ToDouble(angleOfIncidence.Text) <= 90 
                && Convert.ToDouble(angleOfIncidence.Text) >= 0
                && Convert.ToDouble(refractiveIndex1.Text) >= 1
                && Convert.ToDouble(refractiveIndex1.Text) <= 2
                && Convert.ToDouble(refractiveIndex2.Text) >= 1
                && Convert.ToDouble(refractiveIndex2.Text) <= 2
                )
            {
                // Converts aOI text from string to integer for x coord use
                double angleI = (System.Convert.ToDouble(angleOfIncidence.Text))
                    * Math.PI / 180;
                
                
                // Sets the x and y coords of the start and end of the aOI and 
                // based on the angle inputted
     
                double length = this.Width / 3;
                double x1 = this.Width / 100 * 70;
                double y1 = this.Height / 100 * 50;
                double x2I = x1 - Math.Cos(angleI) * length;
                double y2I = y1 - Math.Sin(angleI) * length;

                // For the reflected line
                double x2Re = x1 + Math.Cos(Math.PI - angleI) * length;
                double y2Re = y1 + Math.Sin(Math.PI - angleI) * length;


                // Calculates the angle of refracion
                double angleR;
                if (angleI != Math.PI / 2)
                {
                    angleR = Math.Asin(Math.Sin(angleI) * 
                        Convert.ToDouble(refractiveIndex1.Text) / 
                        Convert.ToDouble(refractiveIndex2.Text));
                }
                else { angleR = Math.PI / 2; }

                double angleRDegrees = Math.Round(angleR * 180 / Math.PI,2);
                if (double.IsNaN(angleRDegrees))
                {
                    aoR.Text = "Total internal reflection has occured";

                    // Draws the end point for the reflected ray
                    rays.DrawLine(aORePen, (float)x1, (float)y1, (float)x2Re, (float)y2Re);

                    // To get an arrow in the middle of the line draw another line ending in the middle

                    double arrowXRe = (x1 + x2Re) / 2;
                    double arrowYRe = (y1 + y2Re) / 2;
                    aORePen.CustomEndCap = bigArrow;
                    rays.DrawLine(aORePen, (float)x1, (float)y1, (float)arrowXRe, (float)arrowYRe);

                }
                else
                {
                    aoR.Text = angleRDegrees.ToString() + "°";

                    // Draws a  dotted horizontal line for the normal if angle != 0 or 90
                    if (Convert.ToDouble(angleOfIncidence.Text) != 0
                        && Convert.ToDouble(angleOfIncidence.Text) != 90)
                    {
                        // Sets the attriubtes of the pen and draws the ray
                        aORePen.DashStyle = DashStyle.Dot;
                        aORePen.Width = 4;
                        rays.DrawLine(aORePen, (float)x1, (float)y1, (float)x2Re, (float)y2Re);
                    }
                }


                // Calculates the end point for the aoR
                double x2R = x1 + Math.Cos(angleR) * length;
                double y2R = y1 + Math.Sin(angleR) * length;

               
                // Draws a line using the AOIPen at the specified loactions
                rays.DrawLine(aOIPen, (float)x1, (float)y1,(float)x2I,(float)y2I);

                // To get an arrow in the middle of the line draw another line ending in the middle

                double arrowXI = (x1 + x2I) / 2;
                double arrowYI = (y1 + y2I) / 2;
                aOIPen.CustomEndCap = bigArrow;
                rays.DrawLine(aOIPen, (float)x2I, (float)y2I, (float)arrowXI, (float)arrowYI);


                // Draws the aOR ray
                rays.DrawLine(aORPen, (float)x1, (float)y1, (float)x2R,(float)y2R);

                // To get an arrow in the middle of the line draw another line ending in the middle

                double arrowXR = (x1 + x2R) / 2;
                double arrowYR = (y1 + y2R) / 2;
                aORPen.CustomEndCap = bigArrow;
                rays.DrawLine(aORPen, (float)x1, (float)y1, (float)arrowXR, (float)arrowYR);


            }

            else
            {
                aoR.Text = "Angle of Refraction";
                initDraw();
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // Refractive index 2
        private void refractiveIndex1_TextChanged(object sender, EventArgs e)
        {
            // Calls the DrawRays method whenever text is changed in the textbox
            // Twice for odd bug to be fixed
            DrawRays();
            DrawRays();
        }

        private void rI1Text_Click(object sender, EventArgs e)
        {
            
        }

        private void aoR_Click(object sender, EventArgs e)
        {
          
        }

        private void refractiveIndex1_TextChanged_1(object sender, EventArgs e)
        {
            bArrow.Location = new Point(0, 0);
            // Calls the DrawRays method whenever text is changed in the textbox
            // Twice for odd bug to be fixed
            DrawRays();
            DrawRays();
        }

        // For the fade out animation
        private void fadeOut_Tick_1(object sender, EventArgs e)
        {
            if (this.Opacity > 0 )
            {
                this.Opacity -= 0.1;
            }
            else
            {
                // When the opacity is 0, close the form
                this.Close();
               
            }
        }

        private void torch_Click(object sender, EventArgs e)
        {
        }

        // For changing each individual cell
        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            // If it is [0,1] then the bg of it will change to grey
            if (e.Column == 1 && e.Row == 1) 
            {
                if (systemWideVariables.lightTheme == true)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.Black), e.CellBounds);
                }
                else { e.Graphics.FillRectangle(new SolidBrush(Color.White), e.CellBounds);}
                
            }
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void angleOfIncidence_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Stops the user from entering any values other than 0-9, backspace and full stop 
            if ((e.KeyChar > (char)Keys.D9 || 
                 e.KeyChar < (char)Keys.D0) && 
                 e.KeyChar != (char)Keys.Back &&
                 e.KeyChar != '.')
            {
                 e.Handled = true;
            }
        }

        private void refractiveIndex1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Stops the user from entering any values other than 0-9, backspace and full stop 
            if ((e.KeyChar > (char)Keys.D9 ||
                 e.KeyChar < (char)Keys.D0) &&
                 e.KeyChar != (char)Keys.Back &&
                 e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void refractiveIndex2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Stops the user from entering any values other than 0-9, backspace and full stop 
            if ((e.KeyChar > (char)Keys.D9 ||
                 e.KeyChar < (char)Keys.D0) &&
                 e.KeyChar != (char)Keys.Back &&
                 e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void bArrow_MouseDown(object sender, MouseEventArgs e)
        {
            bArrow.Size = new Size(ClientSize.Height / 13, ClientSize.Height / 13);
            try
            {
                DrawRays();
            }
            catch 
            {
                initDraw();
            }

        }


        private void bArrow_MouseLeave(object sender, EventArgs e)
        {
            // Returns bArrow size back to normal
            bArrow.BackgroundImageLayout = ImageLayout.Zoom;
            bArrow.Size = new Size(ClientSize.Height / 10, ClientSize.Height / 10);

            // Stops the diagram from dissapering 
            try
            {
                DrawRays();
            }
            catch
            {
                initDraw();
            }
        }

        private void bArrow_MouseEnter(object sender, EventArgs e)
        {
            // Slighly increases the size of the bArrow
            bArrow.BackgroundImageLayout = ImageLayout.Stretch;


        }

        private void glossary_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Opens a link to a useful info page
            System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/List_of_refractive_indices");
            // redraws the diagram accordingly.
            try
            {
                DrawRays();
            }
            catch
            {
                initDraw();
            }

        }
    }
}
