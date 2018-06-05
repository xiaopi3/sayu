using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace sayu
{
    public partial class Form1 : Form
    {
        public static Form1 frm1;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Button cmdCommOpen;
        private System.Windows.Forms.Button cmdCommClose;
        private System.Windows.Forms.Button cmdReadReg;
        private System.Windows.Forms.Button cmdRegisterBlock;
        private System.Windows.Forms.Button frmCSV;
        private System.Windows.Forms.Button frmSystemReg;
        private System.Windows.Forms.Button cmdComm;
        private System.Windows.Forms.Button cmdTableData;
        public AxYCSMPSCOPELib.AxMPScope axMPScope1;
        
        public Form1()
        {
            InitializeComponent();
        }
        //关闭程序
        private void cmdClose_Click(object sender, System.EventArgs e)
        {
            base.OnClick(e);
            Application.Exit();
        }
        //读/写寄存器
        private void cmdReadReg_Click(object sender, System.EventArgs e)
        {
            base.OnClick(e);
            try
            {
                (new frmRegisterData()).ShowDialog();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //打开控制器通信
        private void cmdCommOpen_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.DialogResult result;
            base.OnClick(e);
            result = MessageBox.Show("打开控制器的通信路径。可以吗？\n\n  通信设置文件路径\t：test.ini",
                "メソッド実行", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
            try
            {
                if (result == DialogResult.OK)
                {
                    axMPScope1.ConnectFilePath = ".\\test.ini";
                    axMPScope1.Open(1);
                    MessageBox.Show("メソッドは正常に終了しました。",
                        "メソッド実行", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //关闭控制器通信
        private void cmdCommClose_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.DialogResult result;
            base.OnClick(e);
            result = MessageBox.Show("关闭控制器的通信路径。可以吗？",
                "メソッド実行", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
            try
            {
                if (result == DialogResult.OK)
                {
                    axMPScope1.Close();
                    MessageBox.Show("メソッドは正常に終了しました。",
                        "メソッド実行", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //读/写寄存器块
        private void cmdRegisterBlock_Click(object sender, System.EventArgs e)
        {
            base.OnClick(e);
            try
            {
                (new frmRegisterBlock()).ShowDialog();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //以CSV格式读/写寄存器
        private void frmCSV_Click(object sender, EventArgs e)
        {
            base.OnClick(e);
            try
            {
                (new frmCSV()).ShowDialog();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmSystemReg_Click(object sender, EventArgs e)
        {
            base.OnClick(e);
            try
            {
                (new frmSystemReg()).ShowDialog();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdTableData_Click(object sender, EventArgs e)
        {
            base.OnClick(e);
            try
            {
                (new frmTableData()).ShowDialog();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdComm_Click(object sender, EventArgs e)
        {
            base.OnClick(e);
            try
            {	// 32bitOSでの標準インストール先の場合は下記のフォルダパスになりますが、
                // 64bitOSの場合は、「C:\\Program Files(x86)\\YASKAWA\\～」にインストールされます。
                Process.Start("C:\\Program Files\\YASKAWA\\MPScope Ver2\\Bin\\YeCommUtil.exe", "test.ini");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
