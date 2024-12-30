namespace Physics_Simulation
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