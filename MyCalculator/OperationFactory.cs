using System;
using System.Collections.Generic;
using System.Text;

namespace MyCalculator
{
    /// <summary>
    /// 运算工厂类
    /// </summary>
    public class OperationFactory
    {
        /// <summary>
        /// 只需输入运算符，工厂就能实例化出合适的对象，通过多态，返回父类的方式实现了计算器的结果
        /// </summary>
        /// <param name="operate">运算符</param>
        /// <returns></returns>
        public static Operation createOpeate(EnumOperator op)
        {
            Operation oper = null;
            switch (op)
            {
                case EnumOperator.Add:
                    oper = new OperationAdd();
                    break;
                case EnumOperator.Minus:
                    oper = new OperationSub();
                    break;
                case EnumOperator.Multiply:
                    oper = new OperationMul();
                    break;
                case EnumOperator.Divide:
                    oper = new OperationDiv();
                    break;
                default:
                    break;
            }
            return oper;
        }
    }
}
