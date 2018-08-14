using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorStrategy.Enum;

namespace CalculatorStrategy.Operators
{
	public class DivideOperator : ICalculate
	{
		public bool CanOperate(string type)
		{
			return type == OperatorType.Divide.ToString();
		}

		public int Operate(int num1, int num2)
		{
			return num2 == 0 ? 0 : num1 / num2;
		}
	}
}
