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
    public partial class FindDialog : Form
    {
        public string SearchText { get; private set; }
        public bool MatchCase => checkMatchCase.Checked;
        public bool SearchUp => radio_up.Checked;
        public FindDialog()
        {
            InitializeComponent();
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            SearchText = textBox1.Text;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
