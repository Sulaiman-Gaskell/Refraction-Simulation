using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Physics_Simulation.welcomeScreen;

namespace Physics_Simulation
{
    public partial class wavesQuestions : Form
    {
        public wavesQuestions()
        {
            InitializeComponent();
        }

        private void wavesQQuestions_Load(object sender, EventArgs e)
        {
            if (systemWideVariables.lightTheme)
            {
                this.BackColor = Color.White;
                bArrow.BackgroundImage = Properties.Resources.lightBackArrow;
                bArrow.BackColor = Color.White;
                fParameter1.BackColor = Color.White;
                fParameter1.ForeColor = Color.Black;
                fParameter2.BackColor = Color.White;
                fParameter2.ForeColor = Color.Black;
                mParameter.BackColor = Color.Black;
                mParameter.ForeColor = Color.White;
                promptText.ForeColor = Color.Black;
                promptText.BackColor = Color.White;
                stats.ForeColor = Color.Black;
                stats.BackColor = Color.White;
                amplitude.BackColor = Color.Black;
                amplitude.ForeColor = Color.White;
                amplitudeText.ForeColor = Color.Black;
                amplitudeText.BackColor = Color.White;

                //Added in alpha testing
                generateQuestion.ForeColor = Color.White;
                generateQuestion.BackColor = Color.Black;
            }


         
            this.Text = systemWideVariables.titleVersion;

            this.Opacity = 0;

            fadeIn.Enabled = true;

            lineAnimate.Enabled = true;

            // Sets equal font sizes for controls

            amplitudeText.Font = new Font(amplitudeText.Font.FontFamily,
                ClientSize.Width / 80);

            amplitude.Font = new Font(amplitude.Font.FontFamily,
                ClientSize.Width / 80);
           

            fParameter1.Font = new Font(fParameter1.Font.FontFamily,
                this.Width / 80);

            fParameter2.Font = new Font(fParameter2.Font.FontFamily,
                this.Width / 80);

            mParameter.Font = new Font(mParameter.Font.FontFamily,
                this.Width / 80);

            promptText.Font = new Font(promptText.Font.FontFamily,
                this.Width / 80);

            generateQuestion.Font = new Font(generateQuestion.Font.FontFamily,
                this.Width / 80);



            // Sizes the back arrow
            bArrow.Size = new Size(this.Height / 10, this.Height / 10);


            //Adds some margins between controls


            fParameter1.Margin = new System.Windows.Forms.Padding(
                this.Width / 150, this.Height / 50, 0, 0);

            fParameter2.Margin = new System.Windows.Forms.Padding(
                this.Width / 150, this.Height / 50, 0, 0);

            amplitudeText.Margin = new System.Windows.Forms.Padding(
                ClientSize.Width / 250, ClientSize.Width / 150, 0, 0);

            amplitude.Margin = new System.Windows.Forms.Padding(
                ClientSize.Width / 150, ClientSize.Width / 100, 0, 0);

            mParameter.Margin = new System.Windows.Forms.Padding(
                this.Width / 150, this.Height / 50, 0, 0);

            promptText.Margin = new System.Windows.Forms.Padding(
                this.Width / 150, this.Height / 50, 0, 0);

            result.Font = new Font(result.Font.FontFamily,
                this.Width / 70);

            stats.Font = new Font(stats.Font.FontFamily,
                this.Width / 80);


            // Sets same size for all controls
            fParameter1.Size = promptText.Size;
            fParameter2.Size = promptText.Size;
            mParameter.Size = promptText.Size;
            amplitude.Size = amplitudeText.Size;


            // Hides the controls temporarily
            fParameter1.Hide();
            fParameter2.Hide();
            mParameter.Hide();
            promptText.Hide();
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
            endPoint = endPoint - 20;

            if (endPoint <= 0)
            {
                // Stops the timer    
                waveDraw.Enabled = true;
                lineAnimate.Enabled = false;
            }

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

            Point[] curvePoints = { point0, point1, point2, point3, point4, point5, point6, point7, point8, point9, point10 };

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
            else if (ofsetY == (-upperOfsetY) & waveFlag == false)
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
                ofsetX++;
            }

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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        // Stats
        private double numberOfCorrect;
        private double total;
        private void generateQuestion_Click(object sender, EventArgs e)
        {
            // For first time the user presses the button
            if (generateQuestion.Text == "Generate Question")
            {
                generateQuestion.Text = "Check Answer";
                createQuestion();

                // Shows the parameter boxes if required
                fParameter1.Show();
                fParameter2.Show();
                mParameter.Show();
                promptText.Show();

            }

            else if (generateQuestion.Text == "Check Answer")
            {
                generateQuestion.Enabled = false;

                // Shows if the user got it correct or not and updates the stats
                if (mParameter.Text == Convert.ToString(answer))
                {

                    result.ForeColor = Color.Green;
                    result.Text = "Correct!";

                    numberOfCorrect++;
                    total++;

                    // Less text to read so disapears slower
                    resetResult.Interval = 1000;
                }
                else
                {
                    result.ForeColor = Color.Red;

                    result.Text = "Incorrect. Correct answer is " + answer;
                    total++;

                    // More to read so longer intervel time
                    resetResult.Interval = 1500;


                }

                stats.Text = "Percentage correct: " + Convert.ToString(Math.Round(numberOfCorrect / total * 100, 1)) + "%" +
    "@" + "Questions answered: " + total;

                stats.Text = stats.Text.Replace("@", System.Environment.NewLine);

                mParameter.Text = "";


                resetResult.Enabled = true;
            }
        }


