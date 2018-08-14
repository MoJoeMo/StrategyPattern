using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorStrategy.Enum;

namespace CalculatorStrategy.Operators
{
	public class MultiplyOperator : ICalculate
	{
		public bool CanOperate(string type)
		{
			return type == OperatorType.Multiply.ToString();
		}

		public int Operate(int num1, int num2)
		{
			return num1 * num2;
		}
	}
}
