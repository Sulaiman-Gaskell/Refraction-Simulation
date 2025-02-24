# Project Code 
## /optionsMenu.cs 

```csharp
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Physics_Simulation.welcomeScreen;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Physics_Simulation
{
    public partial class optionsMenu : Form
    {
        public optionsMenu()
        {
            InitializeComponent();

            // Maximises the window and removes the top bar
            this.WindowState = FormWindowState.Maximized;
       

            // Disables annoying windows sounds
            this.AcceptButton = null;
            

        }

        private void Refraction_Load(object sender, EventArgs e)
        {


            // Only enables if powersave is off
            if (systemWideVariables.powerSave == false)
            {
                animateObjects.Enabled = true;
            }
            else
            {
                // Otherwis sets the text
                menuText.Text = "Choose a mode:";
            }
            
            // For light theme
            if (systemWideVariables.lightTheme == true)
            {
                this.BackColor = Color.White;
                interact.BackColor = Color.Black;
                interact.ForeColor = Color.White;
                questions.BackColor = Color.Black;
                questions.ForeColor = Color.White;
                menuText.ForeColor = Color.Black;
                bArrow.BackgroundImage = Properties.Resources.lightBackArrow;
                bArrow.BackColor = Color.White;

                // new in beta testing
                simulationType.ForeColor = Color.Black;
                
            }
            // Sets the form text as the version num defined by the class
            // TitleVersion
            this.Text = systemWideVariables.titleVersion;
         
       
            // Makes the form full screen
            this.WindowState = FormWindowState.Maximized;

            // for fade in effect
            // Set the form's initial opacity to 0 (completely transparent)
            this.Opacity = 0;

            // Start the fade to animate the form
            fadeIn.Enabled = true;

            // Puts the back arrow in the top left hand corner
            bArrow.Location = new Point(0, 0);

            // Sets font size for text based on clients resolution
            menuText.Font = new Font(menuText.Font.FontFamily,
                this.Width / 30);

            simulationType.Font = new Font(simulationType.Font.FontFamily,
                this.Width / 50);

            if (systemWideVariables.whichSim == "refraction")
            {
                simulationType.Text = "Refraction";
            }
            else
            {
                simulationType.Text = "Waves";
            }



            interact.Font = new Font(interact.Font.FontFamily,
                this.Width / 30);
            questions.Font = new Font(questions.Font.FontFamily,
                this.Width / 30);

            // Sizes the back arrow
            bArrow.Size = new Size(this.Height / 10, this.Height / 10);


  

        }


        private void Refraction_Resize(object sender, EventArgs e)
        {
        }

        private void refractionMenu_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e) // interactive button
        {

            // Opens the right widnow based on what options are being displayed and keeps this open 

            if (interact.Text == "Interactive")
            {
                if (systemWideVariables.whichSim == "refraction")
                {
                    
                    rInteract rInteract = new rInteract();
                    rInteract.ShowDialog();
               
                




                }
                else
                {
                    wInteract wInteract = new wInteract();
                    wInteract.ShowDialog();
                }
            }
            else if (interact.Text == "Random")
            {
                systemWideVariables.isRandom = true;

                if (systemWideVariables.whichSim == "refraction")
                {

                    refractionQuestions refractionQQuestions = new refractionQuestions();

                    refractionQQuestions.ShowDialog();
                }
                else
                {
                    wavesQuestions wavesQQuestions = new wavesQuestions();
                    wavesQQuestions.ShowDialog();
                }

            }
            else if (interact.Text == "Play")
            {
                systemWideVariables.isRandom = false;

                if (systemWideVariables.whichSim == "refraction")
                {
                    
                    refractionQuestions refractionQuestions = new refractionQuestions();
                    refractionQuestions.ShowDialog();
                }

                else
                {
                    wavesQuestions wavesQuestions = new wavesQuestions();
                     wavesQuestions.ShowDialog();

                }


            }



            if (systemWideVariables.lightTheme == true)
            {
                menuText.ForeColor = Color.Black;
            }
            else { menuText.ForeColor = Color.White; }

        }

        private void menuText_Click(object sender, EventArgs e)
        {
        }



        // For fade in animation
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

        }

        private void fadeOut_Tick_1(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.2;
            }
            else
            {
                this.Close();
            }
        }

        private void menuText_Click_1(object sender, EventArgs e)
        {

        }

        
        // For menuText animation and fontsize initally growing
        private int tickCount = 0;
        private bool menuTextAnimate = true;
        private void menuTextGrow_Tick(object sender, EventArgs e)
        {
            string label = "Choose a mode:";
        
            if (tickCount <= label.Length)
            {
                // Only triggers once
                if (menuTextAnimate == true)
                {
                    simulationType.Font = new Font(simulationType.Font.FontFamily,
                        ClientSize.Width / (tickCount + 36));

                    menuText.Text = label.Substring(0, tickCount);

                    // so it doesnt trigger again
                    if (tickCount == label.Length)
                    {
                        menuTextAnimate = false;
                    }
                }

                interact.Font = new Font(interact.Font.FontFamily,
                ClientSize.Width / (tickCount + 16));
                questions.Font = new Font(questions.Font.FontFamily,
                ClientSize.Width / (tickCount + 16));

                tickCount++;
            }
            else
            {
                tickCount = 0;
                interact.Enabled = true;
                questions.Enabled = true;
                animateObjects.Enabled = false;
            }



        }

        // ALL BELOW FOR ANIMATIONS
        private void interact_MouseDown(object sender, MouseEventArgs e)
        {
            menuText.ForeColor = Color.LightSkyBlue;

            if (systemWideVariables.powerSave == false)
            {
                interact.Font = new Font(interact.Font.FontFamily,
                    ClientSize.Width / 35);
            }
        }

        private void interact_MouseLeave(object sender, EventArgs e)
        {
            if (systemWideVariables.lightTheme == true)
            {
                menuText.ForeColor = Color.Black;
                interact.BackColor = Color.Black;
            }
            else
            {
                menuText.ForeColor = Color.White;
                interact.BackColor = Color.White;
            }

            if (systemWideVariables.powerSave == false)
            {
                popInInteract.Enabled = true;
            }
        }

        private void questions_MouseDown(object sender, MouseEventArgs e)
        {
            if (systemWideVariables.powerSave == false)
            {
                questions.Font = new Font(questions.Font.FontFamily,
                     ClientSize.Width / 35);
            }

            menuText.ForeColor = Color.Coral;

        }

        private void questions_MouseLeave(object sender, EventArgs e)
        {
            if (systemWideVariables.lightTheme == true)
            {
                menuText.ForeColor = Color.Black;
                questions.BackColor = Color.Black;
            }
            else
            {
                menuText.ForeColor = Color.White;
                questions.BackColor = Color.White;
            }

            if (systemWideVariables.powerSave == false)
            {
                popInQuestions.Enabled = true;
            }
        }

        // Useless
        private void interact_MouseHover(object sender, EventArgs e)
        {
        }

        // Useless
        private void questions_MouseHover(object sender, EventArgs e)
        {
        }



        private void interact_MouseEnter(object sender, EventArgs e)
        {
            interact.BackColor = Color.Blue;

            if (systemWideVariables.powerSave == false)
            {
                popOutInteract.Enabled = true;
            }
        }

        private void questions_MouseEnter(object sender, EventArgs e)
        {
            questions.BackColor = Color.OrangeRed;

            if (systemWideVariables.powerSave == false)
            {
                popOutQuestions.Enabled = true;
            }
        }




        // Animates the interact text
        // Slowely increases the font size
        private int popOutSize = 29;
        private void popOutInteract_Tick(object sender, EventArgs e)
        {
            if (popOutSize >= 25)
            {
                interact.Font = new Font(interact.Font.FontFamily,
                ClientSize.Width / popOutSize);
                popOutSize--;
                
            }
            else
            {
                popOutSize = 29;
                popOutInteract.Enabled = false;
            }
        
        }

        // Slowely decreases the font size when the mouse leaves the interact box
        private int popInSize = 25;
        private void popInInteract_Tick(object sender, EventArgs e)
        {
            if (popInSize <= 30)
            {
                interact.Font = new Font(interact.Font.FontFamily,
                ClientSize.Width / popInSize);
                popInSize++;

            }
            else
            {
                popInSize = 25;
                popInInteract.Enabled = false;
            }

        }

        // Slowely increases the font size of the questions mode when hovering over it
        private void popOutQuestions_Tick(object sender, EventArgs e)
        {
            if (popOutSize >= 25)
            {
                questions.Font = new Font(questions.Font.FontFamily,
                ClientSize.Width / popOutSize);
                popOutSize--;

            }
            else
            {
                popOutSize = 29;
                popOutQuestions.Enabled = false;
            }
        }

        // Slowely decreases the font size and changes the text back to questions
        private void popInQuestions_Tick(object sender, EventArgs e)
        {
            if (popInSize <= 30)
            {
                questions.Font = new Font(questions.Font.FontFamily,
                ClientSize.Width / popInSize);
                popInSize++;

            }
            else
            {
                popInSize = 25;
                popInQuestions.Enabled = false;
            }
        }

        private void refractionMenu_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            // Remove after write up
            //if ((e.Row == 2 | e.Row == 1) && e.Column == 1)
            //{
                //if (systemWideVariables.lightTheme == true)
                //{
                   // e.Graphics.FillRectangle(new SolidBrush(Color.Black), e.CellBounds);
                //}
                //else
               // {
                    //e.Graphics.FillRectangle(new SolidBrush(Color.White), e.CellBounds);
                //}

            //}
        }

        private void bArrow_Click_1(object sender, EventArgs e)
        {
            if (questions.Text == "Questions")
            {
                // Calls the fadeOut timer
               fadeOut.Enabled = true;
            }
            else if (questions.Text == "Player Made")
            {
                interact.Text = "Interactive";
                questions.Text = "Questions";

                if (systemWideVariables.powerSave == false)
                {
                    animateObjects.Enabled = true;
                }
            }
            else if (questions.Text == "Create")
            {
                interact.Text = "Random";
                questions.Text = "Player Made";

                if (systemWideVariables.powerSave == false)
                {
                    animateObjects.Enabled = true;
                }
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

        private void questions_Click(object sender, EventArgs e)
        {
            // Logic for whether to present the user with more options or to open a new form
            if (questions.Text == "Questions")
            {
                interact.Text = "Random";
                questions.Text = "Player Made";

                if (systemWideVariables.powerSave == false)
                {
                    animateObjects.Enabled = true;
                }
            }
            else if (questions.Text == "Player Made")
            {
                interact.Text = "Play";
                questions.Text = "Create";

                if (systemWideVariables.powerSave == false)
                {
                    animateObjects.Enabled = true;
                }
            }
            else if (questions.Text == "Create")
            {
                if (systemWideVariables.whichSim == "refraction")
                {
                 
                    refractionBuilder refractionBuilder = new refractionBuilder();
                    refractionBuilder.ShowDialog();
                   
           
                }

                else
                {
                    wavesBuilder wavesBuilder = new wavesBuilder();
                    wavesBuilder.ShowDialog();
            
                }
            }
            
        }

        private void optionsMenu_SizeChanged(object sender, EventArgs e)
        {

            try
            {
                // Updates the size of controls if the window changes
                // Sets font size for text based on clients resolution
                menuText.Font = new Font(menuText.Font.FontFamily,
                    this.Width / 30);



                interact.Font = new Font(interact.Font.FontFamily,
                    this.Width / 30);
                questions.Font = new Font(questions.Font.FontFamily,
                    this.Width / 30);

                // Sizes the back arrow
                bArrow.Size = new Size(this.Height / 10, this.Height / 10);
            }
            catch  { }
        }
        
    }


}

```

