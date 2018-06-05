namespace sayu
{
    partial class frmCSV
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
            this.cmdReadRegBlockCSV = new System.Windows.Forms.Button();
            this.cmdWriteRegBlockCSV = new System.Windows.Forms.Button();
            this.cmdReadRegListCSV = new System.Windows.Forms.Button();
            this.cmdWriteRegListCSV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(192, 8);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(72, 32);
            this.cmdClose.TabIndex = 0;
            this.cmdClose.Text = "閉じる";
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdReadRegBlockCSV
            // 
            this.cmdReadRegBlockCSV.Location = new System.Drawing.Point(8, 56);
            this.cmdReadRegBlockCSV.Name = "cmdReadRegBlockCSV";
            this.cmdReadRegBlockCSV.Size = new System.Drawing.Size(256, 48);
            this.cmdReadRegBlockCSV.TabIndex = 1;
            this.cmdReadRegBlockCSV.Text = "レジスタデータのブロックCSV形式読み込みReadRegisterBlockCSV";
            this.cmdReadRegBlockCSV.Click += new System.EventHandler(this.cmdReadRegBlockCSV_Click);
            // 
            // cmdWriteRegBlockCSV
            // 
            this.cmdWriteRegBlockCSV.Location = new System.Drawing.Point(8, 112);
            this.cmdWriteRegBlockCSV.Name = "cmdWriteRegBlockCSV";
            this.cmdWriteRegBlockCSV.Size = new System.Drawing.Size(256, 48);
            this.cmdWriteRegBlockCSV.TabIndex = 2;
            this.cmdWriteRegBlockCSV.Text = "レジスタデータのブロックCSV形式書き込みWriteRegisterBlockCSV";
            this.cmdWriteRegBlockCSV.Click += new System.EventHandler(this.cmdWriteRegBlockCSV_Click);
            // 
            // cmdReadRegListCSV
            // 
            this.cmdReadRegListCSV.Location = new System.Drawing.Point(8, 168);
            this.cmdReadRegListCSV.Name = "cmdReadRegListCSV";
            this.cmdReadRegListCSV.Size = new System.Drawing.Size(256, 48);
            this.cmdReadRegListCSV.TabIndex = 3;
            this.cmdReadRegListCSV.Text = "レジスタデータのランダムCSV形式読み込みReadRegisterListCSV";
            this.cmdReadRegListCSV.Click += new System.EventHandler(this.cmdReadRegListCSV_Click);
            // 
            // cmdWriteRegListCSV
            // 
            this.cmdWriteRegListCSV.Location = new System.Drawing.Point(8, 224);
            this.cmdWriteRegListCSV.Name = "cmdWriteRegListCSV";
            this.cmdWriteRegListCSV.Size = new System.Drawing.Size(256, 48);
            this.cmdWriteRegListCSV.TabIndex = 4;
            this.cmdWriteRegListCSV.Text = "レジスタデータのランダムCSV形式書き込みWriteRegisterListCSV";
            this.cmdWriteRegListCSV.Click += new System.EventHandler(cmdWriteRegListCSV_Click);
            // 
            // frmCSV
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
            this.ClientSize = new System.Drawing.Size(272, 310);
            this.Controls.Add(this.cmdWriteRegListCSV);
            this.Controls.Add(this.cmdReadRegListCSV);
            this.Controls.Add(this.cmdWriteRegBlockCSV);
            this.Controls.Add(this.cmdReadRegBlockCSV);
            this.Controls.Add(this.cmdClose);
            this.Name = "frmCSV";
            this.Text = "frmCSV";
            this.ResumeLayout(false);

        }
        #endregion
    }
}