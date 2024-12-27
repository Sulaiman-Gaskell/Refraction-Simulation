using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Physics_Simulation.welcomeScreen;

namespace Physics_Simulation
{
    public partial class wInteract : Form
    {
        public wInteract()
        {
            InitializeComponent();

            //Maximises the form and stops the user
            //from resizing it
            this.WindowState = FormWindowState.Maximized;
            
            
            // Disables annoying windows sounds
            this.AcceptButton = null;


            
        }

        private void wInteract_Load(object sender, EventArgs e)
        {

            this.DoubleBuffered = true; // Enable double buffering
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            this.UpdateStyles();

            // Sets the form text as the version num defined by the class
            // TitleVersion
            this.Text = systemWideVariables.titleVersion;

            // for fade in effect
            // Set the form's initial opacity to 0 (completely transparent)
            this.Opacity = 0;

            // Start the fade to animate the form
            fadeIn.Enabled = true;

            glossary.BackColor = Color.White;
            glossary.ForeColor = Color.Black;
            glossary.LinkColor = Color.Black;
            // For light mode
            if (systemWideVariables.lightTheme == true)
            {
                this.BackColor = Color.White;
                bArrow.BackgroundImage = Properties.Resources.lightBackArrow;
                bArrow.BackColor = Color.White;
                frequencyText.ForeColor = Color.Black;
                frequency.BackColor = Color.Black;
                frequency.ForeColor = Color.White;
                wSpeedText.BackColor = Color.White;
                wSpeedText.ForeColor = Color.Black;
                waveSpeed.BackColor = Color.Black;
                waveSpeed.ForeColor = Color.White;
                amplitudeText.BackColor = Color.White;
                amplitudeText.ForeColor = Color.Black;
                amplitude.BackColor = Color.Black;
                amplitude.ForeColor = Color.White;
                unitConvert.BackColor = Color.Black;
                unitConvert.ForeColor = Color.White;
                waveLength.ForeColor = Color.Black;


            }

            // differentiates the button from the textboxes
            unitConvert.FlatStyle = FlatStyle.System;

            // Hides a placeholder label for consistancy
            //placeholder.Hide();

            // Puts the back arrow in the top left hand corner
            bArrow.Location = new Point(0, 0);

            // Sizes the back arrow
            bArrow.Size = new Size(ClientSize.Height / 10, ClientSize.Height / 10);

            // For sizing objects based on clients resoloution
            frequencyText.Font = new Font(frequencyText.Font.FontFamily,
            ClientSize.Width / 80);

            frequency.Font = new Font(frequency.Font.FontFamily,
            ClientSize.Width / 80);

            wSpeedText.Font = new Font(wSpeedText.Font.FontFamily,
            ClientSize.Width / 80);

            waveSpeed.Font = new Font(waveSpeed.Font.FontFamily,
                ClientSize.Width / 80);

            amplitudeText.Font = new Font(amplitudeText.Font.FontFamily,
                ClientSize.Width / 80);

            amplitude.Font = new Font(amplitude.Font.FontFamily,
                ClientSize.Width / 80);

            unitConvert.Font = new Font(unitConvert.Font.FontFamily,
                ClientSize.Width / 80);

            glossary.Font = new Font(glossary.Font.FontFamily,
                ClientSize.Width / 80);

            waveLength.Font = new Font(glossary.Font.FontFamily,
                ClientSize.Width / 80);

            // Sets the same size as the largest item

            frequency.Size = wSpeedText.Size;
            frequencyText.Size = wSpeedText.Size;
            waveSpeed.Size = wSpeedText.Size;
            amplitudeText.Size = wSpeedText.Size;
            amplitude.Size = wSpeedText.Size;
            unitConvert.Size = waveSpeed.Size;
            glossary.Size = wSpeedText.Size;
            waveLength.Size = wSpeedText.Size;

        
            

            // Adds margins between objects to look nicer
            // Adds some margin gaps between controls to look better
            frequencyText.Margin = new System.Windows.Forms.Padding(
                0, ClientSize.Width / 150, 0, 0);

            frequency.Margin = new System.Windows.Forms.Padding(
                ClientSize.Width / 150, ClientSize.Width / 100, 0, 0);

            wSpeedText.Margin = new System.Windows.Forms.Padding(
                ClientSize.Width / 150, ClientSize.Width / 100, 0, 0);

            waveSpeed.Margin = new System.Windows.Forms.Padding(
                ClientSize.Width / 150,ClientSize.Width / 100,0,0);


            // new column
            amplitudeText.Margin = new System.Windows.Forms.Padding(
                ClientSize.Width / 250, ClientSize.Width / 150,0,0);

            amplitude.Margin = new System.Windows.Forms.Padding(
                ClientSize.Width / 150, ClientSize.Width / 100,0,0);

            unitConvert.Margin = new System.Windows.Forms.Padding(
                0, ClientSize.Width / 100, 0, 0);

            glossary.Margin = new System.Windows.Forms.Padding(
                ClientSize.Width / 150, ClientSize.Width/100, 0, 0);

            lineAnimate.Enabled = true;
        }

    
        private void fadeIn_Tick(object sender, EventArgs e)
        {
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

        private void bArrow_Click(object sender, EventArgs e)
        {
            fadeOut.Enabled = true;
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

        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            // If it is [0,2] then the bg of it will change to the right colour
            if (e.Column == 0 && e.Row == 2)
            {
                if (systemWideVariables.lightTheme == true)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.Black), e.CellBounds);
                }
                else { e.Graphics.FillRectangle(new SolidBrush(Color.White), e.CellBounds); }

            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void glossary_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Opens a link to a useful info page
            System.Diagnostics.Process.Start("https://pmt.physicsandmathstutor.com/download/Physics/A-level/Notes/AQA/03-Waves/Detailed%20Notes%20-%20Section%2003%20Waves%20-%20AQA%20Physics%20A-level.pdf");

        }




