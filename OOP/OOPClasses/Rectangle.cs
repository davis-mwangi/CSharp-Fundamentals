using System;
namespace OOP.OOPClasses
{
    class Rectangle
    {
        private int Width; //public variable
        private int Height; //public variable

        readonly int NumberOfSides; //Not a must to assign a value

        private string Name { get; set; }

        public Rectangle(int width, int height)
        {
            Width = GetLengthOrDefault(width, nameof(Width)); // nameof returns Width
            Height = GetLengthOrDefault(height, nameof(Height)); // nameof returns Height
        }

        private int GetLengthOrDefault(int length, string name)
        {
            const int defaultValueIfNonPositive = 1;//const field must be assigned a value
            if (length <= 0)
            {
                Console.WriteLine($"{name} must be a positive number.");
                return defaultValueIfNonPositive;
            }
            return length;
        }

        public int GetWidth()
        {
            return Width;
        }

        public int GetHeight()
        {
            return Height;
        }
    }



}

