
namespace SimpleNotepad
{
    partial class SimpleNotepadForm
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
            if(saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFileDialog1.FileName.Length > 0)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName);
                this.Text = "File [" + saveFileDialog1 + "]";
                m_DocumentChanged = false;
            }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimpleNotepadForm));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            menuFileNew = new ToolStripMenuItem();
            menuFileOpen = new ToolStripMenuItem();
            menuFileSave = new ToolStripMenuItem();
            menuFileSaveAs = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            menuFilePrint = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            menuEditUndo = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            menuEditFind = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            menuEditCut = new ToolStripMenuItem();
            menuEditCopy = new ToolStripMenuItem();
            menuEditPaste = new ToolStripMenuItem();
            menuEditDelete = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            menuEditSelectall = new ToolStripMenuItem();
            formatToolStripMenuItem = new ToolStripMenuItem();
            menuFormatFont = new ToolStripMenuItem();
            menuFormatColor = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            menuFormatCharacterStyle = new ToolStripMenuItem();
            menuFormatCharacterStyleBold = new ToolStripMenuItem();
            menuFormatCharacterStyleItalic = new ToolStripMenuItem();
            menuFormatCharacterStyleUnderline = new ToolStripMenuItem();
            menuFormatCharacterStyleStrikeout = new ToolStripMenuItem();
            menuFormatParagraphAlignment = new ToolStripMenuItem();
            menuFormatParagraphAlignmentLeft = new ToolStripMenuItem();
            menuFormatParagraphAlignmentRight = new ToolStripMenuItem();
            menuFormatParagraphAlignmentCenter = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            menuHelpAbout = new ToolStripMenuItem();
            richTextBox1 = new RichTextBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            printDialog1 = new PrintDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            fontDialog1 = new FontDialog();
            colorDialog1 = new ColorDialog();
            toolStrip1 = new ToolStrip();
            toolStripButtonNew = new ToolStripButton();
            toolStripButtonSave = new ToolStripButton();
            toolStripButtonOpen = new ToolStripButton();
            toolStripButtonPrint = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            toolStripButtonCut = new ToolStripButton();
            toolStripButtonCopy = new ToolStripButton();
            toolStripButtonPaste = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            replaceToolStripMenuItem = new ToolStripMenuItem();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, formatToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(858, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuFileNew, menuFileOpen, menuFileSave, menuFileSaveAs, toolStripSeparator1, menuFilePrint, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            fileToolStripMenuItem.DropDownItemClicked += fileToolStripMenuItem_DropDownItemClicked;
            // 
            // menuFileNew
            // 
            menuFileNew.Name = "menuFileNew";
            menuFileNew.Size = new Size(121, 22);
            menuFileNew.Text = "&New";
            menuFileNew.Click += menuFileNew_Click;
            // 
            // menuFileOpen
            // 
            menuFileOpen.Name = "menuFileOpen";
            menuFileOpen.Size = new Size(121, 22);
            menuFileOpen.Text = "&Open";
            menuFileOpen.Click += menuFileOpen_Click;
            // 
            // menuFileSave
            // 
            menuFileSave.Name = "menuFileSave";
            menuFileSave.Size = new Size(121, 22);
            menuFileSave.Text = "&Save";
            menuFileSave.Click += menuFileSave_Click;
            // 
            // menuFileSaveAs
            // 
            menuFileSaveAs.Name = "menuFileSaveAs";
            menuFileSaveAs.Size = new Size(121, 22);
            menuFileSaveAs.Text = "&Save as...";
            menuFileSaveAs.Click += menuFileSaveAs_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(118, 6);
            // 
            // menuFilePrint
            // 
            menuFilePrint.Name = "menuFilePrint";
            menuFilePrint.Size = new Size(121, 22);
            menuFilePrint.Text = "&Print...";
            menuFilePrint.Click += menuFilePrint_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(121, 22);
            exitToolStripMenuItem.Text = "&Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuEditUndo, redoToolStripMenuItem, menuEditFind, replaceToolStripMenuItem, toolStripSeparator2, menuEditCut, menuEditCopy, menuEditPaste, menuEditDelete, toolStripSeparator3, menuEditSelectall });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "&Edit";
            editToolStripMenuItem.DropDownItemClicked += editToolStripMenuItem_DropDownItemClicked;
            // 
            // menuEditUndo
            // 
            menuEditUndo.Name = "menuEditUndo";
            menuEditUndo.Size = new Size(180, 22);
            menuEditUndo.Text = "&Undo";
            menuEditUndo.Click += menuEditUndo_Click;
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.Size = new Size(180, 22);
            redoToolStripMenuItem.Text = "&Redo";
            redoToolStripMenuItem.Click += redoToolStripMenuItem_Click;
            // 
            // menuEditFind
            // 
            menuEditFind.Name = "menuEditFind";
            menuEditFind.Size = new Size(180, 22);
            menuEditFind.Text = "&Find";
            menuEditFind.Click += menuEditFind_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(177, 6);
            // 
            // menuEditCut
            // 
            menuEditCut.Name = "menuEditCut";
            menuEditCut.Size = new Size(180, 22);
            menuEditCut.Text = "&Cut";
            menuEditCut.Click += menuEditCut_Click;
            // 
            // menuEditCopy
            // 
            menuEditCopy.Name = "menuEditCopy";
            menuEditCopy.Size = new Size(180, 22);
            menuEditCopy.Text = "&Copy";
            menuEditCopy.Click += menuEditCopy_Click;
            // 
            // menuEditPaste
            // 
            menuEditPaste.Name = "menuEditPaste";
            menuEditPaste.Size = new Size(180, 22);
            menuEditPaste.Text = "&Paste";
            menuEditPaste.Click += menuEditPaste_Click;
            // 
            // menuEditDelete
            // 
            menuEditDelete.Name = "menuEditDelete";
            menuEditDelete.Size = new Size(180, 22);
            menuEditDelete.Text = "&Delete";
            menuEditDelete.Click += menuEditDelete_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(177, 6);
            // 
            // menuEditSelectall
            // 
            menuEditSelectall.Name = "menuEditSelectall";
            menuEditSelectall.Size = new Size(180, 22);
            menuEditSelectall.Text = "&Select All";
            menuEditSelectall.Click += menuEditSelectall_Click;
            // 
            // formatToolStripMenuItem
            // 
            formatToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuFormatFont, menuFormatColor, toolStripSeparator4, menuFormatCharacterStyle, menuFormatParagraphAlignment });
            formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            formatToolStripMenuItem.Size = new Size(57, 20);
            formatToolStripMenuItem.Text = "&Format";
            formatToolStripMenuItem.DropDownItemClicked += formatToolStripMenuItem_DropDownItemClicked;
            // 
            // menuFormatFont
            // 
            menuFormatFont.Name = "menuFormatFont";
            menuFormatFont.Size = new Size(187, 22);
            menuFormatFont.Text = "&Font...";
            menuFormatFont.Click += menuFormatFont_Click;
            // 
            // menuFormatColor
            // 
            menuFormatColor.Name = "menuFormatColor";
            menuFormatColor.Size = new Size(187, 22);
            menuFormatColor.Text = "&Color...";
            menuFormatColor.Click += menuFormatColor_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(184, 6);
            // 
            // menuFormatCharacterStyle
            // 
            menuFormatCharacterStyle.DropDownItems.AddRange(new ToolStripItem[] { menuFormatCharacterStyleBold, menuFormatCharacterStyleItalic, menuFormatCharacterStyleUnderline, menuFormatCharacterStyleStrikeout });
            menuFormatCharacterStyle.Name = "menuFormatCharacterStyle";
            menuFormatCharacterStyle.Size = new Size(187, 22);
            menuFormatCharacterStyle.Text = "&Character Style";
            // 
            // menuFormatCharacterStyleBold
            // 
            menuFormatCharacterStyleBold.Name = "menuFormatCharacterStyleBold";
            menuFormatCharacterStyleBold.Size = new Size(125, 22);
            menuFormatCharacterStyleBold.Text = "&Bold";
            menuFormatCharacterStyleBold.Click += menuFormatCharacterStyleBold_Click;
            // 
            // menuFormatCharacterStyleItalic
            // 
            menuFormatCharacterStyleItalic.Name = "menuFormatCharacterStyleItalic";
            menuFormatCharacterStyleItalic.Size = new Size(125, 22);
            menuFormatCharacterStyleItalic.Text = "&Italic";
            menuFormatCharacterStyleItalic.Click += menuFormatCharacterStyleItalic_Click;
            // 
            // menuFormatCharacterStyleUnderline
            // 
            menuFormatCharacterStyleUnderline.Name = "menuFormatCharacterStyleUnderline";
            menuFormatCharacterStyleUnderline.Size = new Size(125, 22);
            menuFormatCharacterStyleUnderline.Text = "&Underline";
            menuFormatCharacterStyleUnderline.Click += menuFormatCharacterStyleUnderline_Click;
            // 
            // menuFormatCharacterStyleStrikeout
            // 
            menuFormatCharacterStyleStrikeout.Name = "menuFormatCharacterStyleStrikeout";
            menuFormatCharacterStyleStrikeout.Size = new Size(125, 22);
            menuFormatCharacterStyleStrikeout.Text = "&Strikeout";
            menuFormatCharacterStyleStrikeout.Click += menuFormatCharacterStyleStrikeout_Click;
            // 
            // menuFormatParagraphAlignment
            // 
            menuFormatParagraphAlignment.DropDownItems.AddRange(new ToolStripItem[] { menuFormatParagraphAlignmentLeft, menuFormatParagraphAlignmentRight, menuFormatParagraphAlignmentCenter });
            menuFormatParagraphAlignment.Name = "menuFormatParagraphAlignment";
            menuFormatParagraphAlignment.Size = new Size(187, 22);
            menuFormatParagraphAlignment.Text = "&Paragraph Alignment";
            // 
            // menuFormatParagraphAlignmentLeft
            // 
            menuFormatParagraphAlignmentLeft.Name = "menuFormatParagraphAlignmentLeft";
            menuFormatParagraphAlignmentLeft.Size = new Size(109, 22);
            menuFormatParagraphAlignmentLeft.Text = "&Left";
            menuFormatParagraphAlignmentLeft.Click += menuFormatParagraphAlignmentLeft_Click;
            // 
            // menuFormatParagraphAlignmentRight
            // 
            menuFormatParagraphAlignmentRight.Name = "menuFormatParagraphAlignmentRight";
            menuFormatParagraphAlignmentRight.Size = new Size(109, 22);
            menuFormatParagraphAlignmentRight.Text = "&Right";
            menuFormatParagraphAlignmentRight.Click += menuFormatParagraphAlignmentRight_Click;
            // 
            // menuFormatParagraphAlignmentCenter
            // 
            menuFormatParagraphAlignmentCenter.Name = "menuFormatParagraphAlignmentCenter";
            menuFormatParagraphAlignmentCenter.Size = new Size(109, 22);
            menuFormatParagraphAlignmentCenter.Text = "&Center";
            menuFormatParagraphAlignmentCenter.Click += menuFormatParagraphAlignmentCenter_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuHelpAbout });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "&Help";
            helpToolStripMenuItem.DropDownItemClicked += helpToolStripMenuItem_DropDownItemClicked;
            // 
            // menuHelpAbout
            // 
            menuHelpAbout.Name = "menuHelpAbout";
            menuHelpAbout.Size = new Size(107, 22);
            menuHelpAbout.Text = "&About";
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 49);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(858, 465);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "RTF files|*.rtf|Text files|*.txt|All files|*.*";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileName = "doc1.rtf";
            saveFileDialog1.Filter = "RTFfiles|*.rtf";
            // 
            // printDialog1
            // 
            printDialog1.Document = printDocument1;
            printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            printDocument1.DocumentName = "SimpleNotepadDocument";
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonNew, toolStripButtonSave, toolStripButtonOpen, toolStripButtonPrint, toolStripSeparator5, toolStripButtonCut, toolStripButtonCopy, toolStripButtonPaste, toolStripButton1, toolStripButton2 });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(858, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonNew
            // 
            toolStripButtonNew.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonNew.Image = (Image)resources.GetObject("toolStripButtonNew.Image");
            toolStripButtonNew.ImageTransparentColor = Color.Magenta;
            toolStripButtonNew.Name = "toolStripButtonNew";
            toolStripButtonNew.Size = new Size(23, 22);
            toolStripButtonNew.Text = "toolStripButton1";
            toolStripButtonNew.ToolTipText = "New";
            toolStripButtonNew.Click += menuFileNew_Click;
            // 
            // toolStripButtonSave
            // 
            toolStripButtonSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonSave.Image = (Image)resources.GetObject("toolStripButtonSave.Image");
            toolStripButtonSave.ImageTransparentColor = Color.Magenta;
            toolStripButtonSave.Name = "toolStripButtonSave";
            toolStripButtonSave.Size = new Size(23, 22);
            toolStripButtonSave.Text = "toolStripButton1";
            toolStripButtonSave.ToolTipText = "Save";
            toolStripButtonSave.Click += menuFileSave_Click;
            // 
            // toolStripButtonOpen
            // 
            toolStripButtonOpen.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonOpen.Image = (Image)resources.GetObject("toolStripButtonOpen.Image");
            toolStripButtonOpen.ImageTransparentColor = Color.Magenta;
            toolStripButtonOpen.Name = "toolStripButtonOpen";
            toolStripButtonOpen.Size = new Size(23, 22);
            toolStripButtonOpen.Text = "toolStripButton1";
            toolStripButtonOpen.ToolTipText = "Open";
            toolStripButtonOpen.Click += menuFileOpen_Click;
            // 
            // toolStripButtonPrint
            // 
            toolStripButtonPrint.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonPrint.Image = (Image)resources.GetObject("toolStripButtonPrint.Image");
            toolStripButtonPrint.ImageTransparentColor = Color.Magenta;
            toolStripButtonPrint.Name = "toolStripButtonPrint";
            toolStripButtonPrint.Size = new Size(23, 22);
            toolStripButtonPrint.Text = "toolStripButton1";
            toolStripButtonPrint.ToolTipText = "Print";
            toolStripButtonPrint.Click += menuFilePrint_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 25);
            // 
            // toolStripButtonCut
            // 
            toolStripButtonCut.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonCut.Image = (Image)resources.GetObject("toolStripButtonCut.Image");
            toolStripButtonCut.ImageTransparentColor = Color.Magenta;
            toolStripButtonCut.Name = "toolStripButtonCut";
            toolStripButtonCut.Size = new Size(23, 22);
            toolStripButtonCut.Text = "toolStripButton1";
            toolStripButtonCut.ToolTipText = "Cut";
            toolStripButtonCut.Click += menuEditCut_Click;
            // 
            // toolStripButtonCopy
            // 
            toolStripButtonCopy.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonCopy.Image = (Image)resources.GetObject("toolStripButtonCopy.Image");
            toolStripButtonCopy.ImageTransparentColor = Color.Magenta;
            toolStripButtonCopy.Name = "toolStripButtonCopy";
            toolStripButtonCopy.Size = new Size(23, 22);
            toolStripButtonCopy.Text = "toolStripButton1";
            toolStripButtonCopy.ToolTipText = "Copy";
            toolStripButtonCopy.Click += menuEditCopy_Click;
            // 
            // toolStripButtonPaste
            // 
            toolStripButtonPaste.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonPaste.Image = (Image)resources.GetObject("toolStripButtonPaste.Image");
            toolStripButtonPaste.ImageTransparentColor = Color.Magenta;
            toolStripButtonPaste.Name = "toolStripButtonPaste";
            toolStripButtonPaste.Size = new Size(23, 22);
            toolStripButtonPaste.Text = "toolStripButton1";
            toolStripButtonPaste.ToolTipText = "Paste";
            toolStripButtonPaste.Click += menuEditPaste_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 492);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(858, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(0, 17);
            // 
            // replaceToolStripMenuItem
            // 
            replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            replaceToolStripMenuItem.Size = new Size(180, 22);
            replaceToolStripMenuItem.Text = "&Replace";
            replaceToolStripMenuItem.Click += replaceToolStripMenuItem_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.Click += menuEditFind_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(23, 22);
            toolStripButton2.Text = "toolStripButton2";
            toolStripButton2.Click += replaceToolStripMenuItem_Click;
            // 
            // SimpleNotepadForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 514);
            Controls.Add(statusStrip1);
            Controls.Add(richTextBox1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "SimpleNotepadForm";
            Text = "SimpleNotepad";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem menuFileNew;
        private ToolStripMenuItem menuFileOpen;
        private ToolStripMenuItem menuFileSave;
        private ToolStripMenuItem menuFileSaveAs;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem menuFilePrint;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem menuEditUndo;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem menuEditCut;
        private ToolStripMenuItem menuEditCopy;
        private ToolStripMenuItem menuEditPaste;
        private ToolStripMenuItem menuEditDelete;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem menuEditSelectall;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem menuFormatFont;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem menuHelpAbout;
        private RichTextBox richTextBox1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripMenuItem menuFormatColor;
        private ToolStripMenuItem menuFormatCharacterStyle;
        private ToolStripMenuItem menuFormatCharacterStyleBold;
        private ToolStripMenuItem menuFormatCharacterStyleItalic;
        private ToolStripMenuItem menuFormatCharacterStyleUnderline;
        private ToolStripMenuItem menuFormatCharacterStyleStrikeout;
        private ToolStripMenuItem menuFormatParagraphAlignment;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem menuFormatParagraphAlignmentLeft;
        private ToolStripMenuItem menuFormatParagraphAlignmentRight;
        private ToolStripMenuItem menuFormatParagraphAlignmentCenter;
        private FontDialog fontDialog1;
        private ColorDialog colorDialog1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonNew;
        private ToolStripButton toolStripButtonSave;
        private ToolStripButton toolStripButtonOpen;
        private ToolStripButton toolStripButtonPrint;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton toolStripButtonCut;
        private ToolStripButton toolStripButtonCopy;
        private ToolStripButton toolStripButtonPaste;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripMenuItem menuEditFind;
        private ToolStripMenuItem replaceToolStripMenuItem;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
    }
}
