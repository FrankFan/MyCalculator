using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyCalculator
{
    /*      计算器 MyCalculator v0.2
     * 思路:用几个变量把输入的值保存起来，然后进行加减乘除等各种运算；
     * 得到的结果用一个变量保存起来，输出到结果。
     * 变量1： double 操作数1
     * 变量2： double 计算结果 
     * 变量3： 当前输入的符号
     * 
     */

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        double currentValue = 0;   //第1个数        
        double numSum = 0;  //第2个数
        private EnumOperator currentOperator; //当前操作符
        private string strDisplay = string.Empty; //记录运算符
        private string tempData = string.Empty;//复制数据用

        /// <summary>
        /// 按数字的时候
        /// </summary>
        /// <param name="strNumber"></param>
        private void NumberClick(string strNumber)
        {
            lblResult.Text = lblResult.Text + strNumber;
            currentValue = Convert.ToDouble(lblResult.Text);

            lblEquation.Text += strNumber;
        }

        /// <summary>
        /// 按符号按钮的时候
        /// </summary>
        /// <param name="op"></param>
        private void OperatorClick(EnumOperator op)
        {
            if (currentOperator != EnumOperator.None)
            {
                //计算
                Evaluate();
            }
            else
            {
                //numSum = double.Parse(lblResult.Text);
                double.TryParse(lblResult.Text, out numSum);
            }

            DisplayOperator(op);

            lblResult.Text = "";
            currentOperator = op;


        }

        private void DisplayOperator(EnumOperator op)
        {
            switch (op)
            {
                case EnumOperator.None:
                    lblEquation.Text = lblResult.Text;
                    lblEquation.Text += "";
                    break;
                case EnumOperator.Add:
                    if (lblResult.Text != "")
                    {
                        lblEquation.Text = lblResult.Text;
                    }
                    lblEquation.Text += "+";
                    break;
                case EnumOperator.Minus:
                    if (lblResult.Text != "")
                    {
                        lblEquation.Text = lblResult.Text;
                    }
                    lblEquation.Text += "-";
                    break;
                case EnumOperator.Multiply:
                    lblEquation.Text = lblResult.Text;
                    lblEquation.Text += "x";
                    break;
                case EnumOperator.Divide:
                    lblEquation.Text = lblResult.Text;
                    lblEquation.Text += "÷";
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 根据运算符和两个数字计算结果
        /// 调用简单工厂模式生成的类
        /// </summary>
        private void Evaluate()
        {
            Operation oper;

            //根据不同的对象生成不同的类，多态!
            switch (currentOperator)
            {
                case EnumOperator.None:
                    break;
                case EnumOperator.Add:
                    oper = OperationFactory.createOpeate(EnumOperator.Add);
                    oper.NumberA = numSum;
                    oper.NumnberB = currentValue;
                    numSum = oper.GetResult();
                    break;
                case EnumOperator.Minus:
                    oper = OperationFactory.createOpeate(EnumOperator.Minus);
                    oper.NumberA = numSum;
                    oper.NumnberB = currentValue;
                    numSum = oper.GetResult();
                    break;
                case EnumOperator.Multiply:
                    oper = OperationFactory.createOpeate(EnumOperator.Multiply);
                    oper.NumberA = numSum;
                    oper.NumnberB = currentValue;
                    numSum = oper.GetResult();
                    break;
                case EnumOperator.Divide:
                    if (currentValue != 0)
                    {
                        oper = OperationFactory.createOpeate(EnumOperator.Divide);
                        oper.NumberA = numSum;
                        oper.NumnberB = currentValue;
                        numSum = oper.GetResult();
                    }
                    else
                    {
                        MessageBox.Show("除数不能为0哦，亲~", "出错了~");
                    }
                    break;
            }
            currentValue = 0;
            currentOperator = EnumOperator.None;
        }


        /// <summary>
        /// 保存输入数字，并计算结果缓存起来,按下运算符则保存算式
        /// </summary>
        /// <param name="inputNum"></param>
        /// <param name="sign"></param>
        public void SaveInputed(string inputNum, string sign)
        {
            //TODO:
            //1.显示输入的表达式
            //2.输入过运算符号之后，继续输入运算符，就用新的运算符代替旧的运算符
        }

        #region 数字0-9 + 小数点
        private void btnOne_Click(object sender, EventArgs e)
        {
            NumberClick(btnOne.Text);

        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            NumberClick(btnTwo.Text);
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            NumberClick(btnThree.Text);
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            NumberClick(btnFour.Text);
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            NumberClick(btnFive.Text);
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            NumberClick(btnSix.Text);
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            NumberClick(btnSeven.Text);
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            NumberClick(btnEight.Text);
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            NumberClick(btnNine.Text);
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            NumberClick(btnZero.Text);
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!lblEquation.Text.Contains(".") && !lblResult.Text.Contains("."))
            {
                lblResult.Text = lblResult.Text + ".";
                lblEquation.Text += ".";
            }
        }
        #endregion

        #region 按钮加减乘除
        private void btnPlus_Click(object sender, EventArgs e)
        {
            OperatorClick(EnumOperator.Add);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            OperatorClick(EnumOperator.Minus);
        }

        private void btnMutiply_Click(object sender, EventArgs e)
        {
            OperatorClick(EnumOperator.Multiply);
        }

        private void btnDevide_Click(object sender, EventArgs e)
        {

            OperatorClick(EnumOperator.Divide);

        }
        #endregion

        #region 按钮 等于、退格、清除
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lblResult.Text == "" || lblResult.Text == "0")
            {
                lblResult.Text = "0";
            }
            else
            {
                lblResult.Text = lblResult.Text.Substring(0, lblResult.Text.Length - 1);
            }

            if (lblEquation.Text == "" || lblEquation.Text == "0")
            {
                lblEquation.Text = "";
            }
            else
            {
                lblEquation.Text = lblEquation.Text.Substring(0, lblEquation.Text.Length - 1);
            }

            string tmp = currentValue.ToString();
            tmp = tmp.Substring(0, tmp.Length - 1);
            Double.TryParse(tmp, out currentValue);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            currentOperator = EnumOperator.None;
            lblResult.Text = "";
            lblEquation.Text = "";
            numSum = 0;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            Evaluate();
            lblResult.Text = numSum.ToString();

            //防止重复按 = 
            if (lblEquation.Text.Length > 1 && lblEquation.Text.Substring(lblEquation.Text.Length - 1) != "=")
            {
                lblEquation.Text += "=";
            }
        }
        #endregion

        private void ToolStripMenuItemCopy_Click(object sender, EventArgs e)
        {
            tempData = lblResult.Text;
            if (!string.IsNullOrEmpty(tempData))
            {
                Clipboard.SetDataObject(tempData);
            }
        }

        private void ToolStripMenuItemPaste_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tempData))
            {
                lblResult.Text = tempData;
                //IDataObject clipboardData = Clipboard.GetDataObject();
            }
        }

        private void ToolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            this.FindForm().Close();
        }

        private void ToolStripMenuItemAboutCalc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("一个简单的计算器\r\n Author:fanyong@gmail.com ", "关于", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ToolStripMenuItemAboutComputer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("嗯，这是一台好电脑！ ", "关于", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
