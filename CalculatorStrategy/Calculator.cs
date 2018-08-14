using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorStrategy.Enum;
using CalculatorStrategy.Interfaces;
using CalculatorStrategy.Operators;

namespace CalculatorStrategy
{
	public class Calculator : IMath
	{
		private readonly Dictionary<string, ICalculate> _operators = LoadDictionary();

		private static Dictionary<string, ICalculate> LoadDictionary()
		{
			Dictionary<string, ICalculate > allOperators = new Dictionary<string, ICalculate>()
			{
				{"Add", new AddOperator() },
				{"Subtract", new SubtractOperator() },
				{"Divide", new DivideOperator() },
				{"Multiply", new MultiplyOperator() }
			};

			return allOperators;
		}


		public int PerformOperation(string operation, int num1, int num2)
		{
			int returnValue = 0;
			_operators.Keys.ToList().ForEach(key =>
			{
				if (_operators[key].CanOperate(operation))
				{
					returnValue = _operators[key].Operate(num1, num2);
				}
			});

			return returnValue;
		}
	}
}
