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
    public partial class frmRegisterBlock : Form
    {
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Button cmdReadRegBlock;
        private System.Windows.Forms.Button cmdWriteRegBlock;
        private System.Windows.Forms.Button cmdReadRegList;
        private System.Windows.Forms.Button cmdWriteRegList;
        public frmRegisterBlock()
        {
            InitializeComponent();
        }
        private void cmdClose_Click(object sender, EventArgs e)
        {
            base.OnClick(e);
            Dispose(true);
        }
        //读取寄存器块
        private void cmdReadRegBlock_Click(object sender, EventArgs e)
        {
            string szRegister = "MW00000";
            int nSize = 2;
            object nData;
            short[] ary;
            System.Windows.Forms.DialogResult result;
            base.OnClick(e);
            result = MessageBox.Show("执行“读取寄存器数据的块读取”方法。可以吗？\n\n  寄存器\t\t：MW00000\n  寄存器数\t：2",
                                    "メソッド実行", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
            ary = new short[2];
            nData = new short[2];
            try
            {
                if (result == DialogResult.OK)
                {
                    sayu.Form1.frm1.axMPScope1.ReadRegisterBlock(szRegister, nSize, ref nData);
                    ary = (short[])nData;
                    MessageBox.Show("メソッドは正常に終了しました。\n\n  MW00000\n\n   " + ary[0] + "\n   " + ary[1],
                        "メソッド実行", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //写入寄存器块
        private void cmdWriteRegBlock_Click(object sender, EventArgs e)
        {
            string szRegister = "MW00000";
            int nSize = 2;
            object nData;
            short[] ary;
            System.Windows.Forms.DialogResult result;
            base.OnClick(e);
            result = MessageBox.Show("执行“寄存器数据的块写入”方法。可以吗？\n\n  レジスタ\t\t：MW00000\n  レジスタ数\t：2",
                "メソッド実行", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
            ary = new short[2];
            nData = new short[2];
            ary[0] = 321;
            ary[1] = 112;
            nData = ary;
            try
            {
                if (result == DialogResult.OK)
                {
                    sayu.Form1.frm1.axMPScope1.WriteRegisterBlock(szRegister, nSize, ref nData);
                    ary = (short[])nData;
                    MessageBox.Show("メソッドは正常に終了しました。\n\n  MW00000\n\n   " + ary[0] + "\n   " + ary[1],
                        "メソッド実行", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //寄存器随机读取
        private void cmdReadRegList_Click(object sender, EventArgs e)
        {
            string szRegister = "MW00000\nMW00100";
            object nData;
            short[] ary;
            System.Windows.Forms.DialogResult result;
            base.OnClick(e);
            result = MessageBox.Show("执行“寄存器数据的随机读取”方法。可以吗？\n\n  寄存器\t\t：MW00000\n  寄存器\t\t：MW00100",
                "メソッド実行", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
            ary = new short[2];
            nData = new short[2];
            try
            {
                if (result == DialogResult.OK)
                {
                    sayu.Form1.frm1.axMPScope1.ReadRegisterList(szRegister, ref nData);
                    ary = (short[])nData;
                    MessageBox.Show("メソッドは正常に終了しました。\n\n  MW00000:" + ary[0] + "\n  MW00100:" + ary[1],
                        "メソッド実行", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //寄存器随机写入
        private void cmdWriteRegList_Click(object sender, EventArgs e)
        {
            string szRegister = "MW00000\nMW00100";
            object nData;
            short[] ary;
            System.Windows.Forms.DialogResult result;
            base.OnClick(e);
            result = MessageBox.Show("执行“寄存器数据的随机写入”方法。可以吗？\n\n  レジスタ\t\t：MW00000\n  レジスタ\t\t：MW00100",
                "メソッド実行", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
            ary = new short[2];
            nData = new short[2];
            ary[0] = 321;
            ary[1] = 112;
            nData = ary;
            try
            {
                if (result == DialogResult.OK)
                {
                    sayu.Form1.frm1.axMPScope1.WriteRegisterList(szRegister, ref nData);
                    ary = (short[])nData;
                    MessageBox.Show("メソッドは正常に終了しました。\n\n  MW00000:" + ary[0] + "\n  MW00100:" + ary[1],
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
