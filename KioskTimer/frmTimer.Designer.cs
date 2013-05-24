namespace KioskTimer
{
    partial class frmTimer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTimeLeft = new System.Windows.Forms.Label();
            this.cmdEndSession = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbTimeLeft);
            this.panel1.Controls.Add(this.cmdEndSession);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 34);
            this.panel1.TabIndex = 0;
            // 
            // lbTimeLeft
            // 
            this.lbTimeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeLeft.Location = new System.Drawing.Point(10, 8);
            this.lbTimeLeft.Name = "lbTimeLeft";
            this.lbTimeLeft.Size = new System.Drawing.Size(124, 16);
            this.lbTimeLeft.TabIndex = 1;
            this.lbTimeLeft.Text = "Time Left: 60 min";
            // 
            // cmdEndSession
            // 
            this.cmdEndSession.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdEndSession.Location = new System.Drawing.Point(162, 0);
            this.cmdEndSession.Name = "cmdEndSession";
            this.cmdEndSession.Size = new System.Drawing.Size(82, 32);
            this.cmdEndSession.TabIndex = 0;
            this.cmdEndSession.Text = "End Session";
            this.cmdEndSession.UseVisualStyleBackColor = true;
            this.cmdEndSession.Click += new System.EventHandler(this.cmdEndSession_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 34);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTimer";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "frmTimer";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTimeLeft;
        private System.Windows.Forms.Button cmdEndSession;
        private System.Windows.Forms.Timer timer1;
    }
}