using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ANDREICSLIB;
using ANDREICSLIB.Helpers;
using ANDREICSLIB.Licensing;
using ANDREICSLIB.NewControls;

namespace Timezone_Sleep_Converter
{
    public partial class Form1 : Form
    {
        #region licensing
        private const String HelpString = "";

        private readonly String OtherText =
            @"�" + DateTime.Now.Year +
            @" Andrei Gec (http://www.andreigec.net)

Licensed under GNU LGPL (http://www.gnu.org/)

Zip Assets � SharpZipLib (http://www.sharpdevelop.net/OpenSource/SharpZipLib/)
";

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CustomTimeZones.Create();
            controller.InitDropDownWithTimeZones(fromTZ);
            controller.InitDropDownWithTimeZones(toTZ);
            toTZ.SelectedIndex = 7;
            SetT1Hours(T1Bar.BarMaximumValue, T1Bar.BarMinimumValue);
            SetT2Hours(T2Bar.BarMaximumValue, T2Bar.BarMinimumValue);
            GetOptions();

            Licensing.LicensingForm(this, menuStrip1, HelpString, OtherText);
        }

        private void setmytime_Click(object sender, EventArgs e)
        {
            var me = CustomTimeZones.GetMyTimeZone();
            var s = me.ToString();
            foreach (var v in fromTZ.Items)
            {
                if (v.Equals(s))
                {
                    fromTZ.SelectedItem = v;
                    return;
                }
            }
        }

        private void SetT1Hours(int barmax, int barmin)
        {
            var bar = barmax - barmin;
            if (bar < 0)
                bar = 24 + bar;
            T1hoursawakelabel.Text = controller.HoursAwakeString(bar);
            T1hoursasleeplabel.Text = controller.HoursAsleepString(24 - bar);
        }

        private void SetT2Hours(int barmax, int barmin)
        {
            var bar = barmax - barmin;
            if (bar < 0)
                bar = 24 + bar;
            T2hoursawakelabel.Text = controller.HoursAwakeString(bar);
            T2hoursasleeplabel.Text = controller.HoursAsleepString(24 - bar);
        }

        private void dragBar1_BarValueChange(DragBar entry)
        {
            SetT1Hours(entry.BarMaximumValue, entry.BarMinimumValue);
            GetOptions();
        }

        private void T2Bar_BarValueChange(DragBar entry)
        {
            SetT2Hours(entry.BarMaximumValue, entry.BarMinimumValue);
            GetOptions();
        }


        private void GetOptions()
        {
            if (fromTZ.Text.Length == 0 || toTZ.Text.Length == 0)
                return;

            option1.Text = "";

            var diffhours = 0;
            var diffmins = 0;
            var early = false;

            //wake
            controller.GetDiffHours(T1Bar, T2Bar, true, out diffhours, out diffmins, out early, fromTZ.Text, toTZ.Text);
            option1.Text = controller.MakeTimeString("Wake up", diffhours, diffmins, early);

            //sleep
            controller.GetDiffHours(T1Bar, T2Bar, false, out diffhours, out diffmins, out early, fromTZ.Text, toTZ.Text);
            option2.Text = controller.MakeTimeString("Sleep", diffhours, diffmins, early);
        }

        private void fromTZ_TextChanged(object sender, EventArgs e)
        {
            GetOptions();
        }

        private void toTZ_TextChanged(object sender, EventArgs e)
        {
            GetOptions();
        }
    }
}
