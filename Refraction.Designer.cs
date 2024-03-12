namespace Physics_Simulation
{
    partial class Refraction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Refraction));
            this.refractionMenu = new System.Windows.Forms.TableLayoutPanel();
            this.interact = new System.Windows.Forms.Button();
            this.questions = new System.Windows.Forms.Button();
            this.menuText = new System.Windows.Forms.Label();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.refractionMenu.SuspendLayout();
            this.SuspendLayout();
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
            this.refractionMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.refractionMenu_Paint);
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
            // 
            // menuText
            // 
            this.menuText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menuText.AutoSize = true;
            this.menuText.Location = new System.Drawing.Point(400, 0);
            this.menuText.Name = "menuText";
            this.menuText.Size = new System.Drawing.Size(0, 16);
            this.menuText.TabIndex = 1;
            this.menuText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.menuText.Click += new System.EventHandler(this.menuText_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 24);
            // 
            // Refraction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.refractionMenu);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Refraction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Refraction";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Refraction_Load);
            this.refractionMenu.ResumeLayout(false);
            this.refractionMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel refractionMenu;
        private System.Windows.Forms.Button interact;
        private System.Windows.Forms.Label menuText;
        private System.Windows.Forms.Button questions;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}