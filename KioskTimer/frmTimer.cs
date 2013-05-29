using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KioskTimer
{
    public partial class frmTimer : Form
    {
        int sessionTime;
        DateTime endTime;
        bool _wanded = false;
        Dictionary<string, string> msgs = new Dictionary<string, string>();
        Dictionary<string, int> _Times = new Dictionary<string, int>();

        public frmTimer()
        {
            InitializeComponent();
            _Times = Faulk_Me.ReadSettings.GetTimes();
            msgs = Faulk_Me.ReadSettings.GetText();
            sessionTime = _Times["timeout"];
            lbTimeLeft.Text = "Time left: " + sessionTime.ToString() + " min";
            countdownTimer();
        }

        private void cmdEndSession_Click(object sender, EventArgs e)
        {
            DialogResult eSession = MessageBox.Show("End session?", "Done?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (eSession == DialogResult.Yes)
            {
                endSession();
            }
        }

        private void countdownTimer()
        {
            var start = DateTime.UtcNow;
            endTime = start.AddMinutes(sessionTime);
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan remainingTime = endTime - DateTime.UtcNow;
            if (remainingTime < TimeSpan.Zero)
            {
                lbTimeLeft.Text = "Session has ended";
                timer1.Enabled = false;
                endSession();
            }
            else
            {
                if (remainingTime.Minutes <= _Times["wrntime"] && !_wanded)
                {
                    _wanded = true;
                    string msg = Program.varibleReplaceMent(msgs["WarnMsg"]);
                    MessageBox.Show(msg, "Session Ending Soon", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (remainingTime.Minutes > 0)
                {
                    lbTimeLeft.Text = "Time left: " + remainingTime.Minutes.ToString() + " min";
                }
                else
                {
                    lbTimeLeft.Text = "Time left: " + remainingTime.Seconds.ToString() + " sec";
                }
            }
        }

        private void endSession()
        {
            Program.SessionJustEnded = true;
            frmKioskTimer mainWin = new frmKioskTimer();
            mainWin.Show();
            this.Close();
        }

    }
}
