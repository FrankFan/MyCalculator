using System;

namespace MyCalculator
{
    /// <summary>
    /// 减法类，继承自Operation运算类基类
    /// </summary>
    public class OperationSub : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA - NumnberB;
            return result;
        }
    }
}
