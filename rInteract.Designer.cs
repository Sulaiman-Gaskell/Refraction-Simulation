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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rInteract));
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            linkLabel1 = new System.Windows.Forms.LinkLabel();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            refractiveIndex2 = new System.Windows.Forms.TextBox();
            rI2Text = new System.Windows.Forms.Label();
            refractiveIndex1 = new System.Windows.Forms.TextBox();
            rI1Text = new System.Windows.Forms.Label();
            angleOfIncidence = new System.Windows.Forms.TextBox();
            aOIText = new System.Windows.Forms.Label();
            glossary = new System.Windows.Forms.LinkLabel();
            aoR = new System.Windows.Forms.Label();
            bArrow = new System.Windows.Forms.PictureBox();
            fadeIn = new System.Windows.Forms.Timer(components);
            fadeOut = new System.Windows.Forms.Timer(components);
            linesAnimate = new System.Windows.Forms.Timer(components);
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bArrow).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            tableLayoutPanel1.BackgroundImage = (System.Drawing.Image)resources.GetObject("tableLayoutPanel1.BackgroundImage");
            tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.64975F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.35025F));
            tableLayoutPanel1.Controls.Add(linkLabel1, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 1);
            tableLayoutPanel1.Controls.Add(aoR, 2, 1);
            tableLayoutPanel1.Controls.Add(bArrow, 1, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.80146F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.19854F));
            tableLayoutPanel1.Size = new System.Drawing.Size(1300, 899);
            tableLayoutPanel1.TabIndex = 1;
            tableLayoutPanel1.CellPaint += tableLayoutPanel1_CellPaint;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = System.Drawing.Color.Navy;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = System.Drawing.Color.Transparent;
            linkLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            linkLabel1.DisabledLinkColor = System.Drawing.Color.Transparent;
            linkLabel1.ForeColor = System.Drawing.Color.White;
            linkLabel1.LinkColor = System.Drawing.Color.White;
            linkLabel1.Location = new System.Drawing.Point(5, 0);
            linkLabel1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new System.Drawing.Size(5, 482);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Click here for info";
            linkLabel1.VisitedLinkColor = System.Drawing.Color.White;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(refractiveIndex2);
            flowLayoutPanel1.Controls.Add(rI2Text);
            flowLayoutPanel1.Controls.Add(refractiveIndex1);
            flowLayoutPanel1.Controls.Add(rI1Text);
            flowLayoutPanel1.Controls.Add(angleOfIncidence);
            flowLayoutPanel1.Controls.Add(aOIText);
            flowLayoutPanel1.Controls.Add(glossary);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            flowLayoutPanel1.ForeColor = System.Drawing.Color.White;
            flowLayoutPanel1.Location = new System.Drawing.Point(20, 489);
            flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(203, 404);
            flowLayoutPanel1.TabIndex = 6;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // refractiveIndex2
            // 
            refractiveIndex2.Location = new System.Drawing.Point(5, 357);
            refractiveIndex2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            refractiveIndex2.Name = "refractiveIndex2";
            refractiveIndex2.Size = new System.Drawing.Size(279, 39);
            refractiveIndex2.TabIndex = 3;
            refractiveIndex2.Text = "1";
            refractiveIndex2.TextChanged += refractiveIndex1_TextChanged;
            refractiveIndex2.KeyPress += refractiveIndex2_KeyPress;
            // 
            // rI2Text
            // 
            rI2Text.AutoSize = true;
            rI2Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            rI2Text.Location = new System.Drawing.Point(5, 314);
            rI2Text.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            rI2Text.Name = "rI2Text";
            rI2Text.Size = new System.Drawing.Size(270, 37);
            rI2Text.TabIndex = 2;
            rI2Text.Text = "Refractive Index 2";
            rI2Text.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            rI2Text.Click += rI1Text_Click;
            // 
            // refractiveIndex1
            // 
            refractiveIndex1.Location = new System.Drawing.Point(5, 269);
            refractiveIndex1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            refractiveIndex1.Name = "refractiveIndex1";
            refractiveIndex1.Size = new System.Drawing.Size(279, 39);
            refractiveIndex1.TabIndex = 5;
            refractiveIndex1.Text = "1";
            refractiveIndex1.TextChanged += refractiveIndex1_TextChanged_1;
            refractiveIndex1.KeyPress += refractiveIndex1_KeyPress;
            // 
            // rI1Text
            // 
            rI1Text.AutoSize = true;
            rI1Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            rI1Text.Location = new System.Drawing.Point(5, 226);
            rI1Text.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            rI1Text.Name = "rI1Text";
            rI1Text.Size = new System.Drawing.Size(268, 37);
            rI1Text.TabIndex = 4;
            rI1Text.Text = "Refractive Index 1";
            rI1Text.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // angleOfIncidence
            // 
            angleOfIncidence.Location = new System.Drawing.Point(5, 181);
            angleOfIncidence.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            angleOfIncidence.Name = "angleOfIncidence";
            angleOfIncidence.Size = new System.Drawing.Size(279, 39);
            angleOfIncidence.TabIndex = 1;
            angleOfIncidence.Text = "45";
            angleOfIncidence.TextChanged += angleOfIncidence_TextChanged;
            angleOfIncidence.KeyPress += angleOfIncidence_KeyPress;
            // 
            // aOIText
            // 
            aOIText.AutoSize = true;
            aOIText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            aOIText.Location = new System.Drawing.Point(5, 138);
            aOIText.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            aOIText.Name = "aOIText";
            aOIText.Size = new System.Drawing.Size(279, 37);
            aOIText.TabIndex = 0;
            aOIText.Text = "Angle of Incidence";
            aOIText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            aOIText.Click += aOIText_Click;
            // 
            // glossary
            // 
            glossary.ActiveLinkColor = System.Drawing.Color.Navy;
            glossary.Anchor = System.Windows.Forms.AnchorStyles.None;
            glossary.AutoSize = true;
            glossary.BackColor = System.Drawing.Color.Transparent;
            glossary.DisabledLinkColor = System.Drawing.Color.Transparent;
            glossary.ForeColor = System.Drawing.Color.White;
            glossary.LinkColor = System.Drawing.Color.White;
            glossary.Location = new System.Drawing.Point(294, 160);
            glossary.Margin = new System.Windows.Forms.Padding(5, 0, 5, 200);
            glossary.Name = "glossary";
            glossary.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            glossary.Size = new System.Drawing.Size(205, 42);
            glossary.TabIndex = 2;
            glossary.TabStop = true;
            glossary.Text = "Click here for info";
            glossary.VisitedLinkColor = System.Drawing.Color.White;
            glossary.LinkClicked += glossary_LinkClicked;
            glossary.MouseDown += glossary_MouseDown;
            glossary.MouseLeave += glossary_MouseLeave;
            // 
            // aoR
            // 
            aoR.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            aoR.AutoSize = true;
            aoR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            aoR.Location = new System.Drawing.Point(1006, 862);
            aoR.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            aoR.Name = "aoR";
            aoR.Size = new System.Drawing.Size(289, 37);
            aoR.TabIndex = 2;
            aoR.Text = "Angle of Refraction";
            aoR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            aoR.Click += aoR_Click;
            // 
            // bArrow
            // 
            bArrow.BackColor = System.Drawing.Color.Transparent;
            bArrow.BackgroundImage = (System.Drawing.Image)resources.GetObject("bArrow.BackgroundImage");
            bArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            bArrow.Cursor = System.Windows.Forms.Cursors.Hand;
            bArrow.Location = new System.Drawing.Point(20, 50);
            bArrow.Margin = new System.Windows.Forms.Padding(5, 50, 5, 6);
            bArrow.Name = "bArrow";
            bArrow.Size = new System.Drawing.Size(113, 128);
            bArrow.TabIndex = 5;
            bArrow.TabStop = false;
            bArrow.Click += bArrow_Click_1;
            bArrow.MouseDown += bArrow_MouseDown;
            bArrow.MouseEnter += bArrow_MouseEnter;
            bArrow.MouseLeave += bArrow_MouseLeave;
            // 
            // fadeIn
            // 
            fadeIn.Interval = 1;
            fadeIn.Tick += fade_Tick;
            // 
            // fadeOut
            // 
            fadeOut.Interval = 1;
            fadeOut.Tick += fadeOut_Tick_1;
            // 
            // linesAnimate
            // 
            linesAnimate.Interval = 1;
            linesAnimate.Tick += lineAnimate_Tick;
            // 
            // rInteract
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlText;
            ClientSize = new System.Drawing.Size(1300, 899);
            Controls.Add(tableLayoutPanel1);
            ForeColor = System.Drawing.SystemColors.ControlLight;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            Name = "rInteract";
            Opacity = 0D;
            RightToLeft = System.Windows.Forms.RightToLeft.No;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            FormClosing += rInteract_FormClosing;
            Load += rInteract_Load;
            Shown += rInteract_Shown;
            SizeChanged += rInteract_SizeChanged;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bArrow).EndInit();
            ResumeLayout(false);
            PerformLayout();

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
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}