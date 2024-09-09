
using Exercises;

List<string> words = new List<string> { "bobcat", "wolverine", "grizzly" };

Exercise23 exercise23 = new Exercise23();
List<string>result   = exercise23.ProcessAll(words);

// Print the updated list
foreach (string word in result)
{
    Console.WriteLine(word);
}


Console.ReadKey();



