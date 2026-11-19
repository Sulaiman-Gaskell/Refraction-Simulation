using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Physics_Simulation.welcomeScreen;

namespace Physics_Simulation
{
    public partial class refractionBuilder : Form
    {
        public refractionBuilder()
        {

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }


        private void DrawLinesLeave(Graphics lines)
        {

            // draws nice graphical lines
            Pen line = new Pen(Color.White, 5);

            lines.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            if (systemWideVariables.lightTheme)
            {
                line.Color = Color.Black;
            }


            Point point1Left = new Point((int)horzDrawPoint, this.Height);
            Point point2Left = new Point(0, (int)vertDrawPoint);

            lines.DrawLine(line, point1Left, point2Left);


            Point point1Right = new Point(this.Width - (int)horzDrawPoint, 0);
            Point point2Right = new Point(this.Width, this.Height - (int)vertDrawPoint);

            lines.DrawLine(line, point1Right, point2Right);

            line.Dispose();
        }

        private void DrawLines(Graphics lines)
        {

            // draws nice graphical lines
            Pen line = new Pen(Color.White, 5);

            lines.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            if (systemWideVariables.lightTheme)
            {
                line.Color = Color.Black;
            }


            Point point1Left = new Point(this.Width - (int)horzDrawPoint, this.Height);
            Point point2Left = new Point(0, this.Height - (int)vertDrawPoint);

            lines.DrawLine(line, point1Left, point2Left);


            Point point1Right = new Point((int)horzDrawPoint, 0);
            Point point2Right = new Point(this.Width, (int)vertDrawPoint);

            lines.DrawLine(line,point1Right, point2Right);
   
            line.Dispose();
        }

        private void refreshControls() // update the elemetns on the screen
        {
            // Sizes the back arrow
            bArrow.Size = new Size(this.Height / 10, this.Height / 10);
            bArrow.Location = new Point(0, 0);


            // Sizes controls on the screen

            qNameLabel.Font = new Font(qNameLabel.Font.FontFamily,
                this.Width / 80);
            qName.Font = new Font(qName.Font.FontFamily,
                this.Width / 80);


            aOILabel.Font = new Font(aOILabel.Font.FontFamily,
                this.Width / 80);
            aOI.Font = new Font(aOI.Font.FontFamily,
                this.Width / 80);



            rI1Label.Font = new Font(rI1Label.Font.FontFamily,
                this.Width / 80);
            rI1.Font = new Font(rI1.Font.FontFamily,
                this.Width / 80);



            rI2Label.Font = new Font(rI2Label.Font.FontFamily,
                this.Width / 80);
            rI2.Font = new Font(rI2.Font.FontFamily,
                this.Width / 80);

            saveButton.Font = new Font(saveButton.Font.FontFamily,
                this.Width / 80);
            clearAll.Font = new Font(clearAll.Font.FontFamily,
                this.Width / 80);






            // Same size for controls
            rI2.Size = aOILabel.Size;
            rI1.Size = aOILabel.Size;
            aOI.Size = aOILabel.Size;
            qName.Size = aOILabel.Size;



            // Adds some padding
            aOILabel.Padding = new Padding(0, this.Height / 25, 0, 0);
            rI1Label.Padding = new Padding(0, this.Height / 25, 0, 0);
            rI2Label.Padding = new Padding(0, this.Height / 25, 0, 0);
            saveButton.Margin = new Padding(0, this.Height / 40, 0, 0);
            clearAll.Margin = new Padding(0, this.Height / 40, 0, 0);

        }

        private void refractionBuilder_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            // Sets the form text as the version num defined by the class
            // TitleVersion
            this.Text = systemWideVariables.titleVersion;

            refreshControls();


            this.Opacity = 0;

            fadeIn.Enabled = true;


            // For light mode
            if(systemWideVariables.lightTheme)
            {
                bArrow.BackgroundImage = Properties.Resources.lightBackArrow;
                bArrow.BackColor = Color.White;
                this.BackColor = Color.White;
                qNameLabel.ForeColor = Color.Black;
                qNameLabel.BackColor = Color.White;
                qName.ForeColor = Color.White;
                qName.BackColor = Color.Black;
                aOILabel.ForeColor = Color.Black;
                aOILabel.BackColor = Color.White;
                aOI.ForeColor = Color.White;
                aOI.BackColor = Color.Black;
                rI1Label.ForeColor = Color.Black;
                rI1Label.BackColor = Color.White;
                rI1.ForeColor = Color.White;
                rI1.BackColor = Color.Black;
                rI2Label.ForeColor = Color.Black;
                rI2Label.BackColor = Color.White;
                rI2.ForeColor = Color.White;
                rI2.BackColor = Color.Black;
                saveButton.ForeColor = Color.White;
                saveButton.BackColor = Color.Black;
                clearAll.ForeColor = Color.White;
                clearAll.BackColor = Color.Black;


            }

        }

        private void bArrow_Click(object sender, EventArgs e)
        {
            this.Refresh();

            fadeOut.Enabled = true;
        }

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
            tableLayoutPanel1.Refresh();
            if (this.Opacity > 0)
            {
                tableLayoutPanel1.Refresh();
                this.Opacity -= 0.1;
              

            }
            else
            {
                
                this.Close();
            }
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