## /optionsMenu.Designer.cs 

```csharp
﻿namespace Physics_Simulation
{
    partial class optionsMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(optionsMenu));
            this.refractionMenu = new System.Windows.Forms.TableLayoutPanel();
            this.bArrow = new System.Windows.Forms.PictureBox();
            this.interact = new System.Windows.Forms.Button();
            this.questions = new System.Windows.Forms.Button();
            this.menuText = new System.Windows.Forms.Label();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fadeIn = new System.Windows.Forms.Timer(this.components);
            this.fadeOut = new System.Windows.Forms.Timer(this.components);
            this.animateObjects = new System.Windows.Forms.Timer(this.components);
            this.popOutInteract = new System.Windows.Forms.Timer(this.components);
            this.popInInteract = new System.Windows.Forms.Timer(this.components);
            this.popOutQuestions = new System.Windows.Forms.Timer(this.components);
            this.popInQuestions = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.simulationType = new System.Windows.Forms.Label();
            this.refractionMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // refractionMenu
            // 
            this.refractionMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refractionMenu.ColumnCount = 3;
            this.refractionMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.refractionMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.refractionMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.refractionMenu.Controls.Add(this.bArrow, 0, 0);
            this.refractionMenu.Controls.Add(this.interact, 1, 1);
            this.refractionMenu.Controls.Add(this.questions, 1, 2);
            this.refractionMenu.Controls.Add(this.menuText, 1, 0);
            this.refractionMenu.Controls.Add(this.simulationType, 2, 3);
            this.refractionMenu.Cursor = System.Windows.Forms.Cursors.Default;
            this.refractionMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.refractionMenu.Location = new System.Drawing.Point(0, 0);
            this.refractionMenu.Name = "refractionMenu";
            this.refractionMenu.RowCount = 4;
            this.refractionMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.refractionMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.refractionMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.refractionMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.refractionMenu.Size = new System.Drawing.Size(800, 450);
            this.refractionMenu.TabIndex = 0;
            this.refractionMenu.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.refractionMenu_CellPaint);
            this.refractionMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.refractionMenu_Paint);
            // 
            // bArrow
            // 
            this.bArrow.BackColor = System.Drawing.SystemColors.ControlText;
            this.bArrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bArrow.BackgroundImage")));
            this.bArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bArrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bArrow.Location = new System.Drawing.Point(2, 3);
            this.bArrow.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bArrow.Name = "bArrow";
            this.bArrow.Size = new System.Drawing.Size(75, 83);
            this.bArrow.TabIndex = 6;
            this.bArrow.TabStop = false;
            this.bArrow.Click += new System.EventHandler(this.bArrow_Click_1);
            this.bArrow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bArrow_MouseDown);
            this.bArrow.MouseEnter += new System.EventHandler(this.bArrow_MouseEnter);
            this.bArrow.MouseLeave += new System.EventHandler(this.bArrow_MouseLeave);
            // 
            // interact
            // 
            this.interact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.interact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.interact.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.interact.Location = new System.Drawing.Point(203, 93);
            this.interact.Name = "interact";
            this.interact.Size = new System.Drawing.Size(394, 129);
            this.interact.TabIndex = 0;
            this.interact.Text = "Interactive";
            this.interact.UseVisualStyleBackColor = true;
            this.interact.Click += new System.EventHandler(this.button1_Click);
            this.interact.MouseDown += new System.Windows.Forms.MouseEventHandler(this.interact_MouseDown);
            this.interact.MouseEnter += new System.EventHandler(this.interact_MouseEnter);
            this.interact.MouseLeave += new System.EventHandler(this.interact_MouseLeave);
            this.interact.MouseHover += new System.EventHandler(this.interact_MouseHover);
            // 
            // questions
            // 
            this.questions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.questions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.questions.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.questions.Location = new System.Drawing.Point(203, 228);
            this.questions.Name = "questions";
            this.questions.Size = new System.Drawing.Size(394, 129);
            this.questions.TabIndex = 2;
            this.questions.Text = "Questions";
            this.questions.UseVisualStyleBackColor = true;
            this.questions.Click += new System.EventHandler(this.questions_Click);
            this.questions.MouseDown += new System.Windows.Forms.MouseEventHandler(this.questions_MouseDown);
            this.questions.MouseEnter += new System.EventHandler(this.questions_MouseEnter);
            this.questions.MouseLeave += new System.EventHandler(this.questions_MouseLeave);
            this.questions.MouseHover += new System.EventHandler(this.questions_MouseHover);
            // 
            // menuText
            // 
            this.menuText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menuText.AutoSize = true;
            this.menuText.Location = new System.Drawing.Point(400, 0);
            this.menuText.Name = "menuText";
            this.menuText.Size = new System.Drawing.Size(0, 16);
            this.menuText.TabIndex = 3;
            this.menuText.Click += new System.EventHandler(this.menuText_Click_1);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 24);
            // 
            // fadeIn
            // 
            this.fadeIn.Enabled = true;
            this.fadeIn.Interval = 1;
            this.fadeIn.Tick += new System.EventHandler(this.fadeIn_Tick);
            // 
            // fadeOut
            // 
            this.fadeOut.Interval = 1;
            this.fadeOut.Tick += new System.EventHandler(this.fadeOut_Tick_1);
            // 
            // animateObjects
            // 
            this.animateObjects.Interval = 13;
            this.animateObjects.Tick += new System.EventHandler(this.menuTextGrow_Tick);
            // 
            // popOutInteract
            // 
            this.popOutInteract.Interval = 13;
            this.popOutInteract.Tick += new System.EventHandler(this.popOutInteract_Tick);
            // 
            // popInInteract
            // 
            this.popInInteract.Interval = 13;
            this.popInInteract.Tick += new System.EventHandler(this.popInInteract_Tick);
            // 
            // popOutQuestions
            // 
            this.popOutQuestions.Interval = 13;
            this.popOutQuestions.Tick += new System.EventHandler(this.popOutQuestions_Tick);
            // 
            // popInQuestions
            // 
            this.popInQuestions.Interval = 13;
            this.popInQuestions.Tick += new System.EventHandler(this.popInQuestions_Tick);
            // 
            // simulationType
            // 
            this.simulationType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simulationType.AutoSize = true;
            this.simulationType.Location = new System.Drawing.Point(797, 434);
            this.simulationType.Name = "simulationType";
            this.simulationType.Size = new System.Drawing.Size(0, 16);
            this.simulationType.TabIndex = 7;
            // 
            // optionsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.refractionMenu);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "optionsMenu";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Refraction_Load);
            this.SizeChanged += new System.EventHandler(this.optionsMenu_SizeChanged);
            this.refractionMenu.ResumeLayout(false);
            this.refractionMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bArrow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel refractionMenu;
        private System.Windows.Forms.Button interact;
        private System.Windows.Forms.Button questions;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label menuText;
        private System.Windows.Forms.Timer fadeIn;
        private System.Windows.Forms.Timer fadeOut;
        private System.Windows.Forms.Timer animateObjects;
        private System.Windows.Forms.Timer popOutInteract;
        private System.Windows.Forms.Timer popInInteract;
        private System.Windows.Forms.Timer popOutQuestions;
        private System.Windows.Forms.Timer popInQuestions;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox bArrow;
        private System.Windows.Forms.Label simulationType;
    }
}
```

## /Program.cs 

```csharp
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Physics_Simulation
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new welcomeScreen());
        }
    }
}

```

## /refractionBuilder.cs 

```csharp
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }


        private void DrawLines(Graphics lines)
        {

            // draws nice graphical lines
            Pen line = new Pen(Color.White, 5);

            if (systemWideVariables.lightTheme)
            {
                line.Color = Color.Black;
            }


            Point point1Left = new Point(this.Width / 100 * 30, 0);
            Point point2Left = new Point(this.Width / 100 * 30, this.Height);

            lines.DrawLine(line, point1Left, point2Left);


            Point point1Right = new Point(this.Width / 100 * 70, 0);
            Point point2Right = new Point(this.Width / 100 * 70, this.Height);

            lines.DrawLine(line,point1Right, point2Right);


            Point point1Top = new Point(0, this.Height / 100 * 20);
            Point point2Top = new Point(this.Width, this.Height / 100 * 20);
                
            lines.DrawLine(line,point1Top, point2Top);


            Point point1Bottom = new Point(0, this.Height / 100 * 85);
            Point point2Bottom = new Point(this.Width,this.Height / 100 * 85);

            lines.DrawLine(line,point1Bottom, point2Bottom);




        }

        private void refractionBuilder_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            // Sets the form text as the version num defined by the class
            // TitleVersion
            this.Text = systemWideVariables.titleVersion;

            // Sizes the back arrow
            bArrow.Size = new Size(this.Height / 10, this.Height / 10);
            bArrow.Location = new Point(0, 0);

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
            saveButton.Size = clearAll.Size;
          


            // Adds some padding
            aOILabel.Padding = new Padding(0, this.Height / 25, 0, 0);
            rI1Label.Padding = new Padding(0, this.Height / 25, 0, 0);
            rI2Label.Padding = new Padding(0, this.Height / 25, 0, 0);
        
           



        }

        private void bArrow_Click(object sender, EventArgs e)
        {
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
            if (this.Opacity > 0)
            {
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
            DrawLines(e.Graphics);
        }

        private void aOILabel_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {


    
        }

        private void saveButton_Click(object sender, EventArgs e)
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

                    }
                }

                else { saveButton.Text = "Error! Invalid parameter(s)"; }

            }

            catch {
                saveButton.Text = "Error!";
            }

        }



        private void clearAll_Click(object sender, EventArgs e)
        {
            File.Delete("refractionQuestions.txt");
            clearAll.Text = "Cleared all questions";
     
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
    }
}

```

## /refractionBuilder.Designer.cs 

