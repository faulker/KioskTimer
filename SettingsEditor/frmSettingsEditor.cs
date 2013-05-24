using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SettingsEditor
{
    public partial class frmSettingsEditor : Form
    {
        private Dictionary<string, string> _Text = new Dictionary<string, string>();
        private Dictionary<string, int> _Times = new Dictionary<string, int>();

        public frmSettingsEditor()
        {
            InitializeComponent();
            _Text = Faulk_Me.ReadSettings.GetText();
            _Times = Faulk_Me.ReadSettings.GetTimes();

            Color bg = Faulk_Me.ReadSettings.GetBGColor();
            Color fg = Faulk_Me.ReadSettings.GetForeColor();

            if (bg != null && bg.A != 0)
            {
                txtColorTest.BackColor = bg;
            }

            if (fg != null && fg.A != 0)
            {
                txtColorTest.ForeColor = fg;
            }

            if(_Text.ContainsKey("UserLogInButton"))
            {
                txtLoginBtn.Text = _Text["UserLogInButton"];
            }

            if(_Text.ContainsKey("LogInMessage"))
            {
                txtLogInMsg.Text = _Text["LogInMessage"];
            }

            if(_Text.ContainsKey("WarnMsg"))
            {
                txtWarnMsg.Text = _Text["WarnMsg"];
            }

            if (_Times.ContainsKey("timeout"))
            {
                numTimeout.Value = _Times["timeout"];
            }
            if (_Times.ContainsKey("wrntime"))
            {
                numTimeWarn.Value = _Times["wrntime"];
            }
            if (_Times.ContainsKey("locktime"))
            {
                numLockOutTime.Value = _Times["locktime"];
            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> TextOpt = new Dictionary<string, string>();
            TextOpt.Add("UserLogInButton", txtLoginBtn.Text);
            TextOpt.Add("LogInMessage", txtLogInMsg.Text);
            TextOpt.Add("WarnMsg", txtWarnMsg.Text);

            Faulk_Me.SaveSettings.SetText(TextOpt);

            if (string.Compare(txtPasswd1.Text, txtPasswd2.Text) == 0 && string.Compare(txtPasswd1.Text, "not$for@you") != 0)
            {
                Faulk_Me.SaveSettings.SetPassword(txtPasswd2.Text);
            }

            Dictionary<string, int> TimeOpt = new Dictionary<string, int>();
            TimeOpt.Add("Timeout", (int)numTimeout.Value);
            TimeOpt.Add("WarnTime", (int)numTimeWarn.Value);
            TimeOpt.Add("LockoutTime", (int)numLockOutTime.Value);

            Faulk_Me.SaveSettings.SetTimes(TimeOpt);

            Faulk_Me.SaveSettings.SetBGColor(txtColorTest.BackColor);
            Faulk_Me.SaveSettings.SetForeColor(txtColorTest.ForeColor);



            this.Close();
        }

        private void txtPasswd2_TextChanged(object sender, EventArgs e)
        {
            if (txtPasswd2.Text != txtPasswd1.Text)
            {
                txtPasswd2.ForeColor = Color.Red;
            }
            else
            {
                txtPasswd2.ForeColor = Color.Black;
            }
        }

        private void txtPasswd1_TextChanged(object sender, EventArgs e)
        {
            if (txtPasswd2.Text != txtPasswd1.Text)
            {
                txtPasswd2.ForeColor = Color.Red;
            }
            else
            {
                txtPasswd2.ForeColor = Color.Black;
            }
        }

        private void cmdExitAll_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdBGColor_Click(object sender, EventArgs e)
        {
            ColorDialog ColorDlg = new ColorDialog();

            if (ColorDlg.ShowDialog() == DialogResult.OK)
            {
                txtColorTest.BackColor = ColorDlg.Color;
                //cmdBGColor.ForeColor = Color.FromArgb((byte)~ColorDlg.Color.R, (byte)~ColorDlg.Color.G, (byte)~ColorDlg.Color.B);
            }
        }

        private void cmdForeColor_Click(object sender, EventArgs e)
        {
            ColorDialog ColorDlg = new ColorDialog();

            if (ColorDlg.ShowDialog() == DialogResult.OK)
            {
                txtColorTest.ForeColor = ColorDlg.Color;
            }
        }

        private void txtPasswd1_Enter(object sender, EventArgs e)
        {
            txtPasswd1.SelectAll();
        }

        private void txtPasswd2_Enter(object sender, EventArgs e)
        {
            txtPasswd2.SelectAll();
        }

        private void txtPasswd2_MouseClick(object sender, MouseEventArgs e)
        {
            txtPasswd2.SelectAll();
        }

        private void txtPasswd1_MouseClick(object sender, MouseEventArgs e)
        {
            txtPasswd1.SelectAll();
        }
    }
}
