namespace SimpleNotepad
{
    partial class ReplaceDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReplaceDialog));
            textBox1 = new TextBox();
            checkMatchCase = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            button_replace = new Button();
            button_replall = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(85, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(299, 23);
            textBox1.TabIndex = 10;
            // 
            // checkMatchCase
            // 
            checkMatchCase.AutoSize = true;
            checkMatchCase.Location = new Point(85, 122);
            checkMatchCase.Name = "checkMatchCase";
            checkMatchCase.Size = new Size(97, 19);
            checkMatchCase.TabIndex = 9;
            checkMatchCase.Text = "case sensitive";
            checkMatchCase.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 40);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 8;
            label1.Text = "Find what:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 78);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 11;
            label2.Text = "Replace with:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(85, 75);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(299, 23);
            textBox2.TabIndex = 12;
            // 
            // button_replace
            // 
            button_replace.Location = new Point(411, 35);
            button_replace.Name = "button_replace";
            button_replace.Size = new Size(105, 25);
            button_replace.TabIndex = 13;
            button_replace.Text = "Replace";
            button_replace.UseVisualStyleBackColor = true;
            button_replace.Click += button_replace_Click;
            // 
            // button_replall
            // 
            button_replall.Location = new Point(411, 75);
            button_replall.Name = "button_replall";
            button_replall.Size = new Size(105, 25);
            button_replall.TabIndex = 14;
            button_replall.Text = "Replace all";
            button_replall.UseVisualStyleBackColor = true;
            button_replall.Click += button_replall_Click;
            // 
            // ReplaceDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 181);
            Controls.Add(button_replall);
            Controls.Add(button_replace);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(checkMatchCase);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ReplaceDialog";
            Text = "Replace";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private CheckBox checkMatchCase;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Button button_replace;
        private Button button_replall;
    }
}