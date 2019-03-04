using FluentAssertions;
using Xunit;

namespace SnakeAndLadders.Test
{
    public class TokenMovementTests
    {
        private readonly Game _game;

        public TokenMovementTests()
        {
            _game = new Game();
        }
        
        [Fact]
        public void WhenGameStarts_ThenTokenIsOnSquareOne()
        {
            _game.TokenPosition.Should().Be(1);
        }

        [Fact]
        public void GivenTokenIsOnSquareOne_WhenTokenIsMovedByThreeSpaces_ThenTokeIsOnSquareFour()
        {
            _game.MoveBy(3);
            _game.TokenPosition.Should().Be(4);
        }
        
        [Fact]
        public void GivenTokenIsOnSquareOne_WhenTokenIsMovedByThreeAndThenFourSpaces_ThenTokenIsOnSquareEight()
        {
            _game.MoveBy(3);
            _game.MoveBy(4);
            _game.TokenPosition.Should().Be(8);
        }
    }
}