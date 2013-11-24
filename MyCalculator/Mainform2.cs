using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MyCalculator
{
    /// <summary>
    /// 科学计算器的界面后台逻辑
    /// </summary>
    public partial class MainForm : Form
    {
        private void btnInput_Click(object sender, EventArgs e)
        {
            /*
             *  多个按钮公用同一个Click事件，为了区分每个按钮，给每个按钮设置Tag值
             */ 
            Button currentBtn = sender as Button;
            if (currentBtn != null && currentBtn.Tag != null)
            {
                string input = currentBtn.Tag.ToString();
                MessageBox.Show("点击了 " + input);
            }
        }
    }
}
