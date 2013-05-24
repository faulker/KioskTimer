using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Text.RegularExpressions;

namespace KioskTimer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmKioskTimer());
        }


        public static bool SessionJustEnded = false;

        /// <summary>
        /// Replace varible text.
        /// </summary>
        /// <param name="text">Input type</param>
        /// <returns>Input text with some varibles replaced</returns>
        public static string varibleReplaceMent(string text)
        {
            Dictionary<string, int> _Times = new Dictionary<string, int>();
            _Times = Faulk_Me.ReadSettings.GetTimes();
            Dictionary<string, string> varibles = new Dictionary<string, string>();
            varibles.Add("%sessiontime%", _Times["timeout"].ToString());
            varibles.Add("%warntime%", _Times["wrntime"].ToString());

            foreach (KeyValuePair<string, string> v in varibles)
            {
                text = Regex.Replace(text, v.Key, @v.Value, RegexOptions.IgnoreCase);
            }

            return text;
        }
    }
}
