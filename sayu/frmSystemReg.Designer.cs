namespace sayu
{
    partial class frmSystemReg
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

        #region Windows フォーム デザイナで生成されたコード
        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCalendar = new System.Windows.Forms.Label();
            this.lblRun = new System.Windows.Forms.Label();
            this.lblAlarm = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.cmdStart = new System.Windows.Forms.Button();
            this.cmdStop = new System.Windows.Forms.Button();
            this.timer1 = new System.Timers.Timer();
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(360, 8);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(80, 32);
            this.cmdClose.TabIndex = 0;
            this.cmdClose.Text = "閉じる";
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(26, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "開始ボタン押下で各システムレジスタデータを定周期（０．５秒間隔）で取得します。";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(24, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "カレンダ";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(24, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "RUN";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(24, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "アラーム";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(24, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Version";
            // 
            // lblCalendar
            // 
            this.lblCalendar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblCalendar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCalendar.Location = new System.Drawing.Point(96, 88);
            this.lblCalendar.Name = "lblCalendar";
            this.lblCalendar.Size = new System.Drawing.Size(264, 16);
            this.lblCalendar.TabIndex = 6;
            // 
            // lblRun
            // 
            this.lblRun.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblRun.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRun.Location = new System.Drawing.Point(96, 118);
            this.lblRun.Name = "lblRun";
            this.lblRun.Size = new System.Drawing.Size(264, 16);
            this.lblRun.TabIndex = 7;
            // 
            // lblAlarm
            // 
            this.lblAlarm.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblAlarm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAlarm.Location = new System.Drawing.Point(96, 149);
            this.lblAlarm.Name = "lblAlarm";
            this.lblAlarm.Size = new System.Drawing.Size(264, 16);
            this.lblAlarm.TabIndex = 8;
            // 
            // lblVersion
            // 
            this.lblVersion.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblVersion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVersion.Location = new System.Drawing.Point(96, 176);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(264, 16);
            this.lblVersion.TabIndex = 9;
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(144, 208);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(64, 32);
            this.cmdStart.TabIndex = 10;
            this.cmdStart.Text = "開始";
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // cmdStop
            // 
            this.cmdStop.Location = new System.Drawing.Point(224, 208);
            this.cmdStop.Name = "cmdStop";
            this.cmdStop.Size = new System.Drawing.Size(56, 32);
            this.cmdStop.TabIndex = 11;
            this.cmdStop.Text = "停止";
            this.cmdStop.Click += new System.EventHandler(cmdStop_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = false;
            this.timer1.SynchronizingObject = this;
            this.timer1.Elapsed += new System.Timers.ElapsedEventHandler(timer1_Elapsed);
            // 
            // frmSystemReg
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
            this.ClientSize = new System.Drawing.Size(448, 254);
            this.Controls.Add(this.cmdStop);
            this.Controls.Add(this.cmdStart);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblAlarm);
            this.Controls.Add(this.lblRun);
            this.Controls.Add(this.lblCalendar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdClose);
            this.Name = "frmSystemReg";
            this.Text = "システムレジスタ参照";
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
    }
}