```csharp
﻿namespace Physics_Simulation
{
    partial class refractionBuilder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.fadeIn = new System.Windows.Forms.Timer(this.components);
            this.fadeOut = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.qNameLabel = new System.Windows.Forms.Label();
            this.qName = new System.Windows.Forms.TextBox();
            this.aOILabel = new System.Windows.Forms.Label();
            this.aOI = new System.Windows.Forms.TextBox();
            this.rI1Label = new System.Windows.Forms.Label();
            this.rI1 = new System.Windows.Forms.TextBox();
            this.rI2Label = new System.Windows.Forms.Label();
            this.rI2 = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.clearAll = new System.Windows.Forms.Button();
            this.bArrow = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // fadeIn
            // 
            this.fadeIn.Enabled = true;
            this.fadeIn.Interval = 1;
            this.fadeIn.Tick += new System.EventHandler(this.fadeIn_Tick);
            // 
            // fadeOut
            // 
            this.fadeOut.Interval = 1;
            this.fadeOut.Tick += new System.EventHandler(this.fadeOut_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.95626F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.08748F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.95626F));
            this.tableLayoutPanel1.Controls.Add(this.qNameLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.qName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.aOILabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.aOI, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.rI1Label, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.rI1, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.rI2Label, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.rI2, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.saveButton, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.clearAll, 1, 10);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.65115F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.34885F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(711, 360);
            this.tableLayoutPanel1.TabIndex = 8;
            this.tableLayoutPanel1.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tableLayoutPanel1_CellPaint);
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // qNameLabel
            // 
            this.qNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.qNameLabel.AutoSize = true;
            this.qNameLabel.Location = new System.Drawing.Point(305, 62);
            this.qNameLabel.Name = "qNameLabel";
            this.qNameLabel.Size = new System.Drawing.Size(100, 16);
            this.qNameLabel.TabIndex = 0;
            this.qNameLabel.Text = "Question name:";
            this.qNameLabel.Click += new System.EventHandler(this.qNameLabel_Click);
            // 
            // qName
            // 
            this.qName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.qName.Location = new System.Drawing.Point(310, 80);
            this.qName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.qName.Name = "qName";
            this.qName.Size = new System.Drawing.Size(89, 22);
            this.qName.TabIndex = 1;
            // 
            // aOILabel
            // 
            this.aOILabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.aOILabel.AutoSize = true;
            this.aOILabel.Location = new System.Drawing.Point(277, 104);
            this.aOILabel.Name = "aOILabel";
            this.aOILabel.Size = new System.Drawing.Size(156, 16);
            this.aOILabel.TabIndex = 2;
            this.aOILabel.Text = "Angle of incidence (0-90):";
            this.aOILabel.Click += new System.EventHandler(this.aOILabel_Click);
            // 
            // aOI
            // 
            this.aOI.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.aOI.Location = new System.Drawing.Point(310, 122);
            this.aOI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aOI.Name = "aOI";
            this.aOI.Size = new System.Drawing.Size(89, 22);
            this.aOI.TabIndex = 3;
            this.aOI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aOI_KeyPress);
            // 
            // rI1Label
            // 
            this.rI1Label.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.rI1Label.AutoSize = true;
            this.rI1Label.Location = new System.Drawing.Point(274, 146);
            this.rI1Label.Name = "rI1Label";
            this.rI1Label.Size = new System.Drawing.Size(162, 16);
            this.rI1Label.TabIndex = 4;
            this.rI1Label.Text = "Refractive index 1 (1-2.65):";
            // 
            // rI1
            // 
            this.rI1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rI1.Location = new System.Drawing.Point(310, 164);
            this.rI1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rI1.Name = "rI1";
            this.rI1.Size = new System.Drawing.Size(89, 22);
            this.rI1.TabIndex = 5;
            this.rI1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rI1_KeyPress);
            // 
            // rI2Label
            // 
            this.rI2Label.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.rI2Label.AutoSize = true;
            this.rI2Label.Location = new System.Drawing.Point(274, 188);
            this.rI2Label.Name = "rI2Label";
            this.rI2Label.Size = new System.Drawing.Size(162, 16);
            this.rI2Label.TabIndex = 6;
            this.rI2Label.Text = "Refractive index 2 (1-2.65):";
            // 
            // rI2
            // 
            this.rI2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rI2.Location = new System.Drawing.Point(310, 206);
            this.rI2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rI2.Name = "rI2";
            this.rI2.Size = new System.Drawing.Size(89, 22);
            this.rI2.TabIndex = 7;
            this.rI2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rI2_KeyPress);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.saveButton.AutoSize = true;
            this.saveButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.saveButton.Location = new System.Drawing.Point(321, 232);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(67, 26);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // clearAll
            // 
            this.clearAll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.clearAll.AutoSize = true;
            this.clearAll.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clearAll.Location = new System.Drawing.Point(321, 262);
            this.clearAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(67, 26);
            this.clearAll.TabIndex = 8;
            this.clearAll.Text = "Clear all";
            this.clearAll.UseVisualStyleBackColor = true;
            this.clearAll.Click += new System.EventHandler(this.clearAll_Click);
            // 
            // bArrow
            // 
            this.bArrow.BackColor = System.Drawing.SystemColors.ControlText;
            this.bArrow.BackgroundImage = global::Physics_Simulation.Properties.Resources.darkBackArrow;
            this.bArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bArrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bArrow.Location = new System.Drawing.Point(2, 1);
            this.bArrow.Name = "bArrow";
            this.bArrow.Size = new System.Drawing.Size(80, 80);
            this.bArrow.TabIndex = 7;
            this.bArrow.TabStop = false;
            this.bArrow.Click += new System.EventHandler(this.bArrow_Click);
            this.bArrow.MouseEnter += new System.EventHandler(this.bArrow_MouseEnter);
            this.bArrow.MouseLeave += new System.EventHandler(this.bArrow_MouseLeave);
            // 
            // refractionBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.bArrow);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "refractionBuilder";
            this.Opacity = 0D;
            this.Load += new System.EventHandler(this.refractionBuilder_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bArrow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer fadeIn;
        private System.Windows.Forms.Timer fadeOut;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label qNameLabel;
        private System.Windows.Forms.TextBox qName;
        private System.Windows.Forms.Label aOILabel;
        private System.Windows.Forms.TextBox aOI;
        private System.Windows.Forms.Label rI1Label;
        private System.Windows.Forms.TextBox rI1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.PictureBox bArrow;
        private System.Windows.Forms.Button clearAll;
        private System.Windows.Forms.Label rI2Label;
        private System.Windows.Forms.TextBox rI2;
    }
}
```

## /refractionQuestions.cs 

```csharp
﻿using System;
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

```

## /refractionQuestions.Designer.cs 

```csharp
﻿namespace Physics_Simulation
{
    partial class refractionQuestions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(refractionQuestions));
            this.bArrow = new System.Windows.Forms.PictureBox();
            this.fadeIn = new System.Windows.Forms.Timer(this.components);
            this.fadeOut = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.fParameter1 = new System.Windows.Forms.Label();
            this.fParameter2 = new System.Windows.Forms.Label();
            this.fParameter3 = new System.Windows.Forms.Label();
            this.promptText = new System.Windows.Forms.Label();
            this.mParameter = new System.Windows.Forms.TextBox();
            this.stats = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.generateQuestion = new System.Windows.Forms.Button();
            this.glossary = new System.Windows.Forms.LinkLabel();
            this.result = new System.Windows.Forms.Label();
            this.linesAnimate = new System.Windows.Forms.Timer(this.components);
            this.resetResult = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bArrow)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bArrow
            // 
            this.bArrow.BackColor = System.Drawing.SystemColors.ControlText;
            this.bArrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bArrow.BackgroundImage")));
            this.bArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bArrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bArrow.Location = new System.Drawing.Point(13, 4);
            this.bArrow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bArrow.Name = "bArrow";
            this.bArrow.Size = new System.Drawing.Size(90, 100);
            this.bArrow.TabIndex = 7;
            this.bArrow.TabStop = false;
            this.bArrow.Click += new System.EventHandler(this.bArrow_Click);
            this.bArrow.MouseEnter += new System.EventHandler(this.bArrow_MouseEnter);
            this.bArrow.MouseLeave += new System.EventHandler(this.bArrow_MouseLeave);
            // 
            // fadeIn
            // 
            this.fadeIn.Enabled = true;
            this.fadeIn.Interval = 1;
            this.fadeIn.Tick += new System.EventHandler(this.fadeIn_Tick);
            // 
            // fadeOut
            // 
            this.fadeOut.Interval = 1;
            this.fadeOut.Tick += new System.EventHandler(this.fadeOut_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.73421F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.78085F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.48494F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.stats, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.bArrow, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.result, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.48152F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.98002F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.53846F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(900, 562);
            this.tableLayoutPanel1.TabIndex = 8;
            this.tableLayoutPanel1.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tableLayoutPanel1_CellPaint);
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.fParameter1);
            this.flowLayoutPanel1.Controls.Add(this.fParameter2);
            this.flowLayoutPanel1.Controls.Add(this.fParameter3);
            this.flowLayoutPanel1.Controls.Add(this.promptText);
            this.flowLayoutPanel1.Controls.Add(this.mParameter);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 380);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(267, 168);
            this.flowLayoutPanel1.TabIndex = 9;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // fParameter1
            // 
            this.fParameter1.AutoSize = true;
            this.fParameter1.Location = new System.Drawing.Point(3, 0);
            this.fParameter1.Name = "fParameter1";
            this.fParameter1.Size = new System.Drawing.Size(97, 20);
            this.fParameter1.TabIndex = 0;
            this.fParameter1.Text = "fParameter1";
            // 
            // fParameter2
            // 
            this.fParameter2.AutoSize = true;
            this.fParameter2.Location = new System.Drawing.Point(3, 20);
            this.fParameter2.Name = "fParameter2";
            this.fParameter2.Size = new System.Drawing.Size(97, 20);
            this.fParameter2.TabIndex = 1;
            this.fParameter2.Text = "fParameter2";
            // 
            // fParameter3
            // 
            this.fParameter3.AutoSize = true;
            this.fParameter3.Location = new System.Drawing.Point(3, 40);
            this.fParameter3.Name = "fParameter3";
            this.fParameter3.Size = new System.Drawing.Size(97, 20);
            this.fParameter3.TabIndex = 11;
            this.fParameter3.Text = "fParameter3";
            // 
            // promptText
            // 
            this.promptText.AutoSize = true;
            this.promptText.ForeColor = System.Drawing.Color.Red;
            this.promptText.Location = new System.Drawing.Point(3, 60);
            this.promptText.Name = "promptText";
            this.promptText.Size = new System.Drawing.Size(231, 20);
            this.promptText.TabIndex = 10;
            this.promptText.Text = "Enter missing parameter below:";
            // 
            // mParameter
            // 
            this.mParameter.Location = new System.Drawing.Point(3, 83);
            this.mParameter.Name = "mParameter";
            this.mParameter.Size = new System.Drawing.Size(100, 26);
            this.mParameter.TabIndex = 10;
            this.mParameter.TextChanged += new System.EventHandler(this.mParameter_TextChanged);
            this.mParameter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mParameter_KeyPress);
            // 
            // stats
            // 
            this.stats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stats.AutoSize = true;
            this.stats.Location = new System.Drawing.Point(739, 0);
            this.stats.Name = "stats";
            this.stats.Size = new System.Drawing.Size(158, 40);
            this.stats.TabIndex = 11;
            this.stats.Text = "Percentage correct:\r\nQuestions answered:\r\n";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.generateQuestion);
            this.flowLayoutPanel2.Controls.Add(this.glossary);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(13, 310);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(267, 64);
            this.flowLayoutPanel2.TabIndex = 13;
            // 
            // generateQuestion
            // 
            this.generateQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.generateQuestion.AutoSize = true;
            this.generateQuestion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.generateQuestion.Location = new System.Drawing.Point(3, 21);
            this.generateQuestion.Name = "generateQuestion";
            this.generateQuestion.Size = new System.Drawing.Size(155, 40);
            this.generateQuestion.TabIndex = 8;
            this.generateQuestion.Text = "Generate Question";
            this.generateQuestion.UseVisualStyleBackColor = true;
            this.generateQuestion.Click += new System.EventHandler(this.Test_Click);
            // 
            // glossary
            // 
            this.glossary.ActiveLinkColor = System.Drawing.Color.Navy;
            this.glossary.AutoSize = true;
            this.glossary.LinkColor = System.Drawing.Color.White;
            this.glossary.Location = new System.Drawing.Point(164, 44);
            this.glossary.Name = "glossary";
            this.glossary.Size = new System.Drawing.Size(83, 20);
            this.glossary.TabIndex = 12;
            this.glossary.TabStop = true;
            this.glossary.Text = "Extra Help";
            this.glossary.VisitedLinkColor = System.Drawing.Color.White;
            this.glossary.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.glossary_LinkClicked);
            // 
            // result
            // 
            this.result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(286, 531);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 20);
            this.result.TabIndex = 10;
            // 
            // linesAnimate
            // 
            this.linesAnimate.Interval = 1;
            this.linesAnimate.Tick += new System.EventHandler(this.linesAnimate_Tick);
            // 
            // resetResult
            // 
            this.resetResult.Interval = 1000;
            this.resetResult.Tick += new System.EventHandler(this.resetResult_Tick);
            // 
            // refractionQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "refractionQuestions";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "refractionQQuestions";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.refractionQQuestions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bArrow)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox bArrow;
        private System.Windows.Forms.Timer fadeIn;
        private System.Windows.Forms.Timer fadeOut;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button generateQuestion;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label fParameter1;
        private System.Windows.Forms.Label fParameter2;
        private System.Windows.Forms.TextBox mParameter;
        private System.Windows.Forms.Label promptText;
        private System.Windows.Forms.Label fParameter3;
        private System.Windows.Forms.Timer linesAnimate;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label stats;
        private System.Windows.Forms.Timer resetResult;
        private System.Windows.Forms.LinkLabel glossary;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}
```

