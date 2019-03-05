using System;

namespace SnakeAndLadders
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();
            var dice = new Dice();

            Console.WriteLine($"Game started, Current position {game.TokenPosition}");
            while (!game.Won)
            {
                var roll = dice.Roll();
                game.MoveBy(roll);
                Console.WriteLine($"Dice roll: {roll}, Current Position: {game.TokenPosition}");
            }
            Console.WriteLine("Game won !!!");        
        }
    }
}
