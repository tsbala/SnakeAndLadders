namespace SnakeAndLadders
{
    public class Game
    {
        public int TokenPosition { get; private set; }

        public Game()
        {
            TokenPosition = 1;
        }

        public void MoveBy(int steps)
        {
            TokenPosition += steps;
        }
    }
}