## /rInteract.cs 

```csharp
﻿using System;
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
            
          
            



        }

        private void rInteract_Load(object sender, EventArgs e)
        {
          

            // Sets the active colour of the link label to pink for dark mode
            glossary.ActiveLinkColor = Color.Pink;

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
                glossary.ActiveLinkColor = Color.Blue;

            }

     

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
                this.Width / 60,0, 0,0);

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
            bArrow.Size = new Size(this.Height / 10, this.Height / 10);
        }



        private void bArrow_Click_1(object sender, EventArgs e)
        {
         
            fadeOut.Enabled = true;
          

        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

            // draws base lines (already disabled animation in form_Load)
            if (systemWideVariables.powerSave)
            {
                initDraw();
            }
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
            // Calls the DrawRays method whenever text is changed in the textbox
            DrawRays();
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

  

        // For changing each individual cell
        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            // If it is [0,1] then the bg of it will change to the right colour
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
            System.Diagnostics.Process.Start("https://www.savemyexams.com/a-level/physics/aqa/17/revision-notes/3-waves/3-5-refraction/3-5-2-snells-law/");
            // redraws the diagram accordingly.

            
           initDraw();
            

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
        private void lineAnimate_Tick(object sender, EventArgs e)
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

        private void glossary_MouseLeave(object sender, EventArgs e)
        {
       
          

        }

        private void glossary_MouseDown(object sender, MouseEventArgs e)
        {
            linesAnimate.Enabled = true;
        }

        private void rInteract_SizeChanged(object sender, EventArgs e)
        {
            configControls();
            DrawRays();
        }
    }
}

```

## /rInteract.Designer.cs 

```csharp
﻿namespace Physics_Simulation
{
    partial class rInteract
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rInteract));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.refractiveIndex2 = new System.Windows.Forms.TextBox();
            this.rI2Text = new System.Windows.Forms.Label();
            this.refractiveIndex1 = new System.Windows.Forms.TextBox();
            this.rI1Text = new System.Windows.Forms.Label();
            this.angleOfIncidence = new System.Windows.Forms.TextBox();
            this.aOIText = new System.Windows.Forms.Label();
            this.aoR = new System.Windows.Forms.Label();
            this.bArrow = new System.Windows.Forms.PictureBox();
            this.fadeIn = new System.Windows.Forms.Timer(this.components);
            this.fadeOut = new System.Windows.Forms.Timer(this.components);
            this.glossary = new System.Windows.Forms.LinkLabel();
            this.linesAnimate = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.64975F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.35025F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.aoR, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.bArrow, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.07109F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.9289F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tableLayoutPanel1_CellPaint);
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.refractiveIndex2);
            this.flowLayoutPanel1.Controls.Add(this.rI2Text);
            this.flowLayoutPanel1.Controls.Add(this.refractiveIndex1);
            this.flowLayoutPanel1.Controls.Add(this.rI1Text);
            this.flowLayoutPanel1.Controls.Add(this.angleOfIncidence);
            this.flowLayoutPanel1.Controls.Add(this.aOIText);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 277);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(125, 161);
            this.flowLayoutPanel1.TabIndex = 6;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // refractiveIndex2
            // 
            this.refractiveIndex2.Location = new System.Drawing.Point(3, 136);
            this.refractiveIndex2.Name = "refractiveIndex2";
            this.refractiveIndex2.Size = new System.Drawing.Size(173, 22);
            this.refractiveIndex2.TabIndex = 3;
            this.refractiveIndex2.Text = "1";
            this.refractiveIndex2.TextChanged += new System.EventHandler(this.refractiveIndex1_TextChanged);
            this.refractiveIndex2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.refractiveIndex2_KeyPress);
            // 
            // rI2Text
            // 
            this.rI2Text.AutoSize = true;
            this.rI2Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rI2Text.Location = new System.Drawing.Point(3, 108);
            this.rI2Text.Name = "rI2Text";
            this.rI2Text.Size = new System.Drawing.Size(167, 25);
            this.rI2Text.TabIndex = 2;
            this.rI2Text.Text = "Refractive Index 2";
            this.rI2Text.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rI2Text.Click += new System.EventHandler(this.rI1Text_Click);
            // 
            // refractiveIndex1
            // 
            this.refractiveIndex1.Location = new System.Drawing.Point(3, 83);
            this.refractiveIndex1.Name = "refractiveIndex1";
            this.refractiveIndex1.Size = new System.Drawing.Size(173, 22);
            this.refractiveIndex1.TabIndex = 5;
            this.refractiveIndex1.Text = "1";
            this.refractiveIndex1.TextChanged += new System.EventHandler(this.refractiveIndex1_TextChanged_1);
            this.refractiveIndex1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.refractiveIndex1_KeyPress);
            // 
            // rI1Text
            // 
            this.rI1Text.AutoSize = true;
            this.rI1Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rI1Text.Location = new System.Drawing.Point(3, 55);
            this.rI1Text.Name = "rI1Text";
            this.rI1Text.Size = new System.Drawing.Size(167, 25);
            this.rI1Text.TabIndex = 4;
            this.rI1Text.Text = "Refractive Index 1";
            this.rI1Text.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // angleOfIncidence
            // 
            this.angleOfIncidence.Location = new System.Drawing.Point(182, 136);
            this.angleOfIncidence.Name = "angleOfIncidence";
            this.angleOfIncidence.Size = new System.Drawing.Size(173, 22);
            this.angleOfIncidence.TabIndex = 1;
            this.angleOfIncidence.Text = "45";
            this.angleOfIncidence.TextChanged += new System.EventHandler(this.angleOfIncidence_TextChanged);
            this.angleOfIncidence.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.angleOfIncidence_KeyPress);
            // 
            // aOIText
            // 
            this.aOIText.AutoSize = true;
            this.aOIText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aOIText.Location = new System.Drawing.Point(182, 108);
            this.aOIText.Name = "aOIText";
            this.aOIText.Size = new System.Drawing.Size(173, 25);
            this.aOIText.TabIndex = 0;
            this.aOIText.Text = "Angle of Incidence";
            this.aOIText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.aOIText.Click += new System.EventHandler(this.aOIText_Click);
            // 
            // aoR
            // 
            this.aoR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.aoR.AutoSize = true;
            this.aoR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aoR.Location = new System.Drawing.Point(621, 416);
            this.aoR.Name = "aoR";
            this.aoR.Size = new System.Drawing.Size(176, 25);
            this.aoR.TabIndex = 2;
            this.aoR.Text = "Angle of Refraction";
            this.aoR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.aoR.Click += new System.EventHandler(this.aoR_Click);
            // 
            // bArrow
            // 
            this.bArrow.BackColor = System.Drawing.SystemColors.ControlText;
            this.bArrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bArrow.BackgroundImage")));
            this.bArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bArrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bArrow.Location = new System.Drawing.Point(12, 3);
            this.bArrow.Name = "bArrow";
            this.bArrow.Size = new System.Drawing.Size(80, 84);
            this.bArrow.TabIndex = 5;
            this.bArrow.TabStop = false;
            this.bArrow.Click += new System.EventHandler(this.bArrow_Click_1);
            this.bArrow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bArrow_MouseDown);
            this.bArrow.MouseEnter += new System.EventHandler(this.bArrow_MouseEnter);
            this.bArrow.MouseLeave += new System.EventHandler(this.bArrow_MouseLeave);
            // 
            // fadeIn
            // 
            this.fadeIn.Interval = 1;
            this.fadeIn.Tick += new System.EventHandler(this.fade_Tick);
            // 
            // fadeOut
            // 
            this.fadeOut.Interval = 1;
            this.fadeOut.Tick += new System.EventHandler(this.fadeOut_Tick_1);
            // 
            // glossary
            // 
            this.glossary.ActiveLinkColor = System.Drawing.Color.Navy;
            this.glossary.AutoSize = true;
            this.glossary.LinkColor = System.Drawing.Color.White;
            this.glossary.Location = new System.Drawing.Point(0, 0);
            this.glossary.Name = "glossary";
            this.glossary.Size = new System.Drawing.Size(108, 16);
            this.glossary.TabIndex = 2;
            this.glossary.TabStop = true;
            this.glossary.Text = "Click here for info";
            this.glossary.VisitedLinkColor = System.Drawing.Color.White;
            this.glossary.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.glossary_LinkClicked);
            this.glossary.MouseDown += new System.Windows.Forms.MouseEventHandler(this.glossary_MouseDown);
            this.glossary.MouseLeave += new System.EventHandler(this.glossary_MouseLeave);
            // 
            // linesAnimate
            // 
            this.linesAnimate.Interval = 1;
            this.linesAnimate.Tick += new System.EventHandler(this.lineAnimate_Tick);
            // 
            // rInteract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.glossary);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rInteract";
            this.Opacity = 0D;
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.rInteract_Load);
            this.SizeChanged += new System.EventHandler(this.rInteract_SizeChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bArrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox bArrow;
        private System.Windows.Forms.Timer fadeIn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label aOIText;
        private System.Windows.Forms.TextBox angleOfIncidence;
        private System.Windows.Forms.Label rI2Text;
        private System.Windows.Forms.TextBox refractiveIndex2;
        private System.Windows.Forms.Label aoR;
        private System.Windows.Forms.TextBox refractiveIndex1;
        private System.Windows.Forms.Label rI1Text;
        private System.Windows.Forms.Timer fadeOut;
        private System.Windows.Forms.LinkLabel glossary;
        private System.Windows.Forms.Timer linesAnimate;
    }
}
```

