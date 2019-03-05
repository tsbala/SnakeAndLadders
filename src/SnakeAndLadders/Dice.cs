using System;

namespace SnakeAndLadders
{
    public class Dice
    {
        private readonly Random _random;

        public Dice()
        {
            _random = new Random();
        }
        
        public int Roll() => _random.Next(1, 7);
    }
}