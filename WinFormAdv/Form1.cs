using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormAdv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 도움말보기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://support.microsoft.com/ko-kr/windows/windows%EC%97%90%EC%84%9C-%EB%8F%84%EC%9B%80%EB%A7%90%EC%9D%84-%EB%B3%B4%EB%8A%94-%EB%B0%A9%EB%B2%95-711b6492-0435-0038-8706-7c6b0feb200a");
        }

        private void 확대ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripProgressBar1.Maximum < toolStripProgressBar1.Value + toolStripProgressBar1.Step)
            {
                toolStripProgressBar1.Value = toolStripProgressBar1.Maximum;
            }
            else
            {
                toolStripProgressBar1.Value += toolStripProgressBar1.Step;
            }
        }

        private void 축소ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripProgressBar1.Minimum > toolStripProgressBar1.Value - toolStripProgressBar1.Step)
            {
                toolStripProgressBar1.Value = toolStripProgressBar1.Minimum;
            }
            else
            {
                toolStripProgressBar1.Value -= toolStripProgressBar1.Step;
            }
        }

        private void 확대하기축소하기기본값복원ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value = 50;
        }
    }
}
