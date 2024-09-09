using System;
namespace OOP.Inheritance
{
	public class NumbersSumCalculator
	{
		public int Calculate(List<int> numbers)
		{
			int sum = 0;
			foreach(var number in numbers)
			{
                if (ShallBeAdded(number))
				{
					sum += number;
				}

            }
			return sum;
			
		}
		public virtual bool ShallBeAdded(int number)
		{
			return true;
		}
		
	}
}

