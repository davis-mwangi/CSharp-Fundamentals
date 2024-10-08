﻿namespace DiceRollGame.Game
{
    public class Dice
    {
        private Random _random;
        private readonly int SidesCount = 6;

        public Dice(Random random)
        {
            _random = random;
        }
        public int Roll()
        {
            return _random.Next(1, SidesCount + 1);
        }
    }
}

