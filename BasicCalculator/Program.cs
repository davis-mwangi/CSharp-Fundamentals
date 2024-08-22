namespace BasicCalculator;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello!");
        Console.WriteLine("Input the first number:");
        string firstInput = Console.ReadLine();
        int num1 = int.Parse(firstInput);

        Console.WriteLine("Input the second number:");
        string secondInput = Console.ReadLine();
        int num2 = int.Parse(secondInput);

        Console.WriteLine("What do you want to do with those numbers?");
        Console.WriteLine("[A]dd\n" +
                          "[S]ubtract\n" +
                          "[M]ultiply\n");

        string @operator = Console.ReadLine();

        calculate(num1, num2, @operator);

        Console.WriteLine("Press any key to close");
        Console.ReadKey();
    }

    //Calculator
    static void calculate(int num1, int num2, string @operator)
    {
        @operator = @operator.ToUpper();

        switch (@operator)
        {
            case "A":
                PrintResult(num1, num2, (num1 + num2), "+");
                break;
            case "S":
                PrintResult(num1, num2, (num1 - num2), "-");
                break;
            case "M":
                PrintResult(num1, num2, (num1 * num2), "*");
                break;
            default:
                Console.WriteLine("Invalid option");
                break;

        }
    }

    static void PrintResult(int num1, int num2, int result, string @operator)
    {
        Console.WriteLine($"{num1} {@operator} {num2} = {result}");
    }

}

