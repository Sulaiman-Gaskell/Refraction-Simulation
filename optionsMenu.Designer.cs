namespace Physics_Simulation
{
    partial class optionsMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(optionsMenu));
            this.refractionMenu = new System.Windows.Forms.TableLayoutPanel();
            this.bArrow = new System.Windows.Forms.PictureBox();
            this.interact = new System.Windows.Forms.Button();
            this.questions = new System.Windows.Forms.Button();
            this.menuText = new System.Windows.Forms.Label();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fadeIn = new System.Windows.Forms.Timer(this.components);
            this.fadeOut = new System.Windows.Forms.Timer(this.components);
            this.animateObjects = new System.Windows.Forms.Timer(this.components);
            this.popOutInteract = new System.Windows.Forms.Timer(this.components);
            this.popInInteract = new System.Windows.Forms.Timer(this.components);
            this.popOutQuestions = new System.Windows.Forms.Timer(this.components);
            this.popInQuestions = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.refractionMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // refractionMenu
            // 
            this.refractionMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refractionMenu.ColumnCount = 3;
            this.refractionMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.refractionMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.refractionMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.refractionMenu.Controls.Add(this.bArrow, 0, 0);
            this.refractionMenu.Controls.Add(this.interact, 1, 1);
            this.refractionMenu.Controls.Add(this.questions, 1, 2);
            this.refractionMenu.Controls.Add(this.menuText, 1, 0);
            this.refractionMenu.Cursor = System.Windows.Forms.Cursors.Default;
            this.refractionMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.refractionMenu.Location = new System.Drawing.Point(0, 0);
            this.refractionMenu.Name = "refractionMenu";
            this.refractionMenu.RowCount = 4;
            this.refractionMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.refractionMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.refractionMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.refractionMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.refractionMenu.Size = new System.Drawing.Size(800, 450);
            this.refractionMenu.TabIndex = 0;
            this.refractionMenu.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.refractionMenu_CellPaint);
            this.refractionMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.refractionMenu_Paint);
            // 
            // bArrow
            // 
            this.bArrow.BackColor = System.Drawing.SystemColors.ControlText;
            this.bArrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bArrow.BackgroundImage")));
            this.bArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bArrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bArrow.Location = new System.Drawing.Point(2, 3);
            this.bArrow.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bArrow.Name = "bArrow";
            this.bArrow.Size = new System.Drawing.Size(75, 83);
            this.bArrow.TabIndex = 6;
            this.bArrow.TabStop = false;
            this.bArrow.Click += new System.EventHandler(this.bArrow_Click_1);
            this.bArrow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bArrow_MouseDown);
            this.bArrow.MouseEnter += new System.EventHandler(this.bArrow_MouseEnter);
            this.bArrow.MouseLeave += new System.EventHandler(this.bArrow_MouseLeave);
            // 
            // interact
            // 
            this.interact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.interact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.interact.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.interact.Location = new System.Drawing.Point(203, 93);
            this.interact.Name = "interact";
            this.interact.Size = new System.Drawing.Size(394, 129);
            this.interact.TabIndex = 0;
            this.interact.Text = "Interactive";
            this.interact.UseVisualStyleBackColor = true;
            this.interact.Click += new System.EventHandler(this.button1_Click);
            this.interact.MouseDown += new System.Windows.Forms.MouseEventHandler(this.interact_MouseDown);
            this.interact.MouseEnter += new System.EventHandler(this.interact_MouseEnter);
            this.interact.MouseLeave += new System.EventHandler(this.interact_MouseLeave);
            this.interact.MouseHover += new System.EventHandler(this.interact_MouseHover);
            // 
            // questions
            // 
            this.questions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.questions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.questions.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.questions.Location = new System.Drawing.Point(203, 228);
            this.questions.Name = "questions";
            this.questions.Size = new System.Drawing.Size(394, 129);
            this.questions.TabIndex = 2;
            this.questions.Text = "Questions";
            this.questions.UseVisualStyleBackColor = true;
            this.questions.Click += new System.EventHandler(this.questions_Click);
            this.questions.MouseDown += new System.Windows.Forms.MouseEventHandler(this.questions_MouseDown);
            this.questions.MouseEnter += new System.EventHandler(this.questions_MouseEnter);
            this.questions.MouseLeave += new System.EventHandler(this.questions_MouseLeave);
            this.questions.MouseHover += new System.EventHandler(this.questions_MouseHover);
            // 
            // menuText
            // 
            this.menuText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menuText.AutoSize = true;
            this.menuText.Location = new System.Drawing.Point(400, 0);
            this.menuText.Name = "menuText";
            this.menuText.Size = new System.Drawing.Size(0, 16);
            this.menuText.TabIndex = 3;
            this.menuText.Click += new System.EventHandler(this.menuText_Click_1);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 24);
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
            this.fadeOut.Tick += new System.EventHandler(this.fadeOut_Tick_1);
            // 
            // animateObjects
            // 
            this.animateObjects.Interval = 13;
            this.animateObjects.Tick += new System.EventHandler(this.menuTextGrow_Tick);
            // 
            // popOutInteract
            // 
            this.popOutInteract.Interval = 13;
            this.popOutInteract.Tick += new System.EventHandler(this.popOutInteract_Tick);
            // 
            // popInInteract
            // 
            this.popInInteract.Interval = 13;
            this.popInInteract.Tick += new System.EventHandler(this.popInInteract_Tick);
            // 
            // popOutQuestions
            // 
            this.popOutQuestions.Interval = 13;
            this.popOutQuestions.Tick += new System.EventHandler(this.popOutQuestions_Tick);
            // 
            // popInQuestions
            // 
            this.popInQuestions.Interval = 13;
            this.popInQuestions.Tick += new System.EventHandler(this.popInQuestions_Tick);
            // 
            // optionsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.refractionMenu);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "optionsMenu";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Refraction_Load);
            this.SizeChanged += new System.EventHandler(this.optionsMenu_SizeChanged);
            this.refractionMenu.ResumeLayout(false);
            this.refractionMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bArrow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel refractionMenu;
        private System.Windows.Forms.Button interact;
        private System.Windows.Forms.Button questions;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label menuText;
        private System.Windows.Forms.Timer fadeIn;
        private System.Windows.Forms.Timer fadeOut;
        private System.Windows.Forms.Timer animateObjects;
        private System.Windows.Forms.Timer popOutInteract;
        private System.Windows.Forms.Timer popInInteract;
        private System.Windows.Forms.Timer popOutQuestions;
        private System.Windows.Forms.Timer popInQuestions;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox bArrow;
    }
}