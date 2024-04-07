using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImagePropertyEditor
{
    public partial class DateEditor : UserControl
    {
        public DateEditor()
        {
            InitializeComponent();
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void yearTextBox_TextChanged(object sender, EventArgs e)
        {
            if (yearTextBox.Text.Length == yearTextBox.MaxLength)
            {
                monthTextBox.Focus();
            }
        }

        private void monthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (monthTextBox.Text.Length == monthTextBox.MaxLength)
            {
                dayTextBox.Focus();
            }
        }
    }
}
