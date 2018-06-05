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
    public partial class frmCSV : Form
    {
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Button cmdReadRegBlockCSV;
        private System.Windows.Forms.Button cmdWriteRegBlockCSV;
        private System.Windows.Forms.Button cmdReadRegListCSV;
        private System.Windows.Forms.Button cmdWriteRegListCSV;
        public frmCSV()
        {
            InitializeComponent();
        }
        private void cmdClose_Click(object sender, EventArgs e)
        {
            base.OnClick(e);
            Dispose(true);
        }

        private void cmdReadRegBlockCSV_Click(object sender, EventArgs e)
        {
            string szRegister = "MW00000";
            int nSize = 12;
            int nSizePerLine = 3;
            string szCSVFilePath = "ReadRegisterBlockCSV.csv";
            System.Windows.Forms.DialogResult result;
            base.OnClick(e);
            result = MessageBox.Show("执行“寄存器数据的块CSV格式读取”方法。可以吗？\n\n  寄存器\t\t：MW00000\n  寄存器数\t：12\n  一行的寄存器数\t：3\n CSV文件\t：ReadRegisterBlockCSV.csv",
                "メソッド実行", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
            try
            {
                if (result == DialogResult.OK)
                {
                    sayu.Form1.frm1.axMPScope1.ReadRegisterBlockCSV(szRegister, nSize, nSizePerLine, szCSVFilePath);
                    MessageBox.Show("メソッドは正常に終了しました。\n\n  CSVファイルを確認してください。",
                        "メソッド実行", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmdWriteRegBlockCSV_Click(object sender, EventArgs e)
        {
            string szRegister = "MW00000";
            int nSize = 12;
            int nSizePerLine = 3;
            string szCSVFilePath = "WriteRegisterBlockCSV.csv";
            System.Windows.Forms.DialogResult result;
            base.OnClick(e);
            result = MessageBox.Show("执行“寄存器数据的块CSV形式写入”方法。可以吗？\n\n  レジスタ\t\t：MW00000\n  レジスタ数\t：12\n  1行のレジスタ数\t：3\n  CSVファイル\t：WriteRegisterBlockCSV.csv",
                "メソッド実行", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
            try
            {
                if (result == DialogResult.OK)
                {
                    sayu.Form1.frm1.axMPScope1.WriteRegisterBlockCSV(szRegister, nSize, nSizePerLine, szCSVFilePath);
                    MessageBox.Show("メソッドは正常に終了しました。\n\n  レジスタを確認してください。",
                        "メソッド実行", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmdReadRegListCSV_Click(object sender, EventArgs e)
        {
            string szRegister = "MW00000\nMW00100\nSW00015";
            int nSize = 4;
            string szCSVFilePath = "ReadRegisterListCSV.csv";
            System.Windows.Forms.DialogResult result;
            base.OnClick(e);
            result = MessageBox.Show("执行“寄存器数据的随机CSV形式读取”方法。可以吗？\n\n 寄存器\t\t：MW00000\n 寄存器\t\t：MW00100\n 寄存器\t\t：SW00015\n  数据数t：4\n  CSV文件\t：ReadRegisterListCSV.csv",
                "メソッド実行", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
            try
            {
                if (result == DialogResult.OK)
                {
                    sayu.Form1.frm1.axMPScope1.ReadRegisterListCSV(szRegister, nSize, szCSVFilePath);
                    MessageBox.Show("メソッドは正常に終了しました。\n\n  CSVファイルを確認してください。",
                        "メソッド実行", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdWriteRegListCSV_Click(object sender, EventArgs e)
        {
            string szRegister = "MW00000\nMW00100\nMW00200";
            int nSize = 4;
            string szCSVFilePath = "WriteRegisterListCSV.csv";
            System.Windows.Forms.DialogResult result;
            base.OnClick(e);
            result = MessageBox.Show("「レジスタデータのランダムCSV形式書き込み」メソッドを実行します。よろしいですか？\n\n  レジスタ\t\t：MW00000\n  レジスタ\t\t：MW00100\n  レジスタ\t\t：MW00200\n 数据数\t：4\n  CSVファイル\t：WriteRegisterListCSV.csv",
                "メソッド実行", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
            try
            {
                if (result == DialogResult.OK)
                {
                    sayu.Form1.frm1.axMPScope1.WriteRegisterListCSV(szRegister, nSize, szCSVFilePath);
                    MessageBox.Show("メソッドは正常に終了しました。\n\n  レジスタを確認してください。",
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
