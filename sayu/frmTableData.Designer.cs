namespace sayu
{
    partial class frmTableData
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
            this.cmdReadTableData = new System.Windows.Forms.Button();
            this.cmdWriteTableData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(168, 8);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(64, 32);
            this.cmdClose.TabIndex = 0;
            this.cmdClose.Text = "閉じる";
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdReadTableData
            // 
            this.cmdReadTableData.Location = new System.Drawing.Point(16, 56);
            this.cmdReadTableData.Name = "cmdReadTableData";
            this.cmdReadTableData.Size = new System.Drawing.Size(216, 48);
            this.cmdReadTableData.TabIndex = 1;
            this.cmdReadTableData.Text = "表データのCSV形式読み込み";
            this.cmdReadTableData.Click += new System.EventHandler(this.cmdReadTableData_Click);
            // 
            // cmdWriteTableData
            // 
            this.cmdWriteTableData.Location = new System.Drawing.Point(16, 112);
            this.cmdWriteTableData.Name = "cmdWriteTableData";
            this.cmdWriteTableData.Size = new System.Drawing.Size(216, 48);
            this.cmdWriteTableData.TabIndex = 2;
            this.cmdWriteTableData.Text = "表データのCSV形式書き込み";
            this.cmdWriteTableData.Click += new System.EventHandler(this.cmdWriteTableData_Click);
            // 
            // frmTableData
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
            this.ClientSize = new System.Drawing.Size(240, 262);
            this.Controls.Add(this.cmdWriteTableData);
            this.Controls.Add(this.cmdReadTableData);
            this.Controls.Add(this.cmdClose);
            this.Name = "frmTableData";
            this.Text = "frmTableData";
            this.ResumeLayout(false);

        }
        #endregion
    }
}