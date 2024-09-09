using System;
namespace Exercises
{
	public class Exercise23
	{
        public List<string> ProcessAll(List<string> words)
        {
            var stringsProcessors = new List<StringsProcessor>
                {
                    new StringsTrimmingProcessor(),
                    new StringsUppercaseProcessor()
                };

            List<string> result = words;
            foreach (var stringsProcessor in stringsProcessors)
            {
                result = stringsProcessor.Process(result);
            }
            return result;
        }
    }

    //your code goes here
    class StringsProcessor
    {

        public virtual List<string> Process(List<string> words)
        {
            return words;
        }

    }

    class StringsTrimmingProcessor : StringsProcessor
    {

        public override List<string> Process(List<string> words)
        {

            for (int i = 0; i < words.Count; i++)
            {
                int len = words[i].Length;
                words[i] = words[i].Substring(0, (len / 2));
            }
            return words;
        }
    }

    class StringsUppercaseProcessor : StringsProcessor
    {

        public override List<string> Process(List<string> words)
        {

            for (int i = 0; i < words.Count; i++)
            {

                words[i] = words[i].ToUpper();
            }
            return words;
        }
    }
}

