using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Physics_Simulation.welcomeScreen;

namespace Physics_Simulation
{
    public partial class refractionQuestions : Form
    {
        public refractionQuestions()
        {
            InitializeComponent();
        }

        private class AltKeyFilter : IMessageFilter
        {
            public bool PreFilterMessage(ref Message m)
            {
                return m.Msg == 0x0104 && ((int)m.LParam & 0x20000000) != 0;
            }
        }

        private void refractionQQuestions_Load(object sender, EventArgs e)
        {
           

            Application.AddMessageFilter(new AltKeyFilter());
            // Gives a full screen window
            this.WindowState = FormWindowState.Maximized;

            // removes annoying windows sound
            this.AcceptButton = null;
           

            // Sets the form text as the version num defined by the class
            // TitleVersion
            this.Text = systemWideVariables.titleVersion;


            // Sets up the glossary loaction
            glossary.Font = new Font(
                glossary.Font.FontFamily, this.Width / 80);


            glossary.Location = new Point(ClientSize.Width / 100 * 20,
                Convert.ToInt32(this.Height / 2));

            glossary.Padding = new System.Windows.Forms.Padding(
                this.Width / 60, 0, 0, this.Height / 100);

            // Sets the active colour of the link label to pink for dark mode
            glossary.ActiveLinkColor = Color.Pink;


            if (systemWideVariables.lightTheme == true)
            {
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;   
                bArrow.BackgroundImage = Properties.Resources.lightBackArrow;
                bArrow.BackColor = Color.White;
                fParameter1.BackColor = Color.White;
                fParameter1.ForeColor = Color.Black;
                fParameter2.BackColor = Color.White;
                fParameter2.ForeColor = Color.Black;
                fParameter3.BackColor = Color.White;
                fParameter3.ForeColor = Color.Black;
                mParameter.ForeColor = Color.White;
                mParameter.BackColor = Color.Black;
                glossary.BackColor  = Color.White;
                glossary.LinkColor = Color.Black;
                generateQuestion.BackColor = Color.Black;
                generateQuestion.ForeColor = Color.White;
                result.BackColor = Color.White;
                result.ForeColor = Color.Black;
                stats.ForeColor = Color.Black;
                stats.BackColor = Color.White;


            }

     
            // Puts the back arrow in the top left hand corner
            bArrow.Location = new Point(0, 0);


            // sets up the fade in animatino
            this.Opacity = 0;
            fadeIn.Enabled = true;

            // Sizes the back arrow
            bArrow.Size = new Size(ClientSize.Height / 10, ClientSize.Height / 10);



            // Sets equal font sizes for controls

            fParameter1.Font = new Font(fParameter1.Font.FontFamily,
            this.Width / 80);

            fParameter2.Font = new Font(fParameter2.Font.FontFamily,
            this.Width / 80);

            fParameter3.Font = new Font(fParameter3.Font.FontFamily,
            this.Width / 80);

            mParameter.Font = new Font(mParameter.Font.FontFamily,
                this.Width / 80);


            promptText.Font = new Font(promptText.Font.FontFamily,
                this.Width / 80);

            generateQuestion.Font = new Font(generateQuestion.Font.FontFamily,
                this.Width / 80);

            result.Font = new Font(result.Font.FontFamily,
                this.Width / 70);

            stats.Font = new Font(stats.Font.FontFamily,
                this.Width / 80);

            flowLayoutPanel2.Size = new Size(this.Width, this.Height / 20);


            //Adds some margins between controls


            fParameter1.Margin = new System.Windows.Forms.Padding(
                this.Width / 150, this.Height / 50, 0, 0);

            fParameter2.Margin = new System.Windows.Forms.Padding(
                this.Width / 150, this.Height / 50, 0, 0);

            fParameter3.Margin = new System.Windows.Forms.Padding(
                this.Width / 150, this.Height / 50, 0, 0);



            mParameter.Margin = new System.Windows.Forms.Padding(
                this.Width / 150, this.Height / 50, 0, 0);

            promptText.Margin = new System.Windows.Forms.Padding(
                this.Width / 150, this.Height / 50, 0, 0);




            // for consisant sizing
            fParameter1.Size = promptText.Size;
            fParameter2.Size = promptText.Size;
            fParameter3.Size = promptText.Size;
            mParameter.Size = promptText.Size;


            // Hides controls to begin with
            fParameter1.Hide();
            fParameter2.Hide();
            fParameter3.Hide();
            mParameter.Hide();
            promptText.Hide();


            // Allow animaton on no power save
            if (systemWideVariables.powerSave == false)
            {
                linesAnimate.Enabled = true;
            }

        }

