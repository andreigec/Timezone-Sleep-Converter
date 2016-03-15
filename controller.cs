using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ANDREICSLIB;
using System.Windows.Forms;
using ANDREICSLIB.Helpers;
using ANDREICSLIB.NewControls;

namespace Timezone_Sleep_Converter
{
    public class controller
    {

        public static string HoursAwakeString(int hours)
        {
            return "Hours Awake:" + hours.ToString();
        }

        public static void InitDropDownWithTimeZones(ComboBox CB)
        {
            CB.Items.Clear();
            var index = 0;
            var me = CustomTimeZones.GetMyTimeZone();
            foreach (var v in CustomTimeZones.Zones)
            {
                CB.Items.Add(v.ToString());

                if (me == v)
                    CB.SelectedIndex = index;
                index++;
            }
        }

        public static string HoursAsleepString(int hours)
        {
            return "Hours Asleep:" + hours.ToString();
        }

        public static void GetDiffHours(DragBar T1, DragBar T2, bool min, out int diffhours, out int diffmins, out bool early, string fromTZ, string toTZ)
        {
            diffhours = diffmins = 0;

            var here = CustomTimeZones.FromString(fromTZ);

            var there = CustomTimeZones.FromString(toTZ);

            var TS1 = here.UTCoffset - there.UTCoffset;

            var wakeH = T1.BarMinimumValue;
            var wakeM = 0;

            var wakeH2 = T2.BarMinimumValue;
            var wakeM2 = 0;
            if (min == false)
            {
                wakeH = T1.BarMaximumValue;
                wakeH2 = T2.BarMaximumValue;
            }

            var a = 0;

            //option1
            while (wakeH != wakeH2 || wakeM != wakeM2)
            {
                if (wakeH > wakeH2)
                {
                    wakeH--;
                    diffhours--;
                }
                else if (wakeH < wakeH2)
                {
                    wakeH++;
                    diffhours++;
                }
                if (wakeM > wakeM2)
                {
                    wakeM -= 30;
                    diffmins -= 30;
                }
                else if (wakeM > wakeM2)
                {
                    wakeM += 30;
                    diffmins += 30;
                }
            }
            diffhours += TS1.Hours;
            diffmins += TS1.Minutes;
            diffhours %= 24;
            if (diffhours > 12)
            {
                diffhours = 24 - diffhours;
                early = true;
            }
            else if (diffhours < -12)
            {
                diffhours = 24 + diffhours;
                early = false;
            }
            else

                early = !(diffhours >= 0);// && diffmins >= 0);

            diffhours = Math.Abs(diffhours);
            diffmins = Math.Abs(diffmins);
        }


        public static String MakeTimeString(String prepend, int hours, int minutes, bool early)
        {
            var earlierstr = "earlier";
            if (early == false)
                earlierstr = "later";

            String hour;
            if (hours == 1)
                hour = " Hour ";
            else
                hour = " Hours ";

            String mins;
            if (minutes == 1)
                mins = " Minute ";
            else
                mins = " Minutes ";

            var ret = prepend + " ";
            if (hours != 0)
            {
                ret += hours.ToString() + hour + earlierstr;
                if (minutes != 0)
                    ret += " and ";
            }

            if (minutes != 0)
            {
                ret += minutes.ToString() + mins + earlierstr;
            }

            if (hours == 0 && minutes == 0)
                ret += "at the same time";

            return ret;
        }
    }
}
