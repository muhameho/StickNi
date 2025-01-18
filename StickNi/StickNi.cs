using System;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace StickNi
{
    public partial class StickNi : Form
    {
        public StickNi()
        {
            InitializeComponent();
        }

        const int WM_NCHITTEST = 0x84;
        const int HTCLIENT = 1;
        const int HTCAPTION = 2;

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    if (m.Result == (IntPtr)HTCLIENT)
                    {
                        m.Result = (IntPtr)HTCAPTION;
                    }
                    break;
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {

                CreateParams cp = base.CreateParams;
                cp.Style = (cp.Style | 262144);
                return cp;
            }
        }
        private void StickNi_Load(object sender, EventArgs e)
        {

            this.FormBorderStyle = FormBorderStyle.None;
            this.Size = new System.Drawing.Size(340, 364);
        }


        private void ChangeColors(Color backColor, Color foreColor)
        {
            rtbText.BackColor = backColor;
            pnlHeaderControls.BackColor = backColor;
            pnlBottom.BackColor = backColor;
            rtbText.ForeColor = foreColor;
            pnlBackColor.Size = new Size(31, 31);
            // Return focus to the RichTextBox after the button press
            rtbText.Focus();
        }


        private void btnCyan_Click(object sender, EventArgs e)
        {
            ChangeColors(Color.Cyan, Color.Black);
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            ChangeColors(Color.FromArgb(255, 247, 209), Color.Black);
        }

        private void btnDarkGrey_Click(object sender, EventArgs e)
        {
            ChangeColors(Color.FromArgb(106, 106, 106), Color.White);
        }

        private void pbBackColor_Click(object sender, EventArgs e)
        {
            if (pnlBackColor.Size == new Size(31, 31))
            {
                pnlBackColor.Size = new Size(125, 31);
            }
            else
            {
                pnlBackColor.Size = new Size(31, 31);
            }
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            Font currentFont = rtbText.SelectionFont;

            // Check if any text is selected
            if (currentFont != null)
            {
                // Toggle between bold and regular
                FontStyle newFontStyle = currentFont.Style ^ FontStyle.Bold;

                // Apply the new style to the selected text
                rtbText.SelectionFont = new Font("STC Regular", currentFont.Size, newFontStyle);

                // Update button's background color based on whether bold is applied
                if (newFontStyle.HasFlag(FontStyle.Bold))
                {
                    btnBold.BackColor = Color.FromArgb(247, 247, 247);  // Bold is active
                }
                else
                {
                    btnBold.BackColor = Color.Transparent;  // Bold is not active
                }
            }
            else
            {
                // If no text is selected, set the font of the next text to Bold or regular
                if (rtbText.SelectionFont.Style.HasFlag(FontStyle.Bold))
                {
                    rtbText.SelectionFont = new Font("STC", rtbText.SelectionFont.Size, FontStyle.Regular);
                    btnBold.BackColor = Color.Transparent;  // Bold is not active
                }
                else
                {
                    rtbText.SelectionFont = new Font("STC Bold", rtbText.SelectionFont.Size, FontStyle.Bold);
                    btnBold.BackColor = Color.FromArgb(247, 247, 247);  // Bold is active
                }
            }
            // Return focus to the RichTextBox after the button press
            rtbText.Focus();
        }


        // Variables to track the mouse position during dragging
        private bool isDragging = false;
        private Point dragStartPoint;

        private void pnlHeaderControls_MouseDown(object sender, MouseEventArgs e)
        {
            // Start dragging when mouse is pressed
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                // Capture the mouse's starting position relative to the form
                dragStartPoint = e.Location;
            }
        }

        private void pnlHeaderControls_MouseMove(object sender, MouseEventArgs e)
        {
            // If dragging is in progress, move the form based on the mouse position
            if (isDragging)
            {
                // Calculate the distance moved by the mouse
                Point offset = new Point(e.Location.X - dragStartPoint.X, e.Location.Y - dragStartPoint.Y);

                // Move the form by the calculated offset
                this.Location = new Point(this.Location.X + offset.X, this.Location.Y + offset.Y);
            }
        }

        private void pnlHeaderControls_MouseUp(object sender, MouseEventArgs e)
        {
            // Stop dragging when mouse is released
            isDragging = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbAppIcon_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnItalic_Click(object sender, EventArgs e)
        {
            Font currentFont = rtbText.SelectionFont;

            // Check if any text is selected
            if (currentFont != null)
            {
                // Toggle between Italic and regular
                FontStyle newFontStyle = currentFont.Style ^ FontStyle.Italic;

                // Apply the new style to the selected text
                rtbText.SelectionFont = new Font("STC", currentFont.Size, newFontStyle);

                // Update button's background color based on whether Italic is applied
                if (newFontStyle.HasFlag(FontStyle.Italic))
                {
                    btnItalic.BackColor = Color.FromArgb(247, 247, 247);  // Italic is active
                }
                else
                {
                    btnItalic.BackColor = Color.Transparent;  // Italic is not active
                }
            }
            else
            {
                // If no text is selected, set the font of the next text to Italic or regular
                if (rtbText.SelectionFont.Style.HasFlag(FontStyle.Italic))
                {
                    rtbText.SelectionFont = new Font("STC", rtbText.SelectionFont.Size, FontStyle.Regular);
                    btnItalic.BackColor = Color.Transparent;  // Italic is not active
                }
                else
                {
                    rtbText.SelectionFont = new Font("STC", rtbText.SelectionFont.Size, FontStyle.Italic);
                    btnItalic.BackColor = Color.FromArgb(247, 247, 247);  // Italic is active
                }
            }
            // Return focus to the RichTextBox after the button press
            rtbText.Focus();
        }

        private void btnUnderline_Click(object sender, EventArgs e)
        {
            Font currentFont = rtbText.SelectionFont;

            // Check if any text is selected
            if (currentFont != null)
            {
                // Toggle between Underline and regular
                FontStyle newFontStyle = currentFont.Style ^ FontStyle.Underline;

                // Apply the new style to the selected text
                rtbText.SelectionFont = new Font("STC", currentFont.Size, newFontStyle);

                // Update button's background color based on whether bold is applied
                if (newFontStyle.HasFlag(FontStyle.Underline))
                {
                    btnUnderline.BackColor = Color.FromArgb(247, 247, 247);  // Underline is active
                }
                else
                {
                    btnUnderline.BackColor = Color.Transparent;  // Underline is not active
                }
            }
            else
            {
                // If no text is selected, set the font of the next text to bold or regular
                if (rtbText.SelectionFont.Style.HasFlag(FontStyle.Underline))
                {
                    rtbText.SelectionFont = new Font("STC", rtbText.SelectionFont.Size, FontStyle.Regular);
                    btnUnderline.BackColor = Color.Transparent;  // Underline is not active
                }
                else
                {
                    rtbText.SelectionFont = new Font("STC", rtbText.SelectionFont.Size, FontStyle.Underline);
                    btnUnderline.BackColor = Color.FromArgb(247, 247, 247);  // Underline is active
                }
            }
            // Return focus to the RichTextBox after the button press
            rtbText.Focus();
        }

        // Variables to track resizing state
        private bool isResizing = false;
        private Point resizeStartPoint;

        private void btnRightToLeft_Click(object sender, EventArgs e)
        {
            SetTextDirection(RightToLeft.Yes);
            // Return focus to the RichTextBox after the button press
            rtbText.Focus();
        }

        private void btnLeftToRight_Click(object sender, EventArgs e)
        {
            SetTextDirection(RightToLeft.No);
            // Return focus to the RichTextBox after the button press
            rtbText.Focus();
        }

        private void SetTextDirection(RightToLeft rightToLeft)
        {
            if (rtbText.SelectionLength > 0)
            {
                // Apply to selection (using Paragraph Alignment)
                rtbText.SelectionAlignment = (rightToLeft == RightToLeft.Yes) ? HorizontalAlignment.Right : HorizontalAlignment.Left;
            }
            else
            {
                // Apply to future text (using Paragraph Alignment)
                rtbText.RightToLeft = rightToLeft;
                rtbText.SelectAll(); // Select all text to apply the change
                rtbText.SelectionAlignment = (rightToLeft == RightToLeft.Yes) ? HorizontalAlignment.Right : HorizontalAlignment.Left;
                rtbText.Select(rtbText.TextLength, 0); // Restore cursor position at the end
            }
        }

        private void rtbText_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void StickNi_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Check if the RichTextBox contains text
            if (!string.IsNullOrEmpty(rtbText.Text))
            {
                // Show a confirmation message box
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to exit?",
                    "Exit",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                // If the user clicks 'No', cancel the close event
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void pbGithub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://github.com/muhameho/",
                UseShellExecute = true
            });
        }
    }
}
