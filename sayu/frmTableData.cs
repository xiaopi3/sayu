using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayu
{
    public partial class frmTableData : Form
    {
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Button cmdReadTableData;
        private System.Windows.Forms.Button cmdWriteTableData;
        public frmTableData()
        {
            InitializeComponent();
        }
        private void cmdClose_Click(object sender, EventArgs e)
        {
            base.OnClick(e);
            Dispose(true);
        }

        private void cmdReadTableData_Click(object sender, System.EventArgs e)
        {
            string szTableName = "TBL01";
            int nRowNo = 1;
            int nColNo = 1;
            int nRowSize = 3;
            int nColSize = 3;
            string szCSVFilePath = "ReadTableDataCSV.csv";
            System.Windows.Forms.DialogResult result;
            base.OnClick(e);
            result = MessageBox.Show("「表データのCSV形式読み込み」メソッドを実行します。よろしいですか？\n\n  表名称\t\t：TBL01\n  開始行\t：1\n  開始列\t：1\n  行数\t：3\n  列数\t：3\n  CSVファイル\t：ReadTableDataCSV.csv",
                "メソッド実行", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
            try
            {
                if (result == DialogResult.OK)
                {
                    sayu.Form1.frm1.axMPScope1.ReadTableDataCSV(szTableName, nRowNo, nColNo, nRowSize, nColSize, szCSVFilePath);
                    MessageBox.Show("メソッドは正常に終了しました。\n\n  CSVファイルを確認してください。",
                        "メソッド実行", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdWriteTableData_Click(object sender, System.EventArgs e)
        {
            string szTableName = "TBL01";
            int nRowNo = 1;
            int nColNo = 1;
            int nRowSize = 3;
            int nColSize = 3;
            string szCSVFilePath = "WriteTableDataCSV.csv";
            System.Windows.Forms.DialogResult result;
            base.OnClick(e);
            result = MessageBox.Show("「表データのCSV形式書き込み」メソッドを実行します。よろしいですか？\n\n  表名称\t\t：TBL01\n  開始行\t：1\n  開始列\t：1\n  行数\t：3\n  列数\t：3\n  CSVファイル\t：ReadTableDataCSV.csv",
                "メソッド実行", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
            try
            {
                if (result == DialogResult.OK)
                {
                    sayu.Form1.frm1.axMPScope1.WriteTableDataCSV(szTableName, nRowNo, nColNo, nRowSize, nColSize, szCSVFilePath);
                    MessageBox.Show("メソッドは正常に終了しました。\n\n  表データを確認してください。",
                        "メソッド実行", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
