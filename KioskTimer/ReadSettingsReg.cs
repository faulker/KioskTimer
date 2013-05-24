using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using Microsoft.Win32;
using BCrypt.Net;

namespace Faulk_Me
{
    class ReadSettings
    {
        const string HKLM = "HKEY_LOCAL_MACHINE";
        const string SubKey = HKLM + "\\SOFTWARE\\Faulk_Me\\KioskTimer";
        const string salt = "$2a$12$Oc7YFMxm2RNSkppqD9UiDu";

        /// <summary>
        /// Compairs the hash of the user input to the stored password in the registry.
        /// </summary>
        /// <param name="pwd">Bool</param>
        /// <returns></returns>
        public static bool CheckPassword(string pwd)
        {
            bool pwdGood = false;
            string hPwd = null;
            string StoredPwd = null;

            try
            {
                hPwd = BCrypt.Net.BCrypt.HashPassword(pwd, salt);

                //If there is no password set in the registry than it will assume the default password 'password'
                StoredPwd = Registry.GetValue(SubKey, "PasswordHash", BCrypt.Net.BCrypt.HashPassword("password", salt)).ToString() ?? BCrypt.Net.BCrypt.HashPassword("password", salt).ToString();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }

            if (string.Compare(hPwd, StoredPwd) == 0)
            {
                pwdGood = true;
            }

            return pwdGood;
        }

        /// <summary>
        /// Gets the window background color from the registry.
        /// </summary>
        /// <returns>Color</returns>
        public static Color GetBGColor()
        {
            Color bgColor = Color.FromArgb(255, 255, 255, 255);
            var value = Convert.ToInt32(Registry.GetValue(SubKey, "BackgroundColor", bgColor.ToArgb()));
            bgColor = Color.FromArgb(value);
            return bgColor;
        }

        /// <summary>
        /// Gets the window foreground/text color from the registry.
        /// </summary>
        /// <returns>Color</returns>
        public static Color GetForeColor()
        {
            Color foreColor = Color.FromArgb(255, 0, 0, 0);
            int value = Convert.ToInt32(Registry.GetValue(SubKey, "ForegroundColor", foreColor.ToArgb()));
            foreColor = Color.FromArgb(value);
            return foreColor;
        }

        /// <summary>
        /// Get the custom text messages fromt he registry.
        /// </summary>
        /// <returns>Dictionary: (string)reg entry name, (string)value</returns>
        public static Dictionary<string, string> GetText()
        {
            Dictionary<string, string> TextSetting = new Dictionary<string,string>();
            Dictionary<string, string> txtRegVal = new Dictionary<string, string>();
            txtRegVal.Add("UserLogInButton", "Use Computer");
            txtRegVal.Add("LogInMessage", "Please click the button below to use this computer. You will have %sessiontime% minutes on this computer.");
            txtRegVal.Add("WarnMsg", "Your session will end in less than %warntime% minutes.");

            foreach (KeyValuePair<string, string> val in txtRegVal)
            {
                if (val.Key != null)
                {
                    var data = Registry.GetValue(SubKey, val.Key, val.Value) ?? val.Value;
                    if (data != null)
                    {
                        TextSetting.Add(val.Key, data.ToString());
                    }
                }
            }
            
            return TextSetting;
        }

        /// <summary>
        /// Gets the times settings from the registry
        /// </summary>
        /// <returns>Dictionary: (string)reg entry name, (int)value</returns>
        public static Dictionary<string, int> GetTimes()
        {
            Dictionary<string, int> time = new Dictionary<string, int>();
            var timeout = Registry.GetValue(SubKey, "Timeout", 60) ?? 60;
            var warntime = Registry.GetValue(SubKey, "WarnTime", 5) ?? 5;
            var lockouttime = Registry.GetValue(SubKey, "LockoutTime", 1) ?? 1;
            time.Add("timeout", (int)timeout);
            time.Add("wrntime", (int)warntime);
            time.Add("locktime", (int)lockouttime);
            return time;
        }
    }
}