        private void qNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            //DrawLines(e.Graphics);
        }

        private void aOILabel_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            // If it is [1,1] then the bg of it will change to the right colour
            if (e.Column == 2 && e.Row == 2)
            {
                if (systemWideVariables.lightTheme == true)
                {
                   // e.Graphics.FillRectangle(new SolidBrush(Color.Black), e.CellBounds);
                }
                else { /* e.Graphics.FillRectangle(new SolidBrush(Color.White), e.CellBounds); */ }

            }


        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //update the text during the saving proccess
            saveButton.Text = "Saving...";
            vgf.Enabled = true; // fix for the lines

            // calls the timer for the logic
            saveSwitch.Enabled = true;   

        }



        private void clearAll_Click(object sender, EventArgs e)
        {
            clearAll.Text = "Clearing...";
            vgf.Enabled = true;
            clearSwitch.Enabled = true;
     
        }

        private void aOI_KeyPress(object sender, KeyPressEventArgs e)
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

        private void rI1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void rI2_KeyPress(object sender, KeyPressEventArgs e)
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

        // Sets up the vertical line
        private float vertDrawPoint = 0;
        // Sets up the horizontal line 
        private float horzDrawPoint = 0;

        private void linesAnimate_Tick(object sender, EventArgs e)
        {
            if (systemWideVariables.powerSave)
            {
                // incomplete need to fix
                vertDrawPoint = this.Height - 1;
                horzDrawPoint = this.Width - 1;
            }
            if (vertDrawPoint < this.Height   || horzDrawPoint < this.Width)
            {
                // calls the draw method to draw lines as per the pattern
                Graphics g = tableLayoutPanel1.CreateGraphics();
                DrawLines(g);
                g.Dispose();
                vertDrawPoint += this.Height / 100 * 3;
                horzDrawPoint += this.Width / 100 * 3;
            }
            else
            { // draws final lines and resets vars and disables timer
                vertDrawPoint = this.Height -1;
                horzDrawPoint = this.Width -1;
                Graphics g = tableLayoutPanel1.CreateGraphics();
                DrawLines(g); 
                g.Dispose();


                vertDrawPoint = 0;
                horzDrawPoint = 0;
                linesAnimate.Enabled = false; 
            }   
        }

        private void vgf_Tick(object sender, EventArgs e)
        {
            vertDrawPoint = 0;
            horzDrawPoint = 0;
            linesAnimate.Enabled = true;
            vgf.Enabled = false;
        }

        private void saveSwitch_Tick(object sender, EventArgs e)
        {
            if (saveButton.Text == "Saving...")
            {
                // Calcs the aoR to ensure that it can be done
                try
                {
                    double angleI = Convert.ToDouble(aOI.Text)
                            * Math.PI / 180;
                    double angleRad;
                    if (angleI != Math.PI / 2)
                    {
                        angleRad = Math.Asin((Math.Sin(angleI) *
                            Convert.ToDouble(rI1.Text) /
                            Convert.ToDouble(rI2.Text)));


                    }
                    else { angleRad = Math.PI / 2; }



                    // Validation
                    if (double.TryParse(aOI.Text, out double _)
                        && double.TryParse(rI1.Text, out double _)
                        && double.TryParse(rI2.Text, out double _)
                        && Convert.ToDouble(aOI.Text) <= 90
                        && Convert.ToDouble(aOI.Text) >= 0
                        && Convert.ToDouble(rI1.Text) >= 1
                        && Convert.ToDouble(rI1.Text) <= 2.65
                        && Convert.ToDouble(rI2.Text) >= 1
                        && Convert.ToDouble(rI2.Text) <= 2.65
                        )
                    {
                        using (StreamWriter outputFile = new StreamWriter(Path.Combine("refractionQuestions.txt"), true))
                        {
                            outputFile.WriteLine(qName.Text + "," + aOI.Text + "," + rI1.Text + "," + rI2.Text);

                            qName.Text = "";
                            aOI.Text = "";
                            rI1.Text = "";
                            rI2.Text = "";

                            saveButton.Text = "Saved!";

                        }
                    }

                    else { saveButton.Text = "Error! Invalid parameter(s)"; }

                }

                catch
                {
                    saveButton.Text = "Error!";
                }

                vgf.Enabled = true;
            }
            else
            {
                vgf.Enabled = true;

                saveButton.Text = "Save";
                refreshControls();
                saveSwitch.Enabled = false;
            }
        }

        private void clearSwitch_Tick(object sender, EventArgs e)
        {
            if (clearAll.Text == "Clear all questions")
            {
                File.Delete("refractionQuestions.txt");
                clearAll.Text = "Cleared all questions";
                vgf.Enabled = true;
            }
            else
            {
                clearAll.Text = "Clear all questions";
                refreshControls();
                vgf.Enabled = true;
                clearSwitch.Enabled = false;
            }

           
        }

        private void linesAnimateLeave_Tick(object sender, EventArgs e)
        {
            if (systemWideVariables.powerSave)
            {
                // incomplete need to fix
                vertDrawPoint = this.Height - 1;
                horzDrawPoint = this.Width - 1;
            }
            if (vertDrawPoint < this.Height || horzDrawPoint < this.Width)
            {
                // calls the draw method to draw lines as per the pattern
                Graphics g = tableLayoutPanel1.CreateGraphics();
                DrawLinesLeave(g);
                g.Dispose();
                vertDrawPoint += this.Height / 100 * 3;
                horzDrawPoint += this.Width / 100 * 3;
            }
            else
            { // draws final lines and resets vars and disables timer
                vertDrawPoint = this.Height - 1;
                horzDrawPoint = this.Width - 1;
                Graphics g = tableLayoutPanel1.CreateGraphics();
                DrawLinesLeave(g);
                g.Flush();
                g.Dispose();

                vertDrawPoint = 0;
                horzDrawPoint = 0;
                fadeOut.Enabled = true;
                linesAnimate.Enabled = false;
            }

        }
    }
}
