using System;

namespace Sample.Library
{
	public class SampleClass
	{
		public int Add(int first, int second) => first + second;
		public int Subtract(int minuend, int subtrahend) => minuend - subtrahend;
		public int Multiply(int multiplicand, int multiplier) => multiplicand * multiplier;
		public int Divide(int dividend, int divisor) => dividend / divisor;

		public bool ReturnFalse() => false;
		public bool ReturnTrue() => true;
		public int Square(int num) => num*num;
	}
}
