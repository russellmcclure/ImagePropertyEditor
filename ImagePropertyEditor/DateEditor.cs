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
        public event EventHandler<DateEnteredEventArgs> DateEntered;

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
                this.pmCheckBox.Enabled = value;
            }

            get
            {
                return this.hourTextBox.Enabled;
            }
         }

        public void SetDate(DateTime? date)
        {
            if (date.HasValue)
            {
                this.yearTextBox.Text = date.Value.Year.ToString();
                this.monthTextBox.Text = date.Value.Month.ToString();
                this.dayTextBox.Text = date.Value.Day.ToString();
                this.hourTextBox.Text = AMPMDateTimeUtility.GetAMPMHour(date.Value.Hour).ToString();
                this.minuteTextBox.Text = date.Value.Minute.ToString();
                this.secondTextBox.Text = date.Value.Second.ToString();
                this.pmCheckBox.Checked = date.Value.Hour >= 12;
            }
            else
            {
                this.Clear();
            }

            this.yearTextBox.Focus();
        }

        /// <summary>
        /// Allows external classes to trigger the "we are done enetering a date" logic.
        /// </summary>
        public void SaveDate()
        {
            this.OnDateEntered();
        }

        public DateTime? GetDate()
        {
            return this.ParseEnteredDateTime();
        }

        private void textBox_GotFocus(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            textBox.SelectAll();
        }


        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                this.OnDateEntered();
            }

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

        private DateTime? ParseEnteredDateTime()
        {
            DateTime? enteredDateTime = null;
            try
            {
                int year = int.Parse(yearTextBox.Text);
                int month = int.Parse(monthTextBox.Text);
                int day = int.Parse(dayTextBox.Text);

                // if they aren't able to enter a time, then lets set the time to 12:12:12
                int amPMHour = AllowTimeEditing ? int.Parse(hourTextBox.Text) : 12;
                int minute = AllowTimeEditing ? int.Parse(minuteTextBox.Text) : 12;
                int second = AllowTimeEditing ? int.Parse(secondTextBox.Text) : 12;
                bool isPM = pmCheckBox.Checked;
                if (AMPMDateTimeUtility.IsValid(year, month, day, amPMHour, minute, second, isPM))
                {
                    enteredDateTime = new DateTime(year, month, day, AMPMDateTimeUtility.GetMilitaryHour(amPMHour, isPM), minute, second);
                }
                else
                {
                    throw new Exception("Invalid date/time");
                }
            }
            catch 
            {
                MessageBox.Show("Invalid Date/Time entered!", "Bad Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return enteredDateTime;
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

            this.yearTextBox.Focus();
        }

        protected virtual void OnDateEntered()
        {
            DateTime? entered = this.ParseEnteredDateTime();

            if (entered != null && entered.HasValue)
            {
                DateEntered?.Invoke(this, new DateEnteredEventArgs(entered.Value));
            }
        }

        private void Clear()
        {
            this.yearTextBox.Text = "2012";
            this.monthTextBox.Text = "12";
            this.dayTextBox.Text = "12";
            this.hourTextBox.Text = "12";
            this.minuteTextBox.Text = "12";
            this.secondTextBox.Text = "12";
            this.pmCheckBox.Checked = true;
        }

        private void pmCheckBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                this.OnDateEntered();
            }
        }
    }
}
