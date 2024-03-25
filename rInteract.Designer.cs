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
            this.aoR = new System.Windows.Forms.Label();
            this.bArrow = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.aOIText = new System.Windows.Forms.Label();
            this.angleOfIncidence = new System.Windows.Forms.TextBox();
            this.rI1Text = new System.Windows.Forms.Label();
            this.refractiveIndex2 = new System.Windows.Forms.TextBox();
            this.fadeIn = new System.Windows.Forms.Timer(this.components);
            this.fadeOut = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bArrow)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.5F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.bArrow, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // aoR
            // 
            this.aoR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.aoR.AutoSize = true;
            this.aoR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aoR.Location = new System.Drawing.Point(3, 106);
            this.aoR.Name = "aoR";
            this.aoR.Size = new System.Drawing.Size(176, 25);
            this.aoR.TabIndex = 2;
            this.aoR.Text = "Angle of Refraction";
            this.aoR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.aoR.Click += new System.EventHandler(this.aoR_Click);
            // 
            // bArrow
            // 
            this.bArrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bArrow.BackgroundImage")));
            this.bArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bArrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bArrow.Location = new System.Drawing.Point(3, 3);
            this.bArrow.Name = "bArrow";
            this.bArrow.Size = new System.Drawing.Size(117, 84);
            this.bArrow.TabIndex = 5;
            this.bArrow.TabStop = false;
            this.bArrow.Click += new System.EventHandler(this.bArrow_Click_1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.aOIText);
            this.flowLayoutPanel1.Controls.Add(this.angleOfIncidence);
            this.flowLayoutPanel1.Controls.Add(this.rI1Text);
            this.flowLayoutPanel1.Controls.Add(this.refractiveIndex2);
            this.flowLayoutPanel1.Controls.Add(this.aoR);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 273);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(470, 174);
            this.flowLayoutPanel1.TabIndex = 6;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // aOIText
            // 
            this.aOIText.AutoSize = true;
            this.aOIText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aOIText.Location = new System.Drawing.Point(3, 0);
            this.aOIText.Name = "aOIText";
            this.aOIText.Size = new System.Drawing.Size(173, 25);
            this.aOIText.TabIndex = 0;
            this.aOIText.Text = "Angle of Incidence";
            this.aOIText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.aOIText.Click += new System.EventHandler(this.aOIText_Click);
            // 
            // angleOfIncidence
            // 
            this.angleOfIncidence.Location = new System.Drawing.Point(3, 28);
            this.angleOfIncidence.Name = "angleOfIncidence";
            this.angleOfIncidence.Size = new System.Drawing.Size(173, 22);
            this.angleOfIncidence.TabIndex = 1;
            this.angleOfIncidence.TextChanged += new System.EventHandler(this.angleOfIncidence_TextChanged);
            // 
            // rI1Text
            // 
            this.rI1Text.AutoSize = true;
            this.rI1Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rI1Text.Location = new System.Drawing.Point(3, 53);
            this.rI1Text.Name = "rI1Text";
            this.rI1Text.Size = new System.Drawing.Size(167, 25);
            this.rI1Text.TabIndex = 2;
            this.rI1Text.Text = "Refractive Index 2";
            this.rI1Text.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rI1Text.Click += new System.EventHandler(this.rI1Text_Click);
            // 
            // refractiveIndex2
            // 
            this.refractiveIndex2.Location = new System.Drawing.Point(3, 81);
            this.refractiveIndex2.Name = "refractiveIndex2";
            this.refractiveIndex2.Size = new System.Drawing.Size(173, 22);
            this.refractiveIndex2.TabIndex = 3;
            this.refractiveIndex2.TextChanged += new System.EventHandler(this.refractiveIndex1_TextChanged);
            // 
            // fadeIn
            // 
            this.fadeIn.Enabled = true;
            this.fadeIn.Interval = 1;
            this.fadeIn.Tick += new System.EventHandler(this.fade_Tick);
            // 
            // fadeOut
            // 
            this.fadeOut.Interval = 1;
            this.fadeOut.Tick += new System.EventHandler(this.fadeOut_Tick);
            // 
            // rInteract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "rInteract";
            this.Text = "rInteract";
            this.Load += new System.EventHandler(this.rInteract_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bArrow)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox bArrow;
        private System.Windows.Forms.Timer fadeIn;
        private System.Windows.Forms.Timer fadeOut;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label aOIText;
        private System.Windows.Forms.TextBox angleOfIncidence;
        private System.Windows.Forms.Label rI1Text;
        private System.Windows.Forms.TextBox refractiveIndex2;
        private System.Windows.Forms.Label aoR;
    }
}