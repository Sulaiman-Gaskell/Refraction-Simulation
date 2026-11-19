namespace Physics_Simulation
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.rInteract_FormClosing);
            this.Load += new System.EventHandler(this.rInteract_Load);
            this.Shown += new System.EventHandler(this.rInteract_Shown);
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