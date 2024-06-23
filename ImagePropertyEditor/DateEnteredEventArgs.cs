using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagePropertyEditor
{
    public class DateEnteredEventArgs : EventArgs
    {
        public DateEnteredEventArgs(DateTime dateTime)
        {
            DateEntered = dateTime;
        }

        public DateTime DateEntered { get; set; }
    }
}
