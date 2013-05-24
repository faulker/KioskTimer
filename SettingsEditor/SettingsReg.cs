using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using Microsoft.Win32;
using BCrypt.Net;

namespace Faulk_Me
{
    class SaveSettings
    {
        const string HKLM = "HKEY_LOCAL_MACHINE";
        const string SubKey = HKLM+"\\SOFTWARE\\Faulk_Me\\KioskTimer";
        const string salt = "$2a$12$Oc7YFMxm2RNSkppqD9UiDu";

        /// <summary>
        /// Saves the times settings to the registry.
        /// </summary>
        /// <param name="time">Dictionary: (string)reg entry name, (int)value</param>
        public static void SetTimes(Dictionary<string, int> time)
        {
            foreach (KeyValuePair<string, int> val in time)
            {
                Registry.SetValue(SubKey, val.Key, val.Value, RegistryValueKind.DWord);
            }
        }

        /// <summary>
        /// Hashes and saves the the unlock password to the registry.
        /// </summary>
        /// <param name="pwd">String password</param>
        public static void SetPassword(string pwd)
        {
            string password = BCrypt.Net.BCrypt.HashPassword(pwd, salt);
            Registry.SetValue(SubKey, "PasswordHash", password, RegistryValueKind.String);
        }

        /// <summary>
        /// Saves the background window color to the registry
        /// </summary>
        /// <param name="bgColor">Color</param>
        public static void SetBGColor(Color bgColor)
        {
            Registry.SetValue(SubKey, "BackgroundColor", bgColor.ToArgb(), RegistryValueKind.DWord);
        }

        /// <summary>
        /// Saves the foreground/text color to the registry
        /// </summary>
        /// <param name="foreColor">Color</param>
        public static void SetForeColor(Color foreColor)
        {
            Registry.SetValue(SubKey, "ForegroundColor", foreColor.ToArgb(), RegistryValueKind.DWord);
        }

        /// <summary>
        /// Saves the custom messages to the registry
        /// </summary>
        /// <param name="text">Dictionary: (string)reg entry name, (string)value</param>
        public static void SetText(Dictionary<string, string> text)
        {
            foreach (KeyValuePair<string, string> val in text)
            {
                Registry.SetValue(SubKey, val.Key, val.Value, RegistryValueKind.String);
            }
        }
    }

    class ReadSettings
    {
        const string HKLM = "HKEY_LOCAL_MACHINE";
        const string SubKey = HKLM + "\\SOFTWARE\\Faulk_Me\\KioskTimer";

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
            Dictionary<string, string> TextSetting = new Dictionary<string, string>();
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
    }
}
