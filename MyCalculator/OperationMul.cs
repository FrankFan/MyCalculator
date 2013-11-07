using System;

namespace MyCalculator
{
    /// <summary>
    /// 乘法类，继承自运算类Operation基类
    /// </summary>
    public class OperationMul:Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA * NumnberB;
            return result;
        }
    }
}
