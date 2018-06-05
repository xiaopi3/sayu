namespace sayu
{
    partial class frmRegisterBlock
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
            this.cmdReadRegBlock = new System.Windows.Forms.Button();
            this.cmdWriteRegBlock = new System.Windows.Forms.Button();
            this.cmdReadRegList = new System.Windows.Forms.Button();
            this.cmdWriteRegList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(184, 8);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(72, 32);
            this.cmdClose.TabIndex = 0;
            this.cmdClose.Text = "閉じる";
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdReadRegBlock
            // 
            this.cmdReadRegBlock.Location = new System.Drawing.Point(16, 56);
            this.cmdReadRegBlock.Name = "cmdReadRegBlock";
            this.cmdReadRegBlock.Size = new System.Drawing.Size(240, 48);
            this.cmdReadRegBlock.TabIndex = 1;
            this.cmdReadRegBlock.Text = "レジスタデータのブロック読み込みReadRegisterBlock";
            this.cmdReadRegBlock.Click += new System.EventHandler(this.cmdReadRegBlock_Click);
            // 
            // cmdWriteRegBlock
            // 
            this.cmdWriteRegBlock.Location = new System.Drawing.Point(16, 112);
            this.cmdWriteRegBlock.Name = "cmdWriteRegBlock";
            this.cmdWriteRegBlock.Size = new System.Drawing.Size(240, 48);
            this.cmdWriteRegBlock.TabIndex = 2;
            this.cmdWriteRegBlock.Text = "レジスタデータのブロック書き込みWriteRegisterBlock";
            this.cmdWriteRegBlock.Click += new System.EventHandler(this.cmdWriteRegBlock_Click);
            // 
            // cmdReadRegList
            // 
            this.cmdReadRegList.Location = new System.Drawing.Point(16, 168);
            this.cmdReadRegList.Name = "cmdReadRegList";
            this.cmdReadRegList.Size = new System.Drawing.Size(240, 48);
            this.cmdReadRegList.TabIndex = 3;
            this.cmdReadRegList.Text = "レジスタデータのランダム読み込みReadRegisterList";
            this.cmdReadRegList.Click += new System.EventHandler(this.cmdReadRegList_Click);
            // 
            // cmdWriteRegList
            // 
            this.cmdWriteRegList.Location = new System.Drawing.Point(16, 224);
            this.cmdWriteRegList.Name = "cmdWriteRegList";
            this.cmdWriteRegList.Size = new System.Drawing.Size(240, 48);
            this.cmdWriteRegList.TabIndex = 4;
            this.cmdWriteRegList.Text = "レジスタデータのランダム書き込みWriteRegisterList";
            this.cmdWriteRegList.Click += new System.EventHandler(cmdWriteRegList_Click);
            // 
            // frmRegisterBlock
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
            this.ClientSize = new System.Drawing.Size(272, 294);
            this.Controls.Add(this.cmdWriteRegList);
            this.Controls.Add(this.cmdReadRegList);
            this.Controls.Add(this.cmdWriteRegBlock);
            this.Controls.Add(this.cmdReadRegBlock);
            this.Controls.Add(this.cmdClose);
            this.Name = "frmRegisterBlock";
            this.Text = "frmRegisterBlock";
            this.ResumeLayout(false);

        }
        #endregion
    }
}