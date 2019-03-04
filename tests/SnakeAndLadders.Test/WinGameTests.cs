using FluentAssertions;
using Xunit;

namespace SnakeAndLadders.Test
{
    public class WinGameTests
    {
        private readonly Game _game;

        public WinGameTests()
        {
            _game = new Game();
            _game.MoveBy(96);
        }

        
        [Fact]
        public void WhenTokenIsOnPositionHundred_GameIsWon()
        {
            _game.MoveBy(3);
            _game.TokenPosition.Should().Be(100);
            _game.Won.Should().BeTrue();
        }        
    }
}