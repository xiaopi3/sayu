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
    public partial class frmRegisterData : Form
    {
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Button cmdMB;
        private System.Windows.Forms.Button cmdMW;
        private System.Windows.Forms.Button cmdML;
        private System.Windows.Forms.Button cmdMF;
        private System.Windows.Forms.Button cmdDW;
        private System.Windows.Forms.Button cmdMD;
        private System.Windows.Forms.Button cmdMQ;
        public frmRegisterData()
        {
            InitializeComponent();
        }
        //关闭当前窗口
        private void cmdClose_Click(object sender, EventArgs e)
        {
            base.OnClick(e);
            Dispose(true);
        }
        //MB寄存器Get/Set --BIT数据/位
        private void cmdMB_Click(object sender, EventArgs e)
        {
            bool bGetValue;		// 获取寄存器值
            bool bSetValue;		// 设定寄存器值
            string strGetValue = "";
            string strSetValue = "";
            System.Windows.Forms.DialogResult result;
            base.OnClick(e);
            result = MessageBox.Show("执行“设置/取得寄存器的BIT型数据”方法。可以吗？\n\n  寄存器：MB000000",
                                    "执行", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
            try
            {
                if (result == DialogResult.OK)
                {
                    bGetValue = sayu.Form1.frm1.axMPScope1.get_MB(0, 0);
                    // 反转取得值
                    if (false == bGetValue)
                    {
                        bSetValue = true;
                        strGetValue = "OFF";
                        strSetValue = "ON";
                    }
                    else
                    {
                        bSetValue = false;
                        strGetValue = "ON";
                        strSetValue = "OFF";
                    }
                    sayu.Form1.frm1.axMPScope1.set_MB(0, 0, bSetValue);
                    MessageBox.Show("方法正常结束。\n\n  MB000000\n\n   取得\t：" + strGetValue + "\n   设定\t：" + strSetValue,
                        "执行", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //MW寄存器Get/Set--2字节
        private void cmdMW_Click(object sender, EventArgs e)
        {
            short nGetValue = 0;		// 寄存器取值
            short nSetValue = 0;		// 寄存器设置
            System.Windows.Forms.DialogResult result;
            base.OnClick(e);
            result = MessageBox.Show("执行“设置/取得寄存器的2个字节数据”方法。可以吗？\n\n 寄存器：MW00000",
                "执行", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
            try
            {
                if (result == DialogResult.OK)
                {
                    nGetValue = sayu.Form1.frm1.axMPScope1.get_MW(0);

                    // 补充设置
                    nSetValue = (short)(nGetValue + 1);

                    sayu.Form1.frm1.axMPScope1.set_MW(0, nSetValue);
                    MessageBox.Show("方法正常结束\n\n  MW00000\n\n   取得\t：" + nGetValue + "\n   设定\t：" + nSetValue,
                        "执行", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //ML寄存器Get/Set--4字节
        private void cmdML_Click(object sender, EventArgs e)
        {
            int nGetValue = 0;		//寄存器取得值
            int nSetValue = 0;		// 寄存器设定值
            System.Windows.Forms.DialogResult result;
            base.OnClick(e);
            result = MessageBox.Show("执行“设置/取得寄存器的4个字节数据”方法。可以吗？\n\n  寄存器：ML00000",
                "执行", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
            try
            {
                if (result == DialogResult.OK)
                {
                    nGetValue = sayu.Form1.frm1.axMPScope1.get_ML(0);

                    //补充设置
                    nSetValue = nGetValue + 1;

                    sayu.Form1.frm1.axMPScope1.set_ML(0, nSetValue);
                    MessageBox.Show("方法正常结束\n\n  ML00000\n\n  取得\t：" + nGetValue + "\n   设置\t：" + nSetValue,
                        "执行", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //MF寄存器Get/Set--4字节单精度浮点
        private void cmdMF_Click(object sender, EventArgs e)
        {
            float nGetValue = 0;		//寄存器取得值
            float nSetValue = 0;		// 寄存器设定值
            System.Windows.Forms.DialogResult result;
            base.OnClick(e);
            result = MessageBox.Show("执行“设置/取得寄存器的精度浮点（4字节）的方法。可以吗？\n\n  寄存器：MF00000",
                "执行", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
            try
            {
                if (result == DialogResult.OK)
                {
                    nGetValue = sayu.Form1.frm1.axMPScope1.get_MF(0);

                    // 补充设置
                    nSetValue = nGetValue + 1.0f;

                    sayu.Form1.frm1.axMPScope1.set_MF(0, nSetValue);
                    MessageBox.Show("方法正常结束\n\n  MF00000\n\n   取得\t：" + nGetValue + "\n   设置\t：" + nSetValue,
                        "执行", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //DW寄存器Get/Set--2字节
        private void cmdDW_Click(object sender, EventArgs e)
        {
            short nGetValue = 0;		//寄存器取得
            short nSetValue = 0;		// 寄存器设定
            System.Windows.Forms.DialogResult result;
            base.OnClick(e);
            result = MessageBox.Show("执行“设置/取得寄存器的2个字节数据”方法。可以吗？\n\n  寄存器：DW00000\n  程序：H",
                "执行", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
            try
            {
                if (result == DialogResult.OK)
                {
                    sayu.Form1.frm1.axMPScope1.ProgramName = "H";
                    nGetValue = sayu.Form1.frm1.axMPScope1.get_DW(0);

                    // 补充设置
                    nSetValue = (short)(nGetValue + 1);

                    sayu.Form1.frm1.axMPScope1.set_DW(0, nSetValue);
                    MessageBox.Show("正常结束\n\n  DW00000\n  程序：H\n\n   取得\t：" + nGetValue + "\n   設定\t：" + nSetValue,
                        "执行", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //MQ寄存器Get/Set--8字节
        private void cmdMQ_Click(object sender, System.EventArgs e)
        {
            Int64 nGetValue = 0;		// レジスタ取得値
            Int64 nSetValue = 0;		// レジスタ設定値
            System.Windows.Forms.DialogResult result;
            base.OnClick(e);
            result = MessageBox.Show("执行“设置/获取寄存器的8字节数据”方法。可以吗？\n\n 寄存器：MQ00000",
                "执行", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
            try
            {
                if (result == DialogResult.OK)
                {
                    nGetValue = sayu.Form1.frm1.axMPScope1.get_MQ(0);

                    // インクリメントして設定
                    nSetValue = nGetValue + 1;

                    sayu.Form1.frm1.axMPScope1.set_MQ(0, nSetValue);
                    MessageBox.Show("メソッドは正常に終了しました。\n\n  MQ00000\n\n   取得\t：" + nGetValue + "\n   設定\t：" + nSetValue,
                        "メソッド実行", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //MD寄存器Get/Set--8字节双精度
        private void cmdMD_Click(object sender, System.EventArgs e)
        {
            double nGetValue = 0;		// レジスタ取得値
            double nSetValue = 0;		// レジスタ設定値
            System.Windows.Forms.DialogResult result;
            base.OnClick(e);
            result = MessageBox.Show("设置/取得寄存器的双精度浮点（8字节）”方法。可以吗？\n\n 寄存器：MD00000",
                "执行", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
            try
            {
                if (result == DialogResult.OK)
                {
                    nGetValue = sayu.Form1.frm1.axMPScope1.get_MD(0);

                    // インクリメントして設定
                    nSetValue = nGetValue + 1.0f;

                    sayu.Form1.frm1.axMPScope1.set_MD(0, nSetValue);
                    MessageBox.Show("メソッドは正常に終了しました。\n\n  MD00000\n\n   取得\t：" + nGetValue + "\n   設定\t：" + nSetValue,
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