## /wavesBuilder.cs 

```csharp
﻿using System;
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


            // Sizes the back arrow
            bArrow.Size = new Size(this.Height / 10, this.Height / 10);

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

        private void DrawLines(Graphics lines)
        {

            // draws nice graphical lines
            Pen line = new Pen(Color.White, 5);

            if (systemWideVariables.lightTheme)
            {
                line.Color = Color.Black;
            }


            Point point1Left = new Point(this.Width / 100 * 30, 0);
            Point point2Left = new Point(this.Width / 100 * 30, this.Height);

            lines.DrawLine(line, point1Left, point2Left);


            Point point1Right = new Point(this.Width / 100 * 70, 0);
            Point point2Right = new Point(this.Width / 100 * 70, this.Height);

            lines.DrawLine(line, point1Right, point2Right);


            Point point1Top = new Point(0, this.Height / 100 * 20);
            Point point2Top = new Point(this.Width, this.Height / 100 * 20);

            lines.DrawLine(line, point1Top, point2Top);


            Point point1Bottom = new Point(0, this.Height / 100 * 85);
            Point point2Bottom = new Point(this.Width, this.Height / 100 * 85);

            lines.DrawLine(line, point1Bottom, point2Bottom);




        }

        private void bArrow_MouseLeave(object sender, EventArgs e)
        {
            // Returns bArrow size back to normal
            bArrow.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            DrawLines(e.Graphics);
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

```

## /wavesBuilder.Designer.cs 

```csharp
﻿namespace Physics_Simulation
{
    partial class wavesBuilder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wavesBuilder));
            this.bArrow = new System.Windows.Forms.PictureBox();
            this.fadeIn = new System.Windows.Forms.Timer(this.components);
            this.fadeOut = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.qNameLabel = new System.Windows.Forms.Label();
            this.qName = new System.Windows.Forms.TextBox();
            this.frequencyLabel = new System.Windows.Forms.Label();
            this.frequency = new System.Windows.Forms.TextBox();
            this.wSpeedLabel = new System.Windows.Forms.Label();
            this.waveSpeed = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.clearAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bArrow)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bArrow
            // 
            this.bArrow.BackColor = System.Drawing.SystemColors.ControlText;
            this.bArrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bArrow.BackgroundImage")));
            this.bArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bArrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bArrow.Location = new System.Drawing.Point(-3, 1);
            this.bArrow.Name = "bArrow";
            this.bArrow.Size = new System.Drawing.Size(80, 84);
            this.bArrow.TabIndex = 7;
            this.bArrow.TabStop = false;
            this.bArrow.Click += new System.EventHandler(this.bArrow_Click);
            this.bArrow.MouseEnter += new System.EventHandler(this.bArrow_MouseEnter);
            this.bArrow.MouseLeave += new System.EventHandler(this.bArrow_MouseLeave);
            // 
            // fadeIn
            // 
            this.fadeIn.Interval = 1;
            this.fadeIn.Tick += new System.EventHandler(this.fadeIn_Tick);
            // 
            // fadeOut
            // 
            this.fadeOut.Interval = 1;
            this.fadeOut.Tick += new System.EventHandler(this.fadeOut_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.95626F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.08748F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.95626F));
            this.tableLayoutPanel1.Controls.Add(this.qNameLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.qName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.frequencyLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.frequency, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.wSpeedLabel, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.waveSpeed, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.saveButton, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.clearAll, 1, 10);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.45221F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.54778F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(711, 360);
            this.tableLayoutPanel1.TabIndex = 9;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // qNameLabel
            // 
            this.qNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.qNameLabel.AutoSize = true;
            this.qNameLabel.Location = new System.Drawing.Point(305, 80);
            this.qNameLabel.Name = "qNameLabel";
            this.qNameLabel.Size = new System.Drawing.Size(100, 16);
            this.qNameLabel.TabIndex = 0;
            this.qNameLabel.Text = "Question name:";
            // 
            // qName
            // 
            this.qName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.qName.Location = new System.Drawing.Point(310, 98);
            this.qName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.qName.Name = "qName";
            this.qName.Size = new System.Drawing.Size(89, 22);
            this.qName.TabIndex = 1;
            // 
            // frequencyLabel
            // 
            this.frequencyLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.frequencyLabel.AutoSize = true;
            this.frequencyLabel.Location = new System.Drawing.Point(304, 122);
            this.frequencyLabel.Name = "frequencyLabel";
            this.frequencyLabel.Size = new System.Drawing.Size(101, 16);
            this.frequencyLabel.TabIndex = 2;
            this.frequencyLabel.Text = "Frequency (Hz):";
            // 
            // frequency
            // 
            this.frequency.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.frequency.Location = new System.Drawing.Point(310, 140);
            this.frequency.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.frequency.Name = "frequency";
            this.frequency.Size = new System.Drawing.Size(89, 22);
            this.frequency.TabIndex = 3;
            this.frequency.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frequency_KeyPress);
            // 
            // wSpeedLabel
            // 
            this.wSpeedLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.wSpeedLabel.AutoSize = true;
            this.wSpeedLabel.Location = new System.Drawing.Point(294, 164);
            this.wSpeedLabel.Name = "wSpeedLabel";
            this.wSpeedLabel.Size = new System.Drawing.Size(121, 16);
            this.wSpeedLabel.TabIndex = 4;
            this.wSpeedLabel.Text = "Wave speed (m/s):";
            // 
            // waveSpeed
            // 
            this.waveSpeed.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.waveSpeed.Location = new System.Drawing.Point(310, 182);
            this.waveSpeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.waveSpeed.Name = "waveSpeed";
            this.waveSpeed.Size = new System.Drawing.Size(89, 22);
            this.waveSpeed.TabIndex = 5;
            this.waveSpeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.waveSpeed_KeyPress);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.saveButton.AutoSize = true;
            this.saveButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.saveButton.Location = new System.Drawing.Point(321, 208);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(67, 26);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // clearAll
            // 
            this.clearAll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.clearAll.AutoSize = true;
            this.clearAll.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clearAll.Location = new System.Drawing.Point(321, 238);
            this.clearAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(67, 26);
            this.clearAll.TabIndex = 8;
            this.clearAll.Text = "Clear all";
            this.clearAll.UseVisualStyleBackColor = true;
            this.clearAll.Click += new System.EventHandler(this.clearAll_Click);
            // 
            // wavesBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.bArrow);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "wavesBuilder";
            this.Opacity = 0D;
            this.Text = "wavesBuilder";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.wavesBuilder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bArrow)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox bArrow;
        private System.Windows.Forms.Timer fadeIn;
        private System.Windows.Forms.Timer fadeOut;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label qNameLabel;
        private System.Windows.Forms.TextBox qName;
        private System.Windows.Forms.Label frequencyLabel;
        private System.Windows.Forms.TextBox frequency;
        private System.Windows.Forms.Label wSpeedLabel;
        private System.Windows.Forms.TextBox waveSpeed;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button clearAll;
    }
}
```

## /wavesQuestions.cs 

```csharp
﻿using System;
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


            if (systemWideVariables.powerSave == false)
            {
                lineAnimate.Enabled = true;
            }

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


        private void drawWavePowerSave()
        {

            this.Refresh();

            Pen wave = new Pen(Color.White, 20);
            if (systemWideVariables.lightTheme == true)
            {
                wave.Color = Color.Black;
            }


            // Creates a graphic 'diagram' to draw on the tableLayoutPanel
            Graphics diagram = tableLayoutPanel1.CreateGraphics();



            diagram.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;


            // Gets the points ready to be drawn
            Point point0 = new Point(ClientSize.Width / 100 * (-80), ClientSize.Height / 100 * (50 - upperOfsetY));
            Point point1 = new Point(ClientSize.Width / 100 * (-60), ClientSize.Height / 100 * (50 + upperOfsetY));
            Point point2 = new Point(ClientSize.Width / 100 * (-40), ClientSize.Height / 100 * (50 - upperOfsetY));
            Point point3 = new Point(ClientSize.Width / 100 * (-20), ClientSize.Height / 100 * (50 + upperOfsetY));
            Point point4 = new Point(0, ClientSize.Height / 100 * (50 - upperOfsetY));
            Point point5 = new Point(ClientSize.Width / 100 * (20), ClientSize.Height / 100 * (50 + upperOfsetY));
            Point point6 = new Point(ClientSize.Width / 100 * (40), ClientSize.Height / 100 * (50 - upperOfsetY));
            Point point7 = new Point(ClientSize.Width / 100 * (60), ClientSize.Height / 100 * (50 + upperOfsetY));
            Point point8 = new Point(ClientSize.Width / 100 * (80), ClientSize.Height / 100 * (50 - upperOfsetY));
            Point point9 = new Point(ClientSize.Width / 100 * (100), ClientSize.Height / 100 * (50 + upperOfsetY));
            Point point10 = new Point(ClientSize.Width / 100 * (120), ClientSize.Height / 100 * (50 - upperOfsetY));

            Point[] curvePoints = { point0, point1, point2, point3, point4, point5, point6, point7, point8, point9, point10 };


            drawLine(diagram);




            // Draws the wave function

            diagram.DrawCurve(wave, curvePoints);


      




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

            // for power save
            if (systemWideVariables.powerSave)
            {
                drawLine(e.Graphics);
            }
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



            // For powersave
            if (systemWideVariables.powerSave)
            {
                drawWavePowerSave();
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

```

## /wavesQuestions.Designer.cs 

