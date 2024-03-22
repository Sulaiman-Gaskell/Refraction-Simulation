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
            this.bArrow = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.aOIText = new System.Windows.Forms.Label();
            this.angleOfIncidence = new System.Windows.Forms.TextBox();
            this.rI1Text = new System.Windows.Forms.Label();
            this.refractiveIndex1 = new System.Windows.Forms.TextBox();
            this.fadeIn = new System.Windows.Forms.Timer(this.components);
            this.fadeOut = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bArrow)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.5F));
            this.tableLayoutPanel1.Controls.Add(this.bArrow, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(900, 562);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // bArrow
            // 
            this.bArrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bArrow.BackgroundImage")));
            this.bArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bArrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bArrow.Location = new System.Drawing.Point(3, 4);
            this.bArrow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bArrow.Name = "bArrow";
            this.bArrow.Size = new System.Drawing.Size(132, 105);
            this.bArrow.TabIndex = 5;
            this.bArrow.TabStop = false;
            this.bArrow.Click += new System.EventHandler(this.bArrow_Click_1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.aOIText);
            this.flowLayoutPanel1.Controls.Add(this.angleOfIncidence);
            this.flowLayoutPanel1.Controls.Add(this.rI1Text);
            this.flowLayoutPanel1.Controls.Add(this.refractiveIndex1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 341);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(529, 217);
            this.flowLayoutPanel1.TabIndex = 6;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // aOIText
            // 
            this.aOIText.AutoSize = true;
            this.aOIText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aOIText.Location = new System.Drawing.Point(3, 0);
            this.aOIText.Name = "aOIText";
            this.aOIText.Size = new System.Drawing.Size(211, 29);
            this.aOIText.TabIndex = 0;
            this.aOIText.Text = "Angle of Incidence";
            this.aOIText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.aOIText.Click += new System.EventHandler(this.aOIText_Click);
            // 
            // angleOfIncidence
            // 
            this.angleOfIncidence.Location = new System.Drawing.Point(3, 33);
            this.angleOfIncidence.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.angleOfIncidence.Name = "angleOfIncidence";
            this.angleOfIncidence.Size = new System.Drawing.Size(194, 26);
            this.angleOfIncidence.TabIndex = 1;
            this.angleOfIncidence.TextChanged += new System.EventHandler(this.angleOfIncidence_TextChanged);
            // 
            // rI1Text
            // 
            this.rI1Text.AutoSize = true;
            this.rI1Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rI1Text.Location = new System.Drawing.Point(3, 63);
            this.rI1Text.Name = "rI1Text";
            this.rI1Text.Size = new System.Drawing.Size(203, 29);
            this.rI1Text.TabIndex = 2;
            this.rI1Text.Text = "Refractive Index 1";
            this.rI1Text.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rI1Text.Click += new System.EventHandler(this.rI1Text_Click);
            // 
            // refractiveIndex1
            // 
            this.refractiveIndex1.Location = new System.Drawing.Point(3, 96);
            this.refractiveIndex1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.refractiveIndex1.Name = "refractiveIndex1";
            this.refractiveIndex1.Size = new System.Drawing.Size(194, 26);
            this.refractiveIndex1.TabIndex = 3;
            this.refractiveIndex1.TextChanged += new System.EventHandler(this.refractiveIndex1_TextChanged);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimizeBox = false;
            this.Name = "rInteract";
            this.Text = "rInteract";
            this.Load += new System.EventHandler(this.rInteract_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bArrow)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox refractiveIndex1;
    }
}