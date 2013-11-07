namespace MyCalculator
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnMutiple = new System.Windows.Forms.Button();
            this.btnDevide = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEqueal = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblEquation = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(10, 130);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(324, 311);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnMutiple);
            this.tabPage1.Controls.Add(this.btnDevide);
            this.tabPage1.Controls.Add(this.btnDel);
            this.tabPage1.Controls.Add(this.btnEqueal);
            this.tabPage1.Controls.Add(this.btnPlus);
            this.tabPage1.Controls.Add(this.btnMinus);
            this.tabPage1.Controls.Add(this.btnThree);
            this.tabPage1.Controls.Add(this.btnSix);
            this.tabPage1.Controls.Add(this.btnNine);
            this.tabPage1.Controls.Add(this.btnDot);
            this.tabPage1.Controls.Add(this.btnTwo);
            this.tabPage1.Controls.Add(this.btnFive);
            this.tabPage1.Controls.Add(this.btnEight);
            this.tabPage1.Controls.Add(this.btnZero);
            this.tabPage1.Controls.Add(this.btnOne);
            this.tabPage1.Controls.Add(this.btnFour);
            this.tabPage1.Controls.Add(this.btnSeven);
            this.tabPage1.Controls.Add(this.btnC);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(316, 285);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "标准";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnMutiple
            // 
            this.btnMutiple.Location = new System.Drawing.Point(233, 18);
            this.btnMutiple.Name = "btnMutiple";
            this.btnMutiple.Size = new System.Drawing.Size(63, 47);
            this.btnMutiple.TabIndex = 0;
            this.btnMutiple.Text = "×";
            this.btnMutiple.UseVisualStyleBackColor = true;
            this.btnMutiple.Click += new System.EventHandler(this.btnMutiply_Click);
            // 
            // btnDevide
            // 
            this.btnDevide.Location = new System.Drawing.Point(162, 18);
            this.btnDevide.Name = "btnDevide";
            this.btnDevide.Size = new System.Drawing.Size(63, 47);
            this.btnDevide.TabIndex = 0;
            this.btnDevide.Text = "÷";
            this.btnDevide.UseVisualStyleBackColor = true;
            this.btnDevide.Click += new System.EventHandler(this.btnDevide_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(91, 18);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(63, 47);
            this.btnDel.TabIndex = 0;
            this.btnDel.Text = "DEL";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEqueal
            // 
            this.btnEqueal.Location = new System.Drawing.Point(233, 172);
            this.btnEqueal.Name = "btnEqueal";
            this.btnEqueal.Size = new System.Drawing.Size(60, 94);
            this.btnEqueal.TabIndex = 0;
            this.btnEqueal.Text = "=";
            this.btnEqueal.UseVisualStyleBackColor = true;
            this.btnEqueal.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(233, 119);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(63, 47);
            this.btnPlus.TabIndex = 0;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(233, 69);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(63, 47);
            this.btnMinus.TabIndex = 0;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnThree
            // 
            this.btnThree.Location = new System.Drawing.Point(162, 168);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(63, 47);
            this.btnThree.TabIndex = 0;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnSix
            // 
            this.btnSix.Location = new System.Drawing.Point(162, 119);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(63, 47);
            this.btnSix.TabIndex = 0;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.btnSix_Click);
            // 
            // btnNine
            // 
            this.btnNine.Location = new System.Drawing.Point(162, 69);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(63, 47);
            this.btnNine.TabIndex = 0;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.btnNine_Click);
            // 
            // btnDot
            // 
            this.btnDot.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDot.Location = new System.Drawing.Point(162, 219);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(63, 47);
            this.btnDot.TabIndex = 0;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Location = new System.Drawing.Point(91, 168);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(63, 47);
            this.btnTwo.TabIndex = 0;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnFive
            // 
            this.btnFive.Location = new System.Drawing.Point(91, 119);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(63, 47);
            this.btnFive.TabIndex = 0;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnEight
            // 
            this.btnEight.Location = new System.Drawing.Point(91, 69);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(63, 47);
            this.btnEight.TabIndex = 0;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.btnEight_Click);
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(21, 219);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(133, 47);
            this.btnZero.TabIndex = 0;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(21, 168);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(63, 47);
            this.btnOne.TabIndex = 0;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnFour
            // 
            this.btnFour.Location = new System.Drawing.Point(21, 119);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(63, 47);
            this.btnFour.TabIndex = 0;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.Location = new System.Drawing.Point(21, 69);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(63, 47);
            this.btnSeven.TabIndex = 0;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.btnSeven_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(21, 18);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(63, 47);
            this.btnC.TabIndex = 0;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(316, 285);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "科学";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.White;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblResult.Location = new System.Drawing.Point(10, 38);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(320, 64);
            this.lblResult.TabIndex = 2;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblEquation
            // 
            this.lblEquation.AutoSize = true;
            this.lblEquation.BackColor = System.Drawing.Color.White;
            this.lblEquation.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblEquation.Location = new System.Drawing.Point(278, 51);
            this.lblEquation.Name = "lblEquation";
            this.lblEquation.Size = new System.Drawing.Size(0, 20);
            this.lblEquation.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 453);
            this.Controls.Add(this.lblEquation);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "我的计算器 V1.0";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnMutiple;
        private System.Windows.Forms.Button btnDevide;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEqueal;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblEquation;
    }
}