```csharp
﻿namespace Physics_Simulation
{
    partial class wavesQuestions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wavesQuestions));
            this.bArrow = new System.Windows.Forms.PictureBox();
            this.fadeIn = new System.Windows.Forms.Timer(this.components);
            this.fadeOut = new System.Windows.Forms.Timer(this.components);
            this.lineAnimate = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.amplitudeText = new System.Windows.Forms.Label();
            this.amplitude = new System.Windows.Forms.TextBox();
            this.fParameter1 = new System.Windows.Forms.Label();
            this.fParameter2 = new System.Windows.Forms.Label();
            this.promptText = new System.Windows.Forms.Label();
            this.mParameter = new System.Windows.Forms.TextBox();
            this.stats = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.generateQuestion = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.waveDraw = new System.Windows.Forms.Timer(this.components);
            this.resetResult = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bArrow)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bArrow
            // 
            this.bArrow.BackColor = System.Drawing.SystemColors.ControlText;
            this.bArrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bArrow.BackgroundImage")));
            this.bArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bArrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bArrow.Location = new System.Drawing.Point(-2, 2);
            this.bArrow.Name = "bArrow";
            this.bArrow.Size = new System.Drawing.Size(80, 84);
            this.bArrow.TabIndex = 8;
            this.bArrow.TabStop = false;
            this.bArrow.Click += new System.EventHandler(this.bArrow_Click);
            this.bArrow.MouseEnter += new System.EventHandler(this.bArrow_MouseEnter);
            this.bArrow.MouseLeave += new System.EventHandler(this.bArrow_MouseLeave);
            // 
            // fadeIn
            // 
            this.fadeIn.Interval = 1;
            this.fadeIn.Tick += new System.EventHandler(this.fadeIn_Tick);
            // 
            // fadeOut
            // 
            this.fadeOut.Interval = 1;
            this.fadeOut.Tick += new System.EventHandler(this.fadeOut_Tick);
            // 
            // lineAnimate
            // 
            this.lineAnimate.Interval = 1;
            this.lineAnimate.Tick += new System.EventHandler(this.lineAnimate_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.30197F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.23268F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.46535F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.stats, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.result, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.77179F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.22821F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(711, 360);
            this.tableLayoutPanel1.TabIndex = 9;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.amplitudeText);
            this.flowLayoutPanel1.Controls.Add(this.amplitude);
            this.flowLayoutPanel1.Controls.Add(this.fParameter1);
            this.flowLayoutPanel1.Controls.Add(this.fParameter2);
            this.flowLayoutPanel1.Controls.Add(this.promptText);
            this.flowLayoutPanel1.Controls.Add(this.mParameter);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 231);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(269, 127);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // amplitudeText
            // 
            this.amplitudeText.AutoSize = true;
            this.amplitudeText.Location = new System.Drawing.Point(3, 0);
            this.amplitudeText.Name = "amplitudeText";
            this.amplitudeText.Size = new System.Drawing.Size(86, 16);
            this.amplitudeText.TabIndex = 6;
            this.amplitudeText.Text = "Amplitude(m)";
            // 
            // amplitude
            // 
            this.amplitude.Location = new System.Drawing.Point(3, 18);
            this.amplitude.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.amplitude.Name = "amplitude";
            this.amplitude.Size = new System.Drawing.Size(89, 22);
            this.amplitude.TabIndex = 7;
            this.amplitude.Text = "7.5";
            this.amplitude.TextChanged += new System.EventHandler(this.amplitude_TextChanged);
            // 
            // fParameter1
            // 
            this.fParameter1.AutoSize = true;
            this.fParameter1.Location = new System.Drawing.Point(3, 42);
            this.fParameter1.Name = "fParameter1";
            this.fParameter1.Size = new System.Drawing.Size(80, 16);
            this.fParameter1.TabIndex = 1;
            this.fParameter1.Text = "fParameter1";
            // 
            // fParameter2
            // 
            this.fParameter2.AutoSize = true;
            this.fParameter2.Location = new System.Drawing.Point(3, 58);
            this.fParameter2.Name = "fParameter2";
            this.fParameter2.Size = new System.Drawing.Size(80, 16);
            this.fParameter2.TabIndex = 2;
            this.fParameter2.Text = "fParameter2";
            // 
            // promptText
            // 
            this.promptText.AutoSize = true;
            this.promptText.ForeColor = System.Drawing.Color.Red;
            this.promptText.Location = new System.Drawing.Point(3, 74);
            this.promptText.Name = "promptText";
            this.promptText.Size = new System.Drawing.Size(194, 16);
            this.promptText.TabIndex = 11;
            this.promptText.Text = "Enter missing parameter below:";
            // 
            // mParameter
            // 
            this.mParameter.Location = new System.Drawing.Point(3, 92);
            this.mParameter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mParameter.Name = "mParameter";
            this.mParameter.Size = new System.Drawing.Size(89, 22);
            this.mParameter.TabIndex = 12;
            this.mParameter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mParameter_KeyPress);
            // 
            // stats
            // 
            this.stats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stats.AutoSize = true;
            this.stats.Location = new System.Drawing.Point(576, 0);
            this.stats.Name = "stats";
            this.stats.Size = new System.Drawing.Size(132, 32);
            this.stats.TabIndex = 12;
            this.stats.Text = "Percentage correct:\r\nQuestions answered:\r\n";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.generateQuestion);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(287, 231);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(136, 127);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // generateQuestion
            // 
            this.generateQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.generateQuestion.AutoSize = true;
            this.generateQuestion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.generateQuestion.Location = new System.Drawing.Point(3, 93);
            this.generateQuestion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generateQuestion.Name = "generateQuestion";
            this.generateQuestion.Size = new System.Drawing.Size(138, 32);
            this.generateQuestion.TabIndex = 9;
            this.generateQuestion.Text = "Generate Question";
            this.generateQuestion.UseVisualStyleBackColor = true;
            this.generateQuestion.Click += new System.EventHandler(this.generateQuestion_Click);
            // 
            // result
            // 
            this.result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(429, 344);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 16);
            this.result.TabIndex = 2;
            // 
            // waveDraw
            // 
            this.waveDraw.Interval = 1;
            this.waveDraw.Tick += new System.EventHandler(this.waveDraw_Tick);
            // 
            // resetResult
            // 
            this.resetResult.Tick += new System.EventHandler(this.resetResult_Tick);
            // 
            // wavesQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.bArrow);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "wavesQuestions";
            this.Opacity = 0D;
            this.Text = "wavesQQuestions";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.wavesQQuestions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bArrow)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox bArrow;
        private System.Windows.Forms.Timer fadeIn;
        private System.Windows.Forms.Timer fadeOut;
        private System.Windows.Forms.Timer lineAnimate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Timer waveDraw;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label fParameter1;
        private System.Windows.Forms.Label fParameter2;
        private System.Windows.Forms.Label amplitudeText;
        private System.Windows.Forms.TextBox amplitude;
        private System.Windows.Forms.Label promptText;
        private System.Windows.Forms.TextBox mParameter;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button generateQuestion;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Timer resetResult;
        private System.Windows.Forms.Label stats;
    }
}
```

## /Welcome.cs 

```csharp
﻿using Physics_Simulation.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Linq;
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

            // Sets the opactiy to 0 for the fade in animation
            this.Opacity = 0;

            // Disables annoying windows sounds
            this.AcceptButton = null;
        }

        // Used for all winforms so made public
        public class systemWideVariables
        {
            public static string titleVersion = "V2.4.0";
            public static bool lightTheme = Settings.Default.lightTheme;
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

            // only triggers if powersave is disabled
            if (systemWideVariables.powerSave == false)
            {

                getInitY();
                int x = this.DesktopLocation.X;
                int y = this.DesktopLocation.Y;
                int count = 5;
                while (y < (this.Height * 3))
                {

                    this.Location = new Point(x, y);
                    y = y + count;
                    Thread.Sleep(1);
                    count++;

                }
            }

            this.Hide();

        }



        private void showingAnimation()
        {
            this.Show();
            if (systemWideVariables.powerSave == false)
            {
                int x = this.DesktopLocation.X;
                int y = this.DesktopLocation.Y;
                int count = 50;

                while (y >= (initY))
                {
                    Thread.Sleep(1);
                    this.Location = new Point(x, y);
                    y = y - count;

                    count--;

                }
            }

        }

         
        private void button1_Click(object sender, EventArgs e) // Refraction
        {
            refraction.BackColor = Color.White;

            // Sets the var to tell the program which forms need to be loaded
            systemWideVariables.whichSim = "refraction";


       
            leavingAnimation();

            // Creates an instance of the refraction form when
            // the button is pressed
            optionsMenu options = new optionsMenu();
            options.ShowDialog();
            showingAnimation();
            
            
        }
            
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void updateTheme()
        {

         
            // Sets colours acorrdingly
            if (systemWideVariables.lightTheme == true)
            {
                this.BackColor = Color.White;
                refraction.BackColor = Color.Black;
                refraction.ForeColor = Color.White;
                waves.BackColor = Color.Black;
                waves.ForeColor = Color.White;
                wTxt.BackColor = Color.White;
                wTxt.ForeColor = Color.Black;
                theme.Image = Properties.Resources.sun;
                theme.BackColor = Color.Transparent;
                theme.ForeColor = Color.Transparent;
                energySaver.Image = Properties.Resources.energy_saving_icondark;
                energySaver.ForeColor = Color.Transparent;
                energySaver.BackColor = Color.Transparent;
            }
            else
            {
                this.BackColor = Color.Black;
                refraction.BackColor = Color.White;
                refraction.ForeColor = Color.Black;
                waves.BackColor = Color.White;
                waves.ForeColor = Color.Black;
                wTxt.BackColor = Color.Black;
                wTxt.ForeColor = Color.White;
                theme.Image = Properties.Resources.moon;
                theme.BackColor = Color.Black;
                theme.ForeColor = Color.Black; 
                energySaver.Image = Properties.Resources.energysaverlight;
                energySaver.ForeColor= Color.Black;
                energySaver.BackColor = Color.Black;
            }


            // if power save is on or not
            if (systemWideVariables.powerSave)
            {
                energySaver.BackColor= Color.Red;
            }

        }

    private void welcomeScreen_Load(object sender, EventArgs e)
        {
           
   

            // Sets the form text as the version num defined by the class attribute
            // TitleVersion
            this.Text = systemWideVariables.titleVersion;

            // Sets the right theme
            updateTheme();

            // Triggers the fade in animation
            fadeIn.Enabled = true;

            // Chnages font to a nicer one for both buttons
            wTxt.Font = new Font ("Microsoft Sans Serif", 21);
            refraction.Font = new Font("Microsoft Sans Serif", 20);
            waves.Font = new Font("Microsoft Sans Serif", 20);

            // Keeps sizing consistant
            refraction.Height = Convert.ToInt32(wTxt.Height / 1.5);
            refraction.Width = Convert.ToInt32(wTxt.Width / 1.5);
            waves.Size = refraction.Size;



            // Enables screen animation if power save is off
            if (systemWideVariables.powerSave == false)
            {
                credit.Enabled = true;
            }

           
            

        }

        // For fade in animation
        private void fadeIn_Tick(object sender, EventArgs e)
        {
            // Gradually increase the form's opacity
            if (this.Opacity < 1)
            {
                this.Opacity += 0.3;
            }

            // When fully solid stop the timer
            else
            {
                fadeIn.Enabled = false;
            }
        }

        private void waves_Click(object sender, EventArgs e)
        {
            // Sets the var to tell the program which forms need to be loaded
            systemWideVariables.whichSim = "waves";

            // Creates an instance of optionMenu form when
            // the button is pressed
            leavingAnimation();
            optionsMenu options = new optionsMenu();
     
            options.ShowDialog();

            // When the optionMenu instance is closed by the user
            // the Welcome menu will open again
            showingAnimation();

            // This removed in beta testing.
            //this.Location = new Point(this.Width, this.Height / 100 * 50);

        }

        private void refraction_MouseEnter(object sender, EventArgs e)
        {
            refraction.BackColor = Color.LightSkyBlue;
        }

        private void refraction_MouseLeave(object sender, EventArgs e)
        {
            if (systemWideVariables.lightTheme == true)
            {
                refraction.BackColor = Color.Black;
                wTxt.ForeColor = Color.Black;
            }
            else
            {
                refraction.BackColor = Color.White;
                wTxt.ForeColor = Color.White;
            }

        }

        private void waves_MouseEnter(object sender, EventArgs e)
        {
            waves.BackColor = Color.Coral;
        }

        private void waves_MouseLeave(object sender, EventArgs e)
        {
            if (systemWideVariables.lightTheme == true)
            {
                waves.BackColor = Color.Black;
                wTxt.ForeColor = Color.Black;
            }
            else
            {
                waves.BackColor = Color.White;
                wTxt.ForeColor = Color.White;
            }
            
        }

        private void refraction_MouseDown(object sender, MouseEventArgs e)
        {
            wTxt.ForeColor = Color.LightSkyBlue;
        }

        private void waves_MouseDown(object sender, MouseEventArgs e)
        {
            wTxt.ForeColor = Color.Coral;
        }

        private void welcomeScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Not used anymore
            Settings.Default.lightTheme = systemWideVariables.lightTheme;
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
                wTxt.Text = "Physics Simulations!!";
            }
            else
            {
                wTxt.Text = defaultText;
            }
        }

        private void settings_Click(object sender, EventArgs e)
        {
            // Changes the theme
            if (systemWideVariables.lightTheme == true)
            {
                systemWideVariables.lightTheme = false;
            }
            else
            {
                systemWideVariables.lightTheme = true;
            }

            // Applies changes
            updateTheme();
            
            
        }

        private void settings_MouseEnter(object sender, EventArgs e)
        {
            // Shows a tooltip when hovering over the button
            if (systemWideVariables.lightTheme == true)
            {
                themeTip.SetToolTip(theme, "Click to switch to dark theme");
            }
            else 
            {
                themeTip.SetToolTip(theme, "Click to switch to light theme"); 
            }
            
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

                if (systemWideVariables.lightTheme)
                { 
                    energySaver.BackColor = Color.Transparent;
                }
                else
                {
                    energySaver.BackColor = Color.Black;
                }

                // renables text animation
                credit.Enabled = true;
                
            }
            else {
                systemWideVariables.powerSave = true; 
                energySaver.BackColor = Color.Red;

                // Disables text animation
                credit.Enabled = false;
                // In case two ! are shown
                wTxt.Text = "Physics Simulations!";

            }

                    
        }

        private void themeTip_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}

```

