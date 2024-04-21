namespace Physics_Simulation
{
    partial class Waves
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Waves));
            this.fadeIn = new System.Windows.Forms.Timer(this.components);
            this.fadeOut = new System.Windows.Forms.Timer(this.components);
            this.refractionMenu = new System.Windows.Forms.TableLayoutPanel();
            this.interact = new System.Windows.Forms.Button();
            this.questions = new System.Windows.Forms.Button();
            this.menuText = new System.Windows.Forms.Label();
            this.bArrow = new System.Windows.Forms.PictureBox();
            this.refractionMenu.SuspendLayout();
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
            // refractionMenu
            // 
            this.refractionMenu.ColumnCount = 3;
            this.refractionMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.refractionMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.refractionMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.refractionMenu.Controls.Add(this.interact, 1, 1);
            this.refractionMenu.Controls.Add(this.questions, 1, 2);
            this.refractionMenu.Controls.Add(this.menuText, 1, 0);
            this.refractionMenu.Controls.Add(this.bArrow, 0, 0);
            this.refractionMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.refractionMenu.Location = new System.Drawing.Point(0, 0);
            this.refractionMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.refractionMenu.Name = "refractionMenu";
            this.refractionMenu.RowCount = 4;
            this.refractionMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.refractionMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.refractionMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.refractionMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.refractionMenu.Size = new System.Drawing.Size(711, 360);
            this.refractionMenu.TabIndex = 1;
            // 
            // interact
            // 
            this.interact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.interact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.interact.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.interact.Location = new System.Drawing.Point(181, 75);
            this.interact.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.interact.Name = "interact";
            this.interact.Size = new System.Drawing.Size(347, 102);
            this.interact.TabIndex = 0;
            this.interact.Text = "Coming soon!";
            this.interact.UseVisualStyleBackColor = true;
            // 
            // questions
            // 
            this.questions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.questions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.questions.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.questions.Location = new System.Drawing.Point(181, 183);
            this.questions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.questions.Name = "questions";
            this.questions.Size = new System.Drawing.Size(347, 102);
            this.questions.TabIndex = 2;
            this.questions.Text = "Coming soon!";
            this.questions.UseVisualStyleBackColor = true;
            // 
            // menuText
            // 
            this.menuText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menuText.AutoSize = true;
            this.menuText.Location = new System.Drawing.Point(301, 0);
            this.menuText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.menuText.Name = "menuText";
            this.menuText.Size = new System.Drawing.Size(106, 16);
            this.menuText.TabIndex = 3;
            this.menuText.Text = "Choose a mode:";
            // 
            // bArrow
            // 
            this.bArrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bArrow.BackgroundImage")));
            this.bArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bArrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bArrow.Location = new System.Drawing.Point(4, 3);
            this.bArrow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bArrow.Name = "bArrow";
            this.bArrow.Size = new System.Drawing.Size(92, 66);
            this.bArrow.TabIndex = 4;
            this.bArrow.TabStop = false;
            this.bArrow.Click += new System.EventHandler(this.bArrow_Click);
            // 
            // Waves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.refractionMenu);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Waves";
            this.Opacity = 0D;
            this.Text = "V1.4.0, BETA1";
            this.Load += new System.EventHandler(this.Waves_Load);
            this.refractionMenu.ResumeLayout(false);
            this.refractionMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bArrow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer fadeIn;
        private System.Windows.Forms.Timer fadeOut;
        private System.Windows.Forms.TableLayoutPanel refractionMenu;
        private System.Windows.Forms.Button interact;
        private System.Windows.Forms.Button questions;
        private System.Windows.Forms.Label menuText;
        private System.Windows.Forms.PictureBox bArrow;
    }
}