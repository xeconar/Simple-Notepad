using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleNotepad
{
    public partial class ReplaceDialog : Form
    {
        public string SearchText { get; private set; }
        public string ReplaceText { get; private set; }
        public bool MatchCase => checkMatchCase.Checked;
        public ReplaceDialog()
        {
            InitializeComponent();
        }
        private void button_next_Click(object sender, EventArgs e)
        {
            SearchText = textBox1.Text;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button_replace_Click(object sender, EventArgs e)
        {
            SearchText = textBox1.Text; 
            ReplaceText = textBox2.Text;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button_replall_Click(object sender, EventArgs e)
        {
            SearchText = textBox1.Text;
            ReplaceText = textBox2.Text;
            DialogResult = DialogResult.Yes;
            this.Close();
        }
    }
}
