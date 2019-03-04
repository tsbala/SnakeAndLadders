namespace SnakeAndLadders
{
    public class Token
    {
        public int Position { get; private set; }

        public Token()
        {
            Position = 1;
        }

        public void MoveBy(int spaces)
        {
            Position += spaces;
        }        
    }
}