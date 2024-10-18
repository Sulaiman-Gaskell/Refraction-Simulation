namespace Physics_Simulation
{
    partial class qMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(qMenu));
            this.bArrow = new System.Windows.Forms.PictureBox();
            this.fadeIn = new System.Windows.Forms.Timer(this.components);
            this.fadeOut = new System.Windows.Forms.Timer(this.components);
            this.refractionMenu = new System.Windows.Forms.TableLayoutPanel();
            this.qPlay = new System.Windows.Forms.Button();
            this.pQuestions = new System.Windows.Forms.Button();
            this.menuText = new System.Windows.Forms.Label();
            this.animateObjects = new System.Windows.Forms.Timer(this.components);
            this.popOutQPlay = new System.Windows.Forms.Timer(this.components);
            this.popInQPlay = new System.Windows.Forms.Timer(this.components);
            this.popOutPQuestions = new System.Windows.Forms.Timer(this.components);
            this.popInPQuestions = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bArrow)).BeginInit();
            this.refractionMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // bArrow
            // 
            this.bArrow.BackColor = System.Drawing.SystemColors.ControlText;
            this.bArrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bArrow.BackgroundImage")));
            this.bArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bArrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bArrow.Location = new System.Drawing.Point(3, 4);
            this.bArrow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bArrow.Name = "bArrow";
            this.bArrow.Size = new System.Drawing.Size(90, 82);
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
            // refractionMenu
            // 
            this.refractionMenu.ColumnCount = 3;
            this.refractionMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.refractionMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.refractionMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.refractionMenu.Controls.Add(this.bArrow, 0, 0);
            this.refractionMenu.Controls.Add(this.qPlay, 1, 1);
            this.refractionMenu.Controls.Add(this.pQuestions, 1, 2);
            this.refractionMenu.Controls.Add(this.menuText, 1, 0);
            this.refractionMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.refractionMenu.Location = new System.Drawing.Point(0, 0);
            this.refractionMenu.Margin = new System.Windows.Forms.Padding(4);
            this.refractionMenu.Name = "refractionMenu";
            this.refractionMenu.RowCount = 4;
            this.refractionMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.refractionMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.refractionMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.refractionMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.refractionMenu.Size = new System.Drawing.Size(800, 450);
            this.refractionMenu.TabIndex = 8;
            this.refractionMenu.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.refractionMenu_CellPaint);
            this.refractionMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.refractionMenu_Paint);
            // 
            // qPlay
            // 
            this.qPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.qPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.qPlay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.qPlay.Location = new System.Drawing.Point(204, 94);
            this.qPlay.Margin = new System.Windows.Forms.Padding(4);
            this.qPlay.Name = "qPlay";
            this.qPlay.Size = new System.Drawing.Size(392, 127);
            this.qPlay.TabIndex = 0;
            this.qPlay.Text = "Quick Play";
            this.qPlay.UseVisualStyleBackColor = true;
            this.qPlay.Click += new System.EventHandler(this.qPlay_Click);
            this.qPlay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.qPlay_MouseClick);
            this.qPlay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.qPlay_MouseDown);
            this.qPlay.MouseEnter += new System.EventHandler(this.qPlay_MouseEnter);
            this.qPlay.MouseLeave += new System.EventHandler(this.qPlay_MouseLeave);
            // 
            // pQuestions
            // 
            this.pQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pQuestions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pQuestions.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pQuestions.Location = new System.Drawing.Point(204, 229);
            this.pQuestions.Margin = new System.Windows.Forms.Padding(4);
            this.pQuestions.Name = "pQuestions";
            this.pQuestions.Size = new System.Drawing.Size(392, 127);
            this.pQuestions.TabIndex = 2;
            this.pQuestions.Text = "Player Questions";
            this.pQuestions.UseVisualStyleBackColor = true;
            this.pQuestions.MouseEnter += new System.EventHandler(this.pQuestions_MouseEnter);
            this.pQuestions.MouseLeave += new System.EventHandler(this.pQuestions_MouseLeave);
            // 
            // menuText
            // 
            this.menuText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menuText.AutoSize = true;
            this.menuText.Location = new System.Drawing.Point(337, 0);
            this.menuText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.menuText.Name = "menuText";
            this.menuText.Size = new System.Drawing.Size(125, 20);
            this.menuText.TabIndex = 3;
            this.menuText.Text = "Choose a mode:";
            // 
            // animateObjects
            // 
            this.animateObjects.Interval = 13;
            this.animateObjects.Tick += new System.EventHandler(this.animateObjects_Tick);
            // 
            // popOutQPlay
            // 
            this.popOutQPlay.Interval = 13;
            this.popOutQPlay.Tick += new System.EventHandler(this.popOutQPlay_Tick);
            // 
            // popInQPlay
            // 
            this.popInQPlay.Interval = 13;
            this.popInQPlay.Tick += new System.EventHandler(this.popInQPlay_Tick);
            // 
            // popOutPQuestions
            // 
            this.popOutPQuestions.Interval = 13;
            this.popOutPQuestions.Tick += new System.EventHandler(this.popOutPQuestions_Tick);
            // 
            // popInPQuestions
            // 
            this.popInPQuestions.Interval = 13;
            this.popInPQuestions.Tick += new System.EventHandler(this.popInPQuestions_Tick);
            // 
            // qMenu
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.refractionMenu);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "qMenu";
            this.Text = "qMenu";
            this.Load += new System.EventHandler(this.qMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bArrow)).EndInit();
            this.refractionMenu.ResumeLayout(false);
            this.refractionMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox bArrow;
        private System.Windows.Forms.Timer fadeIn;
        private System.Windows.Forms.Timer fadeOut;
        private System.Windows.Forms.TableLayoutPanel refractionMenu;
        private System.Windows.Forms.Button qPlay;
        private System.Windows.Forms.Button pQuestions;
        private System.Windows.Forms.Label menuText;
        private System.Windows.Forms.Timer animateObjects;
        private System.Windows.Forms.Timer popOutQPlay;
        private System.Windows.Forms.Timer popInQPlay;
        private System.Windows.Forms.Timer popOutPQuestions;
        private System.Windows.Forms.Timer popInPQuestions;
    }
}