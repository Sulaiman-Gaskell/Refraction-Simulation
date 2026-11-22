using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
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

            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);






        }

        private void rInteract_Load(object sender, EventArgs e)
        {
          

            // Sets the active colour of the link label to pink for dark mode
            glossary.ActiveLinkColor = Color.Pink;

      

     

            // Sets the form text as the version num defined by the class
            // TitleVersion
            this.Text = systemWideVariables.titleVersion;

            // for fade in effect
            // Set the form's initial opacity to 0 (completely transparent)
            this.Opacity = 0;

            // Start the fade to animate the form
            fadeIn.Enabled = true;



            if (systemWideVariables.powerSave == false)
            { 
                // Animates the lines as the program is first opened and with power save disabled
                linesAnimate.Enabled = true;
            }
            else
            {
                // else draw the base lines normally
                // doesnt work so tried in tableLayoutPanel_Load
                initDraw();
                
            }

            
           
            

        }

        private void configControls()
        {
            // Sets up the glossary loaction
            glossary.Font = new Font(
                glossary.Font.FontFamily, this.Width / 80);


            glossary.Location = new Point(0,
                Convert.ToInt32(this.Height / 1.85));

            glossary.Padding = new System.Windows.Forms.Padding(
                 0,0, 0,0);

            // Adds some margin gaps between controls to look better
            aOIText.Margin = new System.Windows.Forms.Padding(
                this.Width / 150, 0, 0, 0);

            angleOfIncidence.Margin = new System.Windows.Forms.Padding(
                this.Width / 150, this.Height / 50, 0, 0);

            rI1Text.Margin = new System.Windows.Forms.Padding(
                this.Width / 150, this.Height / 50, 0, 0);

            rI2Text.Margin = new System.Windows.Forms.Padding(
                 this.Width / 150, this.Height / 50, 0, 0);

            refractiveIndex1.Margin = new System.Windows.Forms.Padding(
                this.Width / 150, this.Height / 50, 0, 0);

            refractiveIndex2.Margin = new System.Windows.Forms.Padding(
                this.Width / 150, this.Height / 50,
                0, this.Height / 100);




            // For sizing objects based on clients resoloution
            aOIText.Font = new Font(aOIText.Font.FontFamily,
            this.Width / 80);

            aoR.Font = new Font(aoR.Font.FontFamily,
                this.Width / 80);

            angleOfIncidence.Font = new Font(angleOfIncidence.Font.
                FontFamily, this.Width / 80);

            // Sets the same size for matching objects
            angleOfIncidence.Size = aOIText.Size;

            rI1Text.Font = new Font(rI1Text.Font.FontFamily,
                        this.Width / 80);

            rI2Text.Font = new Font(aOIText.Font.FontFamily,
                this.Size.Width / 80);

            refractiveIndex1.Font = new Font(refractiveIndex1.Font.
                FontFamily, this.Width / 80);

            refractiveIndex2.Font = new Font(refractiveIndex2.Font.
                FontFamily, this.Width / 80);


            // Keeps sizing consistent
            refractiveIndex1.Size = aOIText.Size;
            refractiveIndex2.Size = aOIText.Size;




            // Puts the back arrow in the top left hand corner
            bArrow.Size = new Size(this.Height / 15, this.Height / 15);
            bArrow.Padding = new Padding(20, 50 ,0, 0);
        }



        private void bArrow_Click_1(object sender, EventArgs e)
        {
            tableLayoutPanel1.Hide();
            fadeOut.Enabled = true;
          

        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            DrawRays();
        }

        // For drawing the static lines
        private void initDraw()
        {

            // Changes line col based on the theme
            Color lineCol = Color.White;



            // Creates a white pen
            Pen pen = new Pen(lineCol, 6);

       
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
                // Stops timer
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
            tableLayoutPanel1.Invalidate();
          
        }

    

        private void DrawRays()
        {
            // Creates a pen object to draw the incident ray
            Pen aOIPen = new Pen(Color.Blue,7);
    

            // Creates another pen but for the refracted ray
            Pen aORPen = new Pen(Color.OrangeRed, 7);

            // Creates another pen but for the reflected ray
            Pen aORePen = new Pen(Color.Blue, 7);

            // Creates a graphics to draw on the tableLayoutPanel
            Graphics rays = tableLayoutPanel1.CreateGraphics();

            // Increases the quality of the line 
            rays.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            

            // Used as an arrow cap
            AdjustableArrowCap bigArrow = new AdjustableArrowCap
                (this.Height / 100, 
                this.Width / 200);

            // Refreshes the tableLayout panel to redraw everything
            //tableLayoutPanel1.Refresh();
      
            


            // Redraws the base lines apart from the first time this is called
            initDraw();
            
            // Validation
            if (double.TryParse(angleOfIncidence.Text, out double _)
                && double.TryParse(refractiveIndex1.Text, out double _)
                && double.TryParse(refractiveIndex2.Text, out double _)
                && Convert.ToDouble(angleOfIncidence.Text) <= 90 
                && Convert.ToDouble(angleOfIncidence.Text) >= 0
                && Convert.ToDouble(refractiveIndex1.Text) >= 1
                && Convert.ToDouble(refractiveIndex1.Text) <= 2.65
                && Convert.ToDouble(refractiveIndex2.Text) >= 1
                && Convert.ToDouble(refractiveIndex2.Text) <= 2.65
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

                double angleRDegrees = Math.Round(angleR * 180 / Math.PI,1);



                // Calculates the end point for the aoR
                double x2R = x1 + Math.Cos(angleR) * length;
                double y2R = y1 + Math.Sin(angleR) * length;


                // Draws a line using the AOIPen at the specified loactions

             
                rays.DrawLine(aOIPen, (float)x1, (float)y1, (float)x2I, (float)y2I);
                
               

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

       

                if (double.IsNaN(angleRDegrees))
                {
                    aoR.Text = "Total internal reflection has occurred";

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

                aOIPen.Dispose();
                aORPen.Dispose();
                aORePen.Dispose();
                rays.Dispose();
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
            tableLayoutPanel1.Invalidate();
      
        }

        private void rI1Text_Click(object sender, EventArgs e)
        {
            
        }

        private void aoR_Click(object sender, EventArgs e)
        {
          
        }

        private void refractiveIndex1_TextChanged_1(object sender, EventArgs e)
        {
            tableLayoutPanel1.Invalidate();
          
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
                fadeOut.Stop();      // Stop the timer so it doesn't keep firing
                // When the opacity is 0, close the form
                this.Close();
               
            }
        }

  

        // For changing each individual cell
        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {

          
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
        }


        private void bArrow_MouseLeave(object sender, EventArgs e)
        {
            // Returns bArrow size back to normal
            bArrow.BackgroundImageLayout = ImageLayout.Zoom;

        }

        private void bArrow_MouseEnter(object sender, EventArgs e)
        {
            // Slighly increases the size of the bArrow in non power save

            if (systemWideVariables.powerSave == false)
            {
                bArrow.BackgroundImageLayout = ImageLayout.Stretch;
            }


        }

        private void glossary_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Opens a link to a useful info page
            var psi = new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.savemyexams.com/a-level/physics/aqa/17/revision-notes/3-waves/3-5-refraction/3-5-2-snells-law/",
                UseShellExecute = true
            };
            System.Diagnostics.Process.Start(psi);

            // Optional: mark the link as visited
            linkLabel1.LinkVisited = true;           


            initDraw();
            

        }

        // Sets up the vertical line
        private float vertDrawPoint = 0;

        // Sets up the horizontal line 
        private float horzDrawPoint = 0;

        private void getHorzDrawPoint() 
        {
            if (horzDrawPoint == 0) 
            {
                horzDrawPoint = this.Width / 100 * 50;
            }
        }
        private void lineAnimate_Tick(object sender, EventArgs e)
        {
            // Changes line col based on the theme
            Color lineCol = Color.White;

     

            // Creates a white pen
            Pen pen = new Pen(lineCol, 6);

            // Creates a new graphic object
            Graphics g = tableLayoutPanel1.CreateGraphics();
            getHorzDrawPoint();


            // Draws a vertical and horizontal line

            if (vertDrawPoint < this.Height || horzDrawPoint <= this.Width / 100 * 90)
            {
                // Graduly draws a vertical line
                g.DrawLine(pen, this.Width / 100 * 70, 0,
                this.Width / 100 * 70, vertDrawPoint);
                vertDrawPoint += this.Height / 100 * 3;


                // Draws the horizontal line 
                pen.DashStyle = DashStyle.Dot;

                g.DrawLine(pen, this.Width / 100 * 50, this.Height / 100 * 50,
                    horzDrawPoint, this.Height / 100 * 50);
                horzDrawPoint += this.Width / 100 * 1;

                g.Dispose();
                pen.Dispose();

            }
            else
            {
                g.Dispose();
                pen.Dispose();
                // Stop the timer
                linesAnimate.Enabled = false;
            }


        }

        private void glossary_MouseLeave(object sender, EventArgs e)
        {
       
          

        }

        private void glossary_MouseDown(object sender, MouseEventArgs e)
        {
            //
            //linesAnimate.Enabled = true;
        }

        private void rInteract_SizeChanged(object sender, EventArgs e)
        {
            configControls();
            DrawRays();
        }

        private void rInteract_Shown(object sender, EventArgs e)
        {

        }

        private void rInteract_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
