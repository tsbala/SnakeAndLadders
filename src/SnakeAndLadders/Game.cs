namespace SnakeAndLadders
{
    public class Game
    {
        public int TokenPosition => _token.Position;

        private readonly Token _token;
        
        private readonly int _winningPosition;

        public bool Won => TokenPosition == _winningPosition;

        private Game(int winningPosition)
        {
            _winningPosition = winningPosition;
            _token = new Token();
        }

        public Game() : this(100)
        {
            
        }

        public void MoveBy(int spaces)
        {
            _token.MoveBy(spaces);
        }
    }
}