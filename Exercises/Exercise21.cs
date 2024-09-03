using System;
namespace Exercises
{
	public class Exercise21
	{
        public static class StringsTransformator
        {
            public static string TransformSeparators(
                string input,
                string originalSeparator,
                string targetSeparator)
            {
                //your code goes here
                string[] parts = input.Split(originalSeparator);
                return string.Join(targetSeparator, parts);
            }
        }
    }
}

