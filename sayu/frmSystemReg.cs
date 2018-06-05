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
    public partial class frmSystemReg : Form
    {
        private bool m_bStart;

        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCalendar;
        private System.Windows.Forms.Label lblRun;
        private System.Windows.Forms.Label lblAlarm;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.Button cmdStop;
        private System.Timers.Timer timer1;
        public frmSystemReg()
        {
            InitializeComponent();
        }
        private void cmdClose_Click(object sender, EventArgs e)
        {
            base.OnClick(e);
            timer1.Enabled = false;
            Dispose(true);
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            bool bRet;
            base.OnClick(e);

            // 起動中なら何もしない
            if (m_bStart)
            {
                return;
            }

            // サンプル処理実行
            try
            {
                // 初回表示
                // カレンダ・バージョン表示更新
                bRet = funcDispCalenderVersion();
                if (bRet)
                {
                    // RUN/アラーム表示更新
                    bRet = funcDispRunAlarm();
                }

                // 初回表示で失敗した場合は、タイマ起動しない
                if (!bRet)
                {
                    return;
                }
                else
                {
                    // タイマの起動
                    timer1.Interval = 500;
                    timer1.Enabled = true;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            m_bStart = true;
        }

        private bool funcDispCalenderVersion()
        {
            string strRegisterNameList;
            const int nRegNum = 5;
            short[] nSwData;
            object nData;

            nSwData = new short[nRegNum];
            nData = new short[nRegNum];

            // レジスタリスト（\n区切り）
            strRegisterNameList = "SW00015\nSW00016\nSW00017\nSW00018\nSW00020";

            //読み込み実行
            try
            {
                sayu.Form1.frm1.axMPScope1.ReadRegisterList(strRegisterNameList, ref nData);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (false);
            }
            nSwData = (short[])nData;


            //カレンダ表示更新

            //レジスタ値を時刻文字列に編集
            string strWork;
            int nYear;
            int nMonth;
            int nDay;
            int nHour;
            int nMin;
            int nSec;
            if (nSwData[0] < 0x0090)
            {
                nYear = nSwData[0] + 0x2000;
            }
            else
            {
                nYear = nSwData[0] + 0x1900;
            }

            nMonth = nSwData[1] >> 8;
            nDay = nSwData[1] & 0x00FF;
            nHour = nSwData[2] >> 8;
            nMin = nSwData[2] & 0x00FF;
            nSec = nSwData[3];

            strWork = string.Format("{0:x4}/{1:x2}/{2:x2} {3:x2}:{4:x2}:{5:x2}", nYear, nMonth, nDay, nHour, nMin, nSec);
            lblCalendar.Text = strWork;

            //バージョン表示更新
            int nMajorVersion;
            int nMinorVersion;
            nMajorVersion = (nSwData[4] & 0xFF00);	//上位ワード
            nMajorVersion >>= 8;
            nMinorVersion = (nSwData[4] & 0x00FF);	//下位ワード
            strWork = string.Format("{0:x2}.{1:x2}", nMajorVersion, nMinorVersion);

            // ダイアログ表示
            lblVersion.Text = strWork;

            return (true);
        }

        private bool funcDispRunAlarm()
        {
            int nOffset;
            short nBitOffset;
            const int nRegNum = 2;
            bool[] bSwData;

            //SB000401とSB000402を読み込む
            nOffset = 40;
            bSwData = new bool[nRegNum];

            //読み込み実行（BIT型は、連続読み出し不可）
            try
            {
                // SB000401を読み込む
                nBitOffset = 1;
                bSwData[0] = sayu.Form1.frm1.axMPScope1.get_SB(nOffset, nBitOffset);
                // SB000402を読み込む
                nBitOffset = 2;
                bSwData[1] = sayu.Form1.frm1.axMPScope1.get_SB(nOffset, nBitOffset);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (false);
            }

            //RUN情報更新（SB000401）
            if (bSwData[0] == true)
            {
                lblRun.Text = "ON：運転中";
            }
            else
            {
                lblRun.Text = "OFF：運転停止";
            }

            //アラーム情報更新（SB000402）
            if (bSwData[1] == true)
            {
                lblAlarm.Text = "ON：警報";
            }
            else
            {
                lblAlarm.Text = "OFF：正常";
            }

            return (true);
        }

        private void timer1_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            bool bRet;
            bRet = funcDispCalenderVersion();
            if (bRet)
            {
                // RUN/アラーム表示更新
                bRet = funcDispRunAlarm();
            }
        }

        private void cmdStop_Click(object sender, EventArgs e)
        {
            base.OnClick(e);
            timer1.Enabled = false;
            m_bStart = false;
        }
    }
}
