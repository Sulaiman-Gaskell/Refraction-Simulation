using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Physics_Simulation.welcomeScreen;

namespace Physics_Simulation
{
    public partial class wavesBuilder : Form
    {
        public wavesBuilder()
        {
            InitializeComponent();
        }

        private void wavesBuilder_Load(object sender, EventArgs e)
        {
            this.Text = systemWideVariables.titleVersion;

            this.Opacity = 0;

            fadeIn.Enabled = true;

            // for light mode
            if (systemWideVariables.lightTheme)
            {
                this.BackColor = Color.White;
                bArrow.BackgroundImage = Properties.Resources.lightBackArrow;
                bArrow.BackColor = Color.White;
                qNameLabel.ForeColor = Color.Black;
                qNameLabel.BackColor = Color.White;
                qName.ForeColor = Color.White;
                qName.BackColor = Color.Black;
                frequencyLabel.ForeColor = Color.Black;
                frequencyLabel.BackColor = Color.White;
                frequency.ForeColor = Color.White;
                frequency.BackColor = Color.Black;
                wSpeedLabel.ForeColor = Color.Black;
                wSpeedLabel.BackColor = Color.White;
                waveSpeed.ForeColor = Color.White;
                waveSpeed.BackColor = Color.Black;
                saveButton.ForeColor = Color.White;
                saveButton.BackColor = Color.Black;
                clearAll.ForeColor = Color.White;
                clearAll.BackColor = Color.Black;
            }

                // Sizes controls on the screen

                qNameLabel.Font = new Font(qNameLabel.Font.FontFamily,
                    this.Width / 80);
                qName.Font = new Font(qName.Font.FontFamily,
                    this.Width / 80);

                frequencyLabel.Font = new Font(frequencyLabel.Font.FontFamily,
                 this.Width / 80);
                frequency.Font = new Font(frequency.Font.FontFamily,
                    this.Width / 80);

                wSpeedLabel.Font = new Font(wSpeedLabel.Font.FontFamily,
                      this.Width / 80);
                waveSpeed.Font = new Font(waveSpeed.Font.FontFamily,
                    this.Width / 80);

                saveButton.Font = new Font(saveButton.Font.FontFamily,
                    this.Width / 80);
                clearAll.Font = new Font(clearAll.Font.FontFamily,
                    this.Width / 80);

                // same size for all controls
                saveButton.Size = clearAll.Size;
                frequency.Size = wSpeedLabel.Size;
                waveSpeed.Size = wSpeedLabel.Size;
                qName.Size = wSpeedLabel.Size;


                // Adds some padding
                qNameLabel.Padding = new Padding(0, this.Height / 6, 0, 0);
            frequencyLabel.Padding = new Padding(0, this.Height / 25, 0, 0);
            wSpeedLabel.Padding = new Padding(0, this.Height / 25, 0, 0);
       


            
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frequency_KeyPress(object sender, KeyPressEventArgs e)
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

        private void clearAll_Click(object sender, EventArgs e)
        {
            File.Delete("wavesQuestions.txt");
            clearAll.Text = "Cleared all questions";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                double waveLength = Convert.ToDouble(waveSpeed.Text) / Convert.ToDouble(frequency.Text);

                using (StreamWriter outputFile = new StreamWriter(Path.Combine("wavesQuestions.txt"), true))
                {

                    // writing wavelength too as this equation has no fixed resultant parameter
                    outputFile.WriteLine(qName.Text + "," + frequency.Text + "," + waveSpeed.Text + "," + Convert.ToString(waveLength));

                    qName.Text = "";
                    frequency.Text = "";
                    waveSpeed.Text = "";

               
                }
            }
            catch 
            {
                saveButton.Text = "Error!";
            }
        }
    }
}
