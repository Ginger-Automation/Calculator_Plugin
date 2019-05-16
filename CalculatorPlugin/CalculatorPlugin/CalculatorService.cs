using Amdocs.Ginger.Plugin.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorPlugin
{
    [GingerService("CalculatorExecuter", "Do calculation via Ginger")]
    public class CalculatorService
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="GA"></param>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        [GingerAction("Sum", "Do Sum")]
        public void ExecuteSum(IGingerAction GA, string num1, string num2)
        {
            int num1Int = int.Parse(num1);
            int num2Int = int.Parse(num2);
            GA.AddOutput("Result", num1Int + num2Int);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="GA"></param>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        [GingerAction("Minus", "Do Minus")]
        public void ExecuteMinus(IGingerAction GA, string num1, string num2)
        {
            int num1Int = int.Parse(num1);
            int num2Int = int.Parse(num2);
            GA.AddOutput("Result", num1Int - num2Int);

        }
    }
}
