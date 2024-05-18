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
            this.wTxt = new System.Windows.Forms.Label();
            this.refraction = new System.Windows.Forms.Button();
            this.waves = new System.Windows.Forms.Button();
            this.fadeIn = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wTxt
            // 
            this.wTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.wTxt.AutoSize = true;
            this.wTxt.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.wTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wTxt.ForeColor = System.Drawing.SystemColors.Control;
            this.wTxt.Location = new System.Drawing.Point(230, 0);
            this.wTxt.Name = "wTxt";
            this.wTxt.Size = new System.Drawing.Size(318, 38);
            this.wTxt.TabIndex = 2;
            this.wTxt.Text = "Physics Simulations!";
            this.wTxt.Click += new System.EventHandler(this.label1_Click);
            // 
            // refraction
            // 
            this.refraction.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.refraction.AutoSize = true;
            this.refraction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refraction.Location = new System.Drawing.Point(239, 179);
            this.refraction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.refraction.Name = "refraction";
            this.refraction.Size = new System.Drawing.Size(300, 94);
            this.refraction.TabIndex = 0;
            this.refraction.Text = "Refraction";
            this.refraction.UseVisualStyleBackColor = true;
            this.refraction.Click += new System.EventHandler(this.button1_Click);
            this.refraction.MouseDown += new System.Windows.Forms.MouseEventHandler(this.refraction_MouseDown);
            this.refraction.MouseEnter += new System.EventHandler(this.refraction_MouseEnter);
            this.refraction.MouseLeave += new System.EventHandler(this.refraction_MouseLeave);
            // 
            // waves
            // 
            this.waves.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.waves.AutoSize = true;
            this.waves.Cursor = System.Windows.Forms.Cursors.Hand;
            this.waves.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waves.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.waves.Location = new System.Drawing.Point(304, 281);
            this.waves.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.waves.Name = "waves";
            this.waves.Size = new System.Drawing.Size(169, 100);
            this.waves.TabIndex = 1;
            this.waves.Text = "Waves";
            this.waves.UseVisualStyleBackColor = true;
            this.waves.Click += new System.EventHandler(this.waves_Click);
            this.waves.MouseDown += new System.Windows.Forms.MouseEventHandler(this.waves_MouseDown);
            this.waves.MouseEnter += new System.EventHandler(this.waves_MouseEnter);
            this.waves.MouseLeave += new System.EventHandler(this.waves_MouseLeave);
            // 
            // fadeIn
            // 
            this.fadeIn.Enabled = true;
            this.fadeIn.Interval = 1;
            this.fadeIn.Tick += new System.EventHandler(this.fadeIn_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.wTxt, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.waves, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.refraction, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.65519F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.5043F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.84051F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(778, 566);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // welcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(778, 566);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "welcomeScreen";
            this.Load += new System.EventHandler(this.welcomeScreen_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label wTxt;
        private System.Windows.Forms.Button refraction;
        private System.Windows.Forms.Button waves;
        private System.Windows.Forms.Timer fadeIn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

