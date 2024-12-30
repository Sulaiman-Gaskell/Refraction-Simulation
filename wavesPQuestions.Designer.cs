namespace Physics_Simulation
{
    partial class wavesPQuestions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wavesPQuestions));
            this.bArrow = new System.Windows.Forms.PictureBox();
            this.fadeIn = new System.Windows.Forms.Timer(this.components);
            this.fadeOut = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // bArrow
            // 
            this.bArrow.BackColor = System.Drawing.SystemColors.ControlText;
            this.bArrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bArrow.BackgroundImage")));
            this.bArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bArrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bArrow.Location = new System.Drawing.Point(-2, -5);
            this.bArrow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bArrow.Name = "bArrow";
            this.bArrow.Size = new System.Drawing.Size(90, 105);
            this.bArrow.TabIndex = 9;
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
            // wavesPQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bArrow);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "wavesPQuestions";
            this.Text = "wavesPQuestions";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.wavesPQuestions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bArrow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox bArrow;
        private System.Windows.Forms.Timer fadeIn;
        private System.Windows.Forms.Timer fadeOut;
    }
}