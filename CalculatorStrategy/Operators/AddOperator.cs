using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorStrategy.Enum;

namespace CalculatorStrategy
{
	public class AddOperator : ICalculate
	{
		public bool CanOperate(string type)
		{
			return type == OperatorType.Add.ToString();
		}

		public int Operate(int num1, int num2)
		{
			return (num1 + num2);
		}
	}
}
