namespace Physics_Simulation
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