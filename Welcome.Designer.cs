namespace Physics_Simulation
{
    partial class welcomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(welcomeScreen));
            this.refraction = new System.Windows.Forms.Button();
            this.fadeIn = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.theme = new System.Windows.Forms.Button();
            this.energySaver = new System.Windows.Forms.Button();
            this.wTxt = new System.Windows.Forms.Label();
            this.themeTip = new System.Windows.Forms.ToolTip(this.components);
            this.powerTip = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // refraction
            // 
            this.refraction.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.refraction.AutoSize = true;
            this.refraction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.refraction.Location = new System.Drawing.Point(226, 209);
            this.refraction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.refraction.Name = "refraction";
            this.refraction.Size = new System.Drawing.Size(238, 76);
            this.refraction.TabIndex = 0;
            this.refraction.Text = "     Start     ";
            this.refraction.UseVisualStyleBackColor = true;
            this.refraction.Click += new System.EventHandler(this.button1_Click);
            this.refraction.MouseDown += new System.Windows.Forms.MouseEventHandler(this.refraction_MouseDown);
            this.refraction.MouseEnter += new System.EventHandler(this.refraction_MouseEnter);
            this.refraction.MouseLeave += new System.EventHandler(this.refraction_MouseLeave);
            // 
            // fadeIn
            // 
            this.fadeIn.Enabled = true;
            this.fadeIn.Interval = 1;
            this.fadeIn.Tick += new System.EventHandler(this.fadeIn_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.52838F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.94324F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.52838F));
            this.tableLayoutPanel1.Controls.Add(this.theme, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.energySaver, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.wTxt, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.refraction, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.76264F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.15136F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.086F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(692, 453);
            this.tableLayoutPanel1.TabIndex = 3;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // theme
            // 
            this.theme.AllowDrop = true;
            this.theme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.theme.BackColor = System.Drawing.SystemColors.ControlText;
            this.theme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.theme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.theme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.theme.ForeColor = System.Drawing.SystemColors.ControlText;
            this.theme.Image = global::Physics_Simulation.Properties.Resources.moon;
            this.theme.Location = new System.Drawing.Point(630, 2);
            this.theme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.theme.Name = "theme";
            this.theme.Size = new System.Drawing.Size(59, 57);
            this.theme.TabIndex = 3;
            this.theme.UseVisualStyleBackColor = false;
            this.theme.Click += new System.EventHandler(this.settings_Click);
            this.theme.MouseDown += new System.Windows.Forms.MouseEventHandler(this.theme_MouseDown);
            this.theme.MouseEnter += new System.EventHandler(this.settings_MouseEnter);
            this.theme.MouseUp += new System.Windows.Forms.MouseEventHandler(this.theme_MouseUp);
            // 
            // energySaver
            // 
            this.energySaver.AllowDrop = true;
            this.energySaver.BackColor = System.Drawing.SystemColors.ControlText;
            this.energySaver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.energySaver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.energySaver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.energySaver.ForeColor = System.Drawing.SystemColors.ControlText;
            this.energySaver.Image = global::Physics_Simulation.Properties.Resources.energysaverlight;
            this.energySaver.Location = new System.Drawing.Point(3, 2);
            this.energySaver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.energySaver.Name = "energySaver";
            this.energySaver.Size = new System.Drawing.Size(59, 57);
            this.energySaver.TabIndex = 4;
            this.energySaver.UseVisualStyleBackColor = false;
            this.energySaver.Click += new System.EventHandler(this.energySaver_Click);
            // 
            // wTxt
            // 
            this.wTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.wTxt.AutoSize = true;
            this.wTxt.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.wTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wTxt.ForeColor = System.Drawing.SystemColors.Control;
            this.wTxt.Location = new System.Drawing.Point(202, 0);
            this.wTxt.Name = "wTxt";
            this.wTxt.Size = new System.Drawing.Size(286, 32);
            this.wTxt.TabIndex = 2;
            this.wTxt.Text = "Refraction Simulation";
            this.wTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.wTxt.Click += new System.EventHandler(this.label1_Click);
            this.wTxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.wTxt_MouseClick);
            // 
            // themeTip
            // 
            this.themeTip.Popup += new System.Windows.Forms.PopupEventHandler(this.themeTip_Popup);
            // 
            // welcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(692, 453);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "welcomeScreen";
            this.Opacity = 0.5D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.welcomeScreen_FormClosed);
            this.Load += new System.EventHandler(this.welcomeScreen_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button refraction;
        private System.Windows.Forms.Timer fadeIn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label wTxt;
        private System.Windows.Forms.Button theme;
        private System.Windows.Forms.ToolTip themeTip;
        private System.Windows.Forms.Button energySaver;
        private System.Windows.Forms.ToolTip powerTip;
    }
}

