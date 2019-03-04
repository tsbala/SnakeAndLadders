namespace SnakeAndLadders
{
    public class Game
    {
        public int TokenPosition => _token.Position; 

        private readonly Token _token;

        public Game()
        {
            _token = new Token();
        }

        public void MoveBy(int spaces)
        {
            _token.MoveBy(spaces);
        }
    }
}