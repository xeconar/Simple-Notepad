namespace SimpleNotepad
{
    partial class FindDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindDialog));
            button_next = new Button();
            button_cancel = new Button();
            label1 = new Label();
            checkMatchCase = new CheckBox();
            groupDirection = new GroupBox();
            radio_down = new RadioButton();
            radio_up = new RadioButton();
            textBox1 = new TextBox();
            groupDirection.SuspendLayout();
            SuspendLayout();
            // 
            // button_next
            // 
            button_next.Location = new Point(417, 44);
            button_next.Name = "button_next";
            button_next.Size = new Size(105, 25);
            button_next.TabIndex = 0;
            button_next.Text = "Find next";
            button_next.UseVisualStyleBackColor = true;
            button_next.Click += button_next_Click;
            // 
            // button_cancel
            // 
            button_cancel.Location = new Point(417, 96);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(105, 25);
            button_cancel.TabIndex = 1;
            button_cancel.Text = "Cancel";
            button_cancel.UseVisualStyleBackColor = true;
            button_cancel.Click += button_cancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 49);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 2;
            label1.Text = "Find what:";
            // 
            // checkMatchCase
            // 
            checkMatchCase.AutoSize = true;
            checkMatchCase.Location = new Point(36, 96);
            checkMatchCase.Name = "checkMatchCase";
            checkMatchCase.Size = new Size(97, 19);
            checkMatchCase.TabIndex = 3;
            checkMatchCase.Text = "case sensitive";
            checkMatchCase.UseVisualStyleBackColor = true;
            // 
            // groupDirection
            // 
            groupDirection.Controls.Add(radio_down);
            groupDirection.Controls.Add(radio_up);
            groupDirection.Location = new Point(198, 82);
            groupDirection.Name = "groupDirection";
            groupDirection.Size = new Size(122, 76);
            groupDirection.TabIndex = 4;
            groupDirection.TabStop = false;
            groupDirection.Text = "Direction";
            // 
            // radio_down
            // 
            radio_down.AutoSize = true;
            radio_down.Location = new Point(21, 47);
            radio_down.Name = "radio_down";
            radio_down.Size = new Size(56, 19);
            radio_down.TabIndex = 1;
            radio_down.TabStop = true;
            radio_down.Text = "Down";
            radio_down.UseVisualStyleBackColor = true;
            // 
            // radio_up
            // 
            radio_up.AutoSize = true;
            radio_up.Location = new Point(21, 22);
            radio_up.Name = "radio_up";
            radio_up.Size = new Size(40, 19);
            radio_up.TabIndex = 0;
            radio_up.TabStop = true;
            radio_up.Text = "Up";
            radio_up.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(71, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(299, 23);
            textBox1.TabIndex = 5;
            // 
            // FindDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 181);
            Controls.Add(textBox1);
            Controls.Add(groupDirection);
            Controls.Add(checkMatchCase);
            Controls.Add(label1);
            Controls.Add(button_cancel);
            Controls.Add(button_next);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FindDialog";
            Text = "Find";
            groupDirection.ResumeLayout(false);
            groupDirection.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_next;
        private Button button_cancel;
        private Label label1;
        private CheckBox checkMatchCase;
        private GroupBox groupDirection;
        private RadioButton radio_down;
        private RadioButton radio_up;
        private TextBox textBox1;
    }
}