## /Welcome.Designer.cs 

```csharp
﻿namespace Physics_Simulation
{
    partial class welcomeScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(welcomeScreen));
            this.refraction = new System.Windows.Forms.Button();
            this.waves = new System.Windows.Forms.Button();
            this.fadeIn = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.wTxt = new System.Windows.Forms.Label();
            this.theme = new System.Windows.Forms.Button();
            this.energySaver = new System.Windows.Forms.Button();
            this.credit = new System.Windows.Forms.Timer(this.components);
            this.themeTip = new System.Windows.Forms.ToolTip(this.components);
            this.powerTip = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // refraction
            // 
            this.refraction.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.refraction.AutoSize = true;
            this.refraction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refraction.Location = new System.Drawing.Point(277, 130);
            this.refraction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.refraction.Name = "refraction";
            this.refraction.Size = new System.Drawing.Size(136, 75);
            this.refraction.TabIndex = 0;
            this.refraction.Text = "Refraction";
            this.refraction.UseVisualStyleBackColor = true;
            this.refraction.Click += new System.EventHandler(this.button1_Click);
            this.refraction.MouseDown += new System.Windows.Forms.MouseEventHandler(this.refraction_MouseDown);
            this.refraction.MouseEnter += new System.EventHandler(this.refraction_MouseEnter);
            this.refraction.MouseLeave += new System.EventHandler(this.refraction_MouseLeave);
            // 
            // waves
            // 
            this.waves.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.waves.AutoSize = true;
            this.waves.Cursor = System.Windows.Forms.Cursors.Hand;
            this.waves.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waves.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.waves.Location = new System.Drawing.Point(279, 209);
            this.waves.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.waves.Name = "waves";
            this.waves.Size = new System.Drawing.Size(132, 105);
            this.waves.TabIndex = 1;
            this.waves.Text = "Waves";
            this.waves.UseVisualStyleBackColor = true;
            this.waves.Click += new System.EventHandler(this.waves_Click);
            this.waves.MouseDown += new System.Windows.Forms.MouseEventHandler(this.waves_MouseDown);
            this.waves.MouseEnter += new System.EventHandler(this.waves_MouseEnter);
            this.waves.MouseLeave += new System.EventHandler(this.waves_MouseLeave);
            // 
            // fadeIn
            // 
            this.fadeIn.Enabled = true;
            this.fadeIn.Interval = 1;
            this.fadeIn.Tick += new System.EventHandler(this.fadeIn_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.wTxt, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.refraction, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.waves, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.theme, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.energySaver, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.76264F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.15136F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.086F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(692, 453);
            this.tableLayoutPanel1.TabIndex = 3;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // wTxt
            // 
            this.wTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.wTxt.AutoSize = true;
            this.wTxt.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.wTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wTxt.ForeColor = System.Drawing.SystemColors.Control;
            this.wTxt.Location = new System.Drawing.Point(207, 0);
            this.wTxt.Name = "wTxt";
            this.wTxt.Size = new System.Drawing.Size(276, 32);
            this.wTxt.TabIndex = 2;
            this.wTxt.Text = "Physics Simulations!";
            this.wTxt.Click += new System.EventHandler(this.label1_Click);
            this.wTxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.wTxt_MouseClick);
            // 
            // theme
            // 
            this.theme.AllowDrop = true;
            this.theme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.theme.BackColor = System.Drawing.SystemColors.ControlText;
            this.theme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.theme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.theme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.theme.ForeColor = System.Drawing.SystemColors.ControlText;
            this.theme.Image = global::Physics_Simulation.Properties.Resources.moon;
            this.theme.Location = new System.Drawing.Point(630, 2);
            this.theme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.theme.Name = "theme";
            this.theme.Size = new System.Drawing.Size(59, 57);
            this.theme.TabIndex = 3;
            this.theme.UseVisualStyleBackColor = false;
            this.theme.Click += new System.EventHandler(this.settings_Click);
            this.theme.MouseDown += new System.Windows.Forms.MouseEventHandler(this.theme_MouseDown);
            this.theme.MouseEnter += new System.EventHandler(this.settings_MouseEnter);
            this.theme.MouseUp += new System.Windows.Forms.MouseEventHandler(this.theme_MouseUp);
            // 
            // energySaver
            // 
            this.energySaver.AllowDrop = true;
            this.energySaver.BackColor = System.Drawing.SystemColors.ControlText;
            this.energySaver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.energySaver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.energySaver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.energySaver.ForeColor = System.Drawing.SystemColors.ControlText;
            this.energySaver.Image = global::Physics_Simulation.Properties.Resources.energysaverlight;
            this.energySaver.Location = new System.Drawing.Point(3, 2);
            this.energySaver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.energySaver.Name = "energySaver";
            this.energySaver.Size = new System.Drawing.Size(59, 57);
            this.energySaver.TabIndex = 4;
            this.energySaver.UseVisualStyleBackColor = false;
            this.energySaver.Click += new System.EventHandler(this.energySaver_Click);
            // 
            // credit
            // 
            this.credit.Interval = 400;
            this.credit.Tick += new System.EventHandler(this.themePrompt_Tick);
            // 
            // themeTip
            // 
            this.themeTip.Popup += new System.Windows.Forms.PopupEventHandler(this.themeTip_Popup);
            // 
            // welcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(692, 453);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "welcomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.welcomeScreen_FormClosed);
            this.Load += new System.EventHandler(this.welcomeScreen_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button refraction;
        private System.Windows.Forms.Button waves;
        private System.Windows.Forms.Timer fadeIn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Timer credit;
        private System.Windows.Forms.Label wTxt;
        private System.Windows.Forms.Button theme;
        private System.Windows.Forms.ToolTip themeTip;
        private System.Windows.Forms.Button energySaver;
        private System.Windows.Forms.ToolTip powerTip;
    }
}


```

## /wInteract.cs 

```csharp
﻿using System;
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


            // for power save
            if (systemWideVariables.powerSave == false)
            {
                lineAnimate.Enabled = true;
            }
            else
            {
                drawWavePowerSave();
                
            }
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

        private void drawWavePowerSave()
        {

            this.Refresh();

            Pen wave = new Pen(Color.White, 20);
            if (systemWideVariables.lightTheme == true)
            {
                wave.Color = Color.Black;
            }


            // Creates a graphic 'diagram' to draw on the tableLayoutPanel
            Graphics diagram = tableLayoutPanel1.CreateGraphics();



            diagram.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;


            // Gets the points ready to be drawn
            Point point0 = new Point(ClientSize.Width / 100 * (-80), ClientSize.Height / 100 * (50 - upperOfsetY));
            Point point1 = new Point(ClientSize.Width / 100 * (-60), ClientSize.Height / 100 * (50 + upperOfsetY));
            Point point2 = new Point(ClientSize.Width / 100 * (-40), ClientSize.Height / 100 * (50 - upperOfsetY));
            Point point3 = new Point(ClientSize.Width / 100 * (-20), ClientSize.Height / 100 * (50 + upperOfsetY));
            Point point4 = new Point(0, ClientSize.Height / 100 * (50 - upperOfsetY));
            Point point5 = new Point(ClientSize.Width / 100 * (20), ClientSize.Height / 100 * (50 + upperOfsetY));
            Point point6 = new Point(ClientSize.Width / 100 * (40), ClientSize.Height / 100 * (50 - upperOfsetY));
            Point point7 = new Point(ClientSize.Width / 100 * (60), ClientSize.Height / 100 * (50 + upperOfsetY));
            Point point8 = new Point(ClientSize.Width / 100 * (80), ClientSize.Height / 100 * (50 - upperOfsetY));
            Point point9 = new Point(ClientSize.Width / 100 * (100), ClientSize.Height / 100 * (50 + upperOfsetY));
            Point point10 = new Point(ClientSize.Width / 100 * (120), ClientSize.Height / 100 * (50 - upperOfsetY));

            Point[] curvePoints = { point0, point1, point2, point3, point4, point5, point6, point7, point8, point9, point10 };


            drawLine(diagram);




            // Draws the wave function

            diagram.DrawCurve(wave, curvePoints);


            // Forces any changes to the wavelength stat if needed
            try
            {
                // Updates the stat and rounds to one dp
                waveLength.Text = "Wavelength: " +
                    Convert.ToString(Math.Round(Convert.ToDouble(waveSpeed.Text) / Convert.ToInt32(frequency.Text), 1)
                    + " m (1.dp)");
            }
            catch
            {
                // To pause wave animation if an invalid input is put in and give error messg
                waveDraw.Interval = 1000000;
                waveLength.Text = "Error!";
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




            // all below disabled for powersave
            // Updates ofset accordingly to the inputted amplitude
            if (systemWideVariables.powerSave == false)
            {
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
            
            else
            {
                // Disables this and enables powersave verson
                drawWavePowerSave();
                waveDraw.Enabled = false;
                
               
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
            // for power save 
            if (systemWideVariables.powerSave)
            {
                drawLine(e.Graphics);
            }
               
        }


        private double upperWaveSpeed = 101;
        private void waveSpeed_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // for power save mode
                if (systemWideVariables.powerSave)
                {
                    drawWavePowerSave();
                }

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

                // for power save mode
                if (systemWideVariables.powerSave)
                {
                    drawWavePowerSave();
                }

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
                if (Convert.ToDouble(amplitude.Text) <= 35)
                {
                    upperOfsetY = Convert.ToInt32(Convert.ToDouble(amplitude.Text) * 2);
                    ofsetY = 0;
                }

                else
                {
                    upperOfsetY = 1;
                }

                if (systemWideVariables.powerSave)
                {
                    drawWavePowerSave();
                }
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
 
```

