using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorStrategy.Enum;

namespace CalculatorStrategy.Interfaces
{
	public interface IMath
	{
		int PerformOperation(string type, int num1, int num2);
	}
}
