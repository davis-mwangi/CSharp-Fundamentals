using  OOP.OOPClasses;
using OOP.Inheritance;

class Program
{
    static void Main(string[] args)
    {
        /*
        DateTime dateTime = new DateTime();
        dateTime.AddDays(3);

        Rectangle rectangle = new Rectangle(-5, 10);
        Console.WriteLine($"Width is {rectangle.GetWidth()}");
        Console.WriteLine($"Height is {rectangle.GetHeight()}");
        */

        var numbers = new List<int> { 1, 4, 6, -1, 12, 44, -8, -19 };
        bool shallAddPositiveOnly = true;

        NumbersSumCalculator calculator = shallAddPositiveOnly ?
            new PositiveNumbersSumCalculator() :
            new NumbersSumCalculator();

        int sum = calculator.Calculate(numbers);
        Console.WriteLine("Sum is:: " + sum);

        Console.ReadKey();

    }
}

