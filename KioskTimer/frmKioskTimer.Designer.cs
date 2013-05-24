namespace KioskTimer
{
    partial class frmKioskTimer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.focusTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grpAdminPassword = new System.Windows.Forms.GroupBox();
            this.cmdPwdCan = new System.Windows.Forms.Button();
            this.cmdPwdOk = new System.Windows.Forms.Button();
            this.txtAdminPwd = new System.Windows.Forms.MaskedTextBox();
            this.grpUserDlg = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cmdUseComputer = new System.Windows.Forms.Button();
            this.txtLogInMsg = new System.Windows.Forms.TextBox();
            this.sessionEndedTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.grpAdminPassword.SuspendLayout();
            this.grpUserDlg.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // focusTimer
            // 
            this.focusTimer.Interval = 300;
            this.focusTimer.Tick += new System.EventHandler(this.focusTimer_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.grpAdminPassword, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.grpUserDlg, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.75F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(682, 504);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Click += new System.EventHandler(this.tableLayoutPanel1_Click);
            // 
            // grpAdminPassword
            // 
            this.grpAdminPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpAdminPassword.BackColor = System.Drawing.Color.White;
            this.grpAdminPassword.Controls.Add(this.cmdPwdCan);
            this.grpAdminPassword.Controls.Add(this.cmdPwdOk);
            this.grpAdminPassword.Controls.Add(this.txtAdminPwd);
            this.grpAdminPassword.ForeColor = System.Drawing.Color.Black;
            this.grpAdminPassword.Location = new System.Drawing.Point(216, 108);
            this.grpAdminPassword.Name = "grpAdminPassword";
            this.grpAdminPassword.Size = new System.Drawing.Size(250, 78);
            this.grpAdminPassword.TabIndex = 1;
            this.grpAdminPassword.TabStop = false;
            this.grpAdminPassword.Text = "Admin Password";
            // 
            // cmdPwdCan
            // 
            this.cmdPwdCan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdPwdCan.Location = new System.Drawing.Point(169, 47);
            this.cmdPwdCan.Name = "cmdPwdCan";
            this.cmdPwdCan.Size = new System.Drawing.Size(75, 23);
            this.cmdPwdCan.TabIndex = 2;
            this.cmdPwdCan.Text = "Cancel";
            this.cmdPwdCan.UseVisualStyleBackColor = true;
            this.cmdPwdCan.Click += new System.EventHandler(this.cmdPwdCan_Click);
            // 
            // cmdPwdOk
            // 
            this.cmdPwdOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdPwdOk.Location = new System.Drawing.Point(7, 47);
            this.cmdPwdOk.Name = "cmdPwdOk";
            this.cmdPwdOk.Size = new System.Drawing.Size(120, 23);
            this.cmdPwdOk.TabIndex = 1;
            this.cmdPwdOk.Text = "Exit KioskTimer";
            this.cmdPwdOk.UseVisualStyleBackColor = true;
            this.cmdPwdOk.Click += new System.EventHandler(this.cmdPwdOk_Click);
            // 
            // txtAdminPwd
            // 
            this.txtAdminPwd.Location = new System.Drawing.Point(7, 20);
            this.txtAdminPwd.Name = "txtAdminPwd";
            this.txtAdminPwd.PasswordChar = '●';
            this.txtAdminPwd.Size = new System.Drawing.Size(237, 20);
            this.txtAdminPwd.TabIndex = 0;
            this.txtAdminPwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAdminPwd_KeyDown);
            // 
            // grpUserDlg
            // 
            this.grpUserDlg.Controls.Add(this.tableLayoutPanel2);
            this.grpUserDlg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpUserDlg.Location = new System.Drawing.Point(216, 192);
            this.grpUserDlg.Name = "grpUserDlg";
            this.grpUserDlg.Size = new System.Drawing.Size(250, 125);
            this.grpUserDlg.TabIndex = 2;
            this.grpUserDlg.TabStop = false;
            this.grpUserDlg.Text = "Use Computer";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.cmdUseComputer, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtLogInMsg, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(244, 106);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // cmdUseComputer
            // 
            this.cmdUseComputer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdUseComputer.Location = new System.Drawing.Point(3, 69);
            this.cmdUseComputer.Name = "cmdUseComputer";
            this.cmdUseComputer.Size = new System.Drawing.Size(238, 34);
            this.cmdUseComputer.TabIndex = 0;
            this.cmdUseComputer.Text = "Use Computer";
            this.cmdUseComputer.UseVisualStyleBackColor = true;
            this.cmdUseComputer.Click += new System.EventHandler(this.cmdUseComputer_Click);
            // 
            // txtLogInMsg
            // 
            this.txtLogInMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogInMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLogInMsg.Location = new System.Drawing.Point(3, 3);
            this.txtLogInMsg.Multiline = true;
            this.txtLogInMsg.Name = "txtLogInMsg";
            this.txtLogInMsg.Size = new System.Drawing.Size(238, 60);
            this.txtLogInMsg.TabIndex = 1;
            // 
            // sessionEndedTimer
            // 
            this.sessionEndedTimer.Interval = 1000;
            this.sessionEndedTimer.Tick += new System.EventHandler(this.sessionEndedTimer_Tick);
            // 
            // frmKioskTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(682, 504);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmKioskTimer";
            this.Text = "KioskTimer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grpAdminPassword.ResumeLayout(false);
            this.grpAdminPassword.PerformLayout();
            this.grpUserDlg.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer focusTimer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox grpAdminPassword;
        private System.Windows.Forms.Button cmdPwdCan;
        private System.Windows.Forms.Button cmdPwdOk;
        private System.Windows.Forms.MaskedTextBox txtAdminPwd;
        private System.Windows.Forms.GroupBox grpUserDlg;
        private System.Windows.Forms.Button cmdUseComputer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtLogInMsg;
        private System.Windows.Forms.Timer sessionEndedTimer;
    }
}

