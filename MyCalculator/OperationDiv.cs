using System;
using System.Collections.Generic;
using System.Text;

namespace MyCalculator
{
    /// <summary>
    /// 除法类，继承自元算类Operation基类
    /// </summary>
    public class OperationDiv :Operation
    {
        public override double GetResult()
        {
            double result = 0;
            if (NumnberB == 0)
                throw new Exception("除数不能为0.");
            result = NumberA * 1.0 / NumnberB;
            return result;
        }
    }
}