        private void bArrow_Click(object sender, EventArgs e)
        {
            fadeOut.Enabled = true;
        }

        // For fade in animaiton
        private void fadeIn_Tick(object sender, EventArgs e)
        {

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
                //Close the file.
               
                this.Close();
            }
        }

        private void bArrow_MouseEnter(object sender, EventArgs e)
        {
            // Slighly increases the size of the bArrow in non power save

            if (systemWideVariables.powerSave == false)
            {
                bArrow.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void bArrow_MouseLeave(object sender, EventArgs e)
        {
            // Returns bArrow size back to normal
            bArrow.BackgroundImageLayout = ImageLayout.Zoom;
        }


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
            Pen pen = new Pen(lineCol, 6);


            // Creates a new graphic object
            Graphics g = tableLayoutPanel1.CreateGraphics();


            // Draws a vertical line
            g.DrawLine(pen, this.Width / 100 * 70, 0,
                this.Width / 100 * 70, this.Height);


            // Draws a dotted horizontal line for the normal
            pen.DashStyle = DashStyle.Dot;


            g.DrawLine(pen, this.Width / 100 * 50, this.Height / 100 * 50,
                this.Width / 100 * 90, this.Height / 100 * 50);

        }



        // allows me to access then anywhere
        private double angleOfIncidence;
        private double refractiveIndex1;
        private double refractiveIndex2;
        private double angleOfRefraction;
        private double answer;
        private void createQuestion()
        {
            Random rnd = new Random();

            if (systemWideVariables.isRandom == true)
            {
                // Creates random parameters and calcs the angle of refraction


                angleOfIncidence = rnd.Next(0, 91);

                refractiveIndex1 = rnd.Next(100, 265);
                refractiveIndex1 = refractiveIndex1 / 100;

                refractiveIndex2 = rnd.Next(100, 265);
                refractiveIndex2 = refractiveIndex2 / 100;
            }

            else
            {


                // Gets number of lines in a file
                try
                {
                    int lineCount = File.ReadLines("refractionQuestions.txt").Count();

                    // Selects a random int
                    int chosenQuestion = rnd.Next(0, lineCount);


                    // Reads a random line from the file
                    string qString = File.ReadLines("refractionQuestions.txt").Skip(chosenQuestion).FirstOrDefault();

                    // creates a list from the string
                    string[] qList = qString.Split(new char[] { ',' });

                    // Adds the values accordingly

                    angleOfIncidence = Convert.ToDouble(qList[1]);
                    refractiveIndex1 = Convert.ToDouble(qList[2]);
                    refractiveIndex2 = Convert.ToDouble(qList[3]);

                    // Shows question name:
                    if (systemWideVariables.lightTheme)
                    {
                        result.ForeColor = Color.Black;
                    }
                    else
                    {
                        result.ForeColor = Color.White;
                    }

                    result.Text = qList[0];
                } 
                catch 
                {
                    if (systemWideVariables.lightTheme)
                    {
                        result.ForeColor = Color.Black;
                    }
                    else
                    {
                        result.ForeColor = Color.White;
                    }

                    result.Text = "Please head to the refraction builder to make a question!";
                    generateQuestion.Enabled = false;


                }

            }



                // Calculates the angle of refraction
                double angleI = angleOfIncidence
                    * Math.PI / 180;
                double angleRad;
                if (angleI != Math.PI / 2)
                {
                    angleRad = Math.Asin((Math.Sin(angleI) *
                        refractiveIndex1) /
                        refractiveIndex2);


                }
                else { angleRad = Math.PI / 2; }

                angleOfRefraction = Math.Round(angleRad * 180 / Math.PI, 1);


            


            // Chooses and sets missing and found parameters on a random chance

            int chooseMissing = rnd.Next(1, 5);


            // Forces refraction to be missing if internal reflection question is given
            if (double.IsNaN(angleOfRefraction))
            {
                answer = angleOfIncidence;
                promptText.Text = "Enter angle of reflection below (1.dp):";
                fParameter2.Text = "Refractive index 2: " + Convert.ToString(refractiveIndex2);
                fParameter1.Text = "Refractive index 1: " + Convert.ToString(refractiveIndex1);
                fParameter3.Text = "Angle of incidence: " + Convert.ToString(angleOfIncidence) + "°";
                chooseMissing = 0;
            }

            if (chooseMissing == 1)
            {
                answer = angleOfRefraction;
                promptText.Text = "Enter angle of refraction below (1.dp):";
                fParameter2.Text = "Refractive index 2: " + Convert.ToString(refractiveIndex2);
                fParameter1.Text = "Refractive index 1: " + Convert.ToString(refractiveIndex1);
                fParameter3.Text = "Angle of incidence: " + Convert.ToString(angleOfIncidence) + "°";
            }

            else if (chooseMissing == 2)
            {
                answer = angleOfIncidence;
                promptText.Text = "Enter angle of incidence below (1.dp):";
                fParameter2.Text = "Refractive index 2: " + Convert.ToString(refractiveIndex2);
                fParameter1.Text = "Refractive index 1: " + Convert.ToString(refractiveIndex1);
                fParameter3.Text = "Angle of refraction: " + Convert.ToString(angleOfRefraction) + "°";
            }

            else if (chooseMissing == 3)
            {
                answer = refractiveIndex2;
                promptText.Text = "Enter refractive index 2 below (3.sf):";
                fParameter3.Text = "Angle of refraction: " + Convert.ToString(angleOfRefraction) + "°";
                fParameter1.Text = "Refractive index 1: " + Convert.ToString(refractiveIndex1);
                fParameter2.Text = "Angle of incidence: " + Convert.ToString(angleOfIncidence) + "°";
            } 

            else if (chooseMissing == 4)
            {
                answer = refractiveIndex1;
                promptText.Text = "Enter refractive index 1 below (3.sf):";
                fParameter1.Text = "Refractive index 2: " + Convert.ToString(refractiveIndex2);
                fParameter2.Text = "Angle of refraction " + Convert.ToString(angleOfRefraction) + "°";
                fParameter3.Text = "Angle of incidence: " + Convert.ToString(angleOfIncidence) + "°";
            }

  



            DrawRays(angleOfIncidence,refractiveIndex1,refractiveIndex2);

            


        }



        private void DrawRays(double angleOfIncidence, double refractiveIndex1, double refractiveIndex2)
        {
            // Creates a pen object to draw the incident ray
            Pen aOIPen = new Pen(Color.Blue, 6);


            // Creates another pen but for the refracted ray
            Pen aORPen = new Pen(Color.OrangeRed, 6);

            // Creates another pen but for the reflected ray
            Pen aORePen = new Pen(Color.Blue, 6);

            // Creates a graphics to draw on the tableLayoutPanel
            Graphics rays = tableLayoutPanel1.CreateGraphics();

            // Increases the quality of the line 
            rays.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;


            // Used as an arrow cap
            AdjustableArrowCap bigArrow = new AdjustableArrowCap
                (this.Height / 100,
                this.Width / 200);

            // Refreshes the tableLayout panel to redraw everything
            tableLayoutPanel1.Refresh();

            // Redraws the base lines apart from the first time this is called
            initDraw();

            // Validation
            
                // Converts aOI text from string to integer for x coord use
           double angleI = angleOfIncidence
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
                        refractiveIndex1 /
                        refractiveIndex2);
                }
                else { angleR = Math.PI / 2; }

