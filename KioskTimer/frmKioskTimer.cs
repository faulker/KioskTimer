using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace KioskTimer
{
    public partial class frmKioskTimer : Form
    {
        #region DllImport
        // To use to keep window focus.
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        //Disable Start button and Taskbar
        private const int SWP_HIDEWINDOW = 0x80;
        private const int SWP_SHOWWINDOW = 0x40;
        private const int SW_HIDE = 0;
        private const int SW_SHOW = 1;

        [DllImport("user32.dll")]
        public static extern bool SetWindowPos(
            int hWnd, // handle to window
            int hWndInsertAfter, // placement-order handle
            short X, // horizontal position
            short Y, // vertical position
            short cx, // width
            short cy, // height
            uint uFlags // window-positioning options
        );

        [DllImport("user32.dll")]
        public static extern int FindWindow(
            string lpClassName, // class name
            string lpWindowName // window name
        );

        [DllImport("user32.dll")]
        public static extern int FindWindowEx(
            IntPtr parentHwnd,
            IntPtr childAfterHwnd,
            IntPtr className,
            string windowText
        );

        [DllImport("user32.dll")]
        private static extern int ShowWindow(int hwnd, int command);

        private int hwndOrb = FindWindowEx(IntPtr.Zero, IntPtr.Zero, (IntPtr)0xC017, null);
        private int TaskBarHwnd = FindWindow("Shell_traywnd", "");

        // Disable system keys (Tab, Esc, Both Windows keys)
        [StructLayout(LayoutKind.Sequential)]
        private struct KBDLLHOOKSTRUCT
        {
            public Keys key;
            public int scanCode;
            public int flags;
            public int time;
            public IntPtr extra;
        }

        // System level functions to be used for hook and unhook keyboard input
        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int id, LowLevelKeyboardProc callback, IntPtr hMod, uint dwThreadId);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool UnhookWindowsHookEx(IntPtr hook);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hook, int nCode, IntPtr wp, IntPtr lp);
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string name);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern short GetAsyncKeyState(Keys key);
        #endregion

        #region Declaring Global objects
        private IntPtr ptrHook;
        private LowLevelKeyboardProc objKeyboardProcess;
        private Dictionary<string, string> _Text = new Dictionary<string, string>();
        DateTime endTime;
        #endregion

        public frmKioskTimer()
        {
            InitializeComponent();

            if (Program.SessionJustEnded)
            {
                sessionEndedTimer.Enabled = true;
            }

            setKioskWindowSettings();

            Color bg = Faulk_Me.ReadSettings.GetBGColor();
            Color fg = Faulk_Me.ReadSettings.GetForeColor();

            if (bg != null && bg.A != 0)
            {
                this.BackColor = bg;
            }
            if (fg != null && fg.A != 0)
            {
                this.ForeColor = fg;
            }

            grpAdminPassword.Hide();
            grpAdminPassword.BackColor = bg;
            grpAdminPassword.ForeColor = fg;
            cmdPwdCan.BackColor = bg;
            cmdPwdOk.ForeColor = fg;

            _Text = Faulk_Me.ReadSettings.GetText();

            cmdUseComputer.Text = Program.varibleReplaceMent(_Text["UserLogInButton"]);
            txtLogInMsg.Text = Program.varibleReplaceMent(_Text["LogInMessage"]);

            if (Program.SessionJustEnded)
            {
                Dictionary<string, int> _Times = new Dictionary<string, int>();
                _Times = Faulk_Me.ReadSettings.GetTimes();

                var start = DateTime.UtcNow;
                endTime = start.AddMinutes(_Times["locktime"]);
                cmdUseComputer.Enabled = false;
                sessionEndedTimer.Enabled = true;
            }

        }

        private IntPtr captureKey(int nCode, IntPtr wp, IntPtr lp)
        {
            if (nCode >= 0)
            {
                KBDLLHOOKSTRUCT objKeyInfo = (KBDLLHOOKSTRUCT)Marshal.PtrToStructure(lp, typeof(KBDLLHOOKSTRUCT));

                // Disabling keys
                if (objKeyInfo.key == Keys.RWin || // Right Windows key
                    objKeyInfo.key == Keys.LWin || // Left Windows key
                    objKeyInfo.key == Keys.Tab || // Tab key (for disable Alt+Tab)
                    objKeyInfo.key == Keys.Escape || // Escape key (for disable Ctrl+Esc)
                    objKeyInfo.key == Keys.F4 || // Disable F4 key
                    objKeyInfo.key == Keys.Delete) // Was hoping this would disable Ctrl+Alt+Del but it didn't
                {
                    return (IntPtr)1;
                }
            }
            return CallNextHookEx(ptrHook, nCode, wp, lp);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Bounds = Screen.PrimaryScreen.Bounds; // Set window to full screen
            this.TopMost = true; // Set window as TopMost and having focus
        }

        private void focusTimer_Tick(object sender, EventArgs e)
        {
            // Keep window focus.
            SetForegroundWindow(this.Handle);
            this.TopMost = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            removeKioskWindowSettings();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if ((ModifierKeys & Keys.Alt) == Keys.Alt)
            {
                grpAdminPassword.Show();
            }
        }

        private void cmdExitAll_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void cmdPwdOk_Click(object sender, EventArgs e)
        {
            checkPassword();
        }

        private void cmdPwdCan_Click(object sender, EventArgs e)
        {
            grpAdminPassword.Hide();
        }

        private void tableLayoutPanel1_Click(object sender, EventArgs e)
        {
            if ((ModifierKeys & Keys.Alt) == Keys.Alt)
            {
                grpAdminPassword.Show();
            }
        }

        private void cmdUseComputer_Click(object sender, EventArgs e)
        {
            frmTimer timer = new frmTimer();
            timer.Show();

            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int timerPosX = (screenWidth / 2) - (timer.Width / 2);

            timer.DesktopLocation = new Point(timerPosX, 0);

            removeKioskWindowSettings();
            this.Hide();
        }

        private void setKioskWindowSettings()
        {
            this.ShowInTaskbar = false;
            this.FormBorderStyle = FormBorderStyle.None;

            /*
             * Disable System Keys
             */
            ProcessModule objCurrentModule = Process.GetCurrentProcess().MainModule;
            objKeyboardProcess = new LowLevelKeyboardProc(captureKey);
            ptrHook = SetWindowsHookEx(13, objKeyboardProcess, GetModuleHandle(objCurrentModule.ModuleName), 0);
            /*
             * 
             */

            bool result1 = SetWindowPos(TaskBarHwnd, 0, 0, 0, 0, 0, SWP_HIDEWINDOW); // Hide Taskbar
            ShowWindow(hwndOrb, SW_HIDE); // Hides the Start Button

            focusTimer.Enabled = true;
        }

        private void removeKioskWindowSettings()
        {
            bool result1 = SetWindowPos(TaskBarHwnd, 0, 0, 0, 0, 0, SWP_SHOWWINDOW); // Show Taskbar
            ShowWindow(hwndOrb, SW_SHOW); // Shows the Start Button
            focusTimer.Enabled = false;
        }

        private void sessionEndedTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan remainingTime = endTime - DateTime.UtcNow;
            if (remainingTime < TimeSpan.Zero)
            {
                cmdUseComputer.Enabled = true;
                cmdUseComputer.Text = _Text["UserLogInButton"];
                sessionEndedTimer.Enabled = false;
            }
            else
            {
                if (remainingTime.Minutes > 0)
                {
                    cmdUseComputer.Text = "Next session can start in " + remainingTime.Minutes.ToString() + " min";
                }
                else
                {
                    cmdUseComputer.Text = "Next session can start in " + remainingTime.Seconds.ToString() + " sec";
                }
            }
        }

        private void txtAdminPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                checkPassword();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                grpAdminPassword.Hide();
            }
        }

        private void checkPassword()
        {
            bool pwdCheck = Faulk_Me.ReadSettings.CheckPassword(txtAdminPwd.Text);
            if (pwdCheck)
            {
                Application.Exit();
            }
            else
            {
                grpAdminPassword.Hide();
                txtAdminPwd.Text = "";
            }
        }
    }
}
