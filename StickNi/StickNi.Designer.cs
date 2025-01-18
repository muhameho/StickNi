namespace StickNi
{
    partial class StickNi
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StickNi));
            pnlHeaderControls = new Panel();
            pnlHeaderLeftControls = new Panel();
            pbAppIcon = new PictureBox();
            lblAppName = new Label();
            pnlHeaderRightControls = new Panel();
            btnMinimize = new Button();
            btnClose = new Button();
            pnlBottom = new Panel();
            pbGithub = new PictureBox();
            btnLeftToRight = new Button();
            btnRightToLeft = new Button();
            pnlBackColor = new Panel();
            btnDarkGrey = new Button();
            btnYellow = new Button();
            btnCyan = new Button();
            pbBackColor = new PictureBox();
            btnUnderline = new Button();
            btnItalic = new Button();
            btnBold = new Button();
            pnlBody = new Panel();
            pnlTopLine = new Panel();
            pnlBottomLine = new Panel();
            rtbText = new RichTextBox();
            pnlHeaderControls.SuspendLayout();
            pnlHeaderLeftControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAppIcon).BeginInit();
            pnlHeaderRightControls.SuspendLayout();
            pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbGithub).BeginInit();
            pnlBackColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbBackColor).BeginInit();
            pnlBody.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeaderControls
            // 
            pnlHeaderControls.BackColor = Color.Transparent;
            pnlHeaderControls.Controls.Add(pnlHeaderLeftControls);
            pnlHeaderControls.Controls.Add(pnlHeaderRightControls);
            pnlHeaderControls.Dock = DockStyle.Top;
            pnlHeaderControls.Location = new Point(0, 0);
            pnlHeaderControls.Name = "pnlHeaderControls";
            pnlHeaderControls.Size = new Size(340, 26);
            pnlHeaderControls.TabIndex = 1;
            pnlHeaderControls.MouseDown += pnlHeaderControls_MouseDown;
            pnlHeaderControls.MouseMove += pnlHeaderControls_MouseMove;
            pnlHeaderControls.MouseUp += pnlHeaderControls_MouseUp;
            // 
            // pnlHeaderLeftControls
            // 
            pnlHeaderLeftControls.Controls.Add(pbAppIcon);
            pnlHeaderLeftControls.Controls.Add(lblAppName);
            pnlHeaderLeftControls.Dock = DockStyle.Left;
            pnlHeaderLeftControls.Location = new Point(0, 0);
            pnlHeaderLeftControls.Name = "pnlHeaderLeftControls";
            pnlHeaderLeftControls.Size = new Size(78, 26);
            pnlHeaderLeftControls.TabIndex = 5;
            // 
            // pbAppIcon
            // 
            pbAppIcon.Cursor = Cursors.Hand;
            pbAppIcon.Dock = DockStyle.Left;
            pbAppIcon.Image = (Image)resources.GetObject("pbAppIcon.Image");
            pbAppIcon.Location = new Point(0, 0);
            pbAppIcon.Name = "pbAppIcon";
            pbAppIcon.Size = new Size(23, 26);
            pbAppIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAppIcon.TabIndex = 5;
            pbAppIcon.TabStop = false;
            pbAppIcon.DoubleClick += pbAppIcon_DoubleClick;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppName.ForeColor = Color.Coral;
            lblAppName.Location = new Point(24, 5);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(51, 17);
            lblAppName.TabIndex = 4;
            lblAppName.Text = "StickNi";
            // 
            // pnlHeaderRightControls
            // 
            pnlHeaderRightControls.Controls.Add(btnMinimize);
            pnlHeaderRightControls.Controls.Add(btnClose);
            pnlHeaderRightControls.Dock = DockStyle.Right;
            pnlHeaderRightControls.Location = new Point(295, 0);
            pnlHeaderRightControls.Name = "pnlHeaderRightControls";
            pnlHeaderRightControls.Size = new Size(45, 26);
            pnlHeaderRightControls.TabIndex = 4;
            // 
            // btnMinimize
            // 
            btnMinimize.BackColor = Color.Transparent;
            btnMinimize.Cursor = Cursors.Hand;
            btnMinimize.Dock = DockStyle.Right;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinimize.ForeColor = Color.Peru;
            btnMinimize.Location = new Point(1, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(22, 26);
            btnMinimize.TabIndex = 3;
            btnMinimize.Text = "-";
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.Red;
            btnClose.Location = new Point(23, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(22, 26);
            btnClose.TabIndex = 2;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // pnlBottom
            // 
            pnlBottom.BackColor = Color.Transparent;
            pnlBottom.Controls.Add(pbGithub);
            pnlBottom.Controls.Add(btnLeftToRight);
            pnlBottom.Controls.Add(btnRightToLeft);
            pnlBottom.Controls.Add(pnlBackColor);
            pnlBottom.Controls.Add(btnUnderline);
            pnlBottom.Controls.Add(btnItalic);
            pnlBottom.Controls.Add(btnBold);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(0, 382);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new Size(340, 31);
            pnlBottom.TabIndex = 2;
            // 
            // pbGithub
            // 
            pbGithub.Cursor = Cursors.Hand;
            pbGithub.Dock = DockStyle.Left;
            pbGithub.Image = (Image)resources.GetObject("pbGithub.Image");
            pbGithub.Location = new Point(160, 0);
            pbGithub.Name = "pbGithub";
            pbGithub.Size = new Size(31, 31);
            pbGithub.SizeMode = PictureBoxSizeMode.StretchImage;
            pbGithub.TabIndex = 6;
            pbGithub.TabStop = false;
            pbGithub.Click += pbGithub_Click;
            // 
            // btnLeftToRight
            // 
            btnLeftToRight.AutoSize = true;
            btnLeftToRight.BackColor = Color.Transparent;
            btnLeftToRight.Cursor = Cursors.Hand;
            btnLeftToRight.Dock = DockStyle.Left;
            btnLeftToRight.FlatAppearance.BorderSize = 0;
            btnLeftToRight.FlatStyle = FlatStyle.Flat;
            btnLeftToRight.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLeftToRight.Location = new Point(128, 0);
            btnLeftToRight.Name = "btnLeftToRight";
            btnLeftToRight.Size = new Size(32, 31);
            btnLeftToRight.TabIndex = 5;
            btnLeftToRight.Text = ">";
            btnLeftToRight.TextAlign = ContentAlignment.MiddleRight;
            btnLeftToRight.UseVisualStyleBackColor = false;
            btnLeftToRight.Click += btnLeftToRight_Click;
            // 
            // btnRightToLeft
            // 
            btnRightToLeft.AutoSize = true;
            btnRightToLeft.BackColor = Color.Transparent;
            btnRightToLeft.Cursor = Cursors.Hand;
            btnRightToLeft.Dock = DockStyle.Left;
            btnRightToLeft.FlatAppearance.BorderSize = 0;
            btnRightToLeft.FlatStyle = FlatStyle.Flat;
            btnRightToLeft.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRightToLeft.Location = new Point(96, 0);
            btnRightToLeft.Name = "btnRightToLeft";
            btnRightToLeft.Size = new Size(32, 31);
            btnRightToLeft.TabIndex = 4;
            btnRightToLeft.Text = "<";
            btnRightToLeft.TextAlign = ContentAlignment.MiddleRight;
            btnRightToLeft.UseVisualStyleBackColor = false;
            btnRightToLeft.Click += btnRightToLeft_Click;
            // 
            // pnlBackColor
            // 
            pnlBackColor.Controls.Add(btnDarkGrey);
            pnlBackColor.Controls.Add(btnYellow);
            pnlBackColor.Controls.Add(btnCyan);
            pnlBackColor.Controls.Add(pbBackColor);
            pnlBackColor.Cursor = Cursors.Hand;
            pnlBackColor.Dock = DockStyle.Right;
            pnlBackColor.Location = new Point(309, 0);
            pnlBackColor.Name = "pnlBackColor";
            pnlBackColor.Size = new Size(31, 31);
            pnlBackColor.TabIndex = 3;
            // 
            // btnDarkGrey
            // 
            btnDarkGrey.BackColor = Color.FromArgb(106, 106, 106);
            btnDarkGrey.Cursor = Cursors.Hand;
            btnDarkGrey.Dock = DockStyle.Right;
            btnDarkGrey.FlatAppearance.BorderSize = 0;
            btnDarkGrey.FlatStyle = FlatStyle.Flat;
            btnDarkGrey.Location = new Point(-93, 0);
            btnDarkGrey.Name = "btnDarkGrey";
            btnDarkGrey.Size = new Size(31, 31);
            btnDarkGrey.TabIndex = 3;
            btnDarkGrey.UseVisualStyleBackColor = false;
            btnDarkGrey.Click += btnDarkGrey_Click;
            // 
            // btnYellow
            // 
            btnYellow.BackColor = Color.FromArgb(255, 247, 209);
            btnYellow.Cursor = Cursors.Hand;
            btnYellow.Dock = DockStyle.Right;
            btnYellow.FlatAppearance.BorderSize = 0;
            btnYellow.FlatStyle = FlatStyle.Flat;
            btnYellow.Location = new Point(-62, 0);
            btnYellow.Name = "btnYellow";
            btnYellow.Size = new Size(31, 31);
            btnYellow.TabIndex = 2;
            btnYellow.UseVisualStyleBackColor = false;
            btnYellow.Click += btnYellow_Click;
            // 
            // btnCyan
            // 
            btnCyan.BackColor = Color.Cyan;
            btnCyan.Cursor = Cursors.Hand;
            btnCyan.Dock = DockStyle.Right;
            btnCyan.FlatAppearance.BorderSize = 0;
            btnCyan.FlatStyle = FlatStyle.Flat;
            btnCyan.Location = new Point(-31, 0);
            btnCyan.Name = "btnCyan";
            btnCyan.Size = new Size(31, 31);
            btnCyan.TabIndex = 1;
            btnCyan.UseVisualStyleBackColor = false;
            btnCyan.Click += btnCyan_Click;
            // 
            // pbBackColor
            // 
            pbBackColor.Cursor = Cursors.Hand;
            pbBackColor.Dock = DockStyle.Right;
            pbBackColor.Image = (Image)resources.GetObject("pbBackColor.Image");
            pbBackColor.Location = new Point(0, 0);
            pbBackColor.Name = "pbBackColor";
            pbBackColor.Size = new Size(31, 31);
            pbBackColor.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBackColor.TabIndex = 0;
            pbBackColor.TabStop = false;
            pbBackColor.Click += pbBackColor_Click;
            // 
            // btnUnderline
            // 
            btnUnderline.AutoSize = true;
            btnUnderline.BackColor = Color.Transparent;
            btnUnderline.Cursor = Cursors.Hand;
            btnUnderline.Dock = DockStyle.Left;
            btnUnderline.FlatAppearance.BorderSize = 0;
            btnUnderline.FlatStyle = FlatStyle.Flat;
            btnUnderline.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            btnUnderline.Location = new Point(64, 0);
            btnUnderline.Name = "btnUnderline";
            btnUnderline.Size = new Size(32, 31);
            btnUnderline.TabIndex = 2;
            btnUnderline.Text = "U";
            btnUnderline.TextAlign = ContentAlignment.MiddleRight;
            btnUnderline.UseVisualStyleBackColor = false;
            btnUnderline.Click += btnUnderline_Click;
            // 
            // btnItalic
            // 
            btnItalic.AutoSize = true;
            btnItalic.BackColor = Color.Transparent;
            btnItalic.Cursor = Cursors.Hand;
            btnItalic.Dock = DockStyle.Left;
            btnItalic.FlatAppearance.BorderSize = 0;
            btnItalic.FlatStyle = FlatStyle.Flat;
            btnItalic.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnItalic.Location = new Point(32, 0);
            btnItalic.Name = "btnItalic";
            btnItalic.Size = new Size(32, 31);
            btnItalic.TabIndex = 1;
            btnItalic.Text = "I";
            btnItalic.TextAlign = ContentAlignment.MiddleRight;
            btnItalic.UseVisualStyleBackColor = false;
            btnItalic.Click += btnItalic_Click;
            // 
            // btnBold
            // 
            btnBold.AutoSize = true;
            btnBold.BackColor = Color.Transparent;
            btnBold.Cursor = Cursors.Hand;
            btnBold.Dock = DockStyle.Left;
            btnBold.FlatAppearance.BorderSize = 0;
            btnBold.FlatStyle = FlatStyle.Flat;
            btnBold.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBold.Location = new Point(0, 0);
            btnBold.Name = "btnBold";
            btnBold.Size = new Size(32, 31);
            btnBold.TabIndex = 0;
            btnBold.Text = "B";
            btnBold.TextAlign = ContentAlignment.MiddleRight;
            btnBold.UseVisualStyleBackColor = false;
            btnBold.Click += btnBold_Click;
            // 
            // pnlBody
            // 
            pnlBody.Controls.Add(pnlTopLine);
            pnlBody.Controls.Add(pnlBottomLine);
            pnlBody.Controls.Add(rtbText);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(0, 26);
            pnlBody.Name = "pnlBody";
            pnlBody.Size = new Size(340, 356);
            pnlBody.TabIndex = 3;
            // 
            // pnlTopLine
            // 
            pnlTopLine.BackColor = Color.Gray;
            pnlTopLine.Dock = DockStyle.Top;
            pnlTopLine.Location = new Point(0, 0);
            pnlTopLine.Name = "pnlTopLine";
            pnlTopLine.Size = new Size(340, 1);
            pnlTopLine.TabIndex = 2;
            // 
            // pnlBottomLine
            // 
            pnlBottomLine.BackColor = Color.Gray;
            pnlBottomLine.Dock = DockStyle.Bottom;
            pnlBottomLine.Location = new Point(0, 355);
            pnlBottomLine.Name = "pnlBottomLine";
            pnlBottomLine.Size = new Size(340, 1);
            pnlBottomLine.TabIndex = 1;
            // 
            // rtbText
            // 
            rtbText.BorderStyle = BorderStyle.None;
            rtbText.Dock = DockStyle.Fill;
            rtbText.Font = new Font("STC Regular", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbText.ForeColor = Color.Black;
            rtbText.Location = new Point(0, 0);
            rtbText.Name = "rtbText";
            rtbText.Size = new Size(340, 356);
            rtbText.TabIndex = 0;
            rtbText.Text = "";
            rtbText.KeyDown += rtbText_KeyDown;
            // 
            // StickNi
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(340, 413);
            ControlBox = false;
            Controls.Add(pnlBody);
            Controls.Add(pnlBottom);
            Controls.Add(pnlHeaderControls);
            Font = new Font("STC Regular", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimumSize = new Size(294, 130);
            Name = "StickNi";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StickNi";
            TopMost = true;
            FormClosing += StickNi_FormClosing;
            Load += StickNi_Load;
            pnlHeaderControls.ResumeLayout(false);
            pnlHeaderLeftControls.ResumeLayout(false);
            pnlHeaderLeftControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAppIcon).EndInit();
            pnlHeaderRightControls.ResumeLayout(false);
            pnlBottom.ResumeLayout(false);
            pnlBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbGithub).EndInit();
            pnlBackColor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbBackColor).EndInit();
            pnlBody.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeaderControls;
        private Panel pnlBottom;
        private Panel pnlBody;
        private RichTextBox rtbText;
        private Button btnBold;
        private Button btnUnderline;
        private Button btnItalic;
        private Panel pnlBackColor;
        private PictureBox pbBackColor;
        private Button btnDarkGrey;
        private Button btnYellow;
        private Button btnCyan;
        private Panel pnlHeaderRightControls;
        private Button btnMinimize;
        private Button btnClose;
        private Panel pnlHeaderLeftControls;
        private PictureBox pbAppIcon;
        private Label lblAppName;
        private Button btnLeftToRight;
        private Button btnRightToLeft;
        private Panel pnlBottomLine;
        private Panel pnlTopLine;
        private PictureBox pbGithub;
    }
}