        private void drawLine(Graphics graphics)
        {
            // Creates a pen object and chnages colour accordingly
            Pen line = new Pen(Color.Red, 6);
            if (systemWideVariables.lightTheme == true)
            {
               line.Color = Color.Blue;
            }

            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            line.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;

            graphics.DrawLine(line, 0, ClientSize.Height / 100 * 50,
                ClientSize.Width, ClientSize.Height / 100 * 50);

            line.Dispose();
        }



        private int ofsetY = 1;
        private int ofsetX = 0;
        private bool waveFlag = true;
        private int refreshCount = 0;
        private int upperOfsetY = 15;

        private void waveDraw_Tick(object sender, EventArgs e)
        {

            Pen wave = new Pen(Color.White, 20);
            if (systemWideVariables.lightTheme == true)
            {
                wave.Color = Color.Black;
            }


            // Creates a graphic 'diagram' to draw on the tableLayoutPanel
             Graphics diagram = tableLayoutPanel1.CreateGraphics();

            

            diagram.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            

           

            // resets the points to be reused
            if (ClientSize.Width / 100 * (-80 + ofsetX) == 0)
            {
                ofsetX = 0;
             

            }
        

            // Gets the points ready to be drawn
              Point point0 = new Point(ClientSize.Width / 100 * (-80 + ofsetX), ClientSize.Height / 100 * (50 - ofsetY));
              Point point1 = new Point(ClientSize.Width / 100 * (-60 + ofsetX), ClientSize.Height / 100 * (50 + ofsetY));
              Point point2 = new Point(ClientSize.Width / 100 * (-40 + ofsetX), ClientSize.Height / 100 * (50 - ofsetY));
              Point point3 = new Point(ClientSize.Width / 100 * (-20 + ofsetX), ClientSize.Height / 100 * (50 + ofsetY));
              Point point4 = new Point(ClientSize.Width / 100 * (ofsetX), ClientSize.Height / 100 * (50 - ofsetY));
              Point point5 = new Point(ClientSize.Width / 100 * (20 + ofsetX), ClientSize.Height / 100 * (50 + ofsetY));
              Point point6 = new Point(ClientSize.Width / 100 * (40 + ofsetX), ClientSize.Height / 100 * (50 - ofsetY));
              Point point7 = new Point(ClientSize.Width / 100 * (60 + ofsetX), ClientSize.Height / 100 * (50 + ofsetY));
              Point point8 = new Point(ClientSize.Width / 100 * (80 + ofsetX), ClientSize.Height / 100 * (50 - ofsetY));
              Point point9 = new Point(ClientSize.Width / 100 * (100 + ofsetX), ClientSize.Height / 100 * (50 + ofsetY));
              Point point10 = new Point(ClientSize.Width / 100 * (120 + ofsetX), ClientSize.Height / 100 * (50 - ofsetY));

              Point[] curvePoints = { point0, point1, point2, point3, point4, point5, point6, point7,point8,point9,point10 };

            // Refreshs the screen or clears it

            if (refreshCount == 1 & waveDraw.Interval < 500)
            {
                if (systemWideVariables.lightTheme == true)
                {
                    diagram.Clear(Color.White);
                }
                else
                {
                    diagram.Clear(Color.Black);
                }

                


                refreshCount = 0;

            }

            else if (waveDraw.Interval >= 500)
            {
                if (systemWideVariables.lightTheme == true)
                {
                    diagram.Clear(Color.White);
                }
                else
                {
                    diagram.Clear(Color.Black);
                }
                refreshCount = 0;
            }
            else
            {
                this.Invalidate();
                refreshCount++;
            }

            drawLine(diagram);




            // Draws the wave function

            diagram.DrawCurve(wave, curvePoints);





            // Updates ofset accordingly to the inputted amplitude
            
            if (upperOfsetY == 0)
            {
                ofsetY = 0;
            }
            else if (ofsetY < upperOfsetY & waveFlag == true)
            {
                ofsetY++;
            }
            else if (ofsetY < upperOfsetY & ofsetY != (-upperOfsetY) & waveFlag == false)
            {
                ofsetY--;
            }
            else if (ofsetY == upperOfsetY & waveFlag == true)
            {
                waveFlag = false;
                ofsetY--;
            }
            else if (ofsetY == (-upperOfsetY)  & waveFlag == false )
            {
                waveFlag = true;
                ofsetY++;
            }


            // Fine tune visual effect
            if (waveDraw.Interval < 50)
            {
                ofsetX = ofsetX + 2;
            }
            else
            {
                ofsetX ++;
            }


            // Forces any changes to the wavelength stat if needed
            try
            {
                // Updates the stat and rounds to one dp
                waveLength.Text = "Wavelength: " +
                    Convert.ToString(Math.Round(Convert.ToDouble(waveSpeed.Text) / Convert.ToInt32(frequency.Text),1)
                    + " m (1.dp)");
            }
            catch
            {
                // To pause wave animation if an invalid input is put in and give error messg
                waveDraw.Interval = 1000000;
                waveLength.Text = "Error!";
            }

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }


