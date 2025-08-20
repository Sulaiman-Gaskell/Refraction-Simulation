namespace Physics_Simulation
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
            this.linesAnimate = new System.Windows.Forms.Timer(this.components);
            this.vgf = new System.Windows.Forms.Timer(this.components);
            this.saveSwitch = new System.Windows.Forms.Timer(this.components);
            this.clearSwitch = new System.Windows.Forms.Timer(this.components);
            this.linesAnimateLeave = new System.Windows.Forms.Timer(this.components);
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
            this.tableLayoutPanel1.Controls.Add(this.bArrow, 0, 0);
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
            this.clearAll.Location = new System.Drawing.Point(291, 262);
            this.clearAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(127, 26);
            this.clearAll.TabIndex = 8;
            this.clearAll.Text = "Clear all questions";
            this.clearAll.UseVisualStyleBackColor = true;
            this.clearAll.Click += new System.EventHandler(this.clearAll_Click);
            // 
            // bArrow
            // 
            this.bArrow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bArrow.BackColor = System.Drawing.Color.Transparent;
            this.bArrow.BackgroundImage = global::Physics_Simulation.Properties.Resources.darkBackArrow;
            this.bArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bArrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bArrow.Location = new System.Drawing.Point(13, 3);
            this.bArrow.Name = "bArrow";
            this.bArrow.Size = new System.Drawing.Size(80, 56);
            this.bArrow.TabIndex = 7;
            this.bArrow.TabStop = false;
            this.bArrow.Click += new System.EventHandler(this.bArrow_Click);
            this.bArrow.MouseEnter += new System.EventHandler(this.bArrow_MouseEnter);
            this.bArrow.MouseLeave += new System.EventHandler(this.bArrow_MouseLeave);
            // 
            // linesAnimate
            // 
            this.linesAnimate.Enabled = true;
            this.linesAnimate.Interval = 1;
            this.linesAnimate.Tick += new System.EventHandler(this.linesAnimate_Tick);
            // 
            // vgf
            // 
            this.vgf.Interval = 1;
            this.vgf.Tick += new System.EventHandler(this.vgf_Tick);
            // 
            // saveSwitch
            // 
            this.saveSwitch.Interval = 1000;
            this.saveSwitch.Tick += new System.EventHandler(this.saveSwitch_Tick);
            // 
            // clearSwitch
            // 
            this.clearSwitch.Interval = 1000;
            this.clearSwitch.Tick += new System.EventHandler(this.clearSwitch_Tick);
            // 
            // linesAnimateLeave
            // 
            this.linesAnimateLeave.Interval = 1;
            this.linesAnimateLeave.Tick += new System.EventHandler(this.linesAnimateLeave_Tick);
            // 
            // refractionBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(711, 360);
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
        private System.Windows.Forms.Timer linesAnimate;
        private System.Windows.Forms.Timer vgf;
        private System.Windows.Forms.Timer saveSwitch;
        private System.Windows.Forms.Timer clearSwitch;
        private System.Windows.Forms.Timer linesAnimateLeave;
    }
}