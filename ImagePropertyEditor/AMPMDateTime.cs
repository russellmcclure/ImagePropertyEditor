using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagePropertyEditor
{
    public static class AMPMDateTimeUtility
    {
        public static bool IsValid(int year, int month, int day, int amPMHour, int minute, int second, bool isPM)
        {
            int currentYear = DateTime.Now.Year;
            if (!(year >= 1930 && year <= currentYear))
            {
                return false;
            }

            try
            {
                DateTime dtTemp = new DateTime(year, month, day, GetMilitaryHour(amPMHour, isPM), minute, second);
            }
            catch
            {
                return false;
            }

            return true;
        }
        public static int GetAMPMHour(int militaryHour)
        {
            if (!(militaryHour >= 0 && militaryHour <= 23))
            {
                throw new ArgumentException("Invalid military hour value", "militaryHour");
            }

            if (militaryHour == 0)
            {
                return 12;
            }
            if (militaryHour >= 13)
            {
                return militaryHour - 12;
            }

            return militaryHour;
        }

        public static int GetMilitaryHour(int amPMHour, bool isPM)
        {
            if (!(amPMHour >= 1 && amPMHour <= 12))
            {
                throw new ArgumentException("Invalid AM/PM Hour value", "amPMHour");
            }

            if (isPM)
            {
                if (amPMHour == 12)
                {
                    return amPMHour;
                }
                else
                {
                    return (amPMHour + 12);
                }
            }
            else
            {
                if (amPMHour == 12)
                {
                    return 0;
                }
                else
                {
                    return amPMHour;
                }
            }
        }
    }
}
