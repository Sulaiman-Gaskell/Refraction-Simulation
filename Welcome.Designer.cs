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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(welcomeScreen));
            refractionInteract = new System.Windows.Forms.Button();
            fadeIn = new System.Windows.Forms.Timer(components);
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            bArrow = new System.Windows.Forms.PictureBox();
            theme = new System.Windows.Forms.Button();
            wTxt = new System.Windows.Forms.Label();
            questions = new System.Windows.Forms.Button();
            energySaver = new System.Windows.Forms.Button();
            themeTip = new System.Windows.Forms.ToolTip(components);
            powerTip = new System.Windows.Forms.ToolTip(components);
            bArrowSizeUp = new System.Windows.Forms.Timer(components);
            bArrowSizeDown = new System.Windows.Forms.Timer(components);
            updateText = new System.Windows.Forms.Timer(components);
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bArrow).BeginInit();
            SuspendLayout();
            // 
            // refractionInteract
            // 
            refractionInteract.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            refractionInteract.AutoSize = true;
            refractionInteract.Cursor = System.Windows.Forms.Cursors.Hand;
            refractionInteract.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            refractionInteract.Location = new System.Drawing.Point(246, 260);
            refractionInteract.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            refractionInteract.Name = "refractionInteract";
            refractionInteract.Size = new System.Drawing.Size(629, 152);
            refractionInteract.TabIndex = 0;
            refractionInteract.Text = "Interactive Mode";
            refractionInteract.UseVisualStyleBackColor = true;
            refractionInteract.Click += button1_Click;
            refractionInteract.MouseDown += refraction_MouseDown;
            refractionInteract.MouseEnter += refraction_MouseEnter;
            refractionInteract.MouseLeave += refraction_MouseLeave;
            // 
            // fadeIn
            // 
            fadeIn.Enabled = true;
            fadeIn.Interval = 1;
            fadeIn.Tick += fadeIn_Tick;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            tableLayoutPanel1.BackgroundImage = (System.Drawing.Image)resources.GetObject("tableLayoutPanel1.BackgroundImage");
            tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.52838F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.94324F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.52838F));
            tableLayoutPanel1.Controls.Add(bArrow, 0, 0);
            tableLayoutPanel1.Controls.Add(theme, 2, 0);
            tableLayoutPanel1.Controls.Add(wTxt, 1, 0);
            tableLayoutPanel1.Controls.Add(refractionInteract, 1, 1);
            tableLayoutPanel1.Controls.Add(questions, 1, 2);
            tableLayoutPanel1.Controls.Add(energySaver, 2, 2);
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.76264F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.15136F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.086F));
            tableLayoutPanel1.Size = new System.Drawing.Size(1124, 906);
            tableLayoutPanel1.TabIndex = 3;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // bArrow
            // 
            bArrow.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            bArrow.BackColor = System.Drawing.Color.Transparent;
            bArrow.BackgroundImage = (System.Drawing.Image)resources.GetObject("bArrow.BackgroundImage");
            bArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            bArrow.Cursor = System.Windows.Forms.Cursors.Hand;
            bArrow.Location = new System.Drawing.Point(57, 6);
            bArrow.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            bArrow.Name = "bArrow";
            bArrow.Size = new System.Drawing.Size(71, 176);
            bArrow.TabIndex = 6;
            bArrow.TabStop = false;
            bArrow.Click += bArrow_Click;
            bArrow.MouseDown += bArrow_MouseDown;
            bArrow.MouseEnter += bArrow_MouseEnter;
            bArrow.MouseLeave += bArrow_MouseLeave;
            bArrow.MouseUp += bArrow_MouseUp;
            // 
            // theme
            // 
            theme.AllowDrop = true;
            theme.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            theme.BackColor = System.Drawing.Color.Transparent;
            theme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            theme.Cursor = System.Windows.Forms.Cursors.Hand;
            theme.Enabled = false;
            theme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            theme.ForeColor = System.Drawing.Color.Transparent;
            theme.Location = new System.Drawing.Point(1023, 3);
            theme.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            theme.Name = "theme";
            theme.Size = new System.Drawing.Size(96, 114);
            theme.TabIndex = 3;
            theme.UseVisualStyleBackColor = false;
            theme.Visible = false;
            theme.Click += settings_Click;
            theme.MouseDown += theme_MouseDown;
            theme.MouseEnter += settings_MouseEnter;
            theme.MouseUp += theme_MouseUp;
            // 
            // wTxt
            // 
            wTxt.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            wTxt.AutoSize = true;
            wTxt.BackColor = System.Drawing.Color.Transparent;
            wTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            wTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            wTxt.ForeColor = System.Drawing.SystemColors.Control;
            wTxt.Location = new System.Drawing.Point(342, 0);
            wTxt.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            wTxt.Name = "wTxt";
            wTxt.Size = new System.Drawing.Size(437, 188);
            wTxt.TabIndex = 2;
            wTxt.Text = "Refraction Simulation\r\n";
            wTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            wTxt.Click += label1_Click;
            wTxt.MouseClick += wTxt_MouseClick;
            // 
            // questions
            // 
            questions.Anchor = System.Windows.Forms.AnchorStyles.Top;
            questions.AutoSize = true;
            questions.Cursor = System.Windows.Forms.Cursors.Hand;
            questions.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            questions.Location = new System.Drawing.Point(264, 418);
            questions.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            questions.Name = "questions";
            questions.Size = new System.Drawing.Size(593, 117);
            questions.TabIndex = 5;
            questions.Text = "   Questions   ";
            questions.UseVisualStyleBackColor = true;
            questions.Click += questions_Click;
            questions.MouseEnter += questions_MouseEnter;
            questions.MouseLeave += questions_MouseLeave;
            // 
            // energySaver
            // 
            energySaver.AllowDrop = true;
            energySaver.BackColor = System.Drawing.Color.Transparent;
            energySaver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            energySaver.Cursor = System.Windows.Forms.Cursors.Hand;
            energySaver.Enabled = false;
            energySaver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            energySaver.ForeColor = System.Drawing.Color.Transparent;
            energySaver.Location = new System.Drawing.Point(942, 418);
            energySaver.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            energySaver.Name = "energySaver";
            energySaver.Size = new System.Drawing.Size(96, 114);
            energySaver.TabIndex = 4;
            energySaver.UseVisualStyleBackColor = false;
            energySaver.Visible = false;
            energySaver.Click += energySaver_Click;
            // 
            // themeTip
            // 
            themeTip.Popup += themeTip_Popup;
            // 
            // bArrowSizeUp
            // 
            bArrowSizeUp.Interval = 10;
            bArrowSizeUp.Tick += bArrowSize_Tick;
            // 
            // bArrowSizeDown
            // 
            bArrowSizeDown.Interval = 10;
            bArrowSizeDown.Tick += bArrowSIzeDown_Tick;
            // 
            // updateText
            // 
            updateText.Enabled = true;
            updateText.Interval = 3000;
            updateText.Tick += timer1_Tick;
            // 
            // welcomeScreen
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ClientSize = new System.Drawing.Size(1124, 906);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            MaximizeBox = false;
            Name = "welcomeScreen";
            Opacity = 0.5D;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            FormClosed += welcomeScreen_FormClosed;
            Load += welcomeScreen_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bArrow).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button refractionInteract;
        private System.Windows.Forms.Timer fadeIn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label wTxt;
        private System.Windows.Forms.ToolTip themeTip;
        private System.Windows.Forms.Button energySaver;
        private System.Windows.Forms.ToolTip powerTip;
        private System.Windows.Forms.Button theme;
        private System.Windows.Forms.Button questions;
        private System.Windows.Forms.PictureBox bArrow;
        private System.Windows.Forms.Timer bArrowSizeUp;
        private System.Windows.Forms.Timer bArrowSizeDown;
        private System.Windows.Forms.Timer updateText;
    }
}

