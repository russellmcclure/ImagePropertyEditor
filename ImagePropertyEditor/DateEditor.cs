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

        public bool AllowTimeEditing
        { 
            set
            {
                this.hourTextBox.Enabled = value;
                this.minuteTextBox.Enabled = value;
                this.secondTextBox.Enabled = value;
            }
         }

        private void textBox_GotFocus(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            textBox.SelectAll();
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

        private void dayTextBox_TextChanged(object sender, EventArgs e)
        {
            if (dayTextBox.Text.Length == dayTextBox.MaxLength)
            {
                hourTextBox.Focus(); 
            }
        }

        private void hourTextBox_TextChanged(object sender, EventArgs e)
        {
            if (hourTextBox.Text.Length == hourTextBox.MaxLength)
            {
                minuteTextBox.Focus();
            }
        }

        private void minuteTextBox_TextChanged(object sender, EventArgs e)
        {
            if (minuteTextBox.Text.Length == minuteTextBox.MaxLength)
            {
                secondTextBox.Focus();
            }
        }

        private void secondTextBox_TextChanged(object sender, EventArgs e)
        {
            if (secondTextBox.Text.Length == secondTextBox.MaxLength)
            {
                pmCheckBox.Focus();
            }
        }

        private void DateEditor_Load(object sender, EventArgs e)
        {
            int n = 44;
            this.yearTextBox.GotFocus += textBox_GotFocus;
            this.monthTextBox.GotFocus += textBox_GotFocus;
            this.dayTextBox.GotFocus += textBox_GotFocus;
            this.hourTextBox.GotFocus += textBox_GotFocus;
            this.minuteTextBox.GotFocus += textBox_GotFocus;
            this.secondTextBox.GotFocus += textBox_GotFocus;

            this.yearTextBox.Click += textBox_GotFocus;
            this.monthTextBox.Click += textBox_GotFocus;
            this.dayTextBox.Click += textBox_GotFocus;
            this.hourTextBox.Click += textBox_GotFocus;
            this.minuteTextBox.Click += textBox_GotFocus;
            this.secondTextBox.Click += textBox_GotFocus;
        }
    }
}
