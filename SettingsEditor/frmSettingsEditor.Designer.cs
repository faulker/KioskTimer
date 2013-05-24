namespace SettingsEditor
{
    partial class frmSettingsEditor
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
            this.grpSettings = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtWarnMsg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLogInMsg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLoginBtn = new System.Windows.Forms.TextBox();
            this.grpAppearance = new System.Windows.Forms.GroupBox();
            this.txtColorTest = new System.Windows.Forms.TextBox();
            this.cmdForeColor = new System.Windows.Forms.Button();
            this.cmdBGColor = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numTimeWarn = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numTimeout = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPasswd2 = new System.Windows.Forms.MaskedTextBox();
            this.txtPasswd1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdExitAll = new System.Windows.Forms.Button();
            this.numLockOutTime = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.grpSettings.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpAppearance.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeWarn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeout)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLockOutTime)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSettings
            // 
            this.grpSettings.Controls.Add(this.groupBox3);
            this.grpSettings.Controls.Add(this.grpAppearance);
            this.grpSettings.Controls.Add(this.groupBox2);
            this.grpSettings.Controls.Add(this.groupBox1);
            this.grpSettings.Controls.Add(this.cmdSave);
            this.grpSettings.Controls.Add(this.cmdExitAll);
            this.grpSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSettings.Location = new System.Drawing.Point(0, 0);
            this.grpSettings.Name = "grpSettings";
            this.grpSettings.Size = new System.Drawing.Size(489, 409);
            this.grpSettings.TabIndex = 1;
            this.grpSettings.TabStop = false;
            this.grpSettings.Text = "Settings";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtWarnMsg);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtLogInMsg);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtLoginBtn);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(212, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(269, 354);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Text Options";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 32);
            this.label7.TabIndex = 6;
            this.label7.Text = "%sessiontime% = Timeout\r\n%warntime% = Time left warning";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Session Ending Soon Message";
            // 
            // txtWarnMsg
            // 
            this.txtWarnMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWarnMsg.Location = new System.Drawing.Point(13, 195);
            this.txtWarnMsg.Multiline = true;
            this.txtWarnMsg.Name = "txtWarnMsg";
            this.txtWarnMsg.Size = new System.Drawing.Size(250, 98);
            this.txtWarnMsg.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Log-in Message to User";
            // 
            // txtLogInMsg
            // 
            this.txtLogInMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogInMsg.Location = new System.Drawing.Point(13, 82);
            this.txtLogInMsg.Multiline = true;
            this.txtLogInMsg.Name = "txtLogInMsg";
            this.txtLogInMsg.Size = new System.Drawing.Size(250, 87);
            this.txtLogInMsg.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "User Log-In Button";
            // 
            // txtLoginBtn
            // 
            this.txtLoginBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoginBtn.Location = new System.Drawing.Point(13, 39);
            this.txtLoginBtn.Name = "txtLoginBtn";
            this.txtLoginBtn.Size = new System.Drawing.Size(250, 22);
            this.txtLoginBtn.TabIndex = 0;
            // 
            // grpAppearance
            // 
            this.grpAppearance.Controls.Add(this.txtColorTest);
            this.grpAppearance.Controls.Add(this.cmdForeColor);
            this.grpAppearance.Controls.Add(this.cmdBGColor);
            this.grpAppearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAppearance.Location = new System.Drawing.Point(6, 143);
            this.grpAppearance.Name = "grpAppearance";
            this.grpAppearance.Size = new System.Drawing.Size(200, 128);
            this.grpAppearance.TabIndex = 6;
            this.grpAppearance.TabStop = false;
            this.grpAppearance.Text = "Appearance";
            // 
            // txtColorTest
            // 
            this.txtColorTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtColorTest.Location = new System.Drawing.Point(7, 80);
            this.txtColorTest.Multiline = true;
            this.txtColorTest.Name = "txtColorTest";
            this.txtColorTest.Size = new System.Drawing.Size(187, 42);
            this.txtColorTest.TabIndex = 2;
            this.txtColorTest.Text = "This is a test of the colors you have chosen.";
            // 
            // cmdForeColor
            // 
            this.cmdForeColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdForeColor.Location = new System.Drawing.Point(7, 50);
            this.cmdForeColor.Name = "cmdForeColor";
            this.cmdForeColor.Size = new System.Drawing.Size(187, 23);
            this.cmdForeColor.TabIndex = 1;
            this.cmdForeColor.Text = "Pick Foreground Color";
            this.cmdForeColor.Click += new System.EventHandler(this.cmdForeColor_Click);
            // 
            // cmdBGColor
            // 
            this.cmdBGColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBGColor.Location = new System.Drawing.Point(7, 20);
            this.cmdBGColor.Name = "cmdBGColor";
            this.cmdBGColor.Size = new System.Drawing.Size(187, 23);
            this.cmdBGColor.TabIndex = 0;
            this.cmdBGColor.Text = "Pick Background Color";
            this.cmdBGColor.Click += new System.EventHandler(this.cmdBGColor_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.numLockOutTime);
            this.groupBox2.Controls.Add(this.numTimeWarn);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.numTimeout);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 118);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Time Settings";
            // 
            // numTimeWarn
            // 
            this.numTimeWarn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTimeWarn.Location = new System.Drawing.Point(113, 51);
            this.numTimeWarn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTimeWarn.Name = "numTimeWarn";
            this.numTimeWarn.Size = new System.Drawing.Size(81, 26);
            this.numTimeWarn.TabIndex = 3;
            this.numTimeWarn.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Time Left Warning:";
            // 
            // numTimeout
            // 
            this.numTimeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTimeout.Location = new System.Drawing.Point(113, 19);
            this.numTimeout.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.numTimeout.Name = "numTimeout";
            this.numTimeout.Size = new System.Drawing.Size(81, 26);
            this.numTimeout.TabIndex = 1;
            this.numTimeout.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Timeout:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPasswd2);
            this.groupBox1.Controls.Add(this.txtPasswd1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 277);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 96);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Admin Password";
            // 
            // txtPasswd2
            // 
            this.txtPasswd2.Location = new System.Drawing.Point(10, 64);
            this.txtPasswd2.Name = "txtPasswd2";
            this.txtPasswd2.PasswordChar = '●';
            this.txtPasswd2.Size = new System.Drawing.Size(184, 22);
            this.txtPasswd2.TabIndex = 3;
            this.txtPasswd2.Text = "not$for@you";
            this.txtPasswd2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPasswd2_MouseClick);
            this.txtPasswd2.TextChanged += new System.EventHandler(this.txtPasswd2_TextChanged);
            this.txtPasswd2.Enter += new System.EventHandler(this.txtPasswd2_Enter);
            // 
            // txtPasswd1
            // 
            this.txtPasswd1.Location = new System.Drawing.Point(10, 20);
            this.txtPasswd1.Name = "txtPasswd1";
            this.txtPasswd1.PasswordChar = '●';
            this.txtPasswd1.Size = new System.Drawing.Size(184, 22);
            this.txtPasswd1.TabIndex = 2;
            this.txtPasswd1.Text = "not$for@you";
            this.txtPasswd1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPasswd1_MouseClick);
            this.txtPasswd1.TextChanged += new System.EventHandler(this.txtPasswd1_TextChanged);
            this.txtPasswd1.Enter += new System.EventHandler(this.txtPasswd1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Retype Password";
            // 
            // cmdSave
            // 
            this.cmdSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdSave.Location = new System.Drawing.Point(6, 380);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(107, 23);
            this.cmdSave.TabIndex = 1;
            this.cmdSave.Text = "Save and Exit";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdExitAll
            // 
            this.cmdExitAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdExitAll.Location = new System.Drawing.Point(368, 380);
            this.cmdExitAll.Name = "cmdExitAll";
            this.cmdExitAll.Size = new System.Drawing.Size(115, 23);
            this.cmdExitAll.TabIndex = 0;
            this.cmdExitAll.Text = "Exit";
            this.cmdExitAll.UseVisualStyleBackColor = true;
            this.cmdExitAll.Click += new System.EventHandler(this.cmdExitAll_Click);
            // 
            // numLockOutTime
            // 
            this.numLockOutTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLockOutTime.Location = new System.Drawing.Point(113, 83);
            this.numLockOutTime.Name = "numLockOutTime";
            this.numLockOutTime.Size = new System.Drawing.Size(81, 26);
            this.numLockOutTime.TabIndex = 4;
            this.numLockOutTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Lockout Time:";
            // 
            // frmSettingsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 409);
            this.Controls.Add(this.grpSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSettingsEditor";
            this.Text = "KisokTimer Settings Editor";
            this.grpSettings.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpAppearance.ResumeLayout(false);
            this.grpAppearance.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeWarn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeout)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLockOutTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSettings;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numTimeWarn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numTimeout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtPasswd2;
        private System.Windows.Forms.MaskedTextBox txtPasswd1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdExitAll;
        private System.Windows.Forms.GroupBox grpAppearance;
        private System.Windows.Forms.Button cmdBGColor;
        private System.Windows.Forms.Button cmdForeColor;
        private System.Windows.Forms.TextBox txtColorTest;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtLoginBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLogInMsg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtWarnMsg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numLockOutTime;
        private System.Windows.Forms.Label label8;
    }
}

