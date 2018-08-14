using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorStrategy.Enum;

namespace CalculatorStrategy
{
	public interface ICalculate
	{
		bool CanOperate(string type);
		int Operate(int num1, int num2);
	}
}
