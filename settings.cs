using Physics_Simulation.Properties;
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
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }


        private void settings_Load(object sender, EventArgs e)
        {
            // Sets the size
            this.Size = new Size(200, 200);
            // Sets the form text as the version num defined by the class
            // TitleVersion
            this.Text = TitleVersion.titleVersion;

            // Changes form elements based on what theme is set

            if (LightTheme.lightTheme == true)
            {
                theme.BackColor = Color.White;
                theme.ForeColor = Color.Black;
                this.BackColor = Color.White;
                placeholder.ForeColor = Color.Black;
               
            }

            // If dark theme is on start the winform with that setting checked
            if (LightTheme.lightTheme == false)
            {
                // Deattaches then reattaches the event handler to stop it from
                // triggering when the change is made
                theme.CheckedChanged -= theme_CheckedChanged;
                theme.Checked = true;
                theme.CheckedChanged += theme_CheckedChanged;
            }
            
        }

        private void theme_Click(object sender, EventArgs e)
        { 
        }

        private void theme_CheckedChanged(object sender, EventArgs e)
        {
            // If the checked status changes, change the theme status
            if (LightTheme.lightTheme == true)
            {
                LightTheme.lightTheme = false;
            }
            else
            {
                LightTheme.lightTheme = true;
            }
            Application.Restart();
        }
    }
}
