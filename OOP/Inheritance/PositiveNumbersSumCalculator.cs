using System;

namespace OOP.Inheritance
{
    public class PositiveNumbersSumCalculator : NumbersSumCalculator
    {
        public override bool ShallBeAdded(int number)
        {
            return number > 0;
        }
    }
}