                double angleRDegrees = Math.Round(angleR * 180 / Math.PI, 1);
                



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

                // delays the drawing slightly


                // Draws the aOR ray
                rays.DrawLine(aORPen, (float)x1, (float)y1, (float)x2R, (float)y2R);

                // To get an arrow in the middle of the line draw another line ending in the middle

                double arrowXR = (x1 + x2R) / 2;
                double arrowYR = (y1 + y2R) / 2;
                aORPen.CustomEndCap = bigArrow;
                rays.DrawLine(aORPen, (float)x1, (float)y1, (float)arrowXR, (float)arrowYR);



                if (double.IsNaN(angleRDegrees))
                {
                    //aoR.Text = "Total internal reflection has occurred";

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
                    //aoR.Text = angleRDegrees.ToString() + "°";

                    // Draws a  dotted horizontal line for the normal if angle != 0 or 90
                    if (angleOfIncidence != 0
                        && angleOfIncidence != 90)
                    {
                        // Sets the attriubtes of the pen and draws the ray
                        aORePen.DashStyle = DashStyle.Dot;
                        aORePen.Width = 4;
                        rays.DrawLine(aORePen, (float)x1, (float)y1, (float)x2Re, (float)y2Re);
                    }
                }
        }


        // Stats
        private double numberOfCorrect;
        private double total;

        

        private void Test_Click(object sender, EventArgs e)
        {


            // For first time the user presses the button
            if ( generateQuestion.Text == "Generate Question")
            {
                generateQuestion.Text = "Check Answer";
                createQuestion();

                // Shows the parameter boxes if required
                fParameter1.Show();
                fParameter2.Show();
                fParameter3.Show();
                mParameter.Show();
                promptText.Show();
             
            }

            else if ( generateQuestion.Text == "Check Answer")
            {
                generateQuestion.Enabled = false;

                // Shows if the user got it correct or not and updates the stats
                if (mParameter.Text == Convert.ToString(answer))
                {
       
                    result.ForeColor = Color.Green;
                    result.Text = "Correct!";

                    numberOfCorrect ++;
                    total ++;

                    // Less text to read so disapears slower
                    resetResult.Interval = 1000;
                }
                else
                {
                    result.ForeColor= Color.Red;
                    // If it is an angle or not
                    if (promptText.Text == "Enter angle of incidence below (1.dp):"
                        | promptText.Text == "Enter angle of refraction below (1.dp):")
                    {
                        result.Text = "Incorrect. Correct answer is " + answer + "°";
                    }
                    else
                    {
                        result.Text = "Incorrect. Correct answer is " + answer;
                    }

                    total ++;

                    // More to read so longer intervel time

                    resetResult.Interval = 1500;
                }

                stats.Text = "Percentage correct: " + Convert.ToString(Math.Round(numberOfCorrect / total * 100,1)) + "%" +
                    "@" + "Questions answered: " + total;

                stats.Text = stats.Text.Replace("@", System.Environment.NewLine);

                mParameter.Text = "";
                    

                // Diagram disapears for some reason so redrawing here
                DrawRays(angleOfIncidence, refractiveIndex1, refractiveIndex2);

                resetResult.Enabled = true;
            }

        }

        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            // If it is [0,1] then the bg of it will change to the right colour
            if (e.Column == 1 && e.Row == 2)
            {
                if (systemWideVariables.lightTheme == true)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.Black), e.CellBounds);
                }
                else { e.Graphics.FillRectangle(new SolidBrush(Color.White), e.CellBounds); }

            }

        }

        private void mParameter_TextChanged(object sender, EventArgs e)
        {
            
        }


        // Sets up the vertical line
        private float vertDrawPoint = 0;
        private void getVertDrawPoint()
        {
            if (vertDrawPoint == 0)
            {
                vertDrawPoint = this.Height;
            }
        }

        // Sets up the horizontal line 
        private float horzDrawPoint = 0;

        private void getHorzDrawPoint()
        {
            if (horzDrawPoint == 0)
            {
                horzDrawPoint = this.Width / 100 * 50;
            }
        }
        private void linesAnimate_Tick(object sender, EventArgs e)
        {
            // Changes line col based on the theme
            Color lineCol = Color.White;

            if (systemWideVariables.lightTheme == true)
            {
                this.BackColor = Color.White;
                lineCol = Color.Black;
            }


            // Creates a white pen
            Pen pen = new Pen(lineCol, 6);


            // Creates a new graphic object
            Graphics g = tableLayoutPanel1.CreateGraphics();
            getVertDrawPoint();
            getHorzDrawPoint();


            // Draws a vertical and horizontal line

            if (vertDrawPoint > 1)
            {
                // Graduly draws a vertical line
                g.DrawLine(pen, this.Width / 100 * 70, 0,
                this.Width / 100 * 70, this.Height - vertDrawPoint);
                vertDrawPoint -= 20;

                // Draws the horizontal line 
                if (horzDrawPoint <= this.Width / 100 * 90)
                {
                    pen.DashStyle = DashStyle.Dot;

                    g.DrawLine(pen, this.Width / 100 * 50, this.Height / 100 * 50,
                        horzDrawPoint, this.Height / 100 * 50);
                    horzDrawPoint += 15;

                }
            }
            else
            {
                // Stop the timer
                linesAnimate.Enabled = false;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            // for power save, disabled animation in form_Load
            if (systemWideVariables.powerSave)
            {
                initDraw();
            }
        }


        private bool flag = true;
        private void resetResult_Tick(object sender, EventArgs e)
        {
            
            if (flag)
            {
                flag = false;
            }
            else
            {
                result.Text = "";
                flag = true;
                createQuestion();
                generateQuestion.Enabled = true;
                resetResult.Enabled = false;
            }
        }

        private void mParameter_KeyPress(object sender, KeyPressEventArgs e)
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

        


        private void glossary_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Opens a link to a useful info page
            System.Diagnostics.Process.Start("https://www.savemyexams.com/a-level/physics/aqa/17/revision-notes/3-waves/3-5-refraction/3-5-2-snells-law/");
            // redraws the diagram accordingly.


            initDraw();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
