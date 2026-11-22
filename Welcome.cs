using Physics_Simulation.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Physics_Simulation
{
    public partial class welcomeScreen : Form

    {

        public welcomeScreen()
        {
            InitializeComponent();

            this.DoubleBuffered = true;

            // Sets the opactiy to 0 for the fade in animation
            this.Opacity = 0;

            // Disables annoying windows sounds
            this.AcceptButton = null;
        }

        // Used for all winforms so made public
        public class systemWideVariables
        {
            public static string titleVersion = "V1.2.0";
            public static string whichSim = "";
            public static bool isRandom = true;
            public static bool powerSave = Settings.Default.powerSave;
        }

        private int initY;
        private void getInitY()
        {
            initY = this.DesktopLocation.Y;
        }


        private void leavingAnimation()
        {
            bArrow.Enabled = false;

            // only triggers if powersave is disabled
            if (systemWideVariables.powerSave == false)
            {

                getInitY();
                int x = this.DesktopLocation.X;
                int y = this.DesktopLocation.Y;
                int count = 5;
                while (y < (this.Height * 1))
                {
                    this.Opacity -= 0.05; // Gradually decrease opacity for fade effect
                    this.Location = new Point(x, y);
                    y = y + count;
                    Thread.Sleep(1);
                    count++;

                }

            }

            this.Hide();

        }

        private async Task showingAnimation()
        {

            this.Opacity = 0; // Start with fully transparent

            this.Show();
            this.Refresh();
            // Forces the initial frame to paint before sliding

            if (!systemWideVariables.powerSave)
            {
                int x = this.DesktopLocation.X;
                int y = this.DesktopLocation.Y;
                this.Location = new Point(x, initY);

                int count = 60 - initY / 20; // Calculate the step size based on the initial Y position


                fadeIn.Enabled = true;
                bArrow.Enabled = true;

            }
        }



        private void button1_Click(object sender, EventArgs e) // Refraction
        {
            refractionInteract.BackColor = Color.White;

            // Sets the var to tell the program which forms need to be loaded
            systemWideVariables.whichSim = "refraction";



            leavingAnimation();

            // Creates an instance of the refraction form when
            // the button is pressed
            if (refractionInteract.Text == "Interactive Mode")
            {
                rInteract RInteract = new rInteract();
                RInteract.ShowDialog();
            }
            else if (refractionInteract.Text == "Quick Play")
            {
                systemWideVariables.isRandom = true;
                refractionQuestions RQuestions = new refractionQuestions();
                RQuestions.ShowDialog();
            }
            else
            {
                systemWideVariables.isRandom = false;
                refractionQuestions RQuestions = new refractionQuestions();
                RQuestions.ShowDialog();
            }


            showingAnimation();




        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void updateTheme()
        {


            // if power save is on or not
            if (systemWideVariables.powerSave)
            {
                energySaver.BackColor = Color.Red;
                energySaver.FlatStyle = FlatStyle.Standard;

            }

        }

        private void welcomeScreen_Load(object sender, EventArgs e)
        {


            bArrow.Height -= 20;
            bArrow.Height -= 20;

            theme.FlatAppearance.BorderSize = 0;
            energySaver.FlatAppearance.BorderSize = 0;
            energySaver.FlatAppearance.MouseOverBackColor = Color.Blue;



            // Sets the form text as the version num defined by the class attribute
            // TitleVersion
            this.Text = systemWideVariables.titleVersion;

            // Sets the right theme
            updateTheme();

            // Triggers the fade in animation
            fadeIn.Enabled = true;

            // Chnages font to a nicer one for both buttons
            wTxt.Font = new Font("Microsoft Sans Serif", 21, FontStyle.Bold);
            refractionInteract.Font = new Font("Microsoft Sans Serif", 20);


            // Keeps sizing consistant
            refractionInteract.Height = Convert.ToInt32(wTxt.Height / 1.5);
            refractionInteract.Width = Convert.ToInt32(wTxt.Width / 1.5);

            questions.Size = refractionInteract.Size;
            refractionInteract.Height = questions.Height;



            // Adds small amount of padding to the welcome text.

            wTxt.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);

            // Enables screen animation if power save is off
            if (systemWideVariables.powerSave == false)
            {
            }




        }

        // For fade in animation
        private void fadeIn_Tick(object sender, EventArgs e)
        {
            // Gradually increase the form's opacity
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

        private void waves_Click(object sender, EventArgs e)
        {

        }

        private void refraction_MouseEnter(object sender, EventArgs e)
        {
            refractionInteract.BackColor = Color.Blue;
            refractionInteract.ForeColor = Color.White;
        }

        private void refraction_MouseLeave(object sender, EventArgs e)
        {

            refractionInteract.BackColor = Color.White;
            refractionInteract.ForeColor = Color.Black;
            wTxt.ForeColor = Color.White;


        }

        private void waves_MouseEnter(object sender, EventArgs e)
        {

        }

        private void waves_MouseLeave(object sender, EventArgs e)
        {

        }

        private void refraction_MouseDown(object sender, MouseEventArgs e)
        {
            wTxt.ForeColor = Color.Blue;
        }

        private void waves_MouseDown(object sender, MouseEventArgs e)
        {
            wTxt.ForeColor = Color.OrangeRed;
        }

        private void welcomeScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Not used anymore
            Settings.Default.powerSave = systemWideVariables.powerSave;
            Settings.Default.Save();
            Application.Exit();
        }

        private void wTxt_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void themePrompt_Tick(object sender, EventArgs e)
        {
            string defaultText = "Physics Simulations!";
            if (wTxt.Text == defaultText)
            {
                wTxt.Text = "Waves is currently unavailable";
            }
            else
            {
                wTxt.Text = defaultText;
            }
        }

        private void settings_Click(object sender, EventArgs e)
        {

            // Applies changes
            updateTheme();


        }

        private void settings_MouseEnter(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void theme_MouseDown(object sender, MouseEventArgs e)
        {


        }

        private void theme_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void cMove_Tick(object sender, EventArgs e)
        {

        }

        private void energySaver_Click(object sender, EventArgs e)
        {

            // Updates the global attribute by swapping value
            if (systemWideVariables.powerSave == true)
            {
                systemWideVariables.powerSave = false;

                energySaver.FlatStyle = FlatStyle.Flat;

                energySaver.BackColor = Color.Transparent;

            }
            else
            {
                systemWideVariables.powerSave = true;

                energySaver.FlatStyle = FlatStyle.Standard;

                energySaver.BackColor = Color.Red;

            }


        }

        private void themeTip_Popup(object sender, PopupEventArgs e)
        {

        }

        private void questions_Click(object sender, EventArgs e)
        {
            if (questions.Text == "   Questions   ")
            {
                refractionInteract.Text = "Quick Play";
                questions.Text = "Custom";
            }
            else if (questions.Text == "Custom")
            {
                refractionInteract.Text = "Play Custom";
                questions.Text = "Build questions";

            }
            else
            {
                refractionBuilder refractionBuilder = new refractionBuilder();
                refractionBuilder.ShowDialog();
            }

        }

        private void questions_MouseEnter(object sender, EventArgs e)
        {
            questions.BackColor = Color.Blue;
            questions.ForeColor = Color.White;
        }

        private void questions_MouseLeave(object sender, EventArgs e)
        {
            questions.BackColor = Color.White;
            questions.ForeColor = Color.Black;
        }

        private void bArrow_Click(object sender, EventArgs e)
        {

            if (refractionInteract.Text == "Quick Play")
            {
                refractionInteract.Text = "Interactive Mode";
                questions.Text = "   Questions   ";
            }
            else if (refractionInteract.Text == "Play Custom")
            {
                refractionInteract.Text = "Quick Play";
                questions.Text = "Custom";
            }
            else
            {
                this.Close();
            }




        }

        private void bArrow_MouseEnter(object sender, EventArgs e)
        {
            bArrowSizeUp.Enabled = true;
        }

        private void bArrowSize_Popup(object sender, PopupEventArgs e)
        {


        }



        int countBArrow = 10;
        private void bArrowSize_Tick(object sender, EventArgs e)
        {


            if (countBArrow >= 0)
            {
                bArrow.Height++;
                bArrow.Width++;
                countBArrow--;
            }

            else
            {
                countBArrow = 10;
                bArrowSizeUp.Enabled = false;
            }


        }

        private void bArrow_MouseLeave(object sender, EventArgs e)
        {
            bArrowSizeDown.Enabled = true;
        }

        private void bArrowSIzeDown_Tick(object sender, EventArgs e)
        {
            bArrow.BorderStyle = BorderStyle.None;


            if (countBArrow >= 0)
            {
                bArrow.Height--;
                bArrow.Width--;
                countBArrow--;
            }

            else
            {
                countBArrow = 10;
                bArrowSizeDown.Enabled = false;
            }

        }


        int questionsHeight = 4;
        private void QuestionsExpand_Tick(object sender, EventArgs e)
        {

        }

        private void QuestionsCollapse_Tick(object sender, EventArgs e)
        {

        }

        private void bArrow_MouseDown(object sender, MouseEventArgs e)
        {
            bArrow.BorderStyle = BorderStyle.FixedSingle;
        }

        private void bArrow_MouseUp(object sender, MouseEventArgs e)
        {
            bArrow.BorderStyle = BorderStyle.None;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (wTxt.Text == "Refraction Simulation")
            {
                wTxt.Text = "Interactive mode redesign now available";
            }
            else
            {
                wTxt.Text = "Refraction Simulation";
            }
        }
    }
}
