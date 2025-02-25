using System.Drawing.Printing;

namespace SimpleNotepad
{
    public partial class SimpleNotepadForm : System.Windows.Forms.Form
    {
        private StringReader m_myReader;
        private uint m_PrintPageNumber;
        private bool m_DocumentChanged;
        public SimpleNotepadForm()
        {

            InitializeComponent();
        }
        private void menuFileOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK && openFileDialog1.FileName.Length > 0)
            {
                try
                {
                    richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
                }
                catch (System.ArgumentException ex)
                {
                    richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                }
                this.Text = "File[" + openFileDialog1.FileName + "]";
            }
        }

        private void menuFileSaveAs_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFileDialog1.FileName.Length > 0)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName);
                this.Text = "File [" + saveFileDialog1 + "]";
                m_DocumentChanged = false;
            }
        }

        private void menuFilePrint_Click(object sender, EventArgs e)
        {
            m_PrintPageNumber = 1;
            string strText = this.richTextBox1.Text;
            m_myReader = new StringReader(strText);
            Margins margins = new Margins(100, 50, 50, 50);
            printDocument1.DefaultPageSettings.Margins = margins;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }
            m_myReader.Close();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {

            int lineCount = 0;
            float linesPerPage = 0;
            float yLinePosition = 0;
            string currentLine = null;
            Font printFont = this.richTextBox1.Font;
            SolidBrush printBrush = new SolidBrush(Color.Black);
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top +
            3 * printFont.GetHeight(e.Graphics);
            linesPerPage = (e.MarginBounds.Height -
            6 * printFont.GetHeight(e.Graphics)) /
            printFont.GetHeight(e.Graphics);

            while (lineCount < linesPerPage &&
            ((currentLine = m_myReader.ReadLine()) != null))
            {
                yLinePosition = topMargin + (lineCount * printFont.GetHeight(e.Graphics));

                e.Graphics.DrawString(currentLine, printFont, printBrush,
                leftMargin, yLinePosition, new StringFormat());

                lineCount++;
            }

            string sPageNumber = "Page " + m_PrintPageNumber.ToString();
            SizeF stringSize = new SizeF();
            stringSize = e.Graphics.MeasureString(sPageNumber, printFont,
            e.MarginBounds.Right - e.MarginBounds.Left);

            e.Graphics.DrawString(sPageNumber, printFont, printBrush,
            e.MarginBounds.Right - stringSize.Width, e.MarginBounds.Top,
            new StringFormat());

            e.Graphics.DrawString(this.Text, printFont, printBrush,
            e.MarginBounds.Left, e.MarginBounds.Top, new StringFormat());

            Pen colontitulPen = new Pen(Color.Black);
            colontitulPen.Width = 2;

            e.Graphics.DrawLine(colontitulPen,
            leftMargin,
            e.MarginBounds.Top + printFont.GetHeight(e.Graphics) + 3,
            e.MarginBounds.Right, e.MarginBounds.Top +
            printFont.GetHeight(e.Graphics) + 3);

            e.Graphics.DrawLine(colontitulPen,
            leftMargin, e.MarginBounds.Bottom - 3,
            e.MarginBounds.Right, e.MarginBounds.Bottom - 3);

            e.Graphics.DrawString(
            "SimpleNotepad",
            printFont, printBrush,
            e.MarginBounds.Left, e.MarginBounds.Bottom, new StringFormat());

            if (currentLine != null)
            {
                e.HasMorePages = true;
                m_PrintPageNumber++;
            }
            else
                e.HasMorePages = false;
            printBrush.Dispose();
            colontitulPen.Dispose();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFileDialog1.FileName.Length > 0)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName);
                this.Text = "File [" + saveFileDialog1 + "]";
                m_DocumentChanged = false;
            }
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            m_DocumentChanged = true;
        }

        private void menuFileNew_Click(object sender, EventArgs e)
        {
            if (m_DocumentChanged)
            {
                if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFileDialog1.FileName.Length > 0)
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName);
                    this.Text = "File [" + saveFileDialog1 + "]";
                    m_DocumentChanged = false;
                }
            }
            richTextBox1.Clear();
        }

        private void menuFileSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFileDialog1.FileName.Length > 0)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName);
                this.Text = "File [" + saveFileDialog1 + "]";
                m_DocumentChanged = false;
            }
        }

        private void menuEditUndo_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void menuEditCut_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void menuEditCopy_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void menuEditPaste_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void menuEditDelete_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void menuEditSelectall_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void menuFormatFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void menuFormatColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }
        private void CheckMenuFontCharacterStyle()
        {
            if (richTextBox1.SelectionFont.Bold == true)
            {
                menuFormatCharacterStyleBold.Checked = true;
            }
            else
            {
                menuFormatCharacterStyleBold.Checked = false;
            }

            if (richTextBox1.SelectionFont.Italic == true)
            {
                menuFormatCharacterStyleItalic.Checked = true;
            }
            else
            {
                menuFormatCharacterStyleItalic.Checked = false;
            }

            if (richTextBox1.SelectionFont.Underline == true)
            {
                menuFormatCharacterStyleUnderline.Checked = true;
            }
            else
            {
                menuFormatCharacterStyleUnderline.Checked = false;
            }

            if (richTextBox1.SelectionFont.Strikeout == true)
            {
                menuFormatCharacterStyleStrikeout.Checked = true;
            }
            else
            {
                menuFormatCharacterStyleStrikeout.Checked = false;
            }
        }

        private void menuFormatCharacterStyleBold_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                System.Drawing.Font currentFont = richTextBox1.SelectionFont;
                System.Drawing.FontStyle newFontStyle;
                if (richTextBox1.SelectionFont.Bold == true)
                {
                    newFontStyle = FontStyle.Regular;
                }
                else
                {
                    newFontStyle = FontStyle.Bold;
                }
                richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
                CheckMenuFontCharacterStyle();
            }
        }

        private void menuFormatCharacterStyleItalic_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                System.Drawing.Font currentFont = richTextBox1.SelectionFont;
                System.Drawing.FontStyle newFontStyle;
                if (richTextBox1.SelectionFont.Italic == true)
                {
                    newFontStyle = FontStyle.Regular;
                }
                else
                {
                    newFontStyle = FontStyle.Italic;
                }
                richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
                CheckMenuFontCharacterStyle();
            }
        }

        private void menuFormatCharacterStyleUnderline_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                System.Drawing.Font currentFont = richTextBox1.SelectionFont;
                System.Drawing.FontStyle newFontStyle;
                if (richTextBox1.SelectionFont.Underline == true)
                {
                    newFontStyle = FontStyle.Regular;
                }
                else
                {
                    newFontStyle = FontStyle.Underline;
                }
                richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
                CheckMenuFontCharacterStyle();
            }
        }

        private void menuFormatCharacterStyleStrikeout_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                System.Drawing.Font currentFont = richTextBox1.SelectionFont;
                System.Drawing.FontStyle newFontStyle;
                if (richTextBox1.SelectionFont.Strikeout == true)
                {
                    newFontStyle = FontStyle.Regular;
                }
                else
                {
                    newFontStyle = FontStyle.Strikeout;
                }
                richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
                CheckMenuFontCharacterStyle();
            }
        }

        private void menuFormatParagraphAlignmentLeft_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void menuFormatParagraphAlignmentRight_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void menuFormatParagraphAlignmentCenter_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void UpdateStatus(ToolStripItem item)
        {
            if (item != null)
            {
                string msg = String.Format("{0} selected", item.Text);
                this.statusStrip1.Items[0].Text = msg;
            }
        }
        private void fileToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.UpdateStatus(e.ClickedItem);
        }

        private void formatToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.UpdateStatus(e.ClickedItem);
        }

        private void helpToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.UpdateStatus(e.ClickedItem);
        }

        private void editToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.UpdateStatus(e.ClickedItem);
        }

        private void menuEditFind_Click(object sender, EventArgs e)
        {
            using (FindDialog findDialog = new FindDialog())
            {
                if (findDialog.ShowDialog() == DialogResult.OK)
                {
                    string searchText = findDialog.SearchText;
                    RichTextBoxFinds options = RichTextBoxFinds.None;

                    if (findDialog.MatchCase)
                    {
                        options |= RichTextBoxFinds.MatchCase;
                    }

                    if (findDialog.SearchUp)
                    {
                        options |= RichTextBoxFinds.Reverse;
                    }

                    int startIndex = richTextBox1.Find(searchText, 0, options);

                    if (startIndex >= 0)
                    {
                        richTextBox1.Select(startIndex, searchText.Length);
                        richTextBox1.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Text not found", "Search");
                    }
                }
            }
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ReplaceDialog replaceDialog = new ReplaceDialog())
            {
                replaceDialog.Tag = "replace";

                if (replaceDialog.ShowDialog() == DialogResult.OK)
                {
                    string searchText = replaceDialog.SearchText;
                    string replaceText = replaceDialog.ReplaceText;
                    RichTextBoxFinds options = RichTextBoxFinds.None;

                    if (replaceDialog.MatchCase)
                    {
                        options |= RichTextBoxFinds.MatchCase;
                    }

                    if (replaceDialog.Tag?.ToString() == "replace")
                    {
                        int startIndex = richTextBox1.Find(searchText, richTextBox1.SelectionStart, options);

                        if (startIndex >= 0)
                        {
                            richTextBox1.Select(startIndex, searchText.Length);
                            richTextBox1.SelectedText = replaceText;
                        }
                        else
                        {
                            MessageBox.Show("Text not found.", "Replace");
                        }
                    }
                    else if (replaceDialog.Tag?.ToString() == "replaceAll")
                    {
                        int startIndex = 0;
                        int count = 0;

                        while ((startIndex = richTextBox1.Find(searchText, startIndex, options)) >= 0)
                        {
                            richTextBox1.Select(startIndex, searchText.Length);
                            richTextBox1.SelectedText = replaceText;
                            startIndex += replaceText.Length;
                            count++;
                        }

                        MessageBox.Show($"Replaced {count} inputs.", "Replace done");
                    }
                }
            }
        }

    }
}
