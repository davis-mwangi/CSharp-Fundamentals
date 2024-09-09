using System;
namespace Exercises
{
	public class Exercise22
	{
        public List<int> GetCountsOfAnimalsLegs()
        {
            var animals = new List<Animal>
            {
                new Lion(),
                new Tiger(),
                new Duck(),
                new Spider()
            };

            var result = new List<int>();
            foreach (var animal in animals)
            {
                result.Add(animal.NumberOfLegs);
            }
            return result;
        }
    }

    //your code goes here
    class Animal
    {
        public virtual int NumberOfLegs { get; set; } = 4;
    }

    class Lion : Animal
    {
        public override int NumberOfLegs { get; set; } = 4;
    }

    class Tiger : Animal
    {
        public override int NumberOfLegs { get; set; } = 4;
    }

    class Duck : Animal
    {
        public override int NumberOfLegs { get; set; } = 2;
    }

    class Spider : Animal
    {
        public override int NumberOfLegs { get; set; } = 8;

    }
}

