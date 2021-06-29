using System;

public class Calculator
{
	public Calculator()
	{

	}

	public class LogicalOperation
	{
		public bool AND(bool x, bool y)
		{
			return x & y;
		}

		public bool OR(bool x, bool y)
		{
			return x || y;
		}

		public bool NOT(bool x, bool y)
		{
			return !(x & y);
		}

	}

	public class ArithmaticOperation
	{
		public int sum(int a,int b)
		{
			return (a + b);
		}

		public int subtract(int a, int b)
		{
			return a - b;
		}

		public int multiplication(int a, int b)
		{
			return a * b;
		}
		public double divide(int a, int b)
		{
			return a / b;
		}
		public int module(int a, int b)
		{
			return a % b;
		}
		public double sqrtRoot(int a)
		{
			return Math.Sqrt(a);
		}
	}

	public class Temperature_Converter
	{
		public double temperature(double celsius)
		{
			return ((celsius * 9) / 5 + 32);
		}

	}


}
