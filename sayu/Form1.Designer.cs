namespace sayu
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
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
        /// 
        /// </summary>
        private void InitializeComponent()
        {
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdReadReg = new System.Windows.Forms.Button();
            this.cmdCommOpen = new System.Windows.Forms.Button();
            this.cmdCommClose = new System.Windows.Forms.Button();
            this.cmdRegisterBlock = new System.Windows.Forms.Button();
            this.frmCSV = new System.Windows.Forms.Button();
            this.frmSystemReg = new System.Windows.Forms.Button();
            this.cmdComm = new System.Windows.Forms.Button();
            this.cmdTableData = new System.Windows.Forms.Button();
            this.axMPScope1 = new AxYCSMPSCOPELib.AxMPScope();
            ((System.ComponentModel.ISupportInitialize)(this.axMPScope1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(392, 24);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(72, 32);
            this.cmdClose.TabIndex = 1;
            this.cmdClose.Text = "关闭";
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdReadReg
            // 
            this.cmdReadReg.Location = new System.Drawing.Point(16, 72);
            this.cmdReadReg.Name = "cmdReadReg";
            this.cmdReadReg.Size = new System.Drawing.Size(96, 128);
            this.cmdReadReg.TabIndex = 2;
            this.cmdReadReg.Text = "レジスタデータの設定／取得（寄存器数据设置和获取）";
            this.cmdReadReg.Click += new System.EventHandler(this.cmdReadReg_Click);
            // 
            // cmdCommOpen
            // 
            this.cmdCommOpen.Location = new System.Drawing.Point(160, 24);
            this.cmdCommOpen.Name = "cmdCommOpen";
            this.cmdCommOpen.Size = new System.Drawing.Size(88, 32);
            this.cmdCommOpen.TabIndex = 3;
            this.cmdCommOpen.Text = "オープン（打开控制器通信）";
            this.cmdCommOpen.Click += new System.EventHandler(this.cmdCommOpen_Click);
            // 
            // cmdCommClose
            // 
            this.cmdCommClose.Location = new System.Drawing.Point(264, 24);
            this.cmdCommClose.Name = "cmdCommClose";
            this.cmdCommClose.Size = new System.Drawing.Size(80, 32);
            this.cmdCommClose.TabIndex = 4;
            this.cmdCommClose.Text = "クローズ（关闭控制器通信）";
            this.cmdCommClose.Click += new System.EventHandler(this.cmdCommClose_Click);
            // 
            // cmdRegisterBlock
            // 
            this.cmdRegisterBlock.Location = new System.Drawing.Point(120, 72);
            this.cmdRegisterBlock.Name = "cmdRegisterBlock";
            this.cmdRegisterBlock.Size = new System.Drawing.Size(96, 128);
            this.cmdRegisterBlock.TabIndex = 5;
            this.cmdRegisterBlock.Text = "レジスタデータの読み込み／書き込み（ブロック／ランダム）（寄存器数据的读取/写入（块/随机））";
            this.cmdRegisterBlock.Click += new System.EventHandler(this.cmdRegisterBlock_Click);
            // 
            // frmCSV
            // 
            this.frmCSV.Location = new System.Drawing.Point(224, 72);
            this.frmCSV.Name = "frmCSV";
            this.frmCSV.Size = new System.Drawing.Size(96, 128);
            this.frmCSV.TabIndex = 6;
            this.frmCSV.Text = "レジスタデータのCSV形式読み込み／書き込み（ブロック／ランダム）（寄存器数据的CSV格式读取/写入（块/随机））";
            this.frmCSV.Click += new System.EventHandler(this.frmCSV_Click);
            // 
            // frmSystemReg
            // 
            this.frmSystemReg.Location = new System.Drawing.Point(328, 72);
            this.frmSystemReg.Name = "frmSystemReg";
            this.frmSystemReg.Size = new System.Drawing.Size(96, 128);
            this.frmSystemReg.TabIndex = 7;
            this.frmSystemReg.Text = "システムレジスタ参照（系统寄存器）";
            this.frmSystemReg.Click += new System.EventHandler(this.frmSystemReg_Click);
            // 
            // cmdComm
            // 
            this.cmdComm.Location = new System.Drawing.Point(64, 24);
            this.cmdComm.Name = "cmdComm";
            this.cmdComm.Size = new System.Drawing.Size(80, 32);
            this.cmdComm.TabIndex = 8;
            this.cmdComm.Text = "通信設定";
            this.cmdComm.Click += new System.EventHandler(this.cmdComm_Click);
            // 
            // cmdTableData
            // 
            this.cmdTableData.Location = new System.Drawing.Point(16, 208);
            this.cmdTableData.Name = "cmdTableData";
            this.cmdTableData.Size = new System.Drawing.Size(96, 128);
            this.cmdTableData.TabIndex = 9;
            this.cmdTableData.Text = "表データのCSV形式読み込み／書き込み）（表格数据的CSV形式读取/写）";
            this.cmdTableData.Click += new System.EventHandler(this.cmdTableData_Click);
            // 
            // axMPScope1
            // 
            this.axMPScope1.Enabled = true;
            this.axMPScope1.Location = new System.Drawing.Point(16, 16);
            this.axMPScope1.Name = "axMPScope1";
            this.axMPScope1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMPScope1.OcxState")));
            this.axMPScope1.Size = new System.Drawing.Size(32, 32);
            this.axMPScope1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
            this.ClientSize = new System.Drawing.Size(488, 350);
            this.Controls.Add(this.axMPScope1);
            this.Controls.Add(this.cmdTableData);
            this.Controls.Add(this.cmdComm);
            this.Controls.Add(this.frmSystemReg);
            this.Controls.Add(this.frmCSV);
            this.Controls.Add(this.cmdRegisterBlock);
            this.Controls.Add(this.cmdCommClose);
            this.Controls.Add(this.cmdCommOpen);
            this.Controls.Add(this.cmdReadReg);
            this.Controls.Add(this.cmdClose);
            this.Name = "Form1";
            this.Text = "MPScope示例(C#)";
            ((System.ComponentModel.ISupportInitialize)(this.axMPScope1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
    }
}

