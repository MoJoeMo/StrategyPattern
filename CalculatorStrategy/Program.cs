using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using CalculatorStrategy.Enum;
using CalculatorStrategy.Operators;

namespace CalculatorStrategy
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> calcs = new List<int>();
			Calculator _calculator = new Calculator();
			calcs.Add(_calculator.PerformOperation("Add", 44, 87));
			calcs.Add(_calculator.PerformOperation("Multiply", 10, 12));
			calcs.Add(_calculator.PerformOperation("Subtract", 25, 36));
			calcs.Add(_calculator.PerformOperation("Divide", 100, 10));
			calcs.ForEach(Console.WriteLine);

			Console.Read();
		}
	}
}