        private double frequency;
        private double waveSpeed;
        private double waveLength = 0;
        private double answer;
        private void createQuestion()
        {
            Random random = new Random();

            if (systemWideVariables.isRandom == true)
            {

                while (waveLength == 0)
                {
                    // suitable freq upper bound
                    frequency = random.Next(1, 200);

                    // Upper bound up a factor of 10 to get some floating values aswell
                    waveSpeed = random.Next(1, 3000);
                    waveSpeed = Math.Round(waveSpeed / 10, 1);


                    // equation for wave speed
                    waveLength = Math.Round(waveSpeed / frequency, 1);


                    // Updates wave intervel
                    waveDraw.Interval = Convert.ToInt32(501 - Convert.ToDouble(waveSpeed)
                        - (Convert.ToInt32(frequency)));
                }


            }
            else
            {
                // Gets number of lines in a file
                try
                {
                    int lineCount = File.ReadLines("wavesQuestions.txt").Count();

                    // Selects a random int
                    int chosenQuestion = random.Next(0, lineCount);


                    // Reads a random line from the file
                    string qString = File.ReadLines("wavesQuestions.txt").Skip(chosenQuestion).FirstOrDefault();

                    // creates a list from the string
                    string[] qList = qString.Split(new char[] { ',' });

                    // Adds the values accordingly

                    frequency = Math.Round(Convert.ToDouble(qList[1]));
                    waveSpeed = Math.Round(Convert.ToDouble(qList[2]), 1);
                    waveLength = Math.Round(Convert.ToDouble(qList[3]),1);

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

                    result.Text = "Please head to the waves builder to make a question!";
                    generateQuestion.Enabled = false;
                }
            }

             
            
            // Chooses and sets missing and found parameters on a random chance

            int chooseMissing = random.Next(1, 4);

            if (chooseMissing == 1)
            { 
                answer = waveLength;
                promptText.Text = "Enter wavelength below (1.dp):";
                fParameter1.Text = "Frequency: " + Convert.ToString(frequency);
                fParameter2.Text = "Wave speed: " + Convert.ToString(waveSpeed);
            }
            else if (chooseMissing == 2)
            {
                answer = waveSpeed;
                promptText.Text = "Enter wave speed below (1.dp):";
                fParameter1.Text = "Frequency: " + Convert.ToString(frequency);
                fParameter2.Text = "Wavelength: " + Convert.ToString(waveLength);
            }
            else if (chooseMissing == 3)
            {
                answer = frequency;
                promptText.Text = "Enter frequency below:";
                fParameter1.Text = "Wave speed: " + Convert.ToString(waveSpeed);
                fParameter2.Text = "Wavelength: " + Convert.ToString(waveLength);
            }

        }


        private void amplitude_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Conversion string --> double (*2) -- > integer
                if (Convert.ToDouble(amplitude.Text) <= 35)
                {
                    upperOfsetY = Convert.ToInt32(Convert.ToDouble(amplitude.Text) * 2);
                    ofsetY = 0;
                }

                else
                {
                    upperOfsetY = 1;
                }
            }
            catch
            {
                //give error messg and prevent error from happening
                upperOfsetY = 1;
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
                waveLength = 0;
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
    }
}