        private double upperWaveSpeed = 101;
        private void waveSpeed_TextChanged(object sender, EventArgs e)
        {
            try
            {
                waveDraw.Interval = Convert.ToInt32(upperWaveSpeed - Convert.ToDouble(waveSpeed.Text)
                    - (Convert.ToInt32(frequency.Text)));
            }
            catch
            {
                // give error messg and update values if invalid value is given

                if (waveSpeed.Text == "")
                {

                }
                else
                {
                    waveLength.Text = "Error! This wave cannot exist!";
                    waveDraw.Interval = 1;
                }
                
                

                waveLength.Text = "Error!";
            }

            ofsetX = 0;
        }

        private void frequency_TextChanged(object sender, EventArgs e)
        {
            try
            {
                waveDraw.Interval = Convert.ToInt32(upperWaveSpeed - Convert.ToDouble(waveSpeed.Text)
                    - (Convert.ToInt32(frequency.Text)));
            }
            catch
            {

                // To pause wave animation if an invalid input is put in and give error msg
                waveDraw.Interval = 1;
                waveLength.Text = "Error! Wave doesn't exist! Change the frequency or wave speed";
            }
            ofsetX = 0;
        }

        private void amplitude_TextChanged(object sender, EventArgs e)
        {
            try
            {

                // Conversion string --> double (*2) -- > integer
                upperOfsetY = Convert.ToInt32(Convert.ToDouble(amplitude.Text) * 2);
                ofsetY = 0;

              
            }
            catch
            {
                //give error messg and prevent error from happening
                upperOfsetY = 1;
                waveLength.Text = "Error!";
            }

      

        }

        private void tableLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {
          
        

        }


        // Sets up the persistant var
        private float endPoint = 0;
        private void getEndPoint()
        {
            if (endPoint == 0)
            {
                endPoint = this.Width;
            }
        }
        private void lineAnimate_Tick(object sender, EventArgs e)
        {
            // Creates a pen object and chnages colour accordingly
            Pen line = new Pen(Color.Red, 6);
            if (systemWideVariables.lightTheme == true)
            {
                line.Color = Color.Blue;
            }

            Graphics graphics = tableLayoutPanel1.CreateGraphics();


            // Smooths the line and makes it dotted
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            line.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;

            // Gets an updated value for the end point
            getEndPoint();

            // draws a new line based on the var endPoint
            graphics.DrawLine(line, 0, ClientSize.Height / 100 * 50,
                this.Width - endPoint, ClientSize.Height / 100 * 50);

            // Decreases the value of endPoint
            endPoint= endPoint - 20;

            if (endPoint <= 0)
            {
                // Stops the timer    
                waveDraw.Enabled = true;
                lineAnimate.Enabled = false;
            }

        }

        private void unitConvert_Click(object sender, EventArgs e)
        {
            if (unitConvert.Text == "m/s")
            {
                // Updates the text occordingly
                unitConvert.Text = "km/h";

                // Converts occordingly
                waveSpeed.Text = Convert.ToString(Convert.ToDouble(waveSpeed.Text) * 3.6);
                upperWaveSpeed = upperWaveSpeed * 3.6;

            }
            else
            {
                // Same but in reverse
                unitConvert.Text = "m/s";

                waveSpeed.Text = Convert.ToString(Convert.ToDouble(waveSpeed.Text) / 3.6);
                upperWaveSpeed = upperWaveSpeed / 3.6;

            }

            // Sets the new converted speed properly

            try
            {
                waveDraw.Interval = Convert.ToInt32(upperWaveSpeed - Convert.ToDouble(waveSpeed.Text));
            }
            catch
            {
                // To pause wave animation if an invalid input is put in
                waveDraw.Interval = 1000000;
            }

        }

        private void frequency_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Stops the user from entering any values other than 0-9, backspace and full stop 
            if ((e.KeyChar > (char)Keys.D9 || 
                 e.KeyChar < (char)Keys.D0) && 
                 e.KeyChar != (char)Keys.Back)
            {
                 e.Handled = true;
            }
        }

        private void waveSpeed_KeyPress(object sender, KeyPressEventArgs e)
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

        private void amplitude_KeyPress(object sender, KeyPressEventArgs e)
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
    }

}
 