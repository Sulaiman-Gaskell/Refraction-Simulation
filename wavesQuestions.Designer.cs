namespace Physics_Simulation
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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.generateQuestion = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.waveDraw = new System.Windows.Forms.Timer(this.components);
            this.resetResult = new System.Windows.Forms.Timer(this.components);
            this.stats = new System.Windows.Forms.Label();
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
            this.bArrow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bArrow.Name = "bArrow";
            this.bArrow.Size = new System.Drawing.Size(90, 105);
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.30197F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.23268F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.46535F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.stats, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.result, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.77179F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.22821F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 289);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(304, 158);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // amplitudeText
            // 
            this.amplitudeText.AutoSize = true;
            this.amplitudeText.Location = new System.Drawing.Point(3, 0);
            this.amplitudeText.Name = "amplitudeText";
            this.amplitudeText.Size = new System.Drawing.Size(103, 20);
            this.amplitudeText.TabIndex = 6;
            this.amplitudeText.Text = "Amplitude(m)";
            // 
            // amplitude
            // 
            this.amplitude.Location = new System.Drawing.Point(3, 23);
            this.amplitude.Name = "amplitude";
            this.amplitude.Size = new System.Drawing.Size(100, 26);
            this.amplitude.TabIndex = 7;
            this.amplitude.Text = "7.5";
            this.amplitude.TextChanged += new System.EventHandler(this.amplitude_TextChanged);
            // 
            // fParameter1
            // 
            this.fParameter1.AutoSize = true;
            this.fParameter1.Location = new System.Drawing.Point(3, 52);
            this.fParameter1.Name = "fParameter1";
            this.fParameter1.Size = new System.Drawing.Size(97, 20);
            this.fParameter1.TabIndex = 1;
            this.fParameter1.Text = "fParameter1";
            // 
            // fParameter2
            // 
            this.fParameter2.AutoSize = true;
            this.fParameter2.Location = new System.Drawing.Point(3, 72);
            this.fParameter2.Name = "fParameter2";
            this.fParameter2.Size = new System.Drawing.Size(97, 20);
            this.fParameter2.TabIndex = 2;
            this.fParameter2.Text = "fParameter2";
            // 
            // promptText
            // 
            this.promptText.AutoSize = true;
            this.promptText.ForeColor = System.Drawing.Color.Red;
            this.promptText.Location = new System.Drawing.Point(3, 92);
            this.promptText.Name = "promptText";
            this.promptText.Size = new System.Drawing.Size(231, 20);
            this.promptText.TabIndex = 11;
            this.promptText.Text = "Enter missing parameter below:";
            // 
            // mParameter
            // 
            this.mParameter.Location = new System.Drawing.Point(3, 115);
            this.mParameter.Name = "mParameter";
            this.mParameter.Size = new System.Drawing.Size(100, 26);
            this.mParameter.TabIndex = 12;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.generateQuestion);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(323, 289);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(153, 158);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // generateQuestion
            // 
            this.generateQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.generateQuestion.AutoSize = true;
            this.generateQuestion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.generateQuestion.Location = new System.Drawing.Point(3, 115);
            this.generateQuestion.Name = "generateQuestion";
            this.generateQuestion.Size = new System.Drawing.Size(155, 40);
            this.generateQuestion.TabIndex = 9;
            this.generateQuestion.Text = "Generate Question";
            this.generateQuestion.UseVisualStyleBackColor = true;
            this.generateQuestion.Click += new System.EventHandler(this.generateQuestion_Click);
            // 
            // result
            // 
            this.result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(482, 430);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 20);
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
            // stats
            // 
            this.stats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stats.AutoSize = true;
            this.stats.Location = new System.Drawing.Point(639, 0);
            this.stats.Name = "stats";
            this.stats.Size = new System.Drawing.Size(158, 40);
            this.stats.TabIndex = 12;
            this.stats.Text = "Percentage correct:\r\nQuestions answered:\r\n";
            // 
            // wavesQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bArrow);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
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