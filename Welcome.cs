using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Physics_Simulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Refraction
        {
            // Hides the Welcome Form (Form1)
            this.Hide();

            // Creates an instance of the refraction form when
            // the button is pressed
            Refraction refraction = new Refraction();
            refraction.ShowDialog();

            // When the refaction instance is closed by the user
            // the Welcome menu will open again
            this.Show();
        }
    }
}