## /wInteract.Designer.cs 

```csharp
﻿namespace Physics_Simulation
{
    partial class wInteract
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wInteract));
            this.bArrow = new System.Windows.Forms.PictureBox();
            this.fadeIn = new System.Windows.Forms.Timer(this.components);
            this.fadeOut = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.frequencyText = new System.Windows.Forms.Label();
            this.frequency = new System.Windows.Forms.TextBox();
            this.wSpeedText = new System.Windows.Forms.Label();
            this.waveSpeed = new System.Windows.Forms.TextBox();
            this.amplitudeText = new System.Windows.Forms.Label();
            this.amplitude = new System.Windows.Forms.TextBox();
            this.glossary = new System.Windows.Forms.LinkLabel();
            this.unitConvert = new System.Windows.Forms.Button();
            this.waveLength = new System.Windows.Forms.Label();
            this.waveDraw = new System.Windows.Forms.Timer(this.components);
            this.lineAnimate = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bArrow)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bArrow
            // 
            this.bArrow.BackColor = System.Drawing.SystemColors.ControlText;
            this.bArrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bArrow.BackgroundImage")));
            this.bArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bArrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bArrow.Location = new System.Drawing.Point(0, 0);
            this.bArrow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bArrow.Name = "bArrow";
            this.bArrow.Size = new System.Drawing.Size(90, 105);
            this.bArrow.TabIndex = 6;
            this.bArrow.TabStop = false;
            this.bArrow.Click += new System.EventHandler(this.bArrow_Click);
            this.bArrow.MouseEnter += new System.EventHandler(this.bArrow_MouseEnter);
            this.bArrow.MouseLeave += new System.EventHandler(this.bArrow_MouseLeave);
            // 
            // fadeIn
            // 
            this.fadeIn.Interval = 1;
            this.fadeIn.Tick += new System.EventHandler(this.fadeIn_Tick);
            // 
            // fadeOut
            // 
            this.fadeOut.Interval = 1;
            this.fadeOut.Tick += new System.EventHandler(this.fadeOut_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.32271F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.67729F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.waveLength, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(900, 562);
            this.tableLayoutPanel1.TabIndex = 7;
            this.tableLayoutPanel1.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tableLayoutPanel1_CellPaint);
            this.tableLayoutPanel1.SizeChanged += new System.EventHandler(this.tableLayoutPanel1_SizeChanged);
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.frequencyText);
            this.flowLayoutPanel1.Controls.Add(this.frequency);
            this.flowLayoutPanel1.Controls.Add(this.wSpeedText);
            this.flowLayoutPanel1.Controls.Add(this.waveSpeed);
            this.flowLayoutPanel1.Controls.Add(this.amplitudeText);
            this.flowLayoutPanel1.Controls.Add(this.amplitude);
            this.flowLayoutPanel1.Controls.Add(this.glossary);
            this.flowLayoutPanel1.Controls.Add(this.unitConvert);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 424);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(221, 135);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // frequencyText
            // 
            this.frequencyText.AutoSize = true;
            this.frequencyText.Location = new System.Drawing.Point(3, 0);
            this.frequencyText.Name = "frequencyText";
            this.frequencyText.Size = new System.Drawing.Size(114, 20);
            this.frequencyText.TabIndex = 0;
            this.frequencyText.Text = "Frequency(Hz)";
            // 
            // frequency
            // 
            this.frequency.Location = new System.Drawing.Point(3, 23);
            this.frequency.Name = "frequency";
            this.frequency.Size = new System.Drawing.Size(100, 26);
            this.frequency.TabIndex = 1;
            this.frequency.Text = "1";
            this.frequency.TextChanged += new System.EventHandler(this.frequency_TextChanged);
            this.frequency.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frequency_KeyPress);
            // 
            // wSpeedText
            // 
            this.wSpeedText.AutoSize = true;
            this.wSpeedText.Location = new System.Drawing.Point(3, 52);
            this.wSpeedText.Name = "wSpeedText";
            this.wSpeedText.Size = new System.Drawing.Size(97, 20);
            this.wSpeedText.TabIndex = 2;
            this.wSpeedText.Text = "Wave speed";
            // 
            // waveSpeed
            // 
            this.waveSpeed.Location = new System.Drawing.Point(3, 75);
            this.waveSpeed.Name = "waveSpeed";
            this.waveSpeed.Size = new System.Drawing.Size(100, 26);
            this.waveSpeed.TabIndex = 3;
            this.waveSpeed.Text = "100";
            this.waveSpeed.TextChanged += new System.EventHandler(this.waveSpeed_TextChanged);
            this.waveSpeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.waveSpeed_KeyPress);
            // 
            // amplitudeText
            // 
            this.amplitudeText.AutoSize = true;
            this.amplitudeText.Location = new System.Drawing.Point(3, 104);
            this.amplitudeText.Name = "amplitudeText";
            this.amplitudeText.Size = new System.Drawing.Size(103, 20);
            this.amplitudeText.TabIndex = 5;
            this.amplitudeText.Text = "Amplitude(m)";
            // 
            // amplitude
            // 
            this.amplitude.Location = new System.Drawing.Point(123, 3);
            this.amplitude.Name = "amplitude";
            this.amplitude.Size = new System.Drawing.Size(100, 26);
            this.amplitude.TabIndex = 6;
            this.amplitude.Text = "7.5";
            this.amplitude.TextChanged += new System.EventHandler(this.amplitude_TextChanged);
            this.amplitude.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amplitude_KeyPress);
            // 
            // glossary
            // 
            this.glossary.AutoSize = true;
            this.glossary.ForeColor = System.Drawing.SystemColors.ControlText;
            this.glossary.LinkColor = System.Drawing.Color.White;
            this.glossary.Location = new System.Drawing.Point(123, 32);
            this.glossary.Name = "glossary";
            this.glossary.Size = new System.Drawing.Size(71, 20);
            this.glossary.TabIndex = 8;
            this.glossary.TabStop = true;
            this.glossary.Text = "Glossary";
            this.glossary.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.glossary_LinkClicked);
            // 
            // unitConvert
            // 
            this.unitConvert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.unitConvert.Location = new System.Drawing.Point(123, 55);
            this.unitConvert.Name = "unitConvert";
            this.unitConvert.Size = new System.Drawing.Size(75, 23);
            this.unitConvert.TabIndex = 7;
            this.unitConvert.Text = "m/s";
            this.unitConvert.UseVisualStyleBackColor = true;
            this.unitConvert.Click += new System.EventHandler(this.unitConvert_Click);
            // 
            // waveLength
            // 
            this.waveLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.waveLength.AutoSize = true;
            this.waveLength.Location = new System.Drawing.Point(804, 542);
            this.waveLength.Name = "waveLength";
            this.waveLength.Size = new System.Drawing.Size(93, 20);
            this.waveLength.TabIndex = 9;
            this.waveLength.Text = "Wavelength";
            // 
            // waveDraw
            // 
            this.waveDraw.Interval = 1;
            this.waveDraw.Tick += new System.EventHandler(this.waveDraw_Tick);
            // 
            // lineAnimate
            // 
            this.lineAnimate.Interval = 1;
            this.lineAnimate.Tick += new System.EventHandler(this.lineAnimate_Tick);
            // 
            // wInteract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.bArrow);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "wInteract";
            this.Opacity = 0D;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.wInteract_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bArrow)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox bArrow;
        private System.Windows.Forms.Timer fadeIn;
        private System.Windows.Forms.Timer fadeOut;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label frequencyText;
        private System.Windows.Forms.TextBox frequency;
        private System.Windows.Forms.Label wSpeedText;
        private System.Windows.Forms.TextBox waveSpeed;
        private System.Windows.Forms.Label amplitudeText;
        private System.Windows.Forms.TextBox amplitude;
        private System.Windows.Forms.Button unitConvert;
        private System.Windows.Forms.LinkLabel glossary;
        private System.Windows.Forms.Timer waveDraw;
        private System.Windows.Forms.Timer lineAnimate;
        private System.Windows.Forms.Label waveLength;
    }
}
```

## /obj/Debug/.NETFramework,Version=v4.7.2.AssemblyAttributes.cs 

```csharp
// <autogenerated />
using System;
using System.Reflection;
[assembly: global::System.Runtime.Versioning.TargetFrameworkAttribute(".NETFramework,Version=v4.7.2", FrameworkDisplayName = ".NET Framework 4.7.2")]

```

## /obj/Release/.NETFramework,Version=v4.7.2.AssemblyAttributes.cs 

```csharp
// <autogenerated />
using System;
using System.Reflection;
[assembly: global::System.Runtime.Versioning.TargetFrameworkAttribute(".NETFramework,Version=v4.7.2", FrameworkDisplayName = ".NET Framework 4.7.2")]

```

## /Properties/AssemblyInfo.cs 

```csharp
﻿using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Physics Simulation")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("Physics Simulation")]
[assembly: AssemblyCopyright("Copyright ©  2024")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("7f27ffa7-bcc8-4462-8a4f-30ba0479436b")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

```

## /Properties/Resources.Designer.cs 

```csharp
﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Physics_Simulation.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Physics_Simulation.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap darkBackArrow {
            get {
                object obj = ResourceManager.GetObject("darkBackArrow", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap energy_saving_icondark {
            get {
                object obj = ResourceManager.GetObject("energy_saving_icondark", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap energysaverlight {
            get {
                object obj = ResourceManager.GetObject("energysaverlight", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon Letter_P_blue_34913 {
            get {
                object obj = ResourceManager.GetObject("Letter_P_blue_34913", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap lightBackArrow {
            get {
                object obj = ResourceManager.GetObject("lightBackArrow", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap moon {
            get {
                object obj = ResourceManager.GetObject("moon", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon refraction_icon_154921 {
            get {
                object obj = ResourceManager.GetObject("refraction_icon_154921", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap sun {
            get {
                object obj = ResourceManager.GetObject("sun", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}

```

## /Properties/Settings.Designer.cs 

```csharp
﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Physics_Simulation.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.9.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool lightTheme {
            get {
                return ((bool)(this["lightTheme"]));
            }
            set {
                this["lightTheme"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string Setting {
            get {
                return ((string)(this["Setting"]));
            }
            set {
                this["Setting"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool powerSave {
            get {
                return ((bool)(this["powerSave"]));
            }
            set {
                this["powerSave"] = value;
            }
        }
    }
}

```

