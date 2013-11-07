using System;

namespace MyCalculator
{
    /// <summary>
    /// 操作运算基类
    /// </summary>
    public class Operation
    {
        private double _numberA = 0;
        private double _numberB = 0;

        public double NumberA
        {
            get { return _numberA; }
            set { _numberA = value; }
        }

        public double NumnberB
        {
            get { return _numberB; }
            set { _numberB = value; }
        }

        public virtual double GetResult()
        {
            double result = 0d;
            return result;
        }
    }
}
