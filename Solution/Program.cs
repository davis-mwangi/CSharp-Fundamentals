namespace Solution;
class Program
{
    static void Main(string[] args)
    {
        //int[] numbers = new int[5];
        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    numbers[i] = i * 2;
        //}

        //int firstFromEnd = numbers[^1];
        //int secondFromEnd = numbers[^2];

        //Console.WriteLine("First From End: " +  firstFromEnd);
        //Console.WriteLine("Second from End: " +  secondFromEnd);


        List<string> words = new List<string>();
        words.Add("eggs");
        words.Add("Oranges");
        words.Add("Pinaples");
        words.Add("Peas");
        foreach(var word  in words)
        {
            Console.WriteLine(word);
        }
        words.Remove("eggs");
        int size = words.Count;
        words.RemoveAt(2);
        words.Reverse();
        words.Sort();
        words.ToArray();
        words[0] = "kk";

        Console.ReadKey();
        char letter = 'j';

    }

    public List<string> GetOnlyUpperCaseWords(List<string> words)
    {
        //your code goes here
        List<string> res = new List<string>();

        foreach (string word in words)
        {
            if (word.All(char.IsUpper))
            {
                res.Add(word);
            }
        }
        return res;
    }


}