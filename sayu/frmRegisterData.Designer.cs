namespace sayu
{
    partial class frmRegisterData
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
            this.cmdMB = new System.Windows.Forms.Button();
            this.cmdMW = new System.Windows.Forms.Button();
            this.cmdML = new System.Windows.Forms.Button();
            this.cmdMF = new System.Windows.Forms.Button();
            this.cmdDW = new System.Windows.Forms.Button();
            this.cmdMD = new System.Windows.Forms.Button();
            this.cmdMQ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(360, 8);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(72, 32);
            this.cmdClose.TabIndex = 0;
            this.cmdClose.Text = "閉じる";
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdMB
            // 
            this.cmdMB.Location = new System.Drawing.Point(16, 48);
            this.cmdMB.Name = "cmdMB";
            this.cmdMB.Size = new System.Drawing.Size(208, 40);
            this.cmdMB.TabIndex = 1;
            this.cmdMB.Text = "レジスタのBIT型データの設定／取得 MB";
            this.cmdMB.Click += new System.EventHandler(this.cmdMB_Click);
            // 
            // cmdMW
            // 
            this.cmdMW.Location = new System.Drawing.Point(232, 48);
            this.cmdMW.Name = "cmdMW";
            this.cmdMW.Size = new System.Drawing.Size(208, 40);
            this.cmdMW.TabIndex = 3;
            this.cmdMW.Text = "レジスタの2バイトデータの設定／取得 MW";
            this.cmdMW.Click += new System.EventHandler(this.cmdMW_Click);
            // 
            // cmdML
            // 
            this.cmdML.Location = new System.Drawing.Point(16, 104);
            this.cmdML.Name = "cmdML";
            this.cmdML.Size = new System.Drawing.Size(208, 40);
            this.cmdML.TabIndex = 4;
            this.cmdML.Text = "レジスタの4バイトデータの設定／取得 ML";
            this.cmdML.Click += new System.EventHandler(this.cmdML_Click);
            // 
            // cmdMF
            // 
            this.cmdMF.Location = new System.Drawing.Point(232, 104);
            this.cmdMF.Name = "cmdMF";
            this.cmdMF.Size = new System.Drawing.Size(208, 40);
            this.cmdMF.TabIndex = 5;
            this.cmdMF.Text = "レジスタの単精度浮動小数点（4バイト)の設定／取得 MF";
            this.cmdMF.Click += new System.EventHandler(this.cmdMF_Click);
            // 
            // cmdDW
            // 
            this.cmdDW.Location = new System.Drawing.Point(16, 224);
            this.cmdDW.Name = "cmdDW";
            this.cmdDW.Size = new System.Drawing.Size(208, 40);
            this.cmdDW.TabIndex = 6;
            this.cmdDW.Text = "Dレジスタの2バイトデータの設定／取得 DW";
            this.cmdDW.Click += new System.EventHandler(this.cmdDW_Click);
            // 
            // cmdMD
            // 
            this.cmdMD.Location = new System.Drawing.Point(232, 160);
            this.cmdMD.Name = "cmdMD";
            this.cmdMD.Size = new System.Drawing.Size(208, 40);
            this.cmdMD.TabIndex = 8;
            this.cmdMD.Text = "レジスタの倍精度浮動小数点（8バイト)の設定／取得 MD";
            this.cmdMD.Click += new System.EventHandler(this.cmdMD_Click);
            // 
            // cmdMQ
            // 
            this.cmdMQ.Location = new System.Drawing.Point(16, 160);
            this.cmdMQ.Name = "cmdMQ";
            this.cmdMQ.Size = new System.Drawing.Size(208, 40);
            this.cmdMQ.TabIndex = 7;
            this.cmdMQ.Text = "レジスタの8バイトデータの設定／取得 MQ";
            this.cmdMQ.Click += new System.EventHandler(this.cmdMQ_Click);
            // 
            // frmRegisterData
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
            this.ClientSize = new System.Drawing.Size(448, 282);
            this.Controls.Add(this.cmdMD);
            this.Controls.Add(this.cmdMQ);
            this.Controls.Add(this.cmdDW);
            this.Controls.Add(this.cmdMF);
            this.Controls.Add(this.cmdML);
            this.Controls.Add(this.cmdMW);
            this.Controls.Add(this.cmdMB);
            this.Controls.Add(this.cmdClose);
            this.Name = "frmRegisterData";
            this.Text = "レジスタデータの設定／取得";
            this.ResumeLayout(false);

        }
        #endregion
    